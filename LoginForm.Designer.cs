using System.ComponentModel;

namespace BlueTimelapse;

partial class LoginForm
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        label1 = new System.Windows.Forms.Label();
        usernameTextBox = new System.Windows.Forms.TextBox();
        urlTextBox = new System.Windows.Forms.TextBox();
        label2 = new System.Windows.Forms.Label();
        passwordTextBox = new System.Windows.Forms.TextBox();
        label3 = new System.Windows.Forms.Label();
        loginButton = new System.Windows.Forms.Button();
        SuspendLayout();
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new System.Drawing.Point(12, 44);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(60, 15);
        label1.TabIndex = 0;
        label1.Text = "Username";
        // 
        // usernameTextBox
        // 
        usernameTextBox.Location = new System.Drawing.Point(78, 41);
        usernameTextBox.Name = "usernameTextBox";
        usernameTextBox.Size = new System.Drawing.Size(280, 23);
        usernameTextBox.TabIndex = 1;
        // 
        // urlTextBox
        // 
        urlTextBox.Location = new System.Drawing.Point(78, 12);
        urlTextBox.Name = "urlTextBox";
        urlTextBox.Size = new System.Drawing.Size(280, 23);
        urlTextBox.TabIndex = 0;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new System.Drawing.Point(12, 15);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(48, 15);
        label2.TabIndex = 2;
        label2.Text = "UI3 URL";
        // 
        // passwordTextBox
        // 
        passwordTextBox.Location = new System.Drawing.Point(78, 70);
        passwordTextBox.Name = "passwordTextBox";
        passwordTextBox.Size = new System.Drawing.Size(280, 23);
        passwordTextBox.TabIndex = 2;
        passwordTextBox.UseSystemPasswordChar = true;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new System.Drawing.Point(12, 73);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(57, 15);
        label3.TabIndex = 4;
        label3.Text = "Password";
        // 
        // loginButton
        // 
        loginButton.Location = new System.Drawing.Point(283, 99);
        loginButton.Name = "loginButton";
        loginButton.Size = new System.Drawing.Size(75, 26);
        loginButton.TabIndex = 3;
        loginButton.Text = "Login";
        loginButton.UseVisualStyleBackColor = true;
        loginButton.Click += loginButton_Click;
        // 
        // LoginForm
        // 
        AcceptButton = loginButton;
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(370, 135);
        Controls.Add(loginButton);
        Controls.Add(passwordTextBox);
        Controls.Add(label3);
        Controls.Add(urlTextBox);
        Controls.Add(label2);
        Controls.Add(usernameTextBox);
        Controls.Add(label1);
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
        Text = "BlueIris Login";
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.TextBox usernameTextBox;
    private System.Windows.Forms.TextBox urlTextBox;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox passwordTextBox;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Button loginButton;

    private System.Windows.Forms.Label label1;

    #endregion
}