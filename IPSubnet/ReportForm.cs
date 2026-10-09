
using System.Diagnostics;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace IPSubnet
{
    public partial class ReportForm : Form
    {
        private IpAddressFormat IpAddress;
        private SubnetMaskFormat DefaultMask;
        private SubnetMaskFormat SubnetMask;
        private IpAddressFormat IPNetwork;
        private int NoOfSubnetBits = 0;
        private int NoOfSubnets = 0;
        private int HostsPerSubnet = 0;
        private string HtmlFilePath;
        private string baseFolder;
        private string MyAppPath;
        private bool ReportReady;
        private const string ReportSuccess = "Report displayed below";
        private System.Threading.Thread? loadingThread;
        private CancellationTokenSource? cts;

        public ReportForm(IpAddressFormat IpAddress, SubnetMaskFormat DefaultMask, SubnetMaskFormat SubnetMask)
        {
            InitializeComponent();
            this.IpAddress = IpAddress;
            this.SubnetMask = SubnetMask;
            this.DefaultMask = DefaultMask;
            ReportReady = false;
            TheCode = new StringBuilder();
            this.IPNetwork = new IpAddressFormat();
            baseFolder = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            MyAppPath = Path.Combine(baseFolder, "Downloads", "IPSubnet");
            try
            {
                if (!Directory.Exists(MyAppPath))
                {
                    Directory.CreateDirectory(MyAppPath);
                }
                HtmlFilePath = Path.Combine(MyAppPath, "subnets.html");
            }
            catch (Exception ex)
            {
                HtmlFilePath = "error";
                MessageBox.Show($"{ex.Message} ", "Error creating directory ", MessageBoxButtons.OK , MessageBoxIcon.Error);
            }
        }

        private string ManualFormat(long number, string separator = ",")
        {
            string input = number.ToString(); // Get the raw digits
                                              // Uses Regex to find groups of 3 digits from the right
            return Regex.Replace(input, @"(\d)(?=(\d{3})+(?!\d))", "$1" + separator);
        }

        private void DisplayFormDatas()
        {
            IpOctet1Text.Text = this.IPNetwork.Octet1.ToString();
            IpOctet2Text.Text = this.IPNetwork.Octet2.ToString();
            IpOctet3Text.Text = this.IPNetwork.Octet3.ToString();
            IpOctet4Text.Text = this.IPNetwork.Octet4.ToString();

            SubnetOctet1.Text = this.SubnetMask.Octet1.ToString();
            SubnetOctet2.Text = this.SubnetMask.Octet2.ToString();
            SubnetOctet3.Text = this.SubnetMask.Octet3.ToString();
            SubnetOctet4.Text = this.SubnetMask.Octet4.ToString();

            WildcradOctet1.Text = this.SubnetMask.WildcardOctet1.ToString();
            WildcradOctet2.Text = this.SubnetMask.WildcardOctet2.ToString();
            WildcradOctet3.Text = this.SubnetMask.WildcardOctet3.ToString();
            WildcradOctet4.Text = this.SubnetMask.WildcardOctet4.ToString();

            BlockSizeText.Text = ManualFormat(this.SubnetMask.BlockSize);
            int result = this.SubnetMask.BlockSize - 2;
            if (result < 0)
            {
                result = 0;
            }
            HostsPerSubnet = result;
            HostsPerSubnetText.Text = ManualFormat(HostsPerSubnet);
            //StatusLabel.Visible= false;
            NoOfSubnetBits = this.SubnetMask.Bits - this.IpAddress.ClassBits;
            if (NoOfSubnetBits < 0)
            {
                NoOfSubnetBits = 0;
            }
            NoOfSubnets = (int)Math.Pow(2, NoOfSubnetBits);
            if (NoOfSubnets == 1)
            {
                NoOfSubnets = 0;
            }
            progressBar1.Maximum = NoOfSubnets <= 0 ? 1 : NoOfSubnets;

            SubnetsText.Text = ManualFormat(NoOfSubnets);
        }

        public async void UpdateWebInterface()
        {
            await MyWebView.EnsureCoreWebView2Async();
            MyWebView.DefaultBackgroundColor = Color.White;
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {
            //System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = false;

            UpdateWebInterface();
            switch (IpAddress.Class)
            {
                case "A":
                    IPNetwork.Octet1 = this.IpAddress.Octet1 & this.SubnetMask.Octet1;
                    IPNetwork.Octet2 = 0;
                    IPNetwork.Octet3 = 0;
                    IPNetwork.Octet4 = 0;
                    DefaultOctet1.Text = DefaultMask.Octet1.ToString();
                    DefaultOctet2.Text = DefaultMask.Octet2.ToString();
                    DefaultOctet3.Text = DefaultMask.Octet3.ToString();
                    DefaultOctet4.Text = DefaultMask.Octet4.ToString();
                    DisplayFormDatas();
                    if (SubnetMask.BlockSize > 0)
                    {
                        cts = new CancellationTokenSource();
                        CancellationToken token = cts.Token;
                        var progress = new Progress<int>(value =>
                        {
                            progressBar1.Value = value;
                            if (value >= progressBar1.Maximum)
                            {
                                StatusLabel.Text = ReportSuccess;
                            }
                        });
                        Thread th1 = new Thread(() => LoadClassASubnets(IPNetwork, token, progress));
                        th1.IsBackground = true;
                        th1.Start();
                    }
                    else
                    {
                        StatusLabel.Text = "Block size too low, cannot process.";
                        MyWebView.Visible = false;
                    }
                    break;
                case "B":
                    IPNetwork.Octet1 = this.IpAddress.Octet1 & this.SubnetMask.Octet1;
                    IPNetwork.Octet2 = this.IpAddress.Octet2 & this.SubnetMask.Octet2;
                    IPNetwork.Octet3 = 0;
                    IPNetwork.Octet4 = 0;
                    DefaultOctet1.Text = DefaultMask.Octet1.ToString();
                    DefaultOctet2.Text = DefaultMask.Octet2.ToString();
                    DefaultOctet3.Text = DefaultMask.Octet3.ToString();
                    DefaultOctet4.Text = DefaultMask.Octet4.ToString();
                    DisplayFormDatas();
                    if (SubnetMask.BlockSize > 0)
                    {
                        cts = new CancellationTokenSource();
                        CancellationToken token = cts.Token;
                        var progress = new Progress<int>(value =>
                        {
                            progressBar1.Value = value;
                            if (value >= progressBar1.Maximum)
                            {
                                StatusLabel.Text = ReportSuccess;
                            }
                        });
                        Thread th1 = new Thread(() => LoadClassBSubnets(IPNetwork, token, progress));
                        th1.IsBackground = true;
                        th1.Start();
                    }
                    else
                    {
                        StatusLabel.Text = "Block size too low, cannot process.";
                        MyWebView.Visible = false;
                    }
                    break;
                case "C":
                    IPNetwork.Octet1 = this.IpAddress.Octet1 & this.SubnetMask.Octet1;
                    IPNetwork.Octet2 = this.IpAddress.Octet2 & this.SubnetMask.Octet2;
                    IPNetwork.Octet3 = this.IpAddress.Octet3 & this.SubnetMask.Octet3;
                    IPNetwork.Octet4 = 0;
                    DefaultOctet1.Text = DefaultMask.Octet1.ToString();
                    DefaultOctet2.Text = DefaultMask.Octet2.ToString();
                    DefaultOctet3.Text = DefaultMask.Octet3.ToString();
                    DefaultOctet4.Text = DefaultMask.Octet4.ToString();
                    DisplayFormDatas();
                    if (SubnetMask.BlockSize > 0)
                    {
                        cts = new CancellationTokenSource();
                        CancellationToken token = cts.Token;
                        var progress = new Progress<int>(value =>
                        {
                            progressBar1.Value = value;
                            if (value >= progressBar1.Maximum)
                            {
                                StatusLabel.Text = ReportSuccess;
                            }
                        });
                        Thread th1 = new Thread(() => LoadClassCSubnets(IPNetwork, token, progress));
                        th1.IsBackground = true;
                        th1.Start();
                    }
                    else
                    {
                        StatusLabel.Text = "Block size too low, cannot process.";
                        MyWebView.Visible = false;
                    }
                    break;
            }
        }

        StringBuilder TheCode;
        private void LoadHtmlToWebView()
        {
            LoadDynamicHtml(TheCode);
            MyWebView.Visible = true;
            ExportButton.Visible = true;
        }

        private async void LoadDynamicHtml(StringBuilder myHtmlContent)
        {
            // Important: WebView2 must be initialized before calling its methods
            // This code runs on the UI thread where webView21 lives
            await MyWebView.EnsureCoreWebView2Async();
            MyWebView.DefaultBackgroundColor = System.Drawing.Color.White;

            if (MyWebView.CoreWebView2 != null)
            {
                //MessageBox.Show(myHtmlContent.ToString());
                MyWebView.CoreWebView2.Navigate($"{HtmlFilePath}");
                //webView21.CoreWebView2.NavigateToString(myHtmlContent.ToString());
            }

            //webView21.CoreWebView2.NavigateToString(myHtmlContent.ToString());
        }

        private void LoadClassASubnets(IpAddressFormat IP, CancellationToken token, IProgress<int> progress)
        {
            IpAddressFormat FirstHost = new IpAddressFormat(IP.Octet1, IP.Octet2, IP.Octet3, IP.Octet4);
            IpAddressFormat LastHost = new IpAddressFormat(IP.Octet1, IP.Octet2, IP.Octet3, IP.Octet4);
            IpAddressFormat Broadcast = new IpAddressFormat(IP.Octet1, IP.Octet2, IP.Octet3, IP.Octet4);

            IpAddressFormat SubNetwork = new IpAddressFormat(IP.Octet1, IP.Octet2, IP.Octet3, IP.Octet4);

            if (SubnetMask.BlockSize > 1)
            {
                if (SubnetMask.InterestingByte == 2)
                {
                    int rowCount = 0;
                    StringBuilder htmlfile = new StringBuilder();
                    htmlfile.Append("<!DOCTYPE html>");
                    htmlfile.Append("<html>");
                    htmlfile.Append("<head><title>IP Subnet</title>");
                    htmlfile.Append("<style>body { background-color: white; color: black; font-family: Arial; font-size: 16px; display: grid; justify-content: center;}");
                    htmlfile.Append("table, th, td {border: 1px solid black;border-collapse: collapse;padding: 10px;}h3{text-align: center;}</style>");
                    htmlfile.Append("</head>");
                    htmlfile.Append("<body>");
                    htmlfile.Append("<h3>IP Subnet (Classfull subnetting), Developed by Suncoders </h3>");
                    htmlfile.Append("<table border=\"1\">");
                    htmlfile.Append($"<tr><td>Network Address</td><td>{IPNetwork}</td></tr>");
                    htmlfile.Append($"<tr><td>Default Mask</td><td>{DefaultMask}</td></tr>");
                    htmlfile.Append($"<tr><td>Subnet Mask</td><td>{SubnetMask}</td></tr>");
                    htmlfile.Append($"<tr><td>Wildcard Mask</td><td>{SubnetMask.ToWildcard()}</td></tr>");
                    htmlfile.Append($"<tr><td>Number of subnets</td><td>{ManualFormat(NoOfSubnets)}</td></tr>");
                    htmlfile.Append($"<tr><td>Hots per subnet</td><td>{ManualFormat(HostsPerSubnet)}</td></tr>");
                    htmlfile.Append("</table></br>");
                    htmlfile.Append("<table border=\"1\">");
                    htmlfile.Append("<tr><th>Subnet</th><th>Network Address</th><th>First Host IP Address</th><th>Last Host IP Address</th><th>Broadcast Address</th>");

                    while (SubNetwork.Octet2 < 255)
                    {
                        rowCount++;
                        if (token.IsCancellationRequested)
                        {
                            return;
                        }

                        progress.Report(rowCount);


                        FirstHost.Octet2 = SubNetwork.Octet2;
                        FirstHost.Octet3 = 0;
                        FirstHost.Octet4 = 1;

                        Broadcast.Octet2 = SubNetwork.Octet2 + (SubnetMask.MagicNumber - 1);
                        Broadcast.Octet3 = 255;
                        Broadcast.Octet4 = 255;

                        LastHost.Octet2 = Broadcast.Octet2;
                        LastHost.Octet3 = 255;
                        LastHost.Octet4 = 254;


                        if (Broadcast.Octet4 > 255)
                        {
                            continue;
                        }

                        htmlfile.Append("<tr><td>");
                        htmlfile.Append(rowCount.ToString());
                        htmlfile.Append("</td>");

                        htmlfile.Append("<td>");
                        htmlfile.Append(SubNetwork.ToString());
                        htmlfile.Append("</td>");

                        htmlfile.Append("<td>");
                        htmlfile.Append(FirstHost.ToString());
                        htmlfile.Append("</td>");

                        htmlfile.Append("<td>");
                        htmlfile.Append(LastHost.ToString());
                        htmlfile.Append("</td>");

                        htmlfile.Append("<td>");
                        htmlfile.Append(Broadcast.ToString());
                        htmlfile.Append("</td>");
                        htmlfile.Append("</tr>\r\n");

                        SubNetwork.Octet2 += SubnetMask.MagicNumber;
                    }
                    htmlfile.Append("</body>");
                    htmlfile.Append("</html>");
                    try
                    {
                        FileStream fs = new FileStream(HtmlFilePath, FileMode.Create);
                        StreamWriter stream = new StreamWriter(fs);
                        stream.Write(htmlfile);
                        stream.Close();
                        fs.Close();
                        TheCode = htmlfile;
                        this.Invoke(LoadHtmlToWebView);

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error while saving report", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                else if (SubnetMask.InterestingByte == 3)
                {
                    int secondOctet = 0;
                    int rowCount = 0;

                    StringBuilder htmlfile = new StringBuilder();
                    htmlfile.Append("<!DOCTYPE html>");
                    htmlfile.Append("<html>");
                    htmlfile.Append("<head><title>IP Subnet</title>");
                    htmlfile.Append("<style>body {background-color: white; color: black; font-family: Arial; font-size: 16px; display: grid; justify-content: center;}");
                    htmlfile.Append("table, th, td {border: 1px solid black;border-collapse: collapse;padding: 10px;}h3{text-align: center;}</style>");
                    htmlfile.Append("</head>");
                    htmlfile.Append("<body>");
                    htmlfile.Append("<h3>IP Subnet (Classfull subnetting), Developed by Suncoders </h3>");
                    htmlfile.Append("<table border=\"1\">");
                    htmlfile.Append($"<tr><td>Network Address</td><td>{IPNetwork}</td></tr>");
                    htmlfile.Append($"<tr><td>Default Mask</td><td>{DefaultMask}</td></tr>");
                    htmlfile.Append($"<tr><td>Subnet Mask</td><td>{SubnetMask}</td></tr>");
                    htmlfile.Append($"<tr><td>Wildcard Mask</td><td>{SubnetMask.ToWildcard()}</td></tr>");
                    htmlfile.Append($"<tr><td>Number of subnets</td><td>{ManualFormat(NoOfSubnets)}</td></tr>");
                    htmlfile.Append($"<tr><td>Hots per subnet</td><td>{ManualFormat(HostsPerSubnet)}</td></tr>");
                    htmlfile.Append("</table></br>");
                    htmlfile.Append("<table border=\"1\">");
                    htmlfile.Append("<tr><th>Subnet</th><th>Network Address</th><th>First Host IP Address</th><th>Last Host IP Address</th><th>Broadcast Address</th>");
                    while (secondOctet <= 255)
                    {
                        SubNetwork.Octet2 = secondOctet;
                        SubNetwork.Octet3 = 0;
                        while (SubNetwork.Octet3 < 255)
                        {
                            rowCount++;
                            if (token.IsCancellationRequested)
                            {
                                return;
                            }
                            progress.Report(rowCount);
                            FirstHost.Octet2 = SubNetwork.Octet2;
                            FirstHost.Octet3 = SubNetwork.Octet3;
                            FirstHost.Octet4 = 1;

                            Broadcast.Octet2 = SubNetwork.Octet2;
                            Broadcast.Octet3 = SubNetwork.Octet3 + (SubnetMask.MagicNumber - 1);
                            Broadcast.Octet4 = 255;

                            LastHost.Octet2 = Broadcast.Octet2;
                            LastHost.Octet3 = Broadcast.Octet3;
                            LastHost.Octet4 = Broadcast.Octet4 - 1;


                            if (Broadcast.Octet4 > 255)
                            {
                                continue;
                            }

                            htmlfile.Append("<tr><td>");
                            htmlfile.Append(rowCount.ToString());
                            htmlfile.Append("</td>");

                            htmlfile.Append("<td>");
                            htmlfile.Append(SubNetwork.ToString());
                            htmlfile.Append("</td>");

                            htmlfile.Append("<td>");
                            htmlfile.Append(FirstHost.ToString());
                            htmlfile.Append("</td>");

                            htmlfile.Append("<td>");
                            htmlfile.Append(LastHost.ToString());
                            htmlfile.Append("</td>");

                            htmlfile.Append("<td>");
                            htmlfile.Append(Broadcast.ToString());
                            htmlfile.Append("</td>");
                            htmlfile.Append("</tr>\r\n");

                            SubNetwork.Octet3 += SubnetMask.MagicNumber;
                        }
                        secondOctet++;
                    }

                    htmlfile.Append("</body>");
                    htmlfile.Append("</html>");
                    try
                    {
                        FileStream fs = new FileStream(HtmlFilePath, FileMode.Create);
                        StreamWriter stream = new StreamWriter(fs);
                        stream.Write(htmlfile);
                        stream.Close();
                        fs.Close();
                        TheCode = htmlfile;
                        this.Invoke(LoadHtmlToWebView);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error while saving report", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (SubnetMask.InterestingByte == 4)
                {
                    int secondOctet = 0;
                    int thirdOctet = 0;
                    int rowCount = 0;
                    bool logged = false;
                    int remainingSubnets = 0;

                    StringBuilder htmlfile = new StringBuilder();
                    htmlfile.Append("<!DOCTYPE html>");
                    htmlfile.Append("<html>");
                    htmlfile.Append("<head><title>IP Subnet</title>");
                    htmlfile.Append("<style>body {background-color: white; color: black; font-family: Arial; font-size: 16px; display: grid; justify-content: center;}");
                    htmlfile.Append("table, th, td {border: 1px solid black;border-collapse: collapse;padding: 10px;}h3{text-align: center;}</style>");
                    htmlfile.Append("</head>");
                    htmlfile.Append("<body>");
                    htmlfile.Append("<h3>IP Subnet (Classfull subnetting), Developed by Suncoders </h3>");
                    htmlfile.Append("<table border=\"1\">");
                    htmlfile.Append($"<tr><td>Network Address</td><td>{IPNetwork}</td></tr>");
                    htmlfile.Append($"<tr><td>Default Mask</td><td>{DefaultMask}</td></tr>");
                    htmlfile.Append($"<tr><td>Subnet Mask</td><td>{SubnetMask}</td></tr>");
                    htmlfile.Append($"<tr><td>Wildcard Mask</td><td>{SubnetMask.ToWildcard()}</td></tr>");
                    htmlfile.Append($"<tr><td>Number of subnets</td><td>{ManualFormat(NoOfSubnets)}</td></tr>");
                    htmlfile.Append($"<tr><td>Hots per subnet</td><td>{ManualFormat(HostsPerSubnet)}</td></tr>");
                    htmlfile.Append("</table></br>");
                    htmlfile.Append("<table border=\"1\">");
                    htmlfile.Append("<tr><th>Subnet</th><th>Network Address</th><th>First Host IP Address</th><th>Last Host IP Address</th><th>Broadcast Address</th>");
                    while (secondOctet <= 255)
                    {
                        thirdOctet = 0;
                        while (thirdOctet <= 255)
                        {
                            SubNetwork.Octet2 = secondOctet;
                            SubNetwork.Octet3 = thirdOctet;
                            SubNetwork.Octet4 = 0;
                            while (SubNetwork.Octet4 < 255)
                            {
                                rowCount++;
                                if (token.IsCancellationRequested)
                                {
                                    return;
                                }
                                progress.Report(rowCount);
                                remainingSubnets = NoOfSubnets - rowCount;
                                FirstHost.Octet2 = SubNetwork.Octet2;
                                FirstHost.Octet3 = SubNetwork.Octet3;
                                FirstHost.Octet4 = 1;

                                Broadcast.Octet2 = SubNetwork.Octet2;
                                Broadcast.Octet3 = SubNetwork.Octet3;
                                Broadcast.Octet4 = SubNetwork.Octet4 + (SubnetMask.MagicNumber - 1);

                                LastHost.Octet2 = Broadcast.Octet2;
                                LastHost.Octet3 = Broadcast.Octet3;
                                LastHost.Octet4 = Broadcast.Octet4 - 1;


                                if (Broadcast.Octet4 > 255)
                                {
                                    continue;
                                }

                                if (rowCount <= 65536)
                                {
                                    htmlfile.Append("<tr><td>");
                                    htmlfile.Append(rowCount.ToString());
                                    htmlfile.Append("</td>");

                                    htmlfile.Append("<td>");
                                    htmlfile.Append(SubNetwork.ToString());
                                    htmlfile.Append("</td>");

                                    htmlfile.Append("<td>");
                                    htmlfile.Append(FirstHost.ToString());
                                    htmlfile.Append("</td>");

                                    htmlfile.Append("<td>");
                                    htmlfile.Append(LastHost.ToString());
                                    htmlfile.Append("</td>");

                                    htmlfile.Append("<td>");
                                    htmlfile.Append(Broadcast.ToString());
                                    htmlfile.Append("</td>");
                                    htmlfile.Append("</tr>\r\n");
                                }
                                else
                                {
                                    if (!logged)
                                    {
                                        htmlfile.Append("<tr><td>***</td><td>---</td><td>Skipping some</td><td>---</td><td>***</td></tr>");
                                        htmlfile.Append("<tr><td>***</td><td>---</td><td>Skipping some</td><td>---</td><td>***</td></tr>");
                                        htmlfile.Append("<tr><td>***</td><td>---</td><td>Skipping some</td><td>---</td><td>***</td></tr>");
                                        logged = true;
                                    }
                                    else
                                    {
                                        if (remainingSubnets < 100)
                                        {
                                            htmlfile.Append("<tr><td>");
                                            htmlfile.Append(rowCount.ToString());
                                            htmlfile.Append("</td>");

                                            htmlfile.Append("<td>");
                                            htmlfile.Append(SubNetwork.ToString());
                                            htmlfile.Append("</td>");

                                            htmlfile.Append("<td>");
                                            htmlfile.Append(FirstHost.ToString());
                                            htmlfile.Append("</td>");

                                            htmlfile.Append("<td>");
                                            htmlfile.Append(LastHost.ToString());
                                            htmlfile.Append("</td>");

                                            htmlfile.Append("<td>");
                                            htmlfile.Append(Broadcast.ToString());
                                            htmlfile.Append("</td>");
                                            htmlfile.Append("</tr>\r\n");
                                        }
                                    }
                                }
                                SubNetwork.Octet4 += SubnetMask.MagicNumber;
                            }
                            thirdOctet++;
                        }
                        secondOctet++;
                    }

                    htmlfile.Append("</body>");
                    htmlfile.Append("</html>");
                    try
                    {
                        FileStream fs = new FileStream(HtmlFilePath, FileMode.Create);
                        StreamWriter stream = new StreamWriter(fs);
                        stream.Write(htmlfile);
                        stream.Close();
                        fs.Close();
                        TheCode = htmlfile;
                        this.Invoke(LoadHtmlToWebView);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error while saving report", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            ReportReady = true;
        }

        private void LoadClassBSubnets(IpAddressFormat IP, CancellationToken token, IProgress<int> progress)
        {

            IpAddressFormat FirstHost = new IpAddressFormat(IP.Octet1, IP.Octet2, IP.Octet3, IP.Octet4);
            IpAddressFormat LastHost = new IpAddressFormat(IP.Octet1, IP.Octet2, IP.Octet3, IP.Octet4);
            IpAddressFormat Broadcast = new IpAddressFormat(IP.Octet1, IP.Octet2, IP.Octet3, IP.Octet4);

            IpAddressFormat SubNetwork = new IpAddressFormat(IP.Octet1, IP.Octet2, IP.Octet3, IP.Octet4);
            if (SubnetMask.BlockSize > 1)
            {
                if (SubnetMask.InterestingByte == 3)
                {
                    int rowCount = 0;
                    StringBuilder htmlfile = new StringBuilder();
                    htmlfile.Append("<!DOCTYPE html>");
                    htmlfile.Append("<html>");
                    htmlfile.Append("<head><title>IP Subnet</title>");
                    htmlfile.Append("<style>body {background-color: white; color: black; font-family: Arial; font-size: 16px; display: grid; justify-content: center;}");
                    htmlfile.Append("table, th, td {border: 1px solid black;border-collapse: collapse;padding: 10px;}h3{text-align: center;}</style>");
                    htmlfile.Append("</head>");
                    htmlfile.Append("<body>");
                    htmlfile.Append("<h3>IP Subnet (Classfull subnetting), Developed by Suncoders </h3>");
                    htmlfile.Append("<table border=\"1\">");
                    htmlfile.Append($"<tr><td>Network Address</td><td>{IPNetwork}</td></tr>");
                    htmlfile.Append($"<tr><td>Default Mask</td><td>{DefaultMask}</td></tr>");
                    htmlfile.Append($"<tr><td>Subnet Mask</td><td>{SubnetMask}</td></tr>");
                    htmlfile.Append($"<tr><td>Wildcard Mask</td><td>{SubnetMask.ToWildcard()}</td></tr>");
                    htmlfile.Append($"<tr><td>Number of subnets</td><td>{ManualFormat(NoOfSubnets)}</td></tr>");
                    htmlfile.Append($"<tr><td>Hots per subnet</td><td>{ManualFormat(HostsPerSubnet)}</td></tr>");
                    htmlfile.Append("</table></br>");
                    htmlfile.Append("<table border=\"1\">");
                    htmlfile.Append("<tr><th>Subnet</th><th>Network Address</th><th>First Host IP Address</th><th>Last Host IP Address</th><th>Broadcast Address</th>");

                    while (SubNetwork.Octet3 < 255)
                    {
                        rowCount++;
                        if (token.IsCancellationRequested)
                        {
                            return;
                        }
                        progress.Report(rowCount);
                        FirstHost.Octet3 = SubNetwork.Octet3;
                        FirstHost.Octet4 = 1;


                        Broadcast.Octet3 = SubNetwork.Octet3 + (SubnetMask.MagicNumber - 1);
                        Broadcast.Octet4 = 255;

                        LastHost.Octet3 = Broadcast.Octet3;
                        LastHost.Octet4 = 254;



                        if (Broadcast.Octet4 > 255)
                        {
                            continue;
                        }

                        htmlfile.Append("<tr><td>");
                        htmlfile.Append(rowCount.ToString());
                        htmlfile.Append("</td>");

                        htmlfile.Append("<td>");
                        htmlfile.Append(SubNetwork.ToString());
                        htmlfile.Append("</td>");

                        htmlfile.Append("<td>");
                        htmlfile.Append(FirstHost.ToString());
                        htmlfile.Append("</td>");

                        htmlfile.Append("<td>");
                        htmlfile.Append(LastHost.ToString());
                        htmlfile.Append("</td>");

                        htmlfile.Append("<td>");
                        htmlfile.Append(Broadcast.ToString());
                        htmlfile.Append("</td>");
                        htmlfile.Append("</tr>\r\n");
                        SubNetwork.Octet3 += SubnetMask.MagicNumber;
                    }
                    htmlfile.Append("</body>");
                    htmlfile.Append("</html>");
                    try
                    {
                        FileStream fs = new FileStream(HtmlFilePath, FileMode.Create);
                        StreamWriter stream = new StreamWriter(fs);
                        stream.Write(htmlfile);
                        stream.Close();
                        fs.Close();
                        TheCode = htmlfile;
                        this.Invoke(LoadHtmlToWebView);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error while saving report", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (SubnetMask.InterestingByte == 4)
                {
                    int rowCount = 0;
                    int x = 0;

                    StringBuilder htmlfile = new StringBuilder();
                    htmlfile.Append("<!DOCTYPE html>");
                    htmlfile.Append("<html>");
                    htmlfile.Append("<head><title>IP Subnet</title>");
                    htmlfile.Append("<style>body {background-color: white; color: black; font-family: Arial; font-size: 16px; display: grid; justify-content: center;}");
                    htmlfile.Append("table, th, td {border: 1px solid black;border-collapse: collapse;padding: 10px;}h3{text-align: center;}</style>");
                    htmlfile.Append("</head>");
                    htmlfile.Append("<body>");
                    htmlfile.Append("<h3>IP Subnet (Classfull subnetting), Developed by Suncoders </h3>");
                    htmlfile.Append("<table border=\"1\">");
                    htmlfile.Append($"<tr><td>Network Address</td><td>{IPNetwork}</td></tr>");
                    htmlfile.Append($"<tr><td>Default Mask</td><td>{DefaultMask}</td></tr>");
                    htmlfile.Append($"<tr><td>Subnet Mask</td><td>{SubnetMask}</td></tr>");
                    htmlfile.Append($"<tr><td>Wildcard Mask</td><td>{SubnetMask.ToWildcard()}</td></tr>");
                    htmlfile.Append($"<tr><td>Number of subnets</td><td>{ManualFormat(NoOfSubnets)}</td></tr>");
                    htmlfile.Append($"<tr><td>Hots per subnet</td><td>{ManualFormat(HostsPerSubnet)}</td></tr>");
                    htmlfile.Append("</table></br>");
                    htmlfile.Append("<table border=\"1\">");
                    htmlfile.Append("<tr><th>Subnet</th><th>Network Address</th><th>First Host IP Address</th><th>Last Host IP Address</th><th>Broadcast Address</th>");
                    while (x <= 255)
                    {
                        SubNetwork.Octet3 = x;
                        SubNetwork.Octet4 = 0;

                        while (SubNetwork.Octet4 < 255)
                        {
                            rowCount++;
                            if (token.IsCancellationRequested)
                            {
                                return;
                            }
                            progress.Report(rowCount);
                            FirstHost.Octet3 = SubNetwork.Octet3;
                            FirstHost.Octet4 = SubNetwork.Octet4 + 1;

                            Broadcast.Octet3 = SubNetwork.Octet3;
                            Broadcast.Octet4 = SubNetwork.Octet4 + (SubnetMask.MagicNumber - 1);

                            LastHost.Octet3 = SubNetwork.Octet3;
                            LastHost.Octet4 = Broadcast.Octet4 - 1;
                            if (Broadcast.Octet4 > 255)
                            {
                                continue;
                            }
                            htmlfile.Append("<tr><td>");
                            htmlfile.Append(rowCount.ToString());
                            htmlfile.Append("</td>");

                            htmlfile.Append("<td>");
                            htmlfile.Append(SubNetwork.ToString());
                            htmlfile.Append("</td>");
                            if (SubnetMask.BlockSize > 2)
                            {
                                htmlfile.Append("<td>");
                                htmlfile.Append(FirstHost.ToString());
                                htmlfile.Append("</td>");
                                htmlfile.Append("<td>");
                                htmlfile.Append(LastHost.ToString());
                                htmlfile.Append("</td>");
                            }
                            else
                            {
                                htmlfile.Append("<td>");
                                htmlfile.Append("N/A");
                                htmlfile.Append("</td>");
                                htmlfile.Append("<td>");
                                htmlfile.Append("N/A");
                                htmlfile.Append("</td>");
                            }
                            htmlfile.Append("<td>");
                            htmlfile.Append(Broadcast.ToString());
                            htmlfile.Append("</td>");
                            htmlfile.Append("</tr>\r\n");
                            SubNetwork.Octet4 += SubnetMask.MagicNumber;
                        }
                        x++;
                    }
                    htmlfile.Append("</body>");
                    htmlfile.Append("</html>");
                    try
                    {
                        FileStream fs = new FileStream(HtmlFilePath, FileMode.Create);
                        StreamWriter stream = new StreamWriter(fs);
                        stream.Write(htmlfile);
                        stream.Close();
                        fs.Close();
                        TheCode = htmlfile;
                        this.Invoke(LoadHtmlToWebView);

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error while saving report", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            ReportReady = true;
        }

        private void LoadClassCSubnets(IpAddressFormat IP, CancellationToken token, IProgress<int> progress)
        {
            IpAddressFormat FirstHost = new IpAddressFormat(IP.Octet1, IP.Octet2, IP.Octet3, IP.Octet4);
            IpAddressFormat LastsHost = new IpAddressFormat(IP.Octet1, IP.Octet2, IP.Octet3, IP.Octet4);
            IpAddressFormat Broadcast = new IpAddressFormat(IP.Octet1, IP.Octet2, IP.Octet3, IP.Octet4);
            IpAddressFormat SubNetwork = new IpAddressFormat(IP.Octet1, IP.Octet2, IP.Octet3, IP.Octet4);

            if (SubnetMask.BlockSize > 1)
            {
                int rowCount = 0;

                StringBuilder htmlfile = new StringBuilder();
                htmlfile.Append("<!DOCTYPE html>");
                htmlfile.Append("<html>");
                htmlfile.Append("<head><title>IP Subnet</title>");
                htmlfile.Append("<style>body {background-color: white; color: black; font-family: Arial; font-size: 16px; display: grid; justify-content: center;}");
                htmlfile.Append("table, th, td {border: 1px solid black;border-collapse: collapse;padding: 10px;}h3{text-align: center;}</style>");
                htmlfile.Append("</head>");
                htmlfile.Append("<body>");
                htmlfile.Append("<h3>IP Subnet (Classfull subnetting), Developed by Suncoders </h3>");
                htmlfile.Append("<table border=\"1\">");
                htmlfile.Append($"<tr><td>Network Address</td><td>{IPNetwork}</td></tr>");
                htmlfile.Append($"<tr><td>Default Mask</td><td>{DefaultMask}</td></tr>");
                htmlfile.Append($"<tr><td>Subnet Mask</td><td>{SubnetMask}</td></tr>");
                htmlfile.Append($"<tr><td>Wildcard Mask</td><td>{SubnetMask.ToWildcard()}</td></tr>");
                htmlfile.Append($"<tr><td>Number of subnets</td><td>{ManualFormat(NoOfSubnets)}</td></tr>");
                htmlfile.Append($"<tr><td>Hots per subnet</td><td>{ManualFormat(HostsPerSubnet)}</td></tr>");
                htmlfile.Append("</table></br>");
                htmlfile.Append("<table border=\"1\">");
                htmlfile.Append("<tr><th>Subnet</th><th>Network Address</th><th>First Host IP Address</th><th>Last Host IP Address</th><th>Broadcast Address</th>");

                while (SubNetwork.Octet4 < 255)
                {
                    rowCount++;
                    if (token.IsCancellationRequested)
                    {
                        return;
                    }
                    progress.Report(rowCount);
                    FirstHost.Octet4 = SubNetwork.Octet4 + 1;
                    Broadcast.Octet4 = SubNetwork.Octet4 + (SubnetMask.BlockSize - 1);
                    LastsHost.Octet4 = Broadcast.Octet4 - 1;

                    if (Broadcast.Octet4 > 255)
                    {
                        continue;
                    }

                    htmlfile.Append("<tr><td>");
                    htmlfile.Append(rowCount.ToString());
                    htmlfile.Append("</td>");

                    htmlfile.Append("<td>");
                    htmlfile.Append(SubNetwork.ToString());
                    htmlfile.Append("</td>");

                    if (SubnetMask.BlockSize > 2)
                    {
                        htmlfile.Append("<td>");
                        htmlfile.Append(FirstHost.ToString());
                        htmlfile.Append("</td>");
                        htmlfile.Append("<td>");
                        htmlfile.Append(LastsHost.ToString());
                        htmlfile.Append("</td>");
                    }
                    else
                    {
                        htmlfile.Append("<td>N/A</td>");
                        htmlfile.Append("<td>N/A</td>");
                    }
                    htmlfile.Append("<td>");
                    htmlfile.Append(Broadcast.ToString());
                    htmlfile.Append("</td>");
                    htmlfile.Append("</tr>\r\n");

                    SubNetwork.Octet4 += SubnetMask.BlockSize;
                }
                htmlfile.Append("</body>");
                htmlfile.Append("</html>");
                try
                {
                    FileStream fs = new FileStream(HtmlFilePath, FileMode.Create);
                    StreamWriter stream = new StreamWriter(fs);
                    stream.Write(htmlfile);
                    stream.Close();
                    fs.Close();
                    TheCode = htmlfile;
                    this.Invoke(LoadHtmlToWebView);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error while saving report", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            ReportReady = true;
        }


        private void ReportForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (cts != null)
            {
                cts.Cancel();
                cts.Dispose();
                cts = null;
            }
        }


        private void ReportLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                Process p = new Process();
                p.StartInfo = new ProcessStartInfo(HtmlFilePath)
                {
                    UseShellExecute = true
                };
                p.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error opening repot file", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void StatusLabel_Click(object sender, EventArgs e)
        {
            if (ReportReady)
            {


                //try
                //{
                //    if (File.Exists(HtmlFilePath))
                //    {
                //        Process p = new Process
                //        {
                //            StartInfo = new ProcessStartInfo(HtmlFilePath)
                //            {
                //                UseShellExecute = true
                //            }
                //        };
                //        p.Start();
                //    }
                //    else
                //    {
                //        MessageBox.Show($"File does not exist", $"Path = {HtmlFilePath}", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //    }
                //}
                //catch (Exception ex)
                //{
                //    MessageBox.Show($" {ex.Message}", "Opening link failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //}
            }
        }

        Point lastPoint;

        private void ReportForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
                return;
            if (e.Button == MouseButtons.Left)
            {
                this.Left += (e.X - lastPoint.X);
                this.Top += (e.Y - lastPoint.Y);
            }
        }

        private void ReportForm_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private async void ExportButton_Click(object sender, EventArgs e)
        {
            string rawJson = await MyWebView.CoreWebView2.ExecuteScriptAsync("document.documentElement.outerHTML");

            // Decode the JSON-encoded string returned by ExecuteScriptAsync
            string tmp = "<!DOCTYPE html>";
            string? finalHtml = tmp + System.Text.Json.JsonSerializer.Deserialize<string>(rawJson);
            if(finalHtml != null)
            {
                using (SaveFileDialog sfd = new SaveFileDialog())
                {
                    sfd.FileName = "Subnets.html";
                    sfd.Filter = "HTML Files|*.html";
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        System.IO.File.WriteAllText(sfd.FileName, finalHtml);
                        //MessageBox.Show("Report saved successfully", "Report exported", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                MessageBox.Show("HTML code was null", "Could not save", MessageBoxButtons.OK , MessageBoxIcon.Error);
            }
        }
    }
}
