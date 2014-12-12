namespace PacketModerator
{
    partial class frmMain
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
            this.lstDevices = new System.Windows.Forms.ListBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSelectedDevice = new System.Windows.Forms.Label();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.btnLaunch = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDestMac = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSourceMac = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtTTL = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDestIP = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSourceIP = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCapabilities = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtNativeVlan = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtPlatform = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCount = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtSoftVersion = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDeviceID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPortID = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnCap = new System.Windows.Forms.Button();
            this.chkIsRepeater = new System.Windows.Forms.CheckBox();
            this.chkIsIGMPCapable = new System.Windows.Forms.CheckBox();
            this.chkIsHost = new System.Windows.Forms.CheckBox();
            this.chkIsSwitch = new System.Windows.Forms.CheckBox();
            this.chkIsSourceRouteBridge = new System.Windows.Forms.CheckBox();
            this.chkIsTransparentBridge = new System.Windows.Forms.CheckBox();
            this.chkIsRouter = new System.Windows.Forms.CheckBox();
            this.chkFlood = new System.Windows.Forms.CheckBox();
            this.tFlood = new System.Windows.Forms.Timer(this.components);
            this.btnStopFlood = new System.Windows.Forms.Button();
            this.chkMacof = new System.Windows.Forms.CheckBox();
            this.btnAbout = new System.Windows.Forms.Button();
            this.lblCDPCount = new System.Windows.Forms.Label();
            this.imgLoading = new System.Windows.Forms.PictureBox();
            this.rdSlow = new System.Windows.Forms.RadioButton();
            this.rdFast = new System.Windows.Forms.RadioButton();
            this.rdTornado = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLoading)).BeginInit();
            this.SuspendLayout();
            // 
            // lstDevices
            // 
            this.lstDevices.FormattingEnabled = true;
            this.lstDevices.Location = new System.Drawing.Point(12, 30);
            this.lstDevices.Name = "lstDevices";
            this.lstDevices.Size = new System.Drawing.Size(311, 121);
            this.lstDevices.TabIndex = 0;
            this.lstDevices.SelectedIndexChanged += new System.EventHandler(this.lstDevices_SelectedIndexChanged);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(12, 9);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 13);
            this.lblMessage.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(329, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Selected Device:";
            // 
            // lblSelectedDevice
            // 
            this.lblSelectedDevice.AutoSize = true;
            this.lblSelectedDevice.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblSelectedDevice.Location = new System.Drawing.Point(424, 30);
            this.lblSelectedDevice.Name = "lblSelectedDevice";
            this.lblSelectedDevice.Size = new System.Drawing.Size(0, 13);
            this.lblSelectedDevice.TabIndex = 3;
            // 
            // txtLog
            // 
            this.txtLog.BackColor = System.Drawing.Color.Black;
            this.txtLog.ForeColor = System.Drawing.Color.Yellow;
            this.txtLog.Location = new System.Drawing.Point(6, 441);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.Size = new System.Drawing.Size(696, 88);
            this.txtLog.TabIndex = 4;
            // 
            // btnLaunch
            // 
            this.btnLaunch.Location = new System.Drawing.Point(330, 358);
            this.btnLaunch.Name = "btnLaunch";
            this.btnLaunch.Size = new System.Drawing.Size(75, 27);
            this.btnLaunch.TabIndex = 5;
            this.btnLaunch.Text = "Launch!";
            this.btnLaunch.UseVisualStyleBackColor = true;
            this.btnLaunch.Click += new System.EventHandler(this.btnLaunch_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDestMac);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtSourceMac);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(332, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(185, 80);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ethernet Layer";
            // 
            // txtDestMac
            // 
            this.txtDestMac.Location = new System.Drawing.Point(82, 49);
            this.txtDestMac.Name = "txtDestMac";
            this.txtDestMac.ReadOnly = true;
            this.txtDestMac.Size = new System.Drawing.Size(97, 20);
            this.txtDestMac.TabIndex = 3;
            this.txtDestMac.Text = "01:00:0c:cc:cc:cc";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Dest MAC:";
            // 
            // txtSourceMac
            // 
            this.txtSourceMac.Location = new System.Drawing.Point(82, 19);
            this.txtSourceMac.Name = "txtSourceMac";
            this.txtSourceMac.Size = new System.Drawing.Size(97, 20);
            this.txtSourceMac.TabIndex = 0;
            this.txtSourceMac.Text = "1c:aa:07:13:88:09";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Source MAC:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtTTL);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtDestIP);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtSourceIP);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(523, 55);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(185, 103);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Network Layer";
            // 
            // txtTTL
            // 
            this.txtTTL.Location = new System.Drawing.Point(82, 75);
            this.txtTTL.Name = "txtTTL";
            this.txtTTL.Size = new System.Drawing.Size(97, 20);
            this.txtTTL.TabIndex = 5;
            this.txtTTL.Text = "123";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "TTL:";
            // 
            // txtDestIP
            // 
            this.txtDestIP.Location = new System.Drawing.Point(82, 49);
            this.txtDestIP.Name = "txtDestIP";
            this.txtDestIP.Size = new System.Drawing.Size(97, 20);
            this.txtDestIP.TabIndex = 3;
            this.txtDestIP.Text = "224.0.1.40";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Dest IP:";
            // 
            // txtSourceIP
            // 
            this.txtSourceIP.Location = new System.Drawing.Point(82, 19);
            this.txtSourceIP.Name = "txtSourceIP";
            this.txtSourceIP.Size = new System.Drawing.Size(97, 20);
            this.txtSourceIP.TabIndex = 0;
            this.txtSourceIP.Text = "1.1.1.1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Source IP:";
            // 
            // txtCapabilities
            // 
            this.txtCapabilities.Location = new System.Drawing.Point(82, 159);
            this.txtCapabilities.Name = "txtCapabilities";
            this.txtCapabilities.ReadOnly = true;
            this.txtCapabilities.Size = new System.Drawing.Size(411, 20);
            this.txtCapabilities.TabIndex = 10;
            this.txtCapabilities.Text = "0001000";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 162);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(66, 13);
            this.label13.TabIndex = 11;
            this.label13.Text = "Capabilities :";
            // 
            // txtNativeVlan
            // 
            this.txtNativeVlan.Location = new System.Drawing.Point(82, 135);
            this.txtNativeVlan.Name = "txtNativeVlan";
            this.txtNativeVlan.Size = new System.Drawing.Size(411, 20);
            this.txtNativeVlan.TabIndex = 7;
            this.txtNativeVlan.Text = "1";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 138);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 13);
            this.label12.TabIndex = 8;
            this.label12.Text = "Native Vlan :";
            // 
            // txtPlatform
            // 
            this.txtPlatform.Location = new System.Drawing.Point(82, 113);
            this.txtPlatform.Name = "txtPlatform";
            this.txtPlatform.Size = new System.Drawing.Size(411, 20);
            this.txtPlatform.TabIndex = 5;
            this.txtPlatform.Text = "cisco WS-C3560G-24TS";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 116);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 13);
            this.label11.TabIndex = 6;
            this.label11.Text = "Platform :";
            // 
            // txtCount
            // 
            this.txtCount.Location = new System.Drawing.Point(53, 365);
            this.txtCount.Name = "txtCount";
            this.txtCount.Size = new System.Drawing.Size(46, 20);
            this.txtCount.TabIndex = 9;
            this.txtCount.Text = "100";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(12, 368);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(35, 13);
            this.label14.TabIndex = 12;
            this.label14.Text = "Count";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtCapabilities);
            this.groupBox5.Controls.Add(this.label15);
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Controls.Add(this.txtSoftVersion);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.txtNativeVlan);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.txtDeviceID);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.txtPlatform);
            this.groupBox5.Controls.Add(this.txtAddress);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.txtPortID);
            this.groupBox5.Location = new System.Drawing.Point(12, 164);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(499, 188);
            this.groupBox5.TabIndex = 13;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Default Values";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 93);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(67, 13);
            this.label15.TabIndex = 8;
            this.label15.Text = "SoftVersion :";
            // 
            // txtSoftVersion
            // 
            this.txtSoftVersion.Location = new System.Drawing.Point(82, 90);
            this.txtSoftVersion.Name = "txtSoftVersion";
            this.txtSoftVersion.Size = new System.Drawing.Size(411, 20);
            this.txtSoftVersion.TabIndex = 7;
            this.txtSoftVersion.Text = "Software Version: Cisco IOS Software, C3560 Software (C3560-IPBASE-M), Version 12" +
    ".2(50)SE5, RELEASE SOFTWARE (fc1)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Device ID:";
            // 
            // txtDeviceID
            // 
            this.txtDeviceID.Location = new System.Drawing.Point(82, 21);
            this.txtDeviceID.Name = "txtDeviceID";
            this.txtDeviceID.Size = new System.Drawing.Size(411, 20);
            this.txtDeviceID.TabIndex = 3;
            this.txtDeviceID.Text = "CiscoDevice";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 47);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Address :";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(82, 44);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(411, 20);
            this.txtAddress.TabIndex = 5;
            this.txtAddress.Text = "172.20.20.20";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 70);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Port ID :";
            // 
            // txtPortID
            // 
            this.txtPortID.Location = new System.Drawing.Point(82, 67);
            this.txtPortID.Name = "txtPortID";
            this.txtPortID.Size = new System.Drawing.Size(411, 20);
            this.txtPortID.TabIndex = 5;
            this.txtPortID.Text = "Gigabitethernet0/9";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnCap);
            this.groupBox3.Controls.Add(this.chkIsRepeater);
            this.groupBox3.Controls.Add(this.chkIsIGMPCapable);
            this.groupBox3.Controls.Add(this.chkIsHost);
            this.groupBox3.Controls.Add(this.chkIsSwitch);
            this.groupBox3.Controls.Add(this.chkIsSourceRouteBridge);
            this.groupBox3.Controls.Add(this.chkIsTransparentBridge);
            this.groupBox3.Controls.Add(this.chkIsRouter);
            this.groupBox3.Location = new System.Drawing.Point(523, 164);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(185, 182);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Capabilities";
            // 
            // btnCap
            // 
            this.btnCap.Location = new System.Drawing.Point(122, 156);
            this.btnCap.Name = "btnCap";
            this.btnCap.Size = new System.Drawing.Size(57, 23);
            this.btnCap.TabIndex = 9;
            this.btnCap.Text = "Cap";
            this.btnCap.UseVisualStyleBackColor = true;
            this.btnCap.Click += new System.EventHandler(this.btnCap_Click);
            // 
            // chkIsRepeater
            // 
            this.chkIsRepeater.AutoSize = true;
            this.chkIsRepeater.Location = new System.Drawing.Point(12, 157);
            this.chkIsRepeater.Name = "chkIsRepeater";
            this.chkIsRepeater.Size = new System.Drawing.Size(70, 17);
            this.chkIsRepeater.TabIndex = 0;
            this.chkIsRepeater.Tag = "64";
            this.chkIsRepeater.Text = "Repeater";
            this.chkIsRepeater.UseVisualStyleBackColor = true;
            // 
            // chkIsIGMPCapable
            // 
            this.chkIsIGMPCapable.AutoSize = true;
            this.chkIsIGMPCapable.Location = new System.Drawing.Point(12, 134);
            this.chkIsIGMPCapable.Name = "chkIsIGMPCapable";
            this.chkIsIGMPCapable.Size = new System.Drawing.Size(94, 17);
            this.chkIsIGMPCapable.TabIndex = 0;
            this.chkIsIGMPCapable.Tag = "32";
            this.chkIsIGMPCapable.Text = "IGMP capable";
            this.chkIsIGMPCapable.UseVisualStyleBackColor = true;
            // 
            // chkIsHost
            // 
            this.chkIsHost.AutoSize = true;
            this.chkIsHost.Location = new System.Drawing.Point(12, 111);
            this.chkIsHost.Name = "chkIsHost";
            this.chkIsHost.Size = new System.Drawing.Size(48, 17);
            this.chkIsHost.TabIndex = 0;
            this.chkIsHost.Tag = "16";
            this.chkIsHost.Text = "Host";
            this.chkIsHost.UseVisualStyleBackColor = true;
            // 
            // chkIsSwitch
            // 
            this.chkIsSwitch.AutoSize = true;
            this.chkIsSwitch.Checked = true;
            this.chkIsSwitch.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkIsSwitch.Location = new System.Drawing.Point(12, 88);
            this.chkIsSwitch.Name = "chkIsSwitch";
            this.chkIsSwitch.Size = new System.Drawing.Size(58, 17);
            this.chkIsSwitch.TabIndex = 0;
            this.chkIsSwitch.Tag = "8";
            this.chkIsSwitch.Text = "Switch";
            this.chkIsSwitch.UseVisualStyleBackColor = true;
            // 
            // chkIsSourceRouteBridge
            // 
            this.chkIsSourceRouteBridge.AutoSize = true;
            this.chkIsSourceRouteBridge.Location = new System.Drawing.Point(12, 65);
            this.chkIsSourceRouteBridge.Name = "chkIsSourceRouteBridge";
            this.chkIsSourceRouteBridge.Size = new System.Drawing.Size(125, 17);
            this.chkIsSourceRouteBridge.TabIndex = 0;
            this.chkIsSourceRouteBridge.Tag = "4";
            this.chkIsSourceRouteBridge.Text = "Source Route Bridge";
            this.chkIsSourceRouteBridge.UseVisualStyleBackColor = true;
            // 
            // chkIsTransparentBridge
            // 
            this.chkIsTransparentBridge.AutoSize = true;
            this.chkIsTransparentBridge.Location = new System.Drawing.Point(12, 42);
            this.chkIsTransparentBridge.Name = "chkIsTransparentBridge";
            this.chkIsTransparentBridge.Size = new System.Drawing.Size(116, 17);
            this.chkIsTransparentBridge.TabIndex = 0;
            this.chkIsTransparentBridge.Tag = "2";
            this.chkIsTransparentBridge.Text = "Transparent Bridge";
            this.chkIsTransparentBridge.UseVisualStyleBackColor = true;
            // 
            // chkIsRouter
            // 
            this.chkIsRouter.AutoSize = true;
            this.chkIsRouter.Location = new System.Drawing.Point(12, 19);
            this.chkIsRouter.Name = "chkIsRouter";
            this.chkIsRouter.Size = new System.Drawing.Size(58, 17);
            this.chkIsRouter.TabIndex = 0;
            this.chkIsRouter.Tag = "1";
            this.chkIsRouter.Text = "Router";
            this.chkIsRouter.UseVisualStyleBackColor = true;
            // 
            // chkFlood
            // 
            this.chkFlood.AutoSize = true;
            this.chkFlood.Location = new System.Drawing.Point(105, 367);
            this.chkFlood.Name = "chkFlood";
            this.chkFlood.Size = new System.Drawing.Size(101, 17);
            this.chkFlood.TabIndex = 14;
            this.chkFlood.Tag = "16";
            this.chkFlood.Text = "FlOOOOOOOD!";
            this.chkFlood.UseVisualStyleBackColor = true;
            this.chkFlood.CheckedChanged += new System.EventHandler(this.chkFlood_CheckedChanged);
            // 
            // tFlood
            // 
            this.tFlood.Tick += new System.EventHandler(this.tFlood_Tick);
            // 
            // btnStopFlood
            // 
            this.btnStopFlood.Location = new System.Drawing.Point(436, 359);
            this.btnStopFlood.Name = "btnStopFlood";
            this.btnStopFlood.Size = new System.Drawing.Size(75, 25);
            this.btnStopFlood.TabIndex = 15;
            this.btnStopFlood.Text = "Stop Flood";
            this.btnStopFlood.UseVisualStyleBackColor = true;
            this.btnStopFlood.Visible = false;
            this.btnStopFlood.Click += new System.EventHandler(this.btnStopFlood_Click);
            // 
            // chkMacof
            // 
            this.chkMacof.AutoSize = true;
            this.chkMacof.Location = new System.Drawing.Point(105, 390);
            this.chkMacof.Name = "chkMacof";
            this.chkMacof.Size = new System.Drawing.Size(112, 17);
            this.chkMacof.TabIndex = 16;
            this.chkMacof.Tag = "16";
            this.chkMacof.Text = "Of course MACOF";
            this.chkMacof.UseVisualStyleBackColor = true;
            this.chkMacof.Visible = false;
            // 
            // btnAbout
            // 
            this.btnAbout.Location = new System.Drawing.Point(15, 406);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(75, 25);
            this.btnAbout.TabIndex = 18;
            this.btnAbout.Text = "About!";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // lblCDPCount
            // 
            this.lblCDPCount.AutoSize = true;
            this.lblCDPCount.Location = new System.Drawing.Point(556, 384);
            this.lblCDPCount.Name = "lblCDPCount";
            this.lblCDPCount.Size = new System.Drawing.Size(13, 13);
            this.lblCDPCount.TabIndex = 19;
            this.lblCDPCount.Text = "0";
            // 
            // imgLoading
            // 
            this.imgLoading.Image = global::PacketModerator.Properties.Resources.loading;
            this.imgLoading.Location = new System.Drawing.Point(559, 362);
            this.imgLoading.Name = "imgLoading";
            this.imgLoading.Size = new System.Drawing.Size(128, 19);
            this.imgLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.imgLoading.TabIndex = 17;
            this.imgLoading.TabStop = false;
            this.imgLoading.Visible = false;
            // 
            // rdSlow
            // 
            this.rdSlow.AutoSize = true;
            this.rdSlow.Location = new System.Drawing.Point(240, 368);
            this.rdSlow.Name = "rdSlow";
            this.rdSlow.Size = new System.Drawing.Size(48, 17);
            this.rdSlow.TabIndex = 21;
            this.rdSlow.TabStop = true;
            this.rdSlow.Text = "Slow";
            this.rdSlow.UseVisualStyleBackColor = true;
            this.rdSlow.Visible = false;
            // 
            // rdFast
            // 
            this.rdFast.AutoSize = true;
            this.rdFast.Location = new System.Drawing.Point(240, 388);
            this.rdFast.Name = "rdFast";
            this.rdFast.Size = new System.Drawing.Size(45, 17);
            this.rdFast.TabIndex = 22;
            this.rdFast.TabStop = true;
            this.rdFast.Text = "Fast";
            this.rdFast.UseVisualStyleBackColor = true;
            this.rdFast.Visible = false;
            // 
            // rdTornado
            // 
            this.rdTornado.AutoSize = true;
            this.rdTornado.Checked = true;
            this.rdTornado.Location = new System.Drawing.Point(240, 405);
            this.rdTornado.Name = "rdTornado";
            this.rdTornado.Size = new System.Drawing.Size(65, 17);
            this.rdTornado.TabIndex = 23;
            this.rdTornado.TabStop = true;
            this.rdTornado.Text = "Tornado";
            this.rdTornado.UseVisualStyleBackColor = true;
            this.rdTornado.Visible = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 537);
            this.Controls.Add(this.rdTornado);
            this.Controls.Add(this.rdFast);
            this.Controls.Add(this.rdSlow);
            this.Controls.Add(this.lblCDPCount);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.imgLoading);
            this.Controls.Add(this.chkMacof);
            this.Controls.Add(this.btnStopFlood);
            this.Controls.Add(this.chkFlood);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtCount);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnLaunch);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.lblSelectedDevice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.lstDevices);
            this.Name = "frmMain";
            this.Text = "PACKET MODERATOR";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLoading)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstDevices;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSelectedDevice;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.Button btnLaunch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSourceMac;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDestMac;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtDestIP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSourceIP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTTL;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCount;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtCapabilities;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtNativeVlan;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtPlatform;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtPortID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDeviceID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtSoftVersion;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox chkIsRepeater;
        private System.Windows.Forms.CheckBox chkIsIGMPCapable;
        private System.Windows.Forms.CheckBox chkIsHost;
        private System.Windows.Forms.CheckBox chkIsSwitch;
        private System.Windows.Forms.CheckBox chkIsSourceRouteBridge;
        private System.Windows.Forms.CheckBox chkIsTransparentBridge;
        private System.Windows.Forms.CheckBox chkIsRouter;
        private System.Windows.Forms.Button btnCap;
        private System.Windows.Forms.CheckBox chkFlood;
        private System.Windows.Forms.Timer tFlood;
        private System.Windows.Forms.Button btnStopFlood;
        private System.Windows.Forms.CheckBox chkMacof;
        private System.Windows.Forms.PictureBox imgLoading;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Label lblCDPCount;
        private System.Windows.Forms.RadioButton rdSlow;
        private System.Windows.Forms.RadioButton rdFast;
        private System.Windows.Forms.RadioButton rdTornado;
    }
}

