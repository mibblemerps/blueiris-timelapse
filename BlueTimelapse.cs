using System.Globalization;
using BlueTimelapse.BlueIris;
using Newtonsoft.Json;

namespace BlueTimelapse;

public class BlueTimelapse
{
    public event Action? TookSnapshot;
    public event Action? GroupsUpdated;
    
    public readonly Settings Settings = new();
    
    public readonly List<CameraGroup> Groups = new();

    private string? _sessionKey;

    public DateTime? LastTimelapseImage { get; private set; }

    public BlueTimelapse()
    {
        try
        {
            LoadSettings();
        }
        catch (Exception)
        {
            // ignored
        }
        
        LastTimelapseImage = FindLastTimelapseImageDateTime() ?? DateTime.MinValue;

        Task.Run(async () =>
        {
            while (true)
            {
                await Task.Delay(TimeSpan.FromMilliseconds(10));
                try
                {
                    await Tick();
                }
                catch (Exception ex)
                {
                    Log.Error($"Timelapse error: {ex.Message}");
                    Console.WriteLine(ex.StackTrace);
                }
            }
        });
    }

    public void LoadSettings()
    {
        var settingsJson = File.ReadAllText("settings.json");
        JsonConvert.PopulateObject(settingsJson, Settings);
    }

    public void SaveSettings()
    {
        File.WriteAllText("settings.json", JsonConvert.SerializeObject(Settings, Formatting.Indented));
    }

    public async Task Login(string url, string username, string password)
    {
        _sessionKey = await Ui3.GetSessionKey(url, username, password);
        Settings.Url = url;
        Settings.Username = username;
        Settings.Password = password;
        SaveSettings();
        
        Log.Info($"Logged in to {url} as {username}");

        await ReloadGroups();
    }

    public async Task<byte[]> FetchImage(bool noReauth = false)
    {
        if (Settings.Url == null) throw new Exception("No url provided");

        try
        {
            return await Ui3.FetchImage(Settings.Url, _sessionKey, Settings.Group, Settings.Width, Settings.Height,
                Settings.Quality);
        }
        catch (Ui3LoginException)
        {
            if (noReauth || string.IsNullOrWhiteSpace(Settings.Username) || string.IsNullOrWhiteSpace(Settings.Password)) throw;

            // Login and retry
            await Login(Settings.Url, Settings.Username, Settings.Password);
            return await FetchImage(true);
        }
    }

    public async Task SaveTimelapseImage(byte[] image)
    {
        if (Settings.SaveDirectory == null) throw new Exception("No save directory set");
        if (Settings.FileName == null) throw new Exception("No file name set");
        
        Directory.CreateDirectory(Settings.SaveDirectory);

        var fileName = Settings.FileName.Replace('/', '\\');

        fileName = fileName.Replace("%d", DateTime.Now.ToString("dd"))
            .Replace("%M", DateTime.Now.ToString("MM"))
            .Replace("%y", DateTime.Now.ToString("yyyy"))
            .Replace("%h", DateTime.Now.ToString("HH"))
            .Replace("%m", DateTime.Now.ToString("mm"))
            .Replace("%s", DateTime.Now.ToString("ss"))
            .Replace("%w", new GregorianCalendar().GetWeekOfYear(DateTime.Now, CalendarWeekRule.FirstFullWeek, DayOfWeek.Monday).ToString());
        
        var subDirectory = "";
        if (fileName.Contains("\\"))
        {
            subDirectory = fileName.Substring(0, fileName.LastIndexOf('\\'));
            Directory.CreateDirectory(Path.Combine(Settings.SaveDirectory, subDirectory));
        }
        
        await File.WriteAllBytesAsync(Path.Combine(Settings.SaveDirectory, fileName), image);
        
        Log.Info($"Saved timelapse image: {fileName}");
    }

    private async Task ReloadGroups()
    {
        if (Settings.Url == null) throw new Exception("No url provided");
        if (_sessionKey == null) throw new Ui3LoginException("Not logged in");
        
        var groups = await Ui3.GetCamerasAndGroups(Settings.Url, _sessionKey);
        Groups.Clear();
        Groups.AddRange(groups);
        GroupsUpdated?.Invoke();
    }

    private DateTime? FindLastTimelapseImageDateTime()
    {
        var newest = DateTime.MinValue;
        
        if (!Directory.Exists(Settings.SaveDirectory)) return null;
        foreach (var path in Enumerable.Concat(Directory.EnumerateFiles(Settings.SaveDirectory, "*.jpg", SearchOption.AllDirectories),
                     Directory.EnumerateFiles(Settings.SaveDirectory, "*.jpeg", SearchOption.AllDirectories)))
        {
            var created = File.GetCreationTime(path);
            if (created > newest) newest = created;
        }
        
        if (newest <= DateTime.MinValue) return null;
        return newest;
    }

    private async Task Tick()
    {
        var delta = DateTime.Now - LastTimelapseImage;
        if (delta < TimeSpan.FromSeconds(Settings.Interval) || Settings.Paused) return; // not time yet

        LastTimelapseImage = DateTime.Now;
        
        await SaveTimelapseImage(await FetchImage());
        
        TookSnapshot?.Invoke();
    }
}