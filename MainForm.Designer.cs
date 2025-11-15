namespace BlueTimelapse;

partial class MainForm
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
        components = new System.ComponentModel.Container();
        groupBox1 = new System.Windows.Forms.GroupBox();
        previewErrorLabel = new System.Windows.Forms.Label();
        refreshButton = new System.Windows.Forms.Button();
        previewPictureBox = new System.Windows.Forms.PictureBox();
        groupBox2 = new System.Windows.Forms.GroupBox();
        label15 = new System.Windows.Forms.Label();
        groupDropDown = new System.Windows.Forms.ComboBox();
        label14 = new System.Windows.Forms.Label();
        intervalPicker = new System.Windows.Forms.DateTimePicker();
        label11 = new System.Windows.Forms.Label();
        label9 = new System.Windows.Forms.Label();
        fileNameTextBox = new System.Windows.Forms.TextBox();
        label6 = new System.Windows.Forms.Label();
        qualityInput = new System.Windows.Forms.NumericUpDown();
        label5 = new System.Windows.Forms.Label();
        pauseCheckBox = new System.Windows.Forms.CheckBox();
        label4 = new System.Windows.Forms.Label();
        heightInput = new System.Windows.Forms.NumericUpDown();
        widthInput = new System.Windows.Forms.NumericUpDown();
        label3 = new System.Windows.Forms.Label();
        saveToBrowseButton = new System.Windows.Forms.Button();
        saveToTextBox = new System.Windows.Forms.TextBox();
        label2 = new System.Windows.Forms.Label();
        label1 = new System.Windows.Forms.Label();
        groupBox3 = new System.Windows.Forms.GroupBox();
        reconnectButton = new System.Windows.Forms.Button();
        loggedInAsTextBox = new System.Windows.Forms.TextBox();
        label8 = new System.Windows.Forms.Label();
        label7 = new System.Windows.Forms.Label();
        connectedToTextBox = new System.Windows.Forms.TextBox();
        groupBox4 = new System.Windows.Forms.GroupBox();
        totalFileSizeLabel = new System.Windows.Forms.Label();
        totalImagesLabel = new System.Windows.Forms.Label();
        label13 = new System.Windows.Forms.Label();
        label12 = new System.Windows.Forms.Label();
        nextImageTimeLabel = new System.Windows.Forms.Label();
        label10 = new System.Windows.Forms.Label();
        groupBox5 = new System.Windows.Forms.GroupBox();
        logTextBox = new System.Windows.Forms.TextBox();
        timer = new System.Windows.Forms.Timer(components);
        groupBox1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)previewPictureBox).BeginInit();
        groupBox2.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)qualityInput).BeginInit();
        ((System.ComponentModel.ISupportInitialize)heightInput).BeginInit();
        ((System.ComponentModel.ISupportInitialize)widthInput).BeginInit();
        groupBox3.SuspendLayout();
        groupBox4.SuspendLayout();
        groupBox5.SuspendLayout();
        SuspendLayout();
        // 
        // groupBox1
        // 
        groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        groupBox1.Controls.Add(previewErrorLabel);
        groupBox1.Controls.Add(refreshButton);
        groupBox1.Controls.Add(previewPictureBox);
        groupBox1.Location = new System.Drawing.Point(350, 12);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new System.Drawing.Size(698, 530);
        groupBox1.TabIndex = 0;
        groupBox1.TabStop = false;
        groupBox1.Text = "Preview";
        // 
        // previewErrorLabel
        // 
        previewErrorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        previewErrorLabel.AutoEllipsis = true;
        previewErrorLabel.ForeColor = System.Drawing.Color.Red;
        previewErrorLabel.Location = new System.Drawing.Point(6, 501);
        previewErrorLabel.Name = "previewErrorLabel";
        previewErrorLabel.Size = new System.Drawing.Size(553, 23);
        previewErrorLabel.TabIndex = 2;
        previewErrorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // refreshButton
        // 
        refreshButton.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right));
        refreshButton.Location = new System.Drawing.Point(565, 500);
        refreshButton.Name = "refreshButton";
        refreshButton.Size = new System.Drawing.Size(127, 23);
        refreshButton.TabIndex = 100;
        refreshButton.Text = "Refresh Preview";
        refreshButton.UseVisualStyleBackColor = true;
        refreshButton.Click += refreshButton_Click;
        // 
        // previewPictureBox
        // 
        previewPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        previewPictureBox.BackColor = System.Drawing.Color.Black;
        previewPictureBox.Location = new System.Drawing.Point(6, 22);
        previewPictureBox.Name = "previewPictureBox";
        previewPictureBox.Size = new System.Drawing.Size(686, 472);
        previewPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
        previewPictureBox.TabIndex = 0;
        previewPictureBox.TabStop = false;
        // 
        // groupBox2
        // 
        groupBox2.Controls.Add(label15);
        groupBox2.Controls.Add(groupDropDown);
        groupBox2.Controls.Add(label14);
        groupBox2.Controls.Add(intervalPicker);
        groupBox2.Controls.Add(label11);
        groupBox2.Controls.Add(label9);
        groupBox2.Controls.Add(fileNameTextBox);
        groupBox2.Controls.Add(label6);
        groupBox2.Controls.Add(qualityInput);
        groupBox2.Controls.Add(label5);
        groupBox2.Controls.Add(pauseCheckBox);
        groupBox2.Controls.Add(label4);
        groupBox2.Controls.Add(heightInput);
        groupBox2.Controls.Add(widthInput);
        groupBox2.Controls.Add(label3);
        groupBox2.Controls.Add(saveToBrowseButton);
        groupBox2.Controls.Add(saveToTextBox);
        groupBox2.Controls.Add(label2);
        groupBox2.Controls.Add(label1);
        groupBox2.Location = new System.Drawing.Point(12, 100);
        groupBox2.Name = "groupBox2";
        groupBox2.Size = new System.Drawing.Size(332, 278);
        groupBox2.TabIndex = 1;
        groupBox2.TabStop = false;
        groupBox2.Text = "Timelapse Options";
        // 
        // label15
        // 
        label15.AutoSize = true;
        label15.Location = new System.Drawing.Point(6, 44);
        label15.Name = "label15";
        label15.Size = new System.Drawing.Size(40, 15);
        label15.TabIndex = 19;
        label15.Text = "Group";
        // 
        // groupDropDown
        // 
        groupDropDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        groupDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        groupDropDown.FormattingEnabled = true;
        groupDropDown.Location = new System.Drawing.Point(95, 41);
        groupDropDown.Name = "groupDropDown";
        groupDropDown.Size = new System.Drawing.Size(231, 23);
        groupDropDown.TabIndex = 3;
        groupDropDown.SelectedIndexChanged += OnSettingChange;
        groupDropDown.TextUpdate += OnSettingChange;
        // 
        // label14
        // 
        label14.AutoSize = true;
        label14.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
        label14.Location = new System.Drawing.Point(216, 130);
        label14.Name = "label14";
        label14.Size = new System.Drawing.Size(67, 15);
        label14.TabIndex = 18;
        label14.Text = "(hh:mm:ss)";
        // 
        // intervalPicker
        // 
        intervalPicker.CustomFormat = "HH:mm:ss";
        intervalPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
        intervalPicker.Location = new System.Drawing.Point(95, 127);
        intervalPicker.Name = "intervalPicker";
        intervalPicker.ShowUpDown = true;
        intervalPicker.Size = new System.Drawing.Size(115, 23);
        intervalPicker.TabIndex = 17;
        intervalPicker.Value = new System.DateTime(1900, 1, 1, 0, 5, 0, 0);
        intervalPicker.ValueChanged += OnSettingChange;
        // 
        // label11
        // 
        label11.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
        label11.Location = new System.Drawing.Point(181, 211);
        label11.Name = "label11";
        label11.Size = new System.Drawing.Size(104, 61);
        label11.TabIndex = 15;
        label11.Text = "%h Hour\r\n%m Minute\r\n%s Seconds";
        // 
        // label9
        // 
        label9.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
        label9.Location = new System.Drawing.Point(95, 212);
        label9.Name = "label9";
        label9.Size = new System.Drawing.Size(82, 61);
        label9.TabIndex = 14;
        label9.Text = "%d Day\r\n%M Month\r\n%y Year\r\n%w Week";
        // 
        // fileNameTextBox
        // 
        fileNameTextBox.Location = new System.Drawing.Point(95, 186);
        fileNameTextBox.Name = "fileNameTextBox";
        fileNameTextBox.Size = new System.Drawing.Size(231, 23);
        fileNameTextBox.TabIndex = 10;
        fileNameTextBox.TextChanged += OnSettingChange;
        // 
        // label6
        // 
        label6.AutoSize = true;
        label6.Location = new System.Drawing.Point(6, 189);
        label6.Name = "label6";
        label6.Size = new System.Drawing.Size(60, 15);
        label6.TabIndex = 12;
        label6.Text = "File Name";
        // 
        // qualityInput
        // 
        qualityInput.Location = new System.Drawing.Point(95, 99);
        qualityInput.Name = "qualityInput";
        qualityInput.Size = new System.Drawing.Size(120, 23);
        qualityInput.TabIndex = 6;
        qualityInput.ValueChanged += OnSettingChange;
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Location = new System.Drawing.Point(6, 101);
        label5.Name = "label5";
        label5.Size = new System.Drawing.Size(58, 15);
        label5.TabIndex = 10;
        label5.Text = "Quality %";
        // 
        // pauseCheckBox
        // 
        pauseCheckBox.AutoSize = true;
        pauseCheckBox.Location = new System.Drawing.Point(6, 22);
        pauseCheckBox.Name = "pauseCheckBox";
        pauseCheckBox.Size = new System.Drawing.Size(64, 19);
        pauseCheckBox.TabIndex = 3;
        pauseCheckBox.Text = "Paused";
        pauseCheckBox.UseVisualStyleBackColor = true;
        pauseCheckBox.CheckStateChanged += OnPausedChange;
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Location = new System.Drawing.Point(183, 74);
        label4.Name = "label4";
        label4.Size = new System.Drawing.Size(14, 15);
        label4.TabIndex = 8;
        label4.Text = "X";
        // 
        // heightInput
        // 
        heightInput.Location = new System.Drawing.Point(203, 70);
        heightInput.Maximum = new decimal(new int[] { 4320, 0, 0, 0 });
        heightInput.Name = "heightInput";
        heightInput.Size = new System.Drawing.Size(84, 23);
        heightInput.TabIndex = 5;
        heightInput.Value = new decimal(new int[] { 1080, 0, 0, 0 });
        heightInput.ValueChanged += OnSettingChange;
        // 
        // widthInput
        // 
        widthInput.Location = new System.Drawing.Point(95, 70);
        widthInput.Maximum = new decimal(new int[] { 7680, 0, 0, 0 });
        widthInput.Name = "widthInput";
        widthInput.Size = new System.Drawing.Size(84, 23);
        widthInput.TabIndex = 4;
        widthInput.Value = new decimal(new int[] { 1920, 0, 0, 0 });
        widthInput.ValueChanged += OnSettingChange;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new System.Drawing.Point(6, 72);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(63, 15);
        label3.TabIndex = 5;
        label3.Text = "Resolution";
        // 
        // saveToBrowseButton
        // 
        saveToBrowseButton.Location = new System.Drawing.Point(251, 157);
        saveToBrowseButton.Name = "saveToBrowseButton";
        saveToBrowseButton.Size = new System.Drawing.Size(75, 24);
        saveToBrowseButton.TabIndex = 9;
        saveToBrowseButton.Text = "Browse...";
        saveToBrowseButton.UseVisualStyleBackColor = true;
        saveToBrowseButton.Click += saveToBrowseButton_Click;
        // 
        // saveToTextBox
        // 
        saveToTextBox.Location = new System.Drawing.Point(95, 157);
        saveToTextBox.Name = "saveToTextBox";
        saveToTextBox.Size = new System.Drawing.Size(150, 23);
        saveToTextBox.TabIndex = 8;
        saveToTextBox.TextChanged += OnSettingChange;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new System.Drawing.Point(6, 161);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(82, 15);
        label2.TabIndex = 2;
        label2.Text = "Save Directory";
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new System.Drawing.Point(6, 130);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(46, 15);
        label1.TabIndex = 1;
        label1.Text = "Interval";
        // 
        // groupBox3
        // 
        groupBox3.Controls.Add(reconnectButton);
        groupBox3.Controls.Add(loggedInAsTextBox);
        groupBox3.Controls.Add(label8);
        groupBox3.Controls.Add(label7);
        groupBox3.Controls.Add(connectedToTextBox);
        groupBox3.Location = new System.Drawing.Point(12, 384);
        groupBox3.Name = "groupBox3";
        groupBox3.Size = new System.Drawing.Size(332, 113);
        groupBox3.TabIndex = 2;
        groupBox3.TabStop = false;
        groupBox3.Text = "BlueIris";
        // 
        // reconnectButton
        // 
        reconnectButton.Location = new System.Drawing.Point(6, 80);
        reconnectButton.Name = "reconnectButton";
        reconnectButton.Size = new System.Drawing.Size(320, 23);
        reconnectButton.TabIndex = 2;
        reconnectButton.Text = "Reconnect";
        reconnectButton.UseVisualStyleBackColor = true;
        reconnectButton.Click += reconnectButton_Click;
        // 
        // loggedInAsTextBox
        // 
        loggedInAsTextBox.Location = new System.Drawing.Point(92, 51);
        loggedInAsTextBox.Name = "loggedInAsTextBox";
        loggedInAsTextBox.ReadOnly = true;
        loggedInAsTextBox.Size = new System.Drawing.Size(234, 23);
        loggedInAsTextBox.TabIndex = 1;
        // 
        // label8
        // 
        label8.AutoSize = true;
        label8.Location = new System.Drawing.Point(6, 54);
        label8.Name = "label8";
        label8.Size = new System.Drawing.Size(74, 15);
        label8.TabIndex = 2;
        label8.Text = "Logged in as";
        // 
        // label7
        // 
        label7.AutoSize = true;
        label7.Location = new System.Drawing.Point(6, 25);
        label7.Name = "label7";
        label7.Size = new System.Drawing.Size(80, 15);
        label7.TabIndex = 1;
        label7.Text = "Connected To";
        // 
        // connectedToTextBox
        // 
        connectedToTextBox.Location = new System.Drawing.Point(92, 22);
        connectedToTextBox.Name = "connectedToTextBox";
        connectedToTextBox.ReadOnly = true;
        connectedToTextBox.Size = new System.Drawing.Size(234, 23);
        connectedToTextBox.TabIndex = 0;
        // 
        // groupBox4
        // 
        groupBox4.Controls.Add(totalFileSizeLabel);
        groupBox4.Controls.Add(totalImagesLabel);
        groupBox4.Controls.Add(label13);
        groupBox4.Controls.Add(label12);
        groupBox4.Controls.Add(nextImageTimeLabel);
        groupBox4.Controls.Add(label10);
        groupBox4.Location = new System.Drawing.Point(12, 12);
        groupBox4.Name = "groupBox4";
        groupBox4.Size = new System.Drawing.Size(326, 82);
        groupBox4.TabIndex = 3;
        groupBox4.TabStop = false;
        groupBox4.Text = "Status";
        // 
        // totalFileSizeLabel
        // 
        totalFileSizeLabel.AutoSize = true;
        totalFileSizeLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        totalFileSizeLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
        totalFileSizeLabel.Location = new System.Drawing.Point(92, 52);
        totalFileSizeLabel.Name = "totalFileSizeLabel";
        totalFileSizeLabel.Size = new System.Drawing.Size(36, 15);
        totalFileSizeLabel.TabIndex = 5;
        totalFileSizeLabel.Text = "0MiB";
        // 
        // totalImagesLabel
        // 
        totalImagesLabel.AutoSize = true;
        totalImagesLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        totalImagesLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
        totalImagesLabel.Location = new System.Drawing.Point(92, 37);
        totalImagesLabel.Name = "totalImagesLabel";
        totalImagesLabel.Size = new System.Drawing.Size(14, 15);
        totalImagesLabel.TabIndex = 4;
        totalImagesLabel.Text = "0";
        // 
        // label13
        // 
        label13.AutoSize = true;
        label13.Location = new System.Drawing.Point(6, 52);
        label13.Name = "label13";
        label13.Size = new System.Drawing.Size(73, 15);
        label13.TabIndex = 3;
        label13.Text = "Total file size";
        // 
        // label12
        // 
        label12.AutoSize = true;
        label12.Location = new System.Drawing.Point(6, 37);
        label12.Name = "label12";
        label12.Size = new System.Drawing.Size(73, 15);
        label12.TabIndex = 2;
        label12.Text = "Total images";
        // 
        // nextImageTimeLabel
        // 
        nextImageTimeLabel.AutoSize = true;
        nextImageTimeLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        nextImageTimeLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
        nextImageTimeLabel.Location = new System.Drawing.Point(92, 22);
        nextImageTimeLabel.Name = "nextImageTimeLabel";
        nextImageTimeLabel.Size = new System.Drawing.Size(19, 15);
        nextImageTimeLabel.TabIndex = 1;
        nextImageTimeLabel.Text = "0s";
        // 
        // label10
        // 
        label10.AutoSize = true;
        label10.Location = new System.Drawing.Point(6, 22);
        label10.Name = "label10";
        label10.Size = new System.Drawing.Size(81, 15);
        label10.TabIndex = 0;
        label10.Text = "Next image in";
        // 
        // groupBox5
        // 
        groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        groupBox5.Controls.Add(logTextBox);
        groupBox5.Location = new System.Drawing.Point(12, 548);
        groupBox5.Name = "groupBox5";
        groupBox5.Size = new System.Drawing.Size(1036, 175);
        groupBox5.TabIndex = 4;
        groupBox5.TabStop = false;
        groupBox5.Text = "Log";
        // 
        // logTextBox
        // 
        logTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
        logTextBox.Location = new System.Drawing.Point(3, 19);
        logTextBox.Multiline = true;
        logTextBox.Name = "logTextBox";
        logTextBox.ReadOnly = true;
        logTextBox.Size = new System.Drawing.Size(1030, 153);
        logTextBox.TabIndex = 0;
        // 
        // timer
        // 
        timer.Enabled = true;
        timer.Tick += timer_Tick;
        // 
        // MainForm
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(1060, 735);
        Controls.Add(groupBox5);
        Controls.Add(groupBox4);
        Controls.Add(groupBox3);
        Controls.Add(groupBox2);
        Controls.Add(groupBox1);
        Text = "BlueIris Timelapse";
        FormClosed += MainForm_FormClosed;
        Load += MainForm_Load;
        groupBox1.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)previewPictureBox).EndInit();
        groupBox2.ResumeLayout(false);
        groupBox2.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)qualityInput).EndInit();
        ((System.ComponentModel.ISupportInitialize)heightInput).EndInit();
        ((System.ComponentModel.ISupportInitialize)widthInput).EndInit();
        groupBox3.ResumeLayout(false);
        groupBox3.PerformLayout();
        groupBox4.ResumeLayout(false);
        groupBox4.PerformLayout();
        groupBox5.ResumeLayout(false);
        groupBox5.PerformLayout();
        ResumeLayout(false);
    }

    private System.Windows.Forms.Label label15;

    private System.Windows.Forms.Label label14;

    private System.Windows.Forms.DateTimePicker intervalPicker;

    private System.Windows.Forms.Label label12;
    private System.Windows.Forms.Label label13;
    private System.Windows.Forms.Label totalImagesLabel;
    private System.Windows.Forms.Label totalFileSizeLabel;

    private System.Windows.Forms.ComboBox groupDropDown;

    private System.Windows.Forms.Timer timer;

    private System.Windows.Forms.TextBox logTextBox;

    private System.Windows.Forms.GroupBox groupBox5;

    private System.Windows.Forms.Label label11;

    private System.Windows.Forms.GroupBox groupBox4;
    private System.Windows.Forms.Label label10;
    private System.Windows.Forms.Label nextImageTimeLabel;

    private System.Windows.Forms.Label label9;

    private System.Windows.Forms.Label previewErrorLabel;

    private System.Windows.Forms.GroupBox groupBox3;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.TextBox connectedToTextBox;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.TextBox loggedInAsTextBox;
    private System.Windows.Forms.Button reconnectButton;

    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.TextBox fileNameTextBox;

    private System.Windows.Forms.CheckBox pauseCheckBox;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.NumericUpDown qualityInput;

    private System.Windows.Forms.NumericUpDown widthInput;
    private System.Windows.Forms.NumericUpDown heightInput;
    private System.Windows.Forms.Label label4;

    private System.Windows.Forms.Label label3;

    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox saveToTextBox;
    private System.Windows.Forms.Button saveToBrowseButton;

    private System.Windows.Forms.Button refreshButton;

    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.Label label1;

    private System.Windows.Forms.PictureBox previewPictureBox;
    private System.Windows.Forms.GroupBox groupBox1;

    #endregion
}