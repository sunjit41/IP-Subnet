namespace IPSubnet
{
    partial class ClassFull
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClassFull));
            label1 = new Label();
            IP1Text = new TextBox();
            label2 = new Label();
            SupernetButton = new Button();
            SubnetButton = new Button();
            label3 = new Label();
            Byte1Text = new TextBox();
            Byte2Text = new TextBox();
            Byte3Text = new TextBox();
            Byte4Text = new TextBox();
            panel1 = new Panel();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            IP4Text = new TextBox();
            IP3Text = new TextBox();
            IP2Text = new TextBox();
            Byte1Label = new Label();
            Byte2Label = new Label();
            Byte3Label = new Label();
            Byte4Label = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            SubnetTrackBar = new TrackBar();
            panel2 = new Panel();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            Mask4Text = new TextBox();
            Mask3Text = new TextBox();
            Mask2Text = new TextBox();
            Mask1Text = new TextBox();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            MaskByte4Label = new Label();
            MaskByte3Label = new Label();
            MaskByte2Label = new Label();
            MaskByte1Label = new Label();
            MaskByte4Text = new TextBox();
            MaskByte3Text = new TextBox();
            MaskByte2Text = new TextBox();
            MaskByte1Text = new TextBox();
            label16 = new Label();
            IpSectionGroup = new GroupBox();
            IpCollapseLabel = new LinkLabel();
            IpTypeText = new TextBox();
            IpClassText = new TextBox();
            label18 = new Label();
            label17 = new Label();
            MaskSectionGroup = new GroupBox();
            MaskCollapseLabel = new LinkLabel();
            label23 = new Label();
            label22 = new Label();
            HostBitsText = new TextBox();
            NetworkBitsText = new TextBox();
            HostsText = new TextBox();
            label21 = new Label();
            NetworksText = new TextBox();
            label20 = new Label();
            CidrCombo = new ComboBox();
            ShowNetworksButton = new Button();
            SubnetSectionGroup = new GroupBox();
            panel5 = new Panel();
            label36 = new Label();
            label37 = new Label();
            label38 = new Label();
            DefaultOctect4 = new TextBox();
            DefaultOctect3 = new TextBox();
            DefaultOctect2 = new TextBox();
            DefaultOctect1 = new TextBox();
            DefaultMaskLabel = new Label();
            SubnetCollapseLabel = new LinkLabel();
            label34 = new Label();
            label35 = new Label();
            HostsPerSubnetText = new TextBox();
            SubnetsText = new TextBox();
            HostBits2Text = new TextBox();
            label33 = new Label();
            SubnetBitsText = new TextBox();
            label32 = new Label();
            BinaryRTF = new RichTextBox();
            panel4 = new Panel();
            label29 = new Label();
            label30 = new Label();
            label31 = new Label();
            SubMask4Text = new TextBox();
            SubMask3Text = new TextBox();
            SubMask2Text = new TextBox();
            SubMask1Text = new TextBox();
            panel3 = new Panel();
            label26 = new Label();
            label27 = new Label();
            label28 = new Label();
            SubIP4Text = new TextBox();
            SubIP3Text = new TextBox();
            SubIP2Text = new TextBox();
            SubIP1Text = new TextBox();
            label25 = new Label();
            label24 = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SubnetTrackBar).BeginInit();
            panel2.SuspendLayout();
            IpSectionGroup.SuspendLayout();
            MaskSectionGroup.SuspendLayout();
            SubnetSectionGroup.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 46);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(92, 18);
            label1.TabIndex = 1;
            label1.Text = "IP Address :";
            // 
            // IP1Text
            // 
            IP1Text.BackColor = Color.White;
            IP1Text.BorderStyle = BorderStyle.None;
            IP1Text.Location = new Point(9, 8);
            IP1Text.Name = "IP1Text";
            IP1Text.Size = new Size(39, 19);
            IP1Text.TabIndex = 3;
            IP1Text.TextAlign = HorizontalAlignment.Center;
            IP1Text.TextChanged += IP1Text_TextChanged;
            IP1Text.KeyDown += IP1Text_KeyDown;
            IP1Text.KeyPress += IP1Text_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 47);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(107, 18);
            label2.TabIndex = 23;
            label2.Text = "Subnet Mask :";
            // 
            // SupernetButton
            // 
            SupernetButton.BackColor = Color.Blue;
            SupernetButton.FlatStyle = FlatStyle.Popup;
            SupernetButton.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SupernetButton.Location = new Point(482, 41);
            SupernetButton.Name = "SupernetButton";
            SupernetButton.Size = new Size(40, 31);
            SupernetButton.TabIndex = 33;
            SupernetButton.TabStop = false;
            SupernetButton.Text = "<";
            SupernetButton.UseVisualStyleBackColor = false;
            SupernetButton.Click += SupernetButton_Click;
            // 
            // SubnetButton
            // 
            SubnetButton.BackColor = Color.Blue;
            SubnetButton.FlatStyle = FlatStyle.Popup;
            SubnetButton.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SubnetButton.Location = new Point(552, 41);
            SubnetButton.Name = "SubnetButton";
            SubnetButton.Size = new Size(40, 31);
            SubnetButton.TabIndex = 34;
            SubnetButton.TabStop = false;
            SubnetButton.Text = ">";
            SubnetButton.UseVisualStyleBackColor = false;
            SubnetButton.Click += SubnetButton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 115);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(103, 18);
            label3.TabIndex = 10;
            label3.Text = "Binary Value :";
            // 
            // Byte1Text
            // 
            Byte1Text.BackColor = Color.White;
            Byte1Text.BorderStyle = BorderStyle.FixedSingle;
            Byte1Text.Location = new Point(152, 112);
            Byte1Text.Name = "Byte1Text";
            Byte1Text.ReadOnly = true;
            Byte1Text.Size = new Size(97, 26);
            Byte1Text.TabIndex = 11;
            Byte1Text.TabStop = false;
            Byte1Text.Text = "00000000";
            Byte1Text.TextAlign = HorizontalAlignment.Center;
            // 
            // Byte2Text
            // 
            Byte2Text.BackColor = Color.White;
            Byte2Text.BorderStyle = BorderStyle.FixedSingle;
            Byte2Text.Location = new Point(268, 112);
            Byte2Text.Name = "Byte2Text";
            Byte2Text.ReadOnly = true;
            Byte2Text.Size = new Size(97, 26);
            Byte2Text.TabIndex = 13;
            Byte2Text.TabStop = false;
            Byte2Text.Text = "00000000";
            Byte2Text.TextAlign = HorizontalAlignment.Center;
            // 
            // Byte3Text
            // 
            Byte3Text.BackColor = Color.White;
            Byte3Text.BorderStyle = BorderStyle.FixedSingle;
            Byte3Text.Location = new Point(381, 112);
            Byte3Text.Name = "Byte3Text";
            Byte3Text.ReadOnly = true;
            Byte3Text.Size = new Size(97, 26);
            Byte3Text.TabIndex = 15;
            Byte3Text.TabStop = false;
            Byte3Text.Text = "00000000";
            Byte3Text.TextAlign = HorizontalAlignment.Center;
            // 
            // Byte4Text
            // 
            Byte4Text.BackColor = Color.White;
            Byte4Text.BorderStyle = BorderStyle.FixedSingle;
            Byte4Text.Location = new Point(495, 112);
            Byte4Text.Name = "Byte4Text";
            Byte4Text.ReadOnly = true;
            Byte4Text.Size = new Size(97, 26);
            Byte4Text.TabIndex = 17;
            Byte4Text.TabStop = false;
            Byte4Text.Text = "00000000";
            Byte4Text.TextAlign = HorizontalAlignment.Center;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(IP4Text);
            panel1.Controls.Add(IP3Text);
            panel1.Controls.Add(IP2Text);
            panel1.Controls.Add(IP1Text);
            panel1.Location = new Point(152, 37);
            panel1.Name = "panel1";
            panel1.Size = new Size(197, 35);
            panel1.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(138, 7);
            label6.Name = "label6";
            label6.Size = new Size(13, 19);
            label6.TabIndex = 8;
            label6.Text = ".";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(92, 8);
            label5.Name = "label5";
            label5.Size = new Size(13, 19);
            label5.TabIndex = 6;
            label5.Text = ".";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(46, 8);
            label4.Name = "label4";
            label4.Size = new Size(13, 19);
            label4.TabIndex = 4;
            label4.Text = ".";
            // 
            // IP4Text
            // 
            IP4Text.BackColor = Color.White;
            IP4Text.BorderStyle = BorderStyle.None;
            IP4Text.Location = new Point(147, 8);
            IP4Text.Name = "IP4Text";
            IP4Text.Size = new Size(39, 19);
            IP4Text.TabIndex = 9;
            IP4Text.TextAlign = HorizontalAlignment.Center;
            IP4Text.TextChanged += IP4Text_TextChanged;
            IP4Text.KeyDown += IP4Text_KeyDown;
            IP4Text.KeyPress += IP4Text_KeyPress;
            // 
            // IP3Text
            // 
            IP3Text.BackColor = Color.White;
            IP3Text.BorderStyle = BorderStyle.None;
            IP3Text.Location = new Point(102, 8);
            IP3Text.Name = "IP3Text";
            IP3Text.Size = new Size(39, 19);
            IP3Text.TabIndex = 7;
            IP3Text.TextAlign = HorizontalAlignment.Center;
            IP3Text.TextChanged += IP3Text_TextChanged;
            IP3Text.KeyDown += IP3Text_KeyDown;
            IP3Text.KeyPress += IP3Text_KeyPress;
            // 
            // IP2Text
            // 
            IP2Text.BackColor = Color.White;
            IP2Text.BorderStyle = BorderStyle.None;
            IP2Text.Location = new Point(57, 8);
            IP2Text.Name = "IP2Text";
            IP2Text.Size = new Size(39, 19);
            IP2Text.TabIndex = 5;
            IP2Text.TextAlign = HorizontalAlignment.Center;
            IP2Text.TextChanged += IP2Text_TextChanged;
            IP2Text.KeyDown += IP2Text_KeyDown;
            IP2Text.KeyPress += IP2Text_KeyPress;
            // 
            // Byte1Label
            // 
            Byte1Label.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Byte1Label.Location = new Point(154, 89);
            Byte1Label.Margin = new Padding(4, 0, 4, 0);
            Byte1Label.Name = "Byte1Label";
            Byte1Label.Size = new Size(95, 18);
            Byte1Label.TabIndex = 13;
            Byte1Label.Text = " ";
            Byte1Label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Byte2Label
            // 
            Byte2Label.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Byte2Label.Location = new Point(270, 89);
            Byte2Label.Margin = new Padding(4, 0, 4, 0);
            Byte2Label.Name = "Byte2Label";
            Byte2Label.Size = new Size(95, 18);
            Byte2Label.TabIndex = 14;
            Byte2Label.Text = " ";
            Byte2Label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Byte3Label
            // 
            Byte3Label.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Byte3Label.Location = new Point(383, 89);
            Byte3Label.Margin = new Padding(4, 0, 4, 0);
            Byte3Label.Name = "Byte3Label";
            Byte3Label.Size = new Size(95, 18);
            Byte3Label.TabIndex = 15;
            Byte3Label.Text = " ";
            Byte3Label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Byte4Label
            // 
            Byte4Label.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Byte4Label.Location = new Point(497, 89);
            Byte4Label.Margin = new Padding(4, 0, 4, 0);
            Byte4Label.Name = "Byte4Label";
            Byte4Label.Size = new Size(95, 18);
            Byte4Label.TabIndex = 16;
            Byte4Label.Text = " ";
            Byte4Label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(251, 89);
            label7.Name = "label7";
            label7.Size = new Size(13, 17);
            label7.TabIndex = 12;
            label7.Text = ".";
            // 
            // label8
            // 
            label8.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.White;
            label8.Location = new Point(365, 90);
            label8.Name = "label8";
            label8.Size = new Size(13, 17);
            label8.TabIndex = 14;
            label8.Text = ".";
            // 
            // label9
            // 
            label9.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.White;
            label9.Location = new Point(478, 90);
            label9.Name = "label9";
            label9.Size = new Size(13, 17);
            label9.TabIndex = 16;
            label9.Text = ".";
            // 
            // SubnetTrackBar
            // 
            SubnetTrackBar.LargeChange = 1;
            SubnetTrackBar.Location = new Point(150, 94);
            SubnetTrackBar.Maximum = 32;
            SubnetTrackBar.Name = "SubnetTrackBar";
            SubnetTrackBar.Size = new Size(442, 45);
            SubnetTrackBar.TabIndex = 35;
            SubnetTrackBar.Scroll += SubnetTrackBar_Scroll;
            SubnetTrackBar.ValueChanged += SubnetTrackBar_ValueChanged;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label10);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(label12);
            panel2.Controls.Add(Mask4Text);
            panel2.Controls.Add(Mask3Text);
            panel2.Controls.Add(Mask2Text);
            panel2.Controls.Add(Mask1Text);
            panel2.Location = new Point(152, 39);
            panel2.Name = "panel2";
            panel2.Size = new Size(197, 35);
            panel2.TabIndex = 24;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(138, 7);
            label10.Name = "label10";
            label10.Size = new Size(13, 19);
            label10.TabIndex = 30;
            label10.Text = ".";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.Black;
            label11.Location = new Point(92, 8);
            label11.Name = "label11";
            label11.Size = new Size(13, 19);
            label11.TabIndex = 28;
            label11.Text = ".";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.Black;
            label12.Location = new Point(46, 8);
            label12.Name = "label12";
            label12.Size = new Size(13, 19);
            label12.TabIndex = 26;
            label12.Text = ".";
            // 
            // Mask4Text
            // 
            Mask4Text.BackColor = Color.White;
            Mask4Text.BorderStyle = BorderStyle.None;
            Mask4Text.Location = new Point(147, 8);
            Mask4Text.Name = "Mask4Text";
            Mask4Text.ReadOnly = true;
            Mask4Text.Size = new Size(39, 19);
            Mask4Text.TabIndex = 31;
            Mask4Text.TabStop = false;
            Mask4Text.Text = "0";
            Mask4Text.TextAlign = HorizontalAlignment.Center;
            Mask4Text.TextChanged += Mask4Text_TextChanged;
            // 
            // Mask3Text
            // 
            Mask3Text.BackColor = Color.White;
            Mask3Text.BorderStyle = BorderStyle.None;
            Mask3Text.Location = new Point(102, 8);
            Mask3Text.Name = "Mask3Text";
            Mask3Text.ReadOnly = true;
            Mask3Text.Size = new Size(39, 19);
            Mask3Text.TabIndex = 29;
            Mask3Text.TabStop = false;
            Mask3Text.Text = "0";
            Mask3Text.TextAlign = HorizontalAlignment.Center;
            Mask3Text.TextChanged += Mask3Text_TextChanged;
            // 
            // Mask2Text
            // 
            Mask2Text.BackColor = Color.White;
            Mask2Text.BorderStyle = BorderStyle.None;
            Mask2Text.Location = new Point(57, 8);
            Mask2Text.Name = "Mask2Text";
            Mask2Text.ReadOnly = true;
            Mask2Text.Size = new Size(39, 19);
            Mask2Text.TabIndex = 27;
            Mask2Text.TabStop = false;
            Mask2Text.Text = "0";
            Mask2Text.TextAlign = HorizontalAlignment.Center;
            Mask2Text.TextChanged += Mask2Text_TextChanged;
            // 
            // Mask1Text
            // 
            Mask1Text.BackColor = Color.White;
            Mask1Text.BorderStyle = BorderStyle.None;
            Mask1Text.Location = new Point(9, 8);
            Mask1Text.Name = "Mask1Text";
            Mask1Text.ReadOnly = true;
            Mask1Text.Size = new Size(39, 19);
            Mask1Text.TabIndex = 25;
            Mask1Text.TabStop = false;
            Mask1Text.Text = "0";
            Mask1Text.TextAlign = HorizontalAlignment.Center;
            Mask1Text.TextChanged += Mask1Text_TextChanged;
            // 
            // label13
            // 
            label13.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.White;
            label13.Location = new Point(478, 144);
            label13.Name = "label13";
            label13.Size = new Size(13, 17);
            label13.TabIndex = 45;
            label13.Text = ".";
            // 
            // label14
            // 
            label14.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.White;
            label14.Location = new Point(365, 144);
            label14.Name = "label14";
            label14.Size = new Size(13, 17);
            label14.TabIndex = 42;
            label14.Text = ".";
            // 
            // label15
            // 
            label15.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.ForeColor = Color.White;
            label15.Location = new Point(251, 144);
            label15.Name = "label15";
            label15.Size = new Size(13, 17);
            label15.TabIndex = 39;
            label15.Text = ".";
            // 
            // MaskByte4Label
            // 
            MaskByte4Label.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MaskByte4Label.Location = new Point(497, 143);
            MaskByte4Label.Margin = new Padding(4, 0, 4, 0);
            MaskByte4Label.Name = "MaskByte4Label";
            MaskByte4Label.Size = new Size(95, 18);
            MaskByte4Label.TabIndex = 46;
            MaskByte4Label.Text = "0";
            MaskByte4Label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MaskByte3Label
            // 
            MaskByte3Label.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MaskByte3Label.Location = new Point(383, 143);
            MaskByte3Label.Margin = new Padding(4, 0, 4, 0);
            MaskByte3Label.Name = "MaskByte3Label";
            MaskByte3Label.Size = new Size(95, 18);
            MaskByte3Label.TabIndex = 43;
            MaskByte3Label.Text = "0";
            MaskByte3Label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MaskByte2Label
            // 
            MaskByte2Label.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MaskByte2Label.Location = new Point(270, 143);
            MaskByte2Label.Margin = new Padding(4, 0, 4, 0);
            MaskByte2Label.Name = "MaskByte2Label";
            MaskByte2Label.Size = new Size(95, 18);
            MaskByte2Label.TabIndex = 40;
            MaskByte2Label.Text = "0";
            MaskByte2Label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MaskByte1Label
            // 
            MaskByte1Label.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MaskByte1Label.Location = new Point(154, 143);
            MaskByte1Label.Margin = new Padding(4, 0, 4, 0);
            MaskByte1Label.Name = "MaskByte1Label";
            MaskByte1Label.Size = new Size(95, 18);
            MaskByte1Label.TabIndex = 37;
            MaskByte1Label.Text = "0";
            MaskByte1Label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MaskByte4Text
            // 
            MaskByte4Text.BackColor = Color.White;
            MaskByte4Text.BorderStyle = BorderStyle.FixedSingle;
            MaskByte4Text.Location = new Point(495, 166);
            MaskByte4Text.Name = "MaskByte4Text";
            MaskByte4Text.ReadOnly = true;
            MaskByte4Text.Size = new Size(97, 26);
            MaskByte4Text.TabIndex = 47;
            MaskByte4Text.TabStop = false;
            MaskByte4Text.Text = "00000000";
            MaskByte4Text.TextAlign = HorizontalAlignment.Center;
            // 
            // MaskByte3Text
            // 
            MaskByte3Text.BackColor = Color.White;
            MaskByte3Text.BorderStyle = BorderStyle.FixedSingle;
            MaskByte3Text.Location = new Point(381, 166);
            MaskByte3Text.Name = "MaskByte3Text";
            MaskByte3Text.ReadOnly = true;
            MaskByte3Text.Size = new Size(97, 26);
            MaskByte3Text.TabIndex = 44;
            MaskByte3Text.TabStop = false;
            MaskByte3Text.Text = "00000000";
            MaskByte3Text.TextAlign = HorizontalAlignment.Center;
            // 
            // MaskByte2Text
            // 
            MaskByte2Text.BackColor = Color.White;
            MaskByte2Text.BorderStyle = BorderStyle.FixedSingle;
            MaskByte2Text.Location = new Point(268, 166);
            MaskByte2Text.Name = "MaskByte2Text";
            MaskByte2Text.ReadOnly = true;
            MaskByte2Text.Size = new Size(97, 26);
            MaskByte2Text.TabIndex = 41;
            MaskByte2Text.TabStop = false;
            MaskByte2Text.Text = "00000000";
            MaskByte2Text.TextAlign = HorizontalAlignment.Center;
            // 
            // MaskByte1Text
            // 
            MaskByte1Text.BackColor = Color.White;
            MaskByte1Text.BorderStyle = BorderStyle.FixedSingle;
            MaskByte1Text.Location = new Point(152, 166);
            MaskByte1Text.Name = "MaskByte1Text";
            MaskByte1Text.ReadOnly = true;
            MaskByte1Text.Size = new Size(97, 26);
            MaskByte1Text.TabIndex = 38;
            MaskByte1Text.TabStop = false;
            MaskByte1Text.Text = "00000000";
            MaskByte1Text.TextAlign = HorizontalAlignment.Center;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(33, 171);
            label16.Margin = new Padding(4, 0, 4, 0);
            label16.Name = "label16";
            label16.Size = new Size(100, 18);
            label16.TabIndex = 36;
            label16.Text = "Binary value :";
            // 
            // IpSectionGroup
            // 
            IpSectionGroup.Controls.Add(IpCollapseLabel);
            IpSectionGroup.Controls.Add(IpTypeText);
            IpSectionGroup.Controls.Add(IpClassText);
            IpSectionGroup.Controls.Add(label18);
            IpSectionGroup.Controls.Add(label17);
            IpSectionGroup.Controls.Add(label1);
            IpSectionGroup.Controls.Add(label3);
            IpSectionGroup.Controls.Add(Byte1Text);
            IpSectionGroup.Controls.Add(Byte2Text);
            IpSectionGroup.Controls.Add(Byte3Text);
            IpSectionGroup.Controls.Add(Byte4Text);
            IpSectionGroup.Controls.Add(panel1);
            IpSectionGroup.Controls.Add(Byte1Label);
            IpSectionGroup.Controls.Add(Byte2Label);
            IpSectionGroup.Controls.Add(Byte3Label);
            IpSectionGroup.Controls.Add(Byte4Label);
            IpSectionGroup.Controls.Add(label7);
            IpSectionGroup.Controls.Add(label8);
            IpSectionGroup.Controls.Add(label9);
            IpSectionGroup.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            IpSectionGroup.ForeColor = Color.White;
            IpSectionGroup.Location = new Point(25, 78);
            IpSectionGroup.Name = "IpSectionGroup";
            IpSectionGroup.Size = new Size(654, 200);
            IpSectionGroup.TabIndex = 0;
            IpSectionGroup.TabStop = false;
            IpSectionGroup.Text = "IP Address Section";
            // 
            // IpCollapseLabel
            // 
            IpCollapseLabel.AutoSize = true;
            IpCollapseLabel.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            IpCollapseLabel.LinkBehavior = LinkBehavior.NeverUnderline;
            IpCollapseLabel.LinkColor = Color.White;
            IpCollapseLabel.Location = new Point(618, 18);
            IpCollapseLabel.Name = "IpCollapseLabel";
            IpCollapseLabel.Size = new Size(29, 29);
            IpCollapseLabel.TabIndex = 22;
            IpCollapseLabel.TabStop = true;
            IpCollapseLabel.Text = "--";
            IpCollapseLabel.LinkClicked += IpCollapseLabel_LinkClicked;
            // 
            // IpTypeText
            // 
            IpTypeText.BackColor = Color.White;
            IpTypeText.BorderStyle = BorderStyle.FixedSingle;
            IpTypeText.Location = new Point(381, 152);
            IpTypeText.Name = "IpTypeText";
            IpTypeText.ReadOnly = true;
            IpTypeText.Size = new Size(97, 26);
            IpTypeText.TabIndex = 21;
            IpTypeText.TabStop = false;
            IpTypeText.TextAlign = HorizontalAlignment.Center;
            // 
            // IpClassText
            // 
            IpClassText.BackColor = Color.White;
            IpClassText.BorderStyle = BorderStyle.FixedSingle;
            IpClassText.Location = new Point(152, 152);
            IpClassText.Name = "IpClassText";
            IpClassText.ReadOnly = true;
            IpClassText.Size = new Size(97, 26);
            IpClassText.TabIndex = 19;
            IpClassText.TabStop = false;
            IpClassText.TextAlign = HorizontalAlignment.Center;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(316, 155);
            label18.Margin = new Padding(4, 0, 4, 0);
            label18.Name = "label18";
            label18.Size = new Size(49, 18);
            label18.TabIndex = 20;
            label18.Text = "Type :";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(33, 155);
            label17.Margin = new Padding(4, 0, 4, 0);
            label17.Name = "label17";
            label17.Size = new Size(56, 18);
            label17.TabIndex = 18;
            label17.Text = "Class :";
            // 
            // MaskSectionGroup
            // 
            MaskSectionGroup.Controls.Add(MaskCollapseLabel);
            MaskSectionGroup.Controls.Add(label23);
            MaskSectionGroup.Controls.Add(label22);
            MaskSectionGroup.Controls.Add(HostBitsText);
            MaskSectionGroup.Controls.Add(NetworkBitsText);
            MaskSectionGroup.Controls.Add(HostsText);
            MaskSectionGroup.Controls.Add(label21);
            MaskSectionGroup.Controls.Add(NetworksText);
            MaskSectionGroup.Controls.Add(label20);
            MaskSectionGroup.Controls.Add(CidrCombo);
            MaskSectionGroup.Controls.Add(label2);
            MaskSectionGroup.Controls.Add(SupernetButton);
            MaskSectionGroup.Controls.Add(label16);
            MaskSectionGroup.Controls.Add(SubnetButton);
            MaskSectionGroup.Controls.Add(label13);
            MaskSectionGroup.Controls.Add(SubnetTrackBar);
            MaskSectionGroup.Controls.Add(label14);
            MaskSectionGroup.Controls.Add(panel2);
            MaskSectionGroup.Controls.Add(label15);
            MaskSectionGroup.Controls.Add(MaskByte1Text);
            MaskSectionGroup.Controls.Add(MaskByte4Label);
            MaskSectionGroup.Controls.Add(MaskByte2Text);
            MaskSectionGroup.Controls.Add(MaskByte3Label);
            MaskSectionGroup.Controls.Add(MaskByte3Text);
            MaskSectionGroup.Controls.Add(MaskByte2Label);
            MaskSectionGroup.Controls.Add(MaskByte4Text);
            MaskSectionGroup.Controls.Add(MaskByte1Label);
            MaskSectionGroup.ForeColor = Color.White;
            MaskSectionGroup.Location = new Point(25, 299);
            MaskSectionGroup.Name = "MaskSectionGroup";
            MaskSectionGroup.Size = new Size(654, 294);
            MaskSectionGroup.TabIndex = 22;
            MaskSectionGroup.TabStop = false;
            MaskSectionGroup.Text = "Subnet Mask Section";
            // 
            // MaskCollapseLabel
            // 
            MaskCollapseLabel.AutoSize = true;
            MaskCollapseLabel.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MaskCollapseLabel.LinkBehavior = LinkBehavior.NeverUnderline;
            MaskCollapseLabel.LinkColor = Color.White;
            MaskCollapseLabel.Location = new Point(618, 18);
            MaskCollapseLabel.Name = "MaskCollapseLabel";
            MaskCollapseLabel.Size = new Size(29, 29);
            MaskCollapseLabel.TabIndex = 59;
            MaskCollapseLabel.TabStop = true;
            MaskCollapseLabel.Text = "--";
            MaskCollapseLabel.LinkClicked += MaskCollapseLabel_LinkClicked;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(279, 245);
            label23.Margin = new Padding(4, 0, 4, 0);
            label23.Name = "label23";
            label23.Size = new Size(117, 18);
            label23.TabIndex = 57;
            label23.Text = "Host bits value :";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(258, 207);
            label22.Margin = new Padding(4, 0, 4, 0);
            label22.Name = "label22";
            label22.Size = new Size(138, 18);
            label22.TabIndex = 53;
            label22.Text = "Network bit values:";
            // 
            // HostBitsText
            // 
            HostBitsText.BackColor = Color.White;
            HostBitsText.BorderStyle = BorderStyle.FixedSingle;
            HostBitsText.Location = new Point(152, 243);
            HostBitsText.Name = "HostBitsText";
            HostBitsText.ReadOnly = true;
            HostBitsText.Size = new Size(60, 26);
            HostBitsText.TabIndex = 56;
            HostBitsText.TabStop = false;
            HostBitsText.Text = "0";
            HostBitsText.TextAlign = HorizontalAlignment.Center;
            // 
            // NetworkBitsText
            // 
            NetworkBitsText.BackColor = Color.White;
            NetworkBitsText.BorderStyle = BorderStyle.FixedSingle;
            NetworkBitsText.Location = new Point(152, 205);
            NetworkBitsText.Name = "NetworkBitsText";
            NetworkBitsText.ReadOnly = true;
            NetworkBitsText.Size = new Size(60, 26);
            NetworkBitsText.TabIndex = 52;
            NetworkBitsText.TabStop = false;
            NetworkBitsText.Text = "0";
            NetworkBitsText.TextAlign = HorizontalAlignment.Center;
            // 
            // HostsText
            // 
            HostsText.BackColor = Color.White;
            HostsText.BorderStyle = BorderStyle.FixedSingle;
            HostsText.Location = new Point(403, 243);
            HostsText.Name = "HostsText";
            HostsText.ReadOnly = true;
            HostsText.Size = new Size(189, 26);
            HostsText.TabIndex = 58;
            HostsText.TabStop = false;
            HostsText.TextAlign = HorizontalAlignment.Center;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(33, 245);
            label21.Margin = new Padding(4, 0, 4, 0);
            label21.Name = "label21";
            label21.Size = new Size(85, 18);
            label21.TabIndex = 55;
            label21.Text = "Hosts bits :";
            // 
            // NetworksText
            // 
            NetworksText.BackColor = Color.White;
            NetworksText.BorderStyle = BorderStyle.FixedSingle;
            NetworksText.Location = new Point(403, 205);
            NetworksText.Name = "NetworksText";
            NetworksText.ReadOnly = true;
            NetworksText.Size = new Size(189, 26);
            NetworksText.TabIndex = 54;
            NetworksText.TabStop = false;
            NetworksText.TextAlign = HorizontalAlignment.Center;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(33, 207);
            label20.Margin = new Padding(4, 0, 4, 0);
            label20.Name = "label20";
            label20.Size = new Size(102, 18);
            label20.TabIndex = 51;
            label20.Text = "Network bits :";
            // 
            // CidrCombo
            // 
            CidrCombo.BackColor = Color.FromArgb(64, 64, 64);
            CidrCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            CidrCombo.ForeColor = Color.White;
            CidrCombo.FormattingEnabled = true;
            CidrCombo.Items.AddRange(new object[] { "/ 0", "/ 1", "/ 2", "/ 3", "/ 4", "/ 5", "/ 6", "/ 7", "/ 8", "/ 9", "/ 10", "/ 11", "/ 12", "/ 13", "/ 14", "/ 15", "/ 16", "/ 17", "/ 18", "/ 19", "/ 20", "/ 21", "/ 22", "/ 23", "/ 24", "/ 25", "/ 26", "/ 27", "/ 28", "/ 29", "/ 30", "/ 31", "/ 32" });
            CidrCombo.Location = new Point(368, 44);
            CidrCombo.Name = "CidrCombo";
            CidrCombo.Size = new Size(71, 26);
            CidrCombo.TabIndex = 32;
            CidrCombo.TabStop = false;
            CidrCombo.SelectedIndexChanged += CidrCombo_SelectedIndexChanged;
            // 
            // ShowNetworksButton
            // 
            ShowNetworksButton.BackColor = Color.Green;
            ShowNetworksButton.FlatStyle = FlatStyle.Popup;
            ShowNetworksButton.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ShowNetworksButton.Location = new Point(394, 128);
            ShowNetworksButton.Name = "ShowNetworksButton";
            ShowNetworksButton.Size = new Size(198, 39);
            ShowNetworksButton.TabIndex = 78;
            ShowNetworksButton.Text = "Show Sub Networks";
            ShowNetworksButton.UseVisualStyleBackColor = false;
            ShowNetworksButton.Click += ShowNetworksButton_Click;
            // 
            // SubnetSectionGroup
            // 
            SubnetSectionGroup.Controls.Add(panel5);
            SubnetSectionGroup.Controls.Add(DefaultMaskLabel);
            SubnetSectionGroup.Controls.Add(SubnetCollapseLabel);
            SubnetSectionGroup.Controls.Add(label34);
            SubnetSectionGroup.Controls.Add(label35);
            SubnetSectionGroup.Controls.Add(HostsPerSubnetText);
            SubnetSectionGroup.Controls.Add(SubnetsText);
            SubnetSectionGroup.Controls.Add(HostBits2Text);
            SubnetSectionGroup.Controls.Add(label33);
            SubnetSectionGroup.Controls.Add(SubnetBitsText);
            SubnetSectionGroup.Controls.Add(label32);
            SubnetSectionGroup.Controls.Add(BinaryRTF);
            SubnetSectionGroup.Controls.Add(panel4);
            SubnetSectionGroup.Controls.Add(panel3);
            SubnetSectionGroup.Controls.Add(label25);
            SubnetSectionGroup.Controls.Add(label24);
            SubnetSectionGroup.Controls.Add(ShowNetworksButton);
            SubnetSectionGroup.ForeColor = Color.White;
            SubnetSectionGroup.Location = new Point(25, 610);
            SubnetSectionGroup.Name = "SubnetSectionGroup";
            SubnetSectionGroup.Size = new Size(654, 318);
            SubnetSectionGroup.TabIndex = 59;
            SubnetSectionGroup.TabStop = false;
            SubnetSectionGroup.Text = "Sub Network";
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(label36);
            panel5.Controls.Add(label37);
            panel5.Controls.Add(label38);
            panel5.Controls.Add(DefaultOctect4);
            panel5.Controls.Add(DefaultOctect3);
            panel5.Controls.Add(DefaultOctect2);
            panel5.Controls.Add(DefaultOctect1);
            panel5.Location = new Point(152, 83);
            panel5.Name = "panel5";
            panel5.Size = new Size(197, 35);
            panel5.TabIndex = 90;
            // 
            // label36
            // 
            label36.AutoSize = true;
            label36.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label36.ForeColor = Color.Black;
            label36.Location = new Point(138, 7);
            label36.Name = "label36";
            label36.Size = new Size(13, 19);
            label36.TabIndex = 76;
            label36.Text = ".";
            // 
            // label37
            // 
            label37.AutoSize = true;
            label37.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label37.ForeColor = Color.Black;
            label37.Location = new Point(92, 8);
            label37.Name = "label37";
            label37.Size = new Size(13, 19);
            label37.TabIndex = 74;
            label37.Text = ".";
            // 
            // label38
            // 
            label38.AutoSize = true;
            label38.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label38.ForeColor = Color.Black;
            label38.Location = new Point(46, 8);
            label38.Name = "label38";
            label38.Size = new Size(13, 19);
            label38.TabIndex = 72;
            label38.Text = ".";
            // 
            // DefaultOctect4
            // 
            DefaultOctect4.BackColor = Color.White;
            DefaultOctect4.BorderStyle = BorderStyle.None;
            DefaultOctect4.Location = new Point(147, 8);
            DefaultOctect4.Name = "DefaultOctect4";
            DefaultOctect4.ReadOnly = true;
            DefaultOctect4.Size = new Size(39, 19);
            DefaultOctect4.TabIndex = 77;
            DefaultOctect4.TabStop = false;
            DefaultOctect4.Text = "0";
            DefaultOctect4.TextAlign = HorizontalAlignment.Center;
            // 
            // DefaultOctect3
            // 
            DefaultOctect3.BackColor = Color.White;
            DefaultOctect3.BorderStyle = BorderStyle.None;
            DefaultOctect3.Location = new Point(102, 8);
            DefaultOctect3.Name = "DefaultOctect3";
            DefaultOctect3.ReadOnly = true;
            DefaultOctect3.Size = new Size(39, 19);
            DefaultOctect3.TabIndex = 75;
            DefaultOctect3.TabStop = false;
            DefaultOctect3.Text = "0";
            DefaultOctect3.TextAlign = HorizontalAlignment.Center;
            // 
            // DefaultOctect2
            // 
            DefaultOctect2.BackColor = Color.White;
            DefaultOctect2.BorderStyle = BorderStyle.None;
            DefaultOctect2.Location = new Point(57, 8);
            DefaultOctect2.Name = "DefaultOctect2";
            DefaultOctect2.ReadOnly = true;
            DefaultOctect2.Size = new Size(39, 19);
            DefaultOctect2.TabIndex = 73;
            DefaultOctect2.TabStop = false;
            DefaultOctect2.Text = "0";
            DefaultOctect2.TextAlign = HorizontalAlignment.Center;
            // 
            // DefaultOctect1
            // 
            DefaultOctect1.BackColor = Color.White;
            DefaultOctect1.BorderStyle = BorderStyle.None;
            DefaultOctect1.Location = new Point(9, 8);
            DefaultOctect1.Name = "DefaultOctect1";
            DefaultOctect1.ReadOnly = true;
            DefaultOctect1.Size = new Size(39, 19);
            DefaultOctect1.TabIndex = 71;
            DefaultOctect1.TabStop = false;
            DefaultOctect1.Text = "0";
            DefaultOctect1.TextAlign = HorizontalAlignment.Center;
            // 
            // DefaultMaskLabel
            // 
            DefaultMaskLabel.AutoSize = true;
            DefaultMaskLabel.Location = new Point(33, 93);
            DefaultMaskLabel.Margin = new Padding(4, 0, 4, 0);
            DefaultMaskLabel.Name = "DefaultMaskLabel";
            DefaultMaskLabel.Size = new Size(107, 18);
            DefaultMaskLabel.TabIndex = 89;
            DefaultMaskLabel.Text = "Default Mask :";
            // 
            // SubnetCollapseLabel
            // 
            SubnetCollapseLabel.AutoSize = true;
            SubnetCollapseLabel.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SubnetCollapseLabel.LinkBehavior = LinkBehavior.NeverUnderline;
            SubnetCollapseLabel.LinkColor = Color.White;
            SubnetCollapseLabel.Location = new Point(618, 18);
            SubnetCollapseLabel.Name = "SubnetCollapseLabel";
            SubnetCollapseLabel.Size = new Size(29, 29);
            SubnetCollapseLabel.TabIndex = 88;
            SubnetCollapseLabel.TabStop = true;
            SubnetCollapseLabel.Text = "--";
            SubnetCollapseLabel.LinkClicked += SubnetCollapseLabel_LinkClicked;
            // 
            // label34
            // 
            label34.AutoSize = true;
            label34.Location = new Point(236, 275);
            label34.Margin = new Padding(4, 0, 4, 0);
            label34.Name = "label34";
            label34.Size = new Size(133, 18);
            label34.TabIndex = 86;
            label34.Text = "Hosts per subnet :";
            // 
            // label35
            // 
            label35.AutoSize = true;
            label35.Location = new Point(296, 237);
            label35.Margin = new Padding(4, 0, 4, 0);
            label35.Name = "label35";
            label35.Size = new Size(73, 18);
            label35.TabIndex = 84;
            label35.Text = "Subnets :";
            // 
            // HostsPerSubnetText
            // 
            HostsPerSubnetText.BackColor = Color.White;
            HostsPerSubnetText.BorderStyle = BorderStyle.FixedSingle;
            HostsPerSubnetText.Location = new Point(376, 273);
            HostsPerSubnetText.Name = "HostsPerSubnetText";
            HostsPerSubnetText.ReadOnly = true;
            HostsPerSubnetText.Size = new Size(216, 26);
            HostsPerSubnetText.TabIndex = 87;
            HostsPerSubnetText.TabStop = false;
            HostsPerSubnetText.TextAlign = HorizontalAlignment.Center;
            // 
            // SubnetsText
            // 
            SubnetsText.BackColor = Color.White;
            SubnetsText.BorderStyle = BorderStyle.FixedSingle;
            SubnetsText.Location = new Point(376, 235);
            SubnetsText.Name = "SubnetsText";
            SubnetsText.ReadOnly = true;
            SubnetsText.Size = new Size(216, 26);
            SubnetsText.TabIndex = 85;
            SubnetsText.TabStop = false;
            SubnetsText.TextAlign = HorizontalAlignment.Center;
            // 
            // HostBits2Text
            // 
            HostBits2Text.BackColor = Color.White;
            HostBits2Text.BorderStyle = BorderStyle.FixedSingle;
            HostBits2Text.Location = new Point(150, 273);
            HostBits2Text.Name = "HostBits2Text";
            HostBits2Text.ReadOnly = true;
            HostBits2Text.Size = new Size(60, 26);
            HostBits2Text.TabIndex = 83;
            HostBits2Text.TabStop = false;
            HostBits2Text.Text = "0";
            HostBits2Text.TextAlign = HorizontalAlignment.Center;
            // 
            // label33
            // 
            label33.AutoSize = true;
            label33.Location = new Point(33, 279);
            label33.Margin = new Padding(4, 0, 4, 0);
            label33.Name = "label33";
            label33.Size = new Size(77, 18);
            label33.TabIndex = 82;
            label33.Text = "Host bits :";
            // 
            // SubnetBitsText
            // 
            SubnetBitsText.BackColor = Color.White;
            SubnetBitsText.BorderStyle = BorderStyle.FixedSingle;
            SubnetBitsText.Location = new Point(150, 235);
            SubnetBitsText.Name = "SubnetBitsText";
            SubnetBitsText.ReadOnly = true;
            SubnetBitsText.Size = new Size(60, 26);
            SubnetBitsText.TabIndex = 81;
            SubnetBitsText.TabStop = false;
            SubnetBitsText.Text = "0";
            SubnetBitsText.TextAlign = HorizontalAlignment.Center;
            // 
            // label32
            // 
            label32.AutoSize = true;
            label32.Location = new Point(33, 237);
            label32.Margin = new Padding(4, 0, 4, 0);
            label32.Name = "label32";
            label32.Size = new Size(94, 18);
            label32.TabIndex = 80;
            label32.Text = "Subnet bits :";
            // 
            // BinaryRTF
            // 
            BinaryRTF.BackColor = Color.White;
            BinaryRTF.BorderStyle = BorderStyle.None;
            BinaryRTF.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BinaryRTF.Location = new Point(152, 179);
            BinaryRTF.Name = "BinaryRTF";
            BinaryRTF.ReadOnly = true;
            BinaryRTF.Size = new Size(440, 42);
            BinaryRTF.TabIndex = 79;
            BinaryRTF.TabStop = false;
            BinaryRTF.Text = "";
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(label29);
            panel4.Controls.Add(label30);
            panel4.Controls.Add(label31);
            panel4.Controls.Add(SubMask4Text);
            panel4.Controls.Add(SubMask3Text);
            panel4.Controls.Add(SubMask2Text);
            panel4.Controls.Add(SubMask1Text);
            panel4.Location = new Point(152, 130);
            panel4.Name = "panel4";
            panel4.Size = new Size(197, 35);
            panel4.TabIndex = 70;
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label29.ForeColor = Color.Black;
            label29.Location = new Point(138, 7);
            label29.Name = "label29";
            label29.Size = new Size(13, 19);
            label29.TabIndex = 76;
            label29.Text = ".";
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label30.ForeColor = Color.Black;
            label30.Location = new Point(92, 8);
            label30.Name = "label30";
            label30.Size = new Size(13, 19);
            label30.TabIndex = 74;
            label30.Text = ".";
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label31.ForeColor = Color.Black;
            label31.Location = new Point(46, 8);
            label31.Name = "label31";
            label31.Size = new Size(13, 19);
            label31.TabIndex = 72;
            label31.Text = ".";
            // 
            // SubMask4Text
            // 
            SubMask4Text.BackColor = Color.White;
            SubMask4Text.BorderStyle = BorderStyle.None;
            SubMask4Text.Location = new Point(147, 8);
            SubMask4Text.Name = "SubMask4Text";
            SubMask4Text.ReadOnly = true;
            SubMask4Text.Size = new Size(39, 19);
            SubMask4Text.TabIndex = 77;
            SubMask4Text.TabStop = false;
            SubMask4Text.Text = "0";
            SubMask4Text.TextAlign = HorizontalAlignment.Center;
            // 
            // SubMask3Text
            // 
            SubMask3Text.BackColor = Color.White;
            SubMask3Text.BorderStyle = BorderStyle.None;
            SubMask3Text.Location = new Point(102, 8);
            SubMask3Text.Name = "SubMask3Text";
            SubMask3Text.ReadOnly = true;
            SubMask3Text.Size = new Size(39, 19);
            SubMask3Text.TabIndex = 75;
            SubMask3Text.TabStop = false;
            SubMask3Text.Text = "0";
            SubMask3Text.TextAlign = HorizontalAlignment.Center;
            // 
            // SubMask2Text
            // 
            SubMask2Text.BackColor = Color.White;
            SubMask2Text.BorderStyle = BorderStyle.None;
            SubMask2Text.Location = new Point(57, 8);
            SubMask2Text.Name = "SubMask2Text";
            SubMask2Text.ReadOnly = true;
            SubMask2Text.Size = new Size(39, 19);
            SubMask2Text.TabIndex = 73;
            SubMask2Text.TabStop = false;
            SubMask2Text.Text = "0";
            SubMask2Text.TextAlign = HorizontalAlignment.Center;
            // 
            // SubMask1Text
            // 
            SubMask1Text.BackColor = Color.White;
            SubMask1Text.BorderStyle = BorderStyle.None;
            SubMask1Text.Location = new Point(9, 8);
            SubMask1Text.Name = "SubMask1Text";
            SubMask1Text.ReadOnly = true;
            SubMask1Text.Size = new Size(39, 19);
            SubMask1Text.TabIndex = 71;
            SubMask1Text.TabStop = false;
            SubMask1Text.Text = "0";
            SubMask1Text.TextAlign = HorizontalAlignment.Center;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(label26);
            panel3.Controls.Add(label27);
            panel3.Controls.Add(label28);
            panel3.Controls.Add(SubIP4Text);
            panel3.Controls.Add(SubIP3Text);
            panel3.Controls.Add(SubIP2Text);
            panel3.Controls.Add(SubIP1Text);
            panel3.Location = new Point(152, 36);
            panel3.Name = "panel3";
            panel3.Size = new Size(197, 35);
            panel3.TabIndex = 61;
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label26.ForeColor = Color.Black;
            label26.Location = new Point(138, 7);
            label26.Name = "label26";
            label26.Size = new Size(13, 19);
            label26.TabIndex = 67;
            label26.Text = ".";
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label27.ForeColor = Color.Black;
            label27.Location = new Point(92, 8);
            label27.Name = "label27";
            label27.Size = new Size(13, 19);
            label27.TabIndex = 65;
            label27.Text = ".";
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label28.ForeColor = Color.Black;
            label28.Location = new Point(46, 8);
            label28.Name = "label28";
            label28.Size = new Size(13, 19);
            label28.TabIndex = 63;
            label28.Text = ".";
            // 
            // SubIP4Text
            // 
            SubIP4Text.BackColor = Color.White;
            SubIP4Text.BorderStyle = BorderStyle.None;
            SubIP4Text.Location = new Point(147, 8);
            SubIP4Text.Name = "SubIP4Text";
            SubIP4Text.ReadOnly = true;
            SubIP4Text.Size = new Size(39, 19);
            SubIP4Text.TabIndex = 68;
            SubIP4Text.TabStop = false;
            SubIP4Text.Text = "0";
            SubIP4Text.TextAlign = HorizontalAlignment.Center;
            // 
            // SubIP3Text
            // 
            SubIP3Text.BackColor = Color.White;
            SubIP3Text.BorderStyle = BorderStyle.None;
            SubIP3Text.Location = new Point(102, 8);
            SubIP3Text.Name = "SubIP3Text";
            SubIP3Text.ReadOnly = true;
            SubIP3Text.Size = new Size(39, 19);
            SubIP3Text.TabIndex = 66;
            SubIP3Text.TabStop = false;
            SubIP3Text.Text = "0";
            SubIP3Text.TextAlign = HorizontalAlignment.Center;
            // 
            // SubIP2Text
            // 
            SubIP2Text.BackColor = Color.White;
            SubIP2Text.BorderStyle = BorderStyle.None;
            SubIP2Text.Location = new Point(57, 8);
            SubIP2Text.Name = "SubIP2Text";
            SubIP2Text.ReadOnly = true;
            SubIP2Text.Size = new Size(39, 19);
            SubIP2Text.TabIndex = 64;
            SubIP2Text.TabStop = false;
            SubIP2Text.Text = "0";
            SubIP2Text.TextAlign = HorizontalAlignment.Center;
            // 
            // SubIP1Text
            // 
            SubIP1Text.BackColor = Color.White;
            SubIP1Text.BorderStyle = BorderStyle.None;
            SubIP1Text.Location = new Point(9, 8);
            SubIP1Text.Name = "SubIP1Text";
            SubIP1Text.ReadOnly = true;
            SubIP1Text.Size = new Size(39, 19);
            SubIP1Text.TabIndex = 62;
            SubIP1Text.TabStop = false;
            SubIP1Text.Text = "0";
            SubIP1Text.TextAlign = HorizontalAlignment.Center;
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Location = new Point(33, 140);
            label25.Margin = new Padding(4, 0, 4, 0);
            label25.Name = "label25";
            label25.Size = new Size(107, 18);
            label25.TabIndex = 69;
            label25.Text = "Subnet Mask :";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new Point(33, 47);
            label24.Margin = new Padding(4, 0, 4, 0);
            label24.Name = "label24";
            label24.Size = new Size(92, 18);
            label24.TabIndex = 60;
            label24.Text = "IP Address :";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.Subnet2;
            pictureBox1.Location = new Point(50, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(600, 60);
            pictureBox1.TabIndex = 60;
            pictureBox1.TabStop = false;
            pictureBox1.MouseDown += ClassFull_MouseDown;
            pictureBox1.MouseMove += ClassFull_MouseMove;
            // 
            // ClassFull
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            BackgroundImage = Properties.Resources.ipsubbg;
            ClientSize = new Size(714, 961);
            Controls.Add(pictureBox1);
            Controls.Add(SubnetSectionGroup);
            Controls.Add(MaskSectionGroup);
            Controls.Add(IpSectionGroup);
            Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.White;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MaximizeBox = false;
            MaximumSize = new Size(730, 1000);
            MinimumSize = new Size(730, 570);
            Name = "ClassFull";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "IP Subnet (Classfull)";
            Load += SubnetForm_Load;
            MouseDown += ClassFull_MouseDown;
            MouseMove += ClassFull_MouseMove;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)SubnetTrackBar).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            IpSectionGroup.ResumeLayout(false);
            IpSectionGroup.PerformLayout();
            MaskSectionGroup.ResumeLayout(false);
            MaskSectionGroup.PerformLayout();
            SubnetSectionGroup.ResumeLayout(false);
            SubnetSectionGroup.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox IP1Text;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SupernetButton;
        private System.Windows.Forms.Button SubnetButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Byte1Text;
        private System.Windows.Forms.TextBox Byte2Text;
        private System.Windows.Forms.TextBox Byte3Text;
        private System.Windows.Forms.TextBox Byte4Text;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox IP4Text;
        private System.Windows.Forms.TextBox IP3Text;
        private System.Windows.Forms.TextBox IP2Text;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Byte1Label;
        private System.Windows.Forms.Label Byte2Label;
        private System.Windows.Forms.Label Byte3Label;
        private System.Windows.Forms.Label Byte4Label;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TrackBar SubnetTrackBar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox Mask4Text;
        private System.Windows.Forms.TextBox Mask3Text;
        private System.Windows.Forms.TextBox Mask2Text;
        private System.Windows.Forms.TextBox Mask1Text;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label MaskByte4Label;
        private System.Windows.Forms.Label MaskByte3Label;
        private System.Windows.Forms.Label MaskByte2Label;
        private System.Windows.Forms.Label MaskByte1Label;
        private System.Windows.Forms.TextBox MaskByte4Text;
        private System.Windows.Forms.TextBox MaskByte3Text;
        private System.Windows.Forms.TextBox MaskByte2Text;
        private System.Windows.Forms.TextBox MaskByte1Text;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox IpSectionGroup;
        private System.Windows.Forms.GroupBox MaskSectionGroup;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox IpTypeText;
        private System.Windows.Forms.TextBox IpClassText;
        private System.Windows.Forms.ComboBox CidrCombo;
        private System.Windows.Forms.TextBox NetworksText;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox HostsText;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button ShowNetworksButton;
        private System.Windows.Forms.GroupBox SubnetSectionGroup;
        private System.Windows.Forms.TextBox HostBitsText;
        private System.Windows.Forms.TextBox NetworkBitsText;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox SubIP4Text;
        private System.Windows.Forms.TextBox SubIP3Text;
        private System.Windows.Forms.TextBox SubIP2Text;
        private System.Windows.Forms.TextBox SubIP1Text;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.TextBox SubMask4Text;
        private System.Windows.Forms.TextBox SubMask3Text;
        private System.Windows.Forms.TextBox SubMask2Text;
        private System.Windows.Forms.TextBox SubMask1Text;
        private System.Windows.Forms.RichTextBox BinaryRTF;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.TextBox SubnetBitsText;
        private System.Windows.Forms.TextBox HostBits2Text;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.TextBox HostsPerSubnetText;
        private System.Windows.Forms.TextBox SubnetsText;
        private System.Windows.Forms.LinkLabel IpCollapseLabel;
        private System.Windows.Forms.LinkLabel MaskCollapseLabel;
        private System.Windows.Forms.LinkLabel SubnetCollapseLabel;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.TextBox DefaultOctect4;
        private System.Windows.Forms.TextBox DefaultOctect3;
        private System.Windows.Forms.TextBox DefaultOctect2;
        private System.Windows.Forms.TextBox DefaultOctect1;
        private System.Windows.Forms.Label DefaultMaskLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
