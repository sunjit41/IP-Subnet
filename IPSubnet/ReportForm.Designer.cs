namespace IPSubnet
{
    partial class ReportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportForm));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            BlockSizeText = new TextBox();
            StatusLabel = new Label();
            label34 = new Label();
            HostsPerSubnetText = new TextBox();
            progressBar1 = new ProgressBar();
            label35 = new Label();
            SubnetsText = new TextBox();
            label4 = new Label();
            IpPanel = new Panel();
            label26 = new Label();
            label27 = new Label();
            label28 = new Label();
            IpOctet4Text = new TextBox();
            IpOctet3Text = new TextBox();
            IpOctet2Text = new TextBox();
            IpOctet1Text = new TextBox();
            panel1 = new Panel();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            DefaultOctet4 = new TextBox();
            DefaultOctet3 = new TextBox();
            DefaultOctet2 = new TextBox();
            DefaultOctet1 = new TextBox();
            panel2 = new Panel();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            SubnetOctet4 = new TextBox();
            SubnetOctet3 = new TextBox();
            SubnetOctet2 = new TextBox();
            SubnetOctet1 = new TextBox();
            panel3 = new Panel();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            WildcradOctet4 = new TextBox();
            WildcradOctet3 = new TextBox();
            WildcradOctet2 = new TextBox();
            WildcradOctet1 = new TextBox();
            label14 = new Label();
            MyWebView = new Microsoft.Web.WebView2.WinForms.WebView2();
            ExportButton = new Button();
            panel4 = new Panel();
            IpPanel.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MyWebView).BeginInit();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(48, 26);
            label1.Name = "label1";
            label1.Size = new Size(83, 18);
            label1.TabIndex = 0;
            label1.Text = "IP Network";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(32, 101);
            label2.Name = "label2";
            label2.Size = new Size(99, 18);
            label2.TabIndex = 2;
            label2.Text = "Subnet Mask";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(505, 98);
            label3.Name = "label3";
            label3.Size = new Size(90, 18);
            label3.TabIndex = 4;
            label3.Text = "Block Size :";
            // 
            // BlockSizeText
            // 
            BlockSizeText.Location = new Point(602, 95);
            BlockSizeText.Name = "BlockSizeText";
            BlockSizeText.ReadOnly = true;
            BlockSizeText.Size = new Size(216, 26);
            BlockSizeText.TabIndex = 5;
            BlockSizeText.TabStop = false;
            BlockSizeText.TextAlign = HorizontalAlignment.Center;
            // 
            // StatusLabel
            // 
            StatusLabel.BackColor = Color.Transparent;
            StatusLabel.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            StatusLabel.ForeColor = Color.Yellow;
            StatusLabel.Location = new Point(12, 194);
            StatusLabel.Name = "StatusLabel";
            StatusLabel.Size = new Size(412, 22);
            StatusLabel.TabIndex = 11;
            StatusLabel.Text = "Loading, Please wait...";
            StatusLabel.TextAlign = ContentAlignment.MiddleLeft;
            StatusLabel.Click += StatusLabel_Click;
            StatusLabel.MouseDown += ReportForm_MouseDown;
            StatusLabel.MouseMove += ReportForm_MouseMove;
            // 
            // label34
            // 
            label34.AutoSize = true;
            label34.ForeColor = Color.White;
            label34.Location = new Point(462, 60);
            label34.Margin = new Padding(4, 0, 4, 0);
            label34.Name = "label34";
            label34.Size = new Size(133, 18);
            label34.TabIndex = 8;
            label34.Text = "Hosts per subnet :";
            // 
            // HostsPerSubnetText
            // 
            HostsPerSubnetText.BackColor = Color.White;
            HostsPerSubnetText.BorderStyle = BorderStyle.FixedSingle;
            HostsPerSubnetText.ForeColor = Color.Black;
            HostsPerSubnetText.Location = new Point(602, 58);
            HostsPerSubnetText.Name = "HostsPerSubnetText";
            HostsPerSubnetText.ReadOnly = true;
            HostsPerSubnetText.Size = new Size(216, 26);
            HostsPerSubnetText.TabIndex = 9;
            HostsPerSubnetText.TabStop = false;
            HostsPerSubnetText.TextAlign = HorizontalAlignment.Center;
            // 
            // progressBar1
            // 
            progressBar1.Dock = DockStyle.Bottom;
            progressBar1.Location = new Point(0, 688);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(834, 23);
            progressBar1.TabIndex = 90;
            // 
            // label35
            // 
            label35.AutoSize = true;
            label35.ForeColor = Color.White;
            label35.Location = new Point(446, 24);
            label35.Margin = new Padding(4, 0, 4, 0);
            label35.Name = "label35";
            label35.Size = new Size(149, 18);
            label35.TabIndex = 6;
            label35.Text = "Number of Subnets :";
            // 
            // SubnetsText
            // 
            SubnetsText.BackColor = Color.White;
            SubnetsText.BorderStyle = BorderStyle.FixedSingle;
            SubnetsText.Location = new Point(602, 22);
            SubnetsText.Name = "SubnetsText";
            SubnetsText.ReadOnly = true;
            SubnetsText.Size = new Size(216, 26);
            SubnetsText.TabIndex = 7;
            SubnetsText.TabStop = false;
            SubnetsText.TextAlign = HorizontalAlignment.Center;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(32, 64);
            label4.Name = "label4";
            label4.Size = new Size(99, 18);
            label4.TabIndex = 92;
            label4.Text = "Default Mask";
            // 
            // IpPanel
            // 
            IpPanel.BackColor = Color.White;
            IpPanel.BorderStyle = BorderStyle.FixedSingle;
            IpPanel.Controls.Add(label26);
            IpPanel.Controls.Add(label27);
            IpPanel.Controls.Add(label28);
            IpPanel.Controls.Add(IpOctet4Text);
            IpPanel.Controls.Add(IpOctet3Text);
            IpPanel.Controls.Add(IpOctet2Text);
            IpPanel.Controls.Add(IpOctet1Text);
            IpPanel.Location = new Point(145, 20);
            IpPanel.Name = "IpPanel";
            IpPanel.Size = new Size(197, 31);
            IpPanel.TabIndex = 94;
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label26.ForeColor = Color.Black;
            label26.Location = new Point(138, 3);
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
            label27.Location = new Point(92, 4);
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
            label28.Location = new Point(46, 4);
            label28.Name = "label28";
            label28.Size = new Size(13, 19);
            label28.TabIndex = 63;
            label28.Text = ".";
            // 
            // IpOctet4Text
            // 
            IpOctet4Text.BackColor = Color.White;
            IpOctet4Text.BorderStyle = BorderStyle.None;
            IpOctet4Text.Location = new Point(147, 4);
            IpOctet4Text.Name = "IpOctet4Text";
            IpOctet4Text.ReadOnly = true;
            IpOctet4Text.Size = new Size(39, 19);
            IpOctet4Text.TabIndex = 68;
            IpOctet4Text.TabStop = false;
            IpOctet4Text.Text = "0";
            IpOctet4Text.TextAlign = HorizontalAlignment.Center;
            // 
            // IpOctet3Text
            // 
            IpOctet3Text.BackColor = Color.White;
            IpOctet3Text.BorderStyle = BorderStyle.None;
            IpOctet3Text.Location = new Point(102, 4);
            IpOctet3Text.Name = "IpOctet3Text";
            IpOctet3Text.ReadOnly = true;
            IpOctet3Text.Size = new Size(39, 19);
            IpOctet3Text.TabIndex = 66;
            IpOctet3Text.TabStop = false;
            IpOctet3Text.Text = "0";
            IpOctet3Text.TextAlign = HorizontalAlignment.Center;
            // 
            // IpOctet2Text
            // 
            IpOctet2Text.BackColor = Color.White;
            IpOctet2Text.BorderStyle = BorderStyle.None;
            IpOctet2Text.Location = new Point(57, 4);
            IpOctet2Text.Name = "IpOctet2Text";
            IpOctet2Text.ReadOnly = true;
            IpOctet2Text.Size = new Size(39, 19);
            IpOctet2Text.TabIndex = 64;
            IpOctet2Text.TabStop = false;
            IpOctet2Text.Text = "0";
            IpOctet2Text.TextAlign = HorizontalAlignment.Center;
            // 
            // IpOctet1Text
            // 
            IpOctet1Text.BackColor = Color.White;
            IpOctet1Text.BorderStyle = BorderStyle.None;
            IpOctet1Text.Location = new Point(9, 4);
            IpOctet1Text.Name = "IpOctet1Text";
            IpOctet1Text.ReadOnly = true;
            IpOctet1Text.Size = new Size(39, 19);
            IpOctet1Text.TabIndex = 62;
            IpOctet1Text.TabStop = false;
            IpOctet1Text.Text = "0";
            IpOctet1Text.TextAlign = HorizontalAlignment.Center;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(DefaultOctet4);
            panel1.Controls.Add(DefaultOctet3);
            panel1.Controls.Add(DefaultOctet2);
            panel1.Controls.Add(DefaultOctet1);
            panel1.Location = new Point(145, 58);
            panel1.Name = "panel1";
            panel1.Size = new Size(197, 31);
            panel1.TabIndex = 95;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(138, 3);
            label5.Name = "label5";
            label5.Size = new Size(13, 19);
            label5.TabIndex = 67;
            label5.Text = ".";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(92, 4);
            label6.Name = "label6";
            label6.Size = new Size(13, 19);
            label6.TabIndex = 65;
            label6.Text = ".";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(46, 4);
            label7.Name = "label7";
            label7.Size = new Size(13, 19);
            label7.TabIndex = 63;
            label7.Text = ".";
            // 
            // DefaultOctet4
            // 
            DefaultOctet4.BackColor = Color.White;
            DefaultOctet4.BorderStyle = BorderStyle.None;
            DefaultOctet4.Location = new Point(147, 4);
            DefaultOctet4.Name = "DefaultOctet4";
            DefaultOctet4.ReadOnly = true;
            DefaultOctet4.Size = new Size(39, 19);
            DefaultOctet4.TabIndex = 68;
            DefaultOctet4.TabStop = false;
            DefaultOctet4.Text = "0";
            DefaultOctet4.TextAlign = HorizontalAlignment.Center;
            // 
            // DefaultOctet3
            // 
            DefaultOctet3.BackColor = Color.White;
            DefaultOctet3.BorderStyle = BorderStyle.None;
            DefaultOctet3.Location = new Point(102, 4);
            DefaultOctet3.Name = "DefaultOctet3";
            DefaultOctet3.ReadOnly = true;
            DefaultOctet3.Size = new Size(39, 19);
            DefaultOctet3.TabIndex = 66;
            DefaultOctet3.TabStop = false;
            DefaultOctet3.Text = "0";
            DefaultOctet3.TextAlign = HorizontalAlignment.Center;
            // 
            // DefaultOctet2
            // 
            DefaultOctet2.BackColor = Color.White;
            DefaultOctet2.BorderStyle = BorderStyle.None;
            DefaultOctet2.Location = new Point(57, 4);
            DefaultOctet2.Name = "DefaultOctet2";
            DefaultOctet2.ReadOnly = true;
            DefaultOctet2.Size = new Size(39, 19);
            DefaultOctet2.TabIndex = 64;
            DefaultOctet2.TabStop = false;
            DefaultOctet2.Text = "0";
            DefaultOctet2.TextAlign = HorizontalAlignment.Center;
            // 
            // DefaultOctet1
            // 
            DefaultOctet1.BackColor = Color.White;
            DefaultOctet1.BorderStyle = BorderStyle.None;
            DefaultOctet1.Location = new Point(9, 4);
            DefaultOctet1.Name = "DefaultOctet1";
            DefaultOctet1.ReadOnly = true;
            DefaultOctet1.Size = new Size(39, 19);
            DefaultOctet1.TabIndex = 62;
            DefaultOctet1.TabStop = false;
            DefaultOctet1.Text = "0";
            DefaultOctet1.TextAlign = HorizontalAlignment.Center;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(SubnetOctet4);
            panel2.Controls.Add(SubnetOctet3);
            panel2.Controls.Add(SubnetOctet2);
            panel2.Controls.Add(SubnetOctet1);
            panel2.Location = new Point(145, 96);
            panel2.Name = "panel2";
            panel2.Size = new Size(197, 31);
            panel2.TabIndex = 96;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(138, 3);
            label8.Name = "label8";
            label8.Size = new Size(13, 19);
            label8.TabIndex = 67;
            label8.Text = ".";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(92, 4);
            label9.Name = "label9";
            label9.Size = new Size(13, 19);
            label9.TabIndex = 65;
            label9.Text = ".";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(46, 4);
            label10.Name = "label10";
            label10.Size = new Size(13, 19);
            label10.TabIndex = 63;
            label10.Text = ".";
            // 
            // SubnetOctet4
            // 
            SubnetOctet4.BackColor = Color.White;
            SubnetOctet4.BorderStyle = BorderStyle.None;
            SubnetOctet4.Location = new Point(147, 4);
            SubnetOctet4.Name = "SubnetOctet4";
            SubnetOctet4.ReadOnly = true;
            SubnetOctet4.Size = new Size(39, 19);
            SubnetOctet4.TabIndex = 68;
            SubnetOctet4.TabStop = false;
            SubnetOctet4.Text = "0";
            SubnetOctet4.TextAlign = HorizontalAlignment.Center;
            // 
            // SubnetOctet3
            // 
            SubnetOctet3.BackColor = Color.White;
            SubnetOctet3.BorderStyle = BorderStyle.None;
            SubnetOctet3.Location = new Point(102, 4);
            SubnetOctet3.Name = "SubnetOctet3";
            SubnetOctet3.ReadOnly = true;
            SubnetOctet3.Size = new Size(39, 19);
            SubnetOctet3.TabIndex = 66;
            SubnetOctet3.TabStop = false;
            SubnetOctet3.Text = "0";
            SubnetOctet3.TextAlign = HorizontalAlignment.Center;
            // 
            // SubnetOctet2
            // 
            SubnetOctet2.BackColor = Color.White;
            SubnetOctet2.BorderStyle = BorderStyle.None;
            SubnetOctet2.Location = new Point(57, 4);
            SubnetOctet2.Name = "SubnetOctet2";
            SubnetOctet2.ReadOnly = true;
            SubnetOctet2.Size = new Size(39, 19);
            SubnetOctet2.TabIndex = 64;
            SubnetOctet2.TabStop = false;
            SubnetOctet2.Text = "0";
            SubnetOctet2.TextAlign = HorizontalAlignment.Center;
            // 
            // SubnetOctet1
            // 
            SubnetOctet1.BackColor = Color.White;
            SubnetOctet1.BorderStyle = BorderStyle.None;
            SubnetOctet1.Location = new Point(9, 4);
            SubnetOctet1.Name = "SubnetOctet1";
            SubnetOctet1.ReadOnly = true;
            SubnetOctet1.Size = new Size(39, 19);
            SubnetOctet1.TabIndex = 62;
            SubnetOctet1.TabStop = false;
            SubnetOctet1.Text = "0";
            SubnetOctet1.TextAlign = HorizontalAlignment.Center;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(label11);
            panel3.Controls.Add(label12);
            panel3.Controls.Add(label13);
            panel3.Controls.Add(WildcradOctet4);
            panel3.Controls.Add(WildcradOctet3);
            panel3.Controls.Add(WildcradOctet2);
            panel3.Controls.Add(WildcradOctet1);
            panel3.Location = new Point(145, 134);
            panel3.Name = "panel3";
            panel3.Size = new Size(197, 31);
            panel3.TabIndex = 98;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.Black;
            label11.Location = new Point(138, 3);
            label11.Name = "label11";
            label11.Size = new Size(13, 19);
            label11.TabIndex = 67;
            label11.Text = ".";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.Black;
            label12.Location = new Point(92, 4);
            label12.Name = "label12";
            label12.Size = new Size(13, 19);
            label12.TabIndex = 65;
            label12.Text = ".";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.Black;
            label13.Location = new Point(46, 4);
            label13.Name = "label13";
            label13.Size = new Size(13, 19);
            label13.TabIndex = 63;
            label13.Text = ".";
            // 
            // WildcradOctet4
            // 
            WildcradOctet4.BackColor = Color.White;
            WildcradOctet4.BorderStyle = BorderStyle.None;
            WildcradOctet4.Location = new Point(147, 4);
            WildcradOctet4.Name = "WildcradOctet4";
            WildcradOctet4.ReadOnly = true;
            WildcradOctet4.Size = new Size(39, 19);
            WildcradOctet4.TabIndex = 68;
            WildcradOctet4.TabStop = false;
            WildcradOctet4.Text = "0";
            WildcradOctet4.TextAlign = HorizontalAlignment.Center;
            // 
            // WildcradOctet3
            // 
            WildcradOctet3.BackColor = Color.White;
            WildcradOctet3.BorderStyle = BorderStyle.None;
            WildcradOctet3.Location = new Point(102, 4);
            WildcradOctet3.Name = "WildcradOctet3";
            WildcradOctet3.ReadOnly = true;
            WildcradOctet3.Size = new Size(39, 19);
            WildcradOctet3.TabIndex = 66;
            WildcradOctet3.TabStop = false;
            WildcradOctet3.Text = "0";
            WildcradOctet3.TextAlign = HorizontalAlignment.Center;
            // 
            // WildcradOctet2
            // 
            WildcradOctet2.BackColor = Color.White;
            WildcradOctet2.BorderStyle = BorderStyle.None;
            WildcradOctet2.Location = new Point(57, 4);
            WildcradOctet2.Name = "WildcradOctet2";
            WildcradOctet2.ReadOnly = true;
            WildcradOctet2.Size = new Size(39, 19);
            WildcradOctet2.TabIndex = 64;
            WildcradOctet2.TabStop = false;
            WildcradOctet2.Text = "0";
            WildcradOctet2.TextAlign = HorizontalAlignment.Center;
            // 
            // WildcradOctet1
            // 
            WildcradOctet1.BackColor = Color.White;
            WildcradOctet1.BorderStyle = BorderStyle.None;
            WildcradOctet1.Location = new Point(9, 4);
            WildcradOctet1.Name = "WildcradOctet1";
            WildcradOctet1.ReadOnly = true;
            WildcradOctet1.Size = new Size(39, 19);
            WildcradOctet1.TabIndex = 62;
            WildcradOctet1.TabStop = false;
            WildcradOctet1.Text = "0";
            WildcradOctet1.TextAlign = HorizontalAlignment.Center;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.ForeColor = Color.White;
            label14.Location = new Point(19, 139);
            label14.Name = "label14";
            label14.Size = new Size(112, 18);
            label14.TabIndex = 97;
            label14.Text = "Wildcard Mask";
            // 
            // MyWebView
            // 
            MyWebView.AllowExternalDrop = true;
            MyWebView.BackColor = Color.Gray;
            MyWebView.CreationProperties = null;
            MyWebView.DefaultBackgroundColor = Color.White;
            MyWebView.Dock = DockStyle.Fill;
            MyWebView.Location = new Point(0, 0);
            MyWebView.Name = "MyWebView";
            MyWebView.Size = new Size(811, 446);
            MyWebView.TabIndex = 101;
            MyWebView.ZoomFactor = 1D;
            // 
            // ExportButton
            // 
            ExportButton.BackColor = Color.Green;
            ExportButton.FlatStyle = FlatStyle.Popup;
            ExportButton.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ExportButton.ForeColor = Color.White;
            ExportButton.Location = new Point(615, 183);
            ExportButton.Name = "ExportButton";
            ExportButton.Size = new Size(203, 37);
            ExportButton.TabIndex = 102;
            ExportButton.Text = "Export Report";
            ExportButton.UseVisualStyleBackColor = false;
            ExportButton.Visible = false;
            ExportButton.Click += ExportButton_Click;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel4.BackColor = Color.White;
            panel4.Controls.Add(MyWebView);
            panel4.Location = new Point(12, 232);
            panel4.Name = "panel4";
            panel4.Size = new Size(811, 446);
            panel4.TabIndex = 103;
            // 
            // ReportForm
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            BackgroundImage = Properties.Resources.ipsubbg;
            ClientSize = new Size(834, 711);
            Controls.Add(panel4);
            Controls.Add(ExportButton);
            Controls.Add(panel3);
            Controls.Add(label14);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(IpPanel);
            Controls.Add(label4);
            Controls.Add(label35);
            Controls.Add(SubnetsText);
            Controls.Add(progressBar1);
            Controls.Add(label34);
            Controls.Add(HostsPerSubnetText);
            Controls.Add(StatusLabel);
            Controls.Add(label3);
            Controls.Add(BlockSizeText);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MinimumSize = new Size(850, 750);
            Name = "ReportForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "IP Subnet - Report";
            FormClosing += ReportForm_FormClosing;
            Load += ReportForm_Load;
            MouseDown += ReportForm_MouseDown;
            MouseMove += ReportForm_MouseMove;
            IpPanel.ResumeLayout(false);
            IpPanel.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)MyWebView).EndInit();
            panel4.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox BlockSizeText;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.TextBox HostsPerSubnetText;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.TextBox SubnetsText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel IpPanel;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox IpOctet4Text;
        private System.Windows.Forms.TextBox IpOctet3Text;
        private System.Windows.Forms.TextBox IpOctet2Text;
        private System.Windows.Forms.TextBox IpOctet1Text;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox DefaultOctet4;
        private System.Windows.Forms.TextBox DefaultOctet3;
        private System.Windows.Forms.TextBox DefaultOctet2;
        private System.Windows.Forms.TextBox DefaultOctet1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox SubnetOctet4;
        private System.Windows.Forms.TextBox SubnetOctet3;
        private System.Windows.Forms.TextBox SubnetOctet2;
        private System.Windows.Forms.TextBox SubnetOctet1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox WildcradOctet4;
        private System.Windows.Forms.TextBox WildcradOctet3;
        private System.Windows.Forms.TextBox WildcradOctet2;
        private System.Windows.Forms.TextBox WildcradOctet1;
        private System.Windows.Forms.Label label14;
        private Microsoft.Web.WebView2.WinForms.WebView2 MyWebView;
        private Button ExportButton;
        private Panel panel4;
    }
}