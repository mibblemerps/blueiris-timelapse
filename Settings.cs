namespace BlueTimelapse;

public class Settings
{
    public bool Paused = true;
    public string Group = "index";
    public int Width = 1920;
    public int Height = 1080;
    public int Quality = 95;
    public int Interval = 300;
    public string SaveDirectory = "";
    public string FileName = "%y-%M-%d %h_%m_%s.jpg";
    public bool Decode;
    public bool Stream;
    public string? Url;
    public string? Username;
    public string? Password;
}