using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json.Nodes;
using System.Text.RegularExpressions;
using Newtonsoft.Json.Linq;

namespace BlueTimelapse.BlueIris;

public static class Ui3
{
    public static async Task<string> GetSessionKey(string url, string username, string password)
    {
        var client = new HttpClient();
        url = url.TrimEnd('/');
        
        var get = await client.GetAsync(url);
        get.EnsureSuccessStatusCode();
        var cookie = get.Headers.GetValues("Set-Cookie");

        var session = Regex.Match(cookie.First(), @"session=([a-z0-9]+)", RegexOptions.IgnoreCase).Groups[1].Value;
        client.DefaultRequestHeaders.Remove("Cookie");
        client.DefaultRequestHeaders.Add("Cookie", "session=" + session);
        
        var loginString = Convert.ToHexString(MD5.HashData(Encoding.UTF8.GetBytes(username + ":" + session + ":" + password))).ToLowerInvariant();

        var json = new JsonObject
        {
            ["cmd"] = "login",
            ["session"] = session,
            ["response"] = loginString
        };

        var resp = await client.PostAsync(url + "/json?_login",
            new StringContent(json.ToString(), Encoding.UTF8, "application/json"));
        resp.EnsureSuccessStatusCode();

        var respText = await resp.Content.ReadAsStringAsync();
        var loginResponse = JsonObject.Parse(respText);

        if (loginResponse["result"].GetValue<string>() != "success")
        {
            throw new Ui3LoginException(loginResponse["data"]?["reason"]?.ToString() ?? "Unknown login error");
        }

        return session;
    }

    public static async Task<byte[]> FetchImage(string url, string? sessionKey, string group, int width, int height, int quality, bool decode = true, bool stream = false)
    {
        var client = new HttpClient();
        if (sessionKey != null) client.DefaultRequestHeaders.Add("Cookie", "session=" + sessionKey);
        
        url = url.TrimEnd('/') + $"/image/{Uri.EscapeDataString(group)}" +
              $"&decode={(decode ? "1" : "0")}" +
              $"&stream={(stream ? "1" : "0")}" +
              $"&w={width}&h={height}&q={quality}";
        
        if (sessionKey != null) url += $"&session={sessionKey}";
        
        var fetch = await client.GetAsync(url);
        
        if (!fetch.IsSuccessStatusCode)
        {
            if (fetch.StatusCode == HttpStatusCode.ServiceUnavailable)
            {
                throw new Ui3LoginException("Not logged in");
            }
            
            fetch.EnsureSuccessStatusCode();
        }

        return await fetch.Content.ReadAsByteArrayAsync();
    }

    public static async Task<CameraGroup[]> GetCamerasAndGroups(string url, string sessionKey)
    {
        var client = new HttpClient();
        client.DefaultRequestHeaders.Add("Cookie", "session=" + sessionKey);
        client.DefaultRequestHeaders.Add("Accept", "application/json, text/javascript, */*; q=0.01");

        var body = "{\"cmd\": \"camlist\", \"session\": \"" + sessionKey + "\"}";
        var post = await client.PostAsync(url.TrimEnd('/') + "/json?_camlist", new StringContent(body));
        
        post.EnsureSuccessStatusCode();
        var json = JObject.Parse(await post.Content.ReadAsStringAsync());
        
        var groups = new List<CameraGroup>();
        foreach (var optionObject in json["data"]!)
        {
            var display = optionObject.Value<string>("optionDisplay")!;
            var value = optionObject.Value<string>("optionValue")!;
            if (value.StartsWith("@")) continue; // groups that start with @ are cycle groups
            groups.Add(new CameraGroup(display, value));
        }

        return groups.ToArray();
    }
}