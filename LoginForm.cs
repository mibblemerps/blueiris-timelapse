using BlueTimelapse.BlueIris;

namespace BlueTimelapse;

public partial class LoginForm : Form
{
    public string Url => urlTextBox.Text;
    public string Username => usernameTextBox.Text;
    public string Password => passwordTextBox.Text;
    
    public LoginForm()
    {
        InitializeComponent();
    }

    private async void loginButton_Click(object sender, EventArgs e)
    {
        DialogResult = DialogResult.OK;
        Close();
    }
}