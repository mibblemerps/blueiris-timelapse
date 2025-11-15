using System.Globalization;
using BlueTimelapse.BlueIris;

namespace BlueTimelapse;

public partial class MainForm : Form
{
    private BlueTimelapse _blueTimelapse;

    private bool _loadingSettings;
    
    public MainForm(BlueTimelapse blueTimelapse)
    {
        InitializeComponent();
        
        _blueTimelapse = blueTimelapse;
        
        LoadSettings();
    }
    
    private async void MainForm_Load(object sender, EventArgs e)
    {
        Log.MessageLogged += LogOnMessageLogged;
        _blueTimelapse.TookSnapshot += BlueTimelapseOnTookSnapshot;
        _blueTimelapse.GroupsUpdated += BlueTimelapseOnGroupsUpdated;
        
        RefreshPreview();
        try
        {
            await RefreshFileStats();
        }
        catch (Exception ex)
        {
            Log.Warning("Failed to get file stats: " + ex.Message);
        }
    }

    private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
    {
        Log.MessageLogged -= LogOnMessageLogged;
        _blueTimelapse.TookSnapshot -= BlueTimelapseOnTookSnapshot;
        _blueTimelapse.GroupsUpdated -= BlueTimelapseOnGroupsUpdated;
    }
    
    private void LogOnMessageLogged(Log.Level level, string msg)
    {
        // invoke required in-case we log from another thread
        Invoke(() =>
        {
            // crudely trim the text if it gets too long
            if (logTextBox.Text.Length > 10240)
            {
                logTextBox.Text = logTextBox.Text.Substring(5120);
            }
        
            logTextBox.AppendText($"[{DateTime.Now:hh:mm:ss}] [{level.ToString().ToUpper()}]\t{msg}\r\n");
        });
    }

    private void LoadSettings()
    {
        _loadingSettings = true;
        
        var settings = _blueTimelapse.Settings;
        groupDropDown.SelectedItem = _blueTimelapse.Groups.FirstOrDefault(g => g.value == settings.Group);
        pauseCheckBox.Checked = settings.Paused;
        widthInput.Value = settings.Width;
        heightInput.Value = settings.Height;
        qualityInput.Value = settings.Quality;
        saveToTextBox.Text = settings.SaveDirectory;
        fileNameTextBox.Text = settings.FileName;
        
        var date = new DateTime(1900, 1, 1, 0, 0, 0).AddSeconds(settings.Interval);
        intervalPicker.Value = date;

        connectedToTextBox.Text = settings.Url;
        loggedInAsTextBox.Text = settings.Username;
        
        _loadingSettings = false;
    }

    private void SaveSettings()
    {
        var settings = _blueTimelapse.Settings;
        settings.Group = (groupDropDown.SelectedItem as CameraGroup)?.value ?? "index";
        settings.Paused = pauseCheckBox.Checked;
        settings.Width = (int)widthInput.Value;
        settings.Height = (int)heightInput.Value;
        settings.Quality = (int)qualityInput.Value;
        settings.SaveDirectory = saveToTextBox.Text;
        settings.FileName = fileNameTextBox.Text;
        settings.Interval = intervalPicker.Value.Hour * 60 * 60 +
                            intervalPicker.Value.Minute * 60 +
                            intervalPicker.Value.Second;
        
        _blueTimelapse.SaveSettings();
    }

    private async void RefreshPreview()
    {
        try
        {
            var image = await _blueTimelapse.FetchImage();
            previewPictureBox.Image = Image.FromStream(new MemoryStream(image));
            previewErrorLabel.Text = "";
        }
        catch (Exception ex)
        {
            previewErrorLabel.Text = ex.Message;
        }
    }

