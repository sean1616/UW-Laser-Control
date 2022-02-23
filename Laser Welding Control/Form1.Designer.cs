namespace Laser_Welding_Control
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.components = new System.ComponentModel.Container();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.comboBoxCOMPort = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.textBoxWrite = new System.Windows.Forms.TextBox();
            this.textBoxRead = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnRead = new System.Windows.Forms.Button();
            this.btnRefreshPorts = new System.Windows.Forms.Button();
            this.comboBoxBaudRate = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.CommandTab = new System.Windows.Forms.TabPage();
            this.label14 = new System.Windows.Forms.Label();
            this.label_takeControl = new System.Windows.Forms.Label();
            this.textBox_setEnergy = new System.Windows.Forms.TextBox();
            this.textBox_energyCap = new System.Windows.Forms.TextBox();
            this.textBox_LowerEnergy = new System.Windows.Forms.TextBox();
            this.textBox_inputPower = new System.Windows.Forms.TextBox();
            this.textBox_peakPower = new System.Windows.Forms.TextBox();
            this.textBox_repetition = new System.Windows.Forms.TextBox();
            this.textBox_firingTimes = new System.Windows.Forms.TextBox();
            this.textBox_feedBack = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox_scheme = new System.Windows.Forms.ComboBox();
            this.btn_readScheme = new System.Windows.Forms.Button();
            this.HexModePanel = new System.Windows.Forms.Panel();
            this.rbtnHexMode = new System.Windows.Forms.RadioButton();
            this.rbtnASCIIMode = new System.Windows.Forms.RadioButton();
            this.SettingsTab = new System.Windows.Forms.TabPage();
            this.comboBoxMachineID = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.COMStatusLabel = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.button_ResetUI = new System.Windows.Forms.Button();
            this.ceLearningToggle1 = new ToggleButtonExample.CeLearningToggle();
            this.ceLearningToggle_LaserVoltage = new ToggleButtonExample.CeLearningToggle();
            this.ceLearningToggle_TakeControl = new ToggleButtonExample.CeLearningToggle();
            this.tabControl1.SuspendLayout();
            this.CommandTab.SuspendLayout();
            this.HexModePanel.SuspendLayout();
            this.SettingsTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxCOMPort
            // 
            this.comboBoxCOMPort.FormattingEnabled = true;
            this.comboBoxCOMPort.Location = new System.Drawing.Point(11, 66);
            this.comboBoxCOMPort.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxCOMPort.Name = "comboBoxCOMPort";
            this.comboBoxCOMPort.Size = new System.Drawing.Size(121, 28);
            this.comboBoxCOMPort.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "選擇 COM port:";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(346, 58);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(120, 45);
            this.btnConnect.TabIndex = 2;
            this.btnConnect.Text = "連線";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // textBoxWrite
            // 
            this.textBoxWrite.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxWrite.Location = new System.Drawing.Point(93, 101);
            this.textBoxWrite.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxWrite.Multiline = true;
            this.textBoxWrite.Name = "textBoxWrite";
            this.textBoxWrite.Size = new System.Drawing.Size(1500, 28);
            this.textBoxWrite.TabIndex = 3;
            // 
            // textBoxRead
            // 
            this.textBoxRead.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRead.Location = new System.Drawing.Point(91, 209);
            this.textBoxRead.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxRead.Multiline = true;
            this.textBoxRead.Name = "textBoxRead";
            this.textBoxRead.Size = new System.Drawing.Size(1500, 28);
            this.textBoxRead.TabIndex = 4;
            // 
            // btnSend
            // 
            this.btnSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.Location = new System.Drawing.Point(12, 101);
            this.btnSend.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 28);
            this.btnSend.TabIndex = 5;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnRead
            // 
            this.btnRead.Enabled = false;
            this.btnRead.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRead.Location = new System.Drawing.Point(12, 209);
            this.btnRead.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(75, 28);
            this.btnRead.TabIndex = 6;
            this.btnRead.Text = "Read";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // btnRefreshPorts
            // 
            this.btnRefreshPorts.Location = new System.Drawing.Point(138, 66);
            this.btnRefreshPorts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRefreshPorts.Name = "btnRefreshPorts";
            this.btnRefreshPorts.Size = new System.Drawing.Size(84, 26);
            this.btnRefreshPorts.TabIndex = 7;
            this.btnRefreshPorts.Text = "刷新";
            this.btnRefreshPorts.UseVisualStyleBackColor = true;
            this.btnRefreshPorts.Click += new System.EventHandler(this.btnRefreshPorts_Click);
            // 
            // comboBoxBaudRate
            // 
            this.comboBoxBaudRate.FormattingEnabled = true;
            this.comboBoxBaudRate.Items.AddRange(new object[] {
            "4800",
            "9600",
            "14400",
            "19200",
            "28800",
            "38400",
            "56000",
            "57600",
            "115200"});
            this.comboBoxBaudRate.Location = new System.Drawing.Point(11, 120);
            this.comboBoxBaudRate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxBaudRate.Name = "comboBoxBaudRate";
            this.comboBoxBaudRate.Size = new System.Drawing.Size(121, 28);
            this.comboBoxBaudRate.TabIndex = 9;
            this.comboBoxBaudRate.SelectedIndexChanged += new System.EventHandler(this.comboBoxBaudRate_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(251, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "選擇 Baud rate: (19200 by default)";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(501, 58);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(0, 20);
            this.labelStatus.TabIndex = 11;
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Enabled = false;
            this.btnDisconnect.Location = new System.Drawing.Point(346, 120);
            this.btnDisconnect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(120, 45);
            this.btnDisconnect.TabIndex = 12;
            this.btnDisconnect.Text = "中斷連線";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(391, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "TX: (Please type in ASCII command format. ex: RALS)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "RX:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.CommandTab);
            this.tabControl1.Controls.Add(this.SettingsTab);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1028, 599);
            this.tabControl1.TabIndex = 15;
            // 
            // CommandTab
            // 
            this.CommandTab.Controls.Add(this.button_ResetUI);
            this.CommandTab.Controls.Add(this.ceLearningToggle1);
            this.CommandTab.Controls.Add(this.label15);
            this.CommandTab.Controls.Add(this.ceLearningToggle_LaserVoltage);
            this.CommandTab.Controls.Add(this.label14);
            this.CommandTab.Controls.Add(this.label_takeControl);
            this.CommandTab.Controls.Add(this.ceLearningToggle_TakeControl);
            this.CommandTab.Controls.Add(this.textBox_setEnergy);
            this.CommandTab.Controls.Add(this.textBox_energyCap);
            this.CommandTab.Controls.Add(this.textBox_LowerEnergy);
            this.CommandTab.Controls.Add(this.textBox_inputPower);
            this.CommandTab.Controls.Add(this.textBox_peakPower);
            this.CommandTab.Controls.Add(this.textBox_repetition);
            this.CommandTab.Controls.Add(this.textBox_firingTimes);
            this.CommandTab.Controls.Add(this.textBox_feedBack);
            this.CommandTab.Controls.Add(this.label13);
            this.CommandTab.Controls.Add(this.label12);
            this.CommandTab.Controls.Add(this.label11);
            this.CommandTab.Controls.Add(this.label10);
            this.CommandTab.Controls.Add(this.label9);
            this.CommandTab.Controls.Add(this.label8);
            this.CommandTab.Controls.Add(this.label7);
            this.CommandTab.Controls.Add(this.label6);
            this.CommandTab.Controls.Add(this.comboBox_scheme);
            this.CommandTab.Controls.Add(this.btn_readScheme);
            this.CommandTab.Controls.Add(this.HexModePanel);
            this.CommandTab.Location = new System.Drawing.Point(4, 29);
            this.CommandTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CommandTab.Name = "CommandTab";
            this.CommandTab.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CommandTab.Size = new System.Drawing.Size(1020, 566);
            this.CommandTab.TabIndex = 1;
            this.CommandTab.Text = "命令";
            this.CommandTab.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(24, 71);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(73, 20);
            this.label14.TabIndex = 50;
            this.label14.Text = "雷射高壓";
            // 
            // label_takeControl
            // 
            this.label_takeControl.AutoSize = true;
            this.label_takeControl.Location = new System.Drawing.Point(24, 22);
            this.label_takeControl.Name = "label_takeControl";
            this.label_takeControl.Size = new System.Drawing.Size(57, 20);
            this.label_takeControl.TabIndex = 49;
            this.label_takeControl.Text = "控制權";
            this.label_takeControl.Click += new System.EventHandler(this.label14_Click);
            // 
            // textBox_setEnergy
            // 
            this.textBox_setEnergy.Location = new System.Drawing.Point(943, 79);
            this.textBox_setEnergy.Name = "textBox_setEnergy";
            this.textBox_setEnergy.Size = new System.Drawing.Size(65, 26);
            this.textBox_setEnergy.TabIndex = 47;
            // 
            // textBox_energyCap
            // 
            this.textBox_energyCap.Location = new System.Drawing.Point(943, 51);
            this.textBox_energyCap.Name = "textBox_energyCap";
            this.textBox_energyCap.Size = new System.Drawing.Size(65, 26);
            this.textBox_energyCap.TabIndex = 46;
            // 
            // textBox_LowerEnergy
            // 
            this.textBox_LowerEnergy.Location = new System.Drawing.Point(943, 22);
            this.textBox_LowerEnergy.Name = "textBox_LowerEnergy";
            this.textBox_LowerEnergy.Size = new System.Drawing.Size(65, 26);
            this.textBox_LowerEnergy.TabIndex = 45;
            // 
            // textBox_inputPower
            // 
            this.textBox_inputPower.Location = new System.Drawing.Point(732, 48);
            this.textBox_inputPower.Name = "textBox_inputPower";
            this.textBox_inputPower.Size = new System.Drawing.Size(65, 26);
            this.textBox_inputPower.TabIndex = 44;
            // 
            // textBox_peakPower
            // 
            this.textBox_peakPower.Location = new System.Drawing.Point(732, 76);
            this.textBox_peakPower.Name = "textBox_peakPower";
            this.textBox_peakPower.Size = new System.Drawing.Size(65, 26);
            this.textBox_peakPower.TabIndex = 43;
            // 
            // textBox_repetition
            // 
            this.textBox_repetition.Location = new System.Drawing.Point(732, 108);
            this.textBox_repetition.Name = "textBox_repetition";
            this.textBox_repetition.Size = new System.Drawing.Size(65, 26);
            this.textBox_repetition.TabIndex = 42;
            // 
            // textBox_firingTimes
            // 
            this.textBox_firingTimes.Location = new System.Drawing.Point(732, 140);
            this.textBox_firingTimes.Name = "textBox_firingTimes";
            this.textBox_firingTimes.Size = new System.Drawing.Size(65, 26);
            this.textBox_firingTimes.TabIndex = 41;
            // 
            // textBox_feedBack
            // 
            this.textBox_feedBack.Location = new System.Drawing.Point(732, 22);
            this.textBox_feedBack.Name = "textBox_feedBack";
            this.textBox_feedBack.Size = new System.Drawing.Size(65, 26);
            this.textBox_feedBack.TabIndex = 40;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(823, 79);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(86, 20);
            this.label13.TabIndex = 31;
            this.label13.Text = "Set energy";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(823, 51);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(89, 20);
            this.label12.TabIndex = 30;
            this.label12.Text = "Energy cap";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(823, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(104, 20);
            this.label11.TabIndex = 29;
            this.label11.Text = "Lower energy";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(612, 143);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 20);
            this.label10.TabIndex = 28;
            this.label10.Text = "Firing times";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(612, 110);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 20);
            this.label9.TabIndex = 27;
            this.label9.Text = "Repetition";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(612, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 20);
            this.label8.TabIndex = 26;
            this.label8.Text = "Input power";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(612, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 20);
            this.label7.TabIndex = 25;
            this.label7.Text = "Peak power";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(612, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 20);
            this.label6.TabIndex = 24;
            this.label6.Text = "FeedBack";
            // 
            // comboBox_scheme
            // 
            this.comboBox_scheme.FormattingEnabled = true;
            this.comboBox_scheme.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.comboBox_scheme.Location = new System.Drawing.Point(473, 68);
            this.comboBox_scheme.Name = "comboBox_scheme";
            this.comboBox_scheme.Size = new System.Drawing.Size(119, 28);
            this.comboBox_scheme.TabIndex = 23;
            this.comboBox_scheme.Text = "00";
            // 
            // btn_readScheme
            // 
            this.btn_readScheme.Location = new System.Drawing.Point(473, 22);
            this.btn_readScheme.Name = "btn_readScheme";
            this.btn_readScheme.Size = new System.Drawing.Size(119, 31);
            this.btn_readScheme.TabIndex = 22;
            this.btn_readScheme.Text = "讀取參數";
            this.btn_readScheme.UseVisualStyleBackColor = true;
            this.btn_readScheme.Click += new System.EventHandler(this.btn_readScheme_Click);
            // 
            // HexModePanel
            // 
            this.HexModePanel.Controls.Add(this.rbtnHexMode);
            this.HexModePanel.Controls.Add(this.rbtnASCIIMode);
            this.HexModePanel.Controls.Add(this.textBoxWrite);
            this.HexModePanel.Controls.Add(this.btnRead);
            this.HexModePanel.Controls.Add(this.label4);
            this.HexModePanel.Controls.Add(this.btnSend);
            this.HexModePanel.Controls.Add(this.textBoxRead);
            this.HexModePanel.Controls.Add(this.label3);
            this.HexModePanel.Location = new System.Drawing.Point(6, 206);
            this.HexModePanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HexModePanel.Name = "HexModePanel";
            this.HexModePanel.Size = new System.Drawing.Size(1666, 293);
            this.HexModePanel.TabIndex = 15;
            // 
            // rbtnHexMode
            // 
            this.rbtnHexMode.AutoSize = true;
            this.rbtnHexMode.Location = new System.Drawing.Point(11, 30);
            this.rbtnHexMode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtnHexMode.Name = "rbtnHexMode";
            this.rbtnHexMode.Size = new System.Drawing.Size(176, 24);
            this.rbtnHexMode.TabIndex = 16;
            this.rbtnHexMode.Text = "Hex Command Mode";
            this.rbtnHexMode.UseVisualStyleBackColor = true;
            this.rbtnHexMode.CheckedChanged += new System.EventHandler(this.CommandModeCheckedChange);
            // 
            // rbtnASCIIMode
            // 
            this.rbtnASCIIMode.AutoSize = true;
            this.rbtnASCIIMode.Checked = true;
            this.rbtnASCIIMode.Location = new System.Drawing.Point(11, 2);
            this.rbtnASCIIMode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtnASCIIMode.Name = "rbtnASCIIMode";
            this.rbtnASCIIMode.Size = new System.Drawing.Size(191, 24);
            this.rbtnASCIIMode.TabIndex = 15;
            this.rbtnASCIIMode.TabStop = true;
            this.rbtnASCIIMode.Text = "ASCII Command Mode";
            this.rbtnASCIIMode.UseVisualStyleBackColor = true;
            this.rbtnASCIIMode.CheckedChanged += new System.EventHandler(this.CommandModeCheckedChange);
            // 
            // SettingsTab
            // 
            this.SettingsTab.Controls.Add(this.comboBoxMachineID);
            this.SettingsTab.Controls.Add(this.label5);
            this.SettingsTab.Controls.Add(this.btnRefreshPorts);
            this.SettingsTab.Controls.Add(this.comboBoxCOMPort);
            this.SettingsTab.Controls.Add(this.label1);
            this.SettingsTab.Controls.Add(this.btnDisconnect);
            this.SettingsTab.Controls.Add(this.btnConnect);
            this.SettingsTab.Controls.Add(this.labelStatus);
            this.SettingsTab.Controls.Add(this.comboBoxBaudRate);
            this.SettingsTab.Controls.Add(this.label2);
            this.SettingsTab.Location = new System.Drawing.Point(4, 29);
            this.SettingsTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SettingsTab.Name = "SettingsTab";
            this.SettingsTab.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SettingsTab.Size = new System.Drawing.Size(1020, 566);
            this.SettingsTab.TabIndex = 2;
            this.SettingsTab.Text = "設定";
            this.SettingsTab.UseVisualStyleBackColor = true;
            // 
            // comboBoxMachineID
            // 
            this.comboBoxMachineID.FormattingEnabled = true;
            this.comboBoxMachineID.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15"});
            this.comboBoxMachineID.Location = new System.Drawing.Point(11, 178);
            this.comboBoxMachineID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxMachineID.Name = "comboBoxMachineID";
            this.comboBoxMachineID.Size = new System.Drawing.Size(121, 28);
            this.comboBoxMachineID.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(285, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "選擇雷射 ID: (預設值為00，1號機為07)";
            // 
            // COMStatusLabel
            // 
            this.COMStatusLabel.AutoSize = true;
            this.COMStatusLabel.BackColor = System.Drawing.Color.Red;
            this.COMStatusLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.COMStatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.COMStatusLabel.Location = new System.Drawing.Point(0, 579);
            this.COMStatusLabel.Name = "COMStatusLabel";
            this.COMStatusLabel.Size = new System.Drawing.Size(226, 20);
            this.COMStatusLabel.TabIndex = 16;
            this.COMStatusLabel.Text = "COM Status: Disconnected";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(24, 120);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(85, 20);
            this.label15.TabIndex = 52;
            this.label15.Text = "能量 / 電流";
            // 
            // button_ResetUI
            // 
            this.button_ResetUI.Location = new System.Drawing.Point(246, 22);
            this.button_ResetUI.Name = "button_ResetUI";
            this.button_ResetUI.Size = new System.Drawing.Size(147, 28);
            this.button_ResetUI.TabIndex = 54;
            this.button_ResetUI.Text = "介面除錯";
            this.button_ResetUI.UseVisualStyleBackColor = true;
            this.button_ResetUI.Click += new System.EventHandler(this.button_ResetUI_Click);
            // 
            // ceLearningToggle1
            // 
            this.ceLearningToggle1.BorderColor = System.Drawing.Color.LightGray;
            this.ceLearningToggle1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ceLearningToggle1.ForeColor = System.Drawing.Color.White;
            this.ceLearningToggle1.IsOn = false;
            this.ceLearningToggle1.Location = new System.Drawing.Point(125, 117);
            this.ceLearningToggle1.Name = "ceLearningToggle1";
            this.ceLearningToggle1.OffColor = System.Drawing.Color.DarkGray;
            this.ceLearningToggle1.OffText = "OFF";
            this.ceLearningToggle1.OnColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ceLearningToggle1.OnText = "ON";
            this.ceLearningToggle1.Size = new System.Drawing.Size(50, 27);
            this.ceLearningToggle1.TabIndex = 53;
            this.ceLearningToggle1.Text = "ceLearningToggle_Energy_Current";
            this.ceLearningToggle1.TextEnabled = true;
            this.ceLearningToggle1.Click += new System.EventHandler(this.ceLearningToggle1_Click);
            // 
            // ceLearningToggle_LaserVoltage
            // 
            this.ceLearningToggle_LaserVoltage.BorderColor = System.Drawing.Color.LightGray;
            this.ceLearningToggle_LaserVoltage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ceLearningToggle_LaserVoltage.ForeColor = System.Drawing.Color.White;
            this.ceLearningToggle_LaserVoltage.IsOn = false;
            this.ceLearningToggle_LaserVoltage.Location = new System.Drawing.Point(125, 68);
            this.ceLearningToggle_LaserVoltage.Name = "ceLearningToggle_LaserVoltage";
            this.ceLearningToggle_LaserVoltage.OffColor = System.Drawing.Color.DarkGray;
            this.ceLearningToggle_LaserVoltage.OffText = "OFF";
            this.ceLearningToggle_LaserVoltage.OnColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ceLearningToggle_LaserVoltage.OnText = "ON";
            this.ceLearningToggle_LaserVoltage.Size = new System.Drawing.Size(50, 27);
            this.ceLearningToggle_LaserVoltage.TabIndex = 51;
            this.ceLearningToggle_LaserVoltage.Text = "ceLearningToggle2";
            this.ceLearningToggle_LaserVoltage.TextEnabled = true;
            this.ceLearningToggle_LaserVoltage.Click += new System.EventHandler(this.ceLearningToggle_LaserVoltage_Click);
            // 
            // ceLearningToggle_TakeControl
            // 
            this.ceLearningToggle_TakeControl.BorderColor = System.Drawing.Color.LightGray;
            this.ceLearningToggle_TakeControl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ceLearningToggle_TakeControl.ForeColor = System.Drawing.Color.White;
            this.ceLearningToggle_TakeControl.IsOn = false;
            this.ceLearningToggle_TakeControl.Location = new System.Drawing.Point(125, 19);
            this.ceLearningToggle_TakeControl.Name = "ceLearningToggle_TakeControl";
            this.ceLearningToggle_TakeControl.OffColor = System.Drawing.Color.DarkGray;
            this.ceLearningToggle_TakeControl.OffText = "OFF";
            this.ceLearningToggle_TakeControl.OnColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ceLearningToggle_TakeControl.OnText = "ON";
            this.ceLearningToggle_TakeControl.Size = new System.Drawing.Size(50, 27);
            this.ceLearningToggle_TakeControl.TabIndex = 48;
            this.ceLearningToggle_TakeControl.Text = "ceLearningToggle1";
            this.ceLearningToggle_TakeControl.TextEnabled = true;
            this.ceLearningToggle_TakeControl.Click += new System.EventHandler(this.ceLearningToggle_TakeControl_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 599);
            this.Controls.Add(this.COMStatusLabel);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Laser Welding Machine Control Panel";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.CommandTab.ResumeLayout(false);
            this.CommandTab.PerformLayout();
            this.HexModePanel.ResumeLayout(false);
            this.HexModePanel.PerformLayout();
            this.SettingsTab.ResumeLayout(false);
            this.SettingsTab.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.ComboBox comboBoxCOMPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox textBoxWrite;
        private System.Windows.Forms.TextBox textBoxRead;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Button btnRefreshPorts;
        private System.Windows.Forms.ComboBox comboBoxBaudRate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage CommandTab;
        private System.Windows.Forms.TabPage SettingsTab;
        private System.Windows.Forms.Label COMStatusLabel;
        private System.Windows.Forms.Panel HexModePanel;
        private System.Windows.Forms.RadioButton rbtnHexMode;
        private System.Windows.Forms.RadioButton rbtnASCIIMode;
        private System.Windows.Forms.ComboBox comboBoxMachineID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox_scheme;
        private System.Windows.Forms.Button btn_readScheme;
        private System.Windows.Forms.TextBox textBox_setEnergy;
        private System.Windows.Forms.TextBox textBox_energyCap;
        private System.Windows.Forms.TextBox textBox_LowerEnergy;
        private System.Windows.Forms.TextBox textBox_inputPower;
        private System.Windows.Forms.TextBox textBox_peakPower;
        private System.Windows.Forms.TextBox textBox_repetition;
        private System.Windows.Forms.TextBox textBox_firingTimes;
        private System.Windows.Forms.TextBox textBox_feedBack;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label_takeControl;
        private ToggleButtonExample.CeLearningToggle ceLearningToggle_TakeControl;
        private ToggleButtonExample.CeLearningToggle ceLearningToggle_LaserVoltage;
        private System.Windows.Forms.Label label14;
        private ToggleButtonExample.CeLearningToggle ceLearningToggle1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button button_ResetUI;
    }
}