    private async Task RefreshFileStats()
    {
        var files = Directory.GetFiles(_blueTimelapse.Settings.SaveDirectory, "*.*", SearchOption.AllDirectories);
        totalImagesLabel.Text = files.Length.ToString();

        double fileSize = 0;
        foreach (var file in files)
        {
            if (!file.EndsWith(".jpg", StringComparison.InvariantCultureIgnoreCase) && !file.EndsWith(".jpeg", StringComparison.InvariantCultureIgnoreCase)) continue;
            fileSize += new FileInfo(file).Length / 1024.0 / 1024.0;
        }

        string fileSizeText;
        if (fileSize < 1024)
        {
            totalFileSizeLabel.Text = Math.Round(fileSize, 2).ToString(CultureInfo.InvariantCulture) + " MiB";
        }
        else if (fileSize < 1024 * 1024)
        {
            totalFileSizeLabel.Text = Math.Round(fileSize / 1024, 2).ToString(CultureInfo.InvariantCulture) + " GiB";
        }
        else
        {
            totalFileSizeLabel.Text = Math.Round(fileSize / 1024 / 1024, 2).ToString(CultureInfo.InvariantCulture) + " TiB";
        }
    }

    private void OnSettingChange(object sender, EventArgs e)
    {
        if (_loadingSettings) return;
        
        SaveSettings();
        RefreshPreview();
    }

    private void OnPausedChange(object sender, EventArgs e)
    {
        OnSettingChange(sender, e);

        var paused = _blueTimelapse.Settings.Paused;
        widthInput.ReadOnly = !paused;
        heightInput.ReadOnly = !paused;
        qualityInput.ReadOnly = !paused;
        saveToTextBox.ReadOnly = !paused;
        saveToBrowseButton.Enabled = paused;
        fileNameTextBox.ReadOnly = !paused;
        intervalPicker.Enabled = paused;
        groupDropDown.Enabled = paused;
        reconnectButton.Enabled = paused;
    }
    
    private void BlueTimelapseOnGroupsUpdated()
    {
        Invoke(() =>
        {
            groupDropDown.Items.Clear();
            groupDropDown.Items.AddRange(_blueTimelapse.Groups.ToArray<object>());

            if (!_loadingSettings)
            {
                _loadingSettings = true;
                groupDropDown.SelectedItem =
                    _blueTimelapse.Groups.FirstOrDefault(g => g.value == _blueTimelapse.Settings.Group);
                _loadingSettings = false;
            }
        });
    }

    private void saveToBrowseButton_Click(object sender, EventArgs e)
    {
        var browseDialog = new FolderBrowserDialog();
        if (browseDialog.ShowDialog() != DialogResult.OK) return;
        saveToTextBox.Text = browseDialog.SelectedPath;
    }

    private async void reconnectButton_Click(object sender, EventArgs e)
    {
        var login = new LoginForm();
        if (login.ShowDialog() != DialogResult.OK) return;

        try
        {
            await _blueTimelapse.Login(login.Url, login.Username, login.Password);
            LoadSettings();
            MessageBox.Show("Logged in as " + login.Username, "BlueIris Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch (Exception ex)
        {
            MessageBox.Show("Login failed: " + ex.Message, "BlueIris Login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        
        RefreshPreview();
    }

    private void refreshButton_Click(object sender, EventArgs e)
    {
        RefreshPreview();
    }

    private void timer_Tick(object sender, EventArgs e)
    {
        if (_blueTimelapse.Settings.Paused)
        {
            nextImageTimeLabel.Text = "Paused";
            return;
        }
        
        var nextImageAt = (_blueTimelapse.LastTimelapseImage ?? DateTime.Now) + TimeSpan.FromSeconds(_blueTimelapse.Settings.Interval);
        if (nextImageAt > DateTime.Now)
        {
            var delta = nextImageAt - DateTime.Now;
            nextImageTimeLabel.Text = delta.Minutes.ToString("00") + ":" + delta.Seconds.ToString("00");
        }
        else
        {
            nextImageTimeLabel.Text = "...";
        }
    }
    
    private void BlueTimelapseOnTookSnapshot()
    {
        Invoke(async () =>
        {
            RefreshPreview();

            try
            {
                await RefreshFileStats();
            }
            catch (Exception ex)
            {
                Log.Warning("Failed to get file stats: " + ex.Message);
            }
        });
    }
}