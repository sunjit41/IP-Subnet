using Microsoft.Win32;
using System.Text.RegularExpressions;

namespace IPSubnet
{
    public partial class ClassFull : Form
    {
        private SubnetMaskFormat subnetMask1;
        private SubnetMaskFormat defaultMask;
        private IpAddressFormat ipAddress;
        private int HeadingOffset = 65;

        private bool IpMinimized = false;
        private bool MaskMinimized = false;
        private bool SubnetMinimized = false;

        private const string userRoot = "HKEY_CURRENT_USER";
        private const string subKey = "SOFTWARE\\Suncoders\\IPSubnet";
        private string keyName = $"{userRoot}\\{subKey}";

        public ClassFull()
        {
            InitializeComponent();
            double factor = (double)this.DeviceDpi / 96.0;

            HeadingOffset = (int)(60 * 1.0);
            subnetMask1 = new SubnetMaskFormat();
            defaultMask = new SubnetMaskFormat();
            ipAddress = new IpAddressFormat();
        }

        private string ManualFormat(double number, string separator = ",")
        {
            string input = number.ToString(); // Get the raw digits
                                              // Uses Regex to find groups of 3 digits from the right
            return Regex.Replace(input, @"(\d)(?=(\d{3})+(?!\d))", "$1" + separator);
        }

        private void DisplayDefaultMask(int bits)
        {
            switch (bits)
            {
                case 0:
                    DefaultOctect1.Text = "0";
                    DefaultOctect2.Text = "0";
                    DefaultOctect3.Text = "0";
                    DefaultOctect4.Text = "0";
                    defaultMask.Octet1 = 0;
                    defaultMask.Octet2 = 0;
                    defaultMask.Octet3 = 0;
                    defaultMask.Octet4 = 0;
                    break;
                case 8:
                    DefaultOctect1.Text = "255";
                    DefaultOctect2.Text = "0";
                    DefaultOctect3.Text = "0";
                    DefaultOctect4.Text = "0";
                    defaultMask.Octet1 = 255;
                    defaultMask.Octet2 = 0;
                    defaultMask.Octet3 = 0;
                    defaultMask.Octet4 = 0;
                    break;
                case 16:
                    DefaultOctect1.Text = "255";
                    DefaultOctect2.Text = "255";
                    DefaultOctect3.Text = "0";
                    DefaultOctect4.Text = "0";
                    defaultMask.Octet1 = 255;
                    defaultMask.Octet2 = 255;
                    defaultMask.Octet3 = 0;
                    defaultMask.Octet4 = 0;
                    break;
                case 24:
                    DefaultOctect1.Text = "255";
                    DefaultOctect2.Text = "255";
                    DefaultOctect3.Text = "255";
                    DefaultOctect4.Text = "0";
                    defaultMask.Octet1 = 255;
                    defaultMask.Octet2 = 255;
                    defaultMask.Octet3 = 255;
                    defaultMask.Octet4 = 0;
                    break;
            }
        }

        private void DisplayClassAndType()
        {
            string IpClass = "";
            string IpType = "";
            if (ipAddress.Octet1 > 0 && ipAddress.Octet1 < 127)
            {
                IpClass = "A";
                ipAddress.Class = IpClass;
                ipAddress.ClassBits = 8;
                SubnetTrackBar.Value = 8;
                DisplayDefaultMask(ipAddress.ClassBits);
                if (ipAddress.Octet1 == 10)
                {
                    IpType = "Private";
                }
                else
                {
                    IpType = "Public";
                }
            }
            else if (ipAddress.Octet1 == 127)
            {
                IpClass = "A";
                ipAddress.Class = IpClass;
                ipAddress.ClassBits = 8;
                SubnetTrackBar.Value = 8;
                DisplayDefaultMask(ipAddress.ClassBits);
                IpType = "Loopback";
            }
            else if (ipAddress.Octet1 >= 128 && ipAddress.Octet1 <= 191)
            {
                IpClass = "B";
                ipAddress.Class = IpClass;
                ipAddress.ClassBits = 16;
                SubnetTrackBar.Value = 16;
                DisplayDefaultMask(ipAddress.ClassBits);
                if (ipAddress.Octet1 == 172 && ipAddress.Octet2 == 16)
                {
                    IpType = "Private";
                }
                else
                {
                    IpType = "Public";
                }
            }
            else if (ipAddress.Octet1 >= 192 && ipAddress.Octet1 <= 223)
            {
                IpClass = "C";
                ipAddress.Class = IpClass;
                ipAddress.ClassBits = 24;
                SubnetTrackBar.Value = 24;
                DisplayDefaultMask(ipAddress.ClassBits);
                if (ipAddress.Octet1 == 192 && ipAddress.Octet2 == 168)
                {
                    IpType = "Private";
                }
                else
                {
                    IpType = "Public";
                }
            }
            else
            {
                IpClass = "";
                ipAddress.Class = IpClass;
                ipAddress.ClassBits = 0;
                DisplayDefaultMask(ipAddress.ClassBits);
                SubnetTrackBar.Value = 0;
                IpType = "";
            }

            IpClassText.Text = IpClass;
            IpTypeText.Text = IpType;
        }

        private void IP1Text_TextChanged(object sender, EventArgs e)
        {
            int value = 0;
            if (int.TryParse(IP1Text.Text, out value))
            {
                if (value <= 0)
                {
                    int newValue = 1;
                    IP1Text.Text = "1";
                    Byte1Label.Text = IP1Text.Text;
                    ipAddress.Octet1 = newValue;
                    Byte1Text.Text = ipAddress.Octet1Binary;
                    SubIP1Text.Text = newValue.ToString();
                    DisplayClassAndType();
                    MessageBox.Show($"{value} is not a valid entry. \nThe value should be between 1 and 223", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                if (value > 223)
                {
                    int newValue = 223;
                    IP1Text.Text = "223";
                    Byte1Label.Text = IP1Text.Text;
                    ipAddress.Octet1 = newValue;
                    Byte1Text.Text = ipAddress.Octet1Binary;
                    SubIP1Text.Text = newValue.ToString();
                    DisplayClassAndType();
                    MessageBox.Show($"{value} is not a valid entry. \nThe value should be between 1 and 223", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                Byte1Label.Text = IP1Text.Text;
                ipAddress.Octet1 = value;
                Byte1Text.Text = ipAddress.Octet1Binary;
                SubIP1Text.Text = value.ToString();
                DisplayClassAndType();
            }
            else
            {
                Byte1Label.Text = IP1Text.Text;
                ipAddress.Octet1 = value;
                Byte1Text.Text = ipAddress.Octet1Binary;
                SubIP1Text.Text = value.ToString();
                DisplayClassAndType();
            }
            if (IP1Text.Text.Length == 3)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void IP1Text_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.')
            {
                e.Handled = true;
                if (IP1Text.Text.Length > 0)
                {
                    SendKeys.Send("{TAB}");
                }
            }
        }

        private void IP2Text_TextChanged(object sender, EventArgs e)
        {
            int value = 0;
            if (int.TryParse(IP2Text.Text, out value))
            {
                if (value < 0)
                {
                    int newValue = 0;
                    IP2Text.Text = "0";
                    Byte2Label.Text = IP2Text.Text;
                    ipAddress.Octet2 = newValue;
                    Byte2Text.Text = ipAddress.Octet2Binary;
                    SubIP2Text.Text = newValue.ToString();
                    DisplayClassAndType();
                    MessageBox.Show($"{value} is not a valid entry. \nThe value should be between 0 and 255", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                if (value > 255)
                {
                    int newValue = 255;
                    IP2Text.Text = "255";
                    Byte2Label.Text = IP2Text.Text;
                    ipAddress.Octet2 = newValue;
                    Byte2Text.Text = ipAddress.Octet2Binary;
                    SubIP2Text.Text = newValue.ToString();
                    DisplayClassAndType();
                    MessageBox.Show($"{value} is not a valid entry. \nThe value should be between 0 and 255", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                Byte2Label.Text = IP2Text.Text;
                ipAddress.Octet2 = value;
                Byte2Text.Text = ipAddress.Octet2Binary;
                SubIP2Text.Text = value.ToString();
                DisplayClassAndType();
            }
            else
            {
                Byte2Label.Text = IP2Text.Text;
                ipAddress.Octet2 = value;
                Byte2Text.Text = ipAddress.Octet2Binary;
                SubIP2Text.Text = value.ToString();
                DisplayClassAndType();
            }
            if (IP2Text.Text.Length == 3)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void IP2Text_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.')
            {
                e.Handled = true;
                if (IP2Text.Text.Length > 0)
                {
                    SendKeys.Send("{TAB}");
                }

            }
        }

        private void IP3Text_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.')
            {
                e.Handled = true;
                if (IP3Text.Text.Length > 0)
                {
                    SendKeys.Send("{TAB}");
                }
            }
        }

        private void IP4Text_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void IP3Text_TextChanged(object sender, EventArgs e)
        {
            int value = 0;
            if (int.TryParse(IP3Text.Text, out value))
            {
                if (value < 0)
                {
                    int newValue = 0;
                    IP3Text.Text = "0";
                    Byte3Label.Text = IP3Text.Text;
                    ipAddress.Octet3 = newValue;
                    Byte3Text.Text = ipAddress.Octet3Binary;
                    SubIP3Text.Text = newValue.ToString();
                    MessageBox.Show($"{value} is not a valid entry. \nThe value should be between 0 and 255", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                if (value > 255)
                {
                    int newValue = 255;
                    IP3Text.Text = "255";
                    Byte3Label.Text = IP3Text.Text;
                    ipAddress.Octet3 = newValue;
                    Byte3Text.Text = ipAddress.Octet3Binary;
                    SubIP3Text.Text = newValue.ToString();
                    MessageBox.Show($"{value} is not a valid entry. \nThe value should be between 0 and 255", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                Byte3Label.Text = IP3Text.Text;
                ipAddress.Octet3 = value;
                Byte3Text.Text = ipAddress.Octet3Binary;
                SubIP3Text.Text = value.ToString();
            }
            else
            {
                Byte3Label.Text = IP3Text.Text;
                ipAddress.Octet3 = value;
                Byte3Text.Text = ipAddress.Octet3Binary;
                SubIP3Text.Text = value.ToString();
            }
            if (IP3Text.Text.Length == 3)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void IP4Text_TextChanged(object sender, EventArgs e)
        {
            int value = 0;
            if (int.TryParse(IP4Text.Text, out value))
            {
                if (value < 0)
                {
                    int newValue = 0;
                    IP4Text.Text = "0";
                    Byte4Label.Text = IP4Text.Text;
                    ipAddress.Octet4 = newValue;
                    Byte4Text.Text = ipAddress.Octet4Binary;
                    SubIP4Text.Text = newValue.ToString();
                    MessageBox.Show($"{value} is not a valid entry. \nThe value should be between 0 and 255", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                if (value > 255)
                {
                    int newValue = 255;
                    IP4Text.Text = "255";
                    Byte4Label.Text = IP4Text.Text;
                    ipAddress.Octet4 = newValue;
                    Byte4Text.Text = ipAddress.Octet4Binary;
                    SubIP4Text.Text = newValue.ToString();
                    MessageBox.Show($"{value} is not a valid entry. \nThe value should be between 0 and 255", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                Byte4Label.Text = IP4Text.Text;
                ipAddress.Octet4 = value;
                Byte4Text.Text = ipAddress.Octet4Binary;
                SubIP4Text.Text = value.ToString();
            }
            else
            {
                Byte4Label.Text = IP4Text.Text;
                ipAddress.Octet4 = value;
                Byte4Text.Text = ipAddress.Octet4Binary;
                SubIP4Text.Text = value.ToString();
            }
        }

        private void UpdateBinary()
        {
            FontFamily defaultFamily = BinaryRTF.Font.FontFamily;
            Color yellowHighlight = Color.Yellow;
            Color defaultColor = Color.Black;
            Color bracketColor = Color.Blue;

            string FirstLine = $"{subnetMask1.Octet1Binary} {subnetMask1.Octet2Binary} {subnetMask1.Octet3Binary} {subnetMask1.Octet4Binary}";

            //FIsrt Line
            int StartPosition = 0;
            int ZeroPosition = FirstLine.IndexOf('0');
            if (ZeroPosition >= 0)
            {
                string tmp = FirstLine.Insert(ZeroPosition, "[");
                int lastPosition = tmp.Length;
                FirstLine = tmp.Insert(lastPosition, "]");
            }
            else
            {
                int lastPosition = FirstLine.Length;
                string tmp = FirstLine.Insert(lastPosition, "[");
                lastPosition = tmp.Length;
                FirstLine = tmp.Insert(lastPosition, "]");
            }



            BinaryRTF.Text = FirstLine;

            if (ipAddress.ClassBits > 0)
            {
                StartPosition = 0;
                int endLength = 0;
                if (ipAddress.ClassBits == 8)
                {
                    endLength = 8;
                }
                else if (ipAddress.ClassBits == 16)
                {
                    endLength = 17;
                }
                else if (ipAddress.ClassBits == 24)
                {
                    endLength = 26;
                }
                BinaryRTF.Select(StartPosition, endLength);
                BinaryRTF.SelectionBackColor = yellowHighlight;
                BinaryRTF.SelectionColor = defaultColor;
                BinaryRTF.SelectionFont = new Font(defaultFamily, 14, FontStyle.Regular);
            }


            //First Line
            int BracketOpenPosition = FirstLine.IndexOf('[');
            if (BracketOpenPosition >= 0)
            {
                BinaryRTF.Select(BracketOpenPosition, 1);
                BinaryRTF.SelectionColor = bracketColor;
                BinaryRTF.SelectionFont = new Font(defaultFamily, 22, FontStyle.Regular);
            }
            int BracketClosePosition = FirstLine.IndexOf(']');

            if (BracketClosePosition >= 0)
            {
                BinaryRTF.Select(BracketClosePosition, 1);
                BinaryRTF.SelectionColor = bracketColor;
                BinaryRTF.SelectionFont = new Font(defaultFamily, 22, FontStyle.Regular);
            }

        }


        private void Mask1Text_TextChanged(object sender, EventArgs e)
        {
            int value = int.Parse(Mask1Text.Text);
            MaskByte1Label.Text = Mask1Text.Text;
            SubMask1Text.Text = Mask1Text.Text;
            subnetMask1.Octet1 = value;
            MaskByte1Text.Text = subnetMask1.Octet1Binary;
            subnetMask1.Bits = SubnetTrackBar.Value;
            UpdateBinary();
        }

        private void Mask2Text_TextChanged(object sender, EventArgs e)
        {
            int value = int.Parse(Mask2Text.Text);
            MaskByte2Label.Text = Mask2Text.Text;
            SubMask2Text.Text = Mask2Text.Text;
            subnetMask1.Octet2 = value;
            MaskByte2Text.Text = subnetMask1.Octet2Binary;
            subnetMask1.Bits = SubnetTrackBar.Value;
            UpdateBinary();
        }

        private void Mask3Text_TextChanged(object sender, EventArgs e)
        {
            int value = int.Parse(Mask3Text.Text);
            MaskByte3Label.Text = Mask3Text.Text;
            SubMask3Text.Text = Mask3Text.Text;
            subnetMask1.Octet3 = value;
            MaskByte3Text.Text = subnetMask1.Octet3Binary;
            subnetMask1.Bits = SubnetTrackBar.Value;
            UpdateBinary();
        }

        private void Mask4Text_TextChanged(object sender, EventArgs e)
        {
            int value = int.Parse(Mask4Text.Text);
            MaskByte4Label.Text = Mask4Text.Text;
            SubMask4Text.Text = Mask4Text.Text;
            subnetMask1.Octet4 = value;
            MaskByte4Text.Text = subnetMask1.Octet4Binary;
            subnetMask1.Bits = SubnetTrackBar.Value;
            UpdateBinary();
        }

        private void SubnetTrackBar_Scroll(object sender, EventArgs e)
        {

        }

        private void SupernetButton_Click(object sender, EventArgs e)
        {
            if (SubnetTrackBar.Value > SubnetTrackBar.Minimum)
            {
                SubnetTrackBar.Value -= 1;
            }
        }

        private void SubnetTrackBar_ValueChanged(object sender, EventArgs e)
        {
            if (ipAddress.ClassBits == 0)
            {
                SubnetTrackBar.Value = 0;
                //MessageBox.Show("Please enter a valid IP Address", "Error in IP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //IP1Text.Focus();

            }
            if (SubnetTrackBar.Value < ipAddress.ClassBits)
            {
                SubnetTrackBar.Value = ipAddress.ClassBits;
            }
            //CidrValueText.Text = $" / {SubnetTrackBar.Value}";
            //CidrValueLabel.Text = $" / {SubnetTrackBar.Value}";
            CidrCombo.SelectedIndex = SubnetTrackBar.Value;
            if (SubnetTrackBar.Value > 0)
            {
                double answer = 0.0;
                if (SubnetTrackBar.Value == SubnetTrackBar.Minimum)
                {
                    answer = 0;
                }
                else
                {
                    answer = Math.Pow(2, SubnetTrackBar.Value);
                }
                NetworkBitsText.Text = SubnetTrackBar.Value.ToString();
                NetworksText.Text = ManualFormat(answer);
                if (SubnetTrackBar.Value == SubnetTrackBar.Maximum)
                {
                    answer = 0;
                }
                else
                {
                    answer = Math.Pow(2, (32 - SubnetTrackBar.Value));
                }
                HostsText.Text = ManualFormat(answer);
                HostBitsText.Text = (32 - SubnetTrackBar.Value).ToString();
                HostBits2Text.Text = (32 - SubnetTrackBar.Value).ToString();
                SubnetBitsText.Text = (SubnetTrackBar.Value - ipAddress.ClassBits).ToString();

                answer = double.Parse(SubnetBitsText.Text);
                if (answer > 0)
                {
                    SubnetsText.Text = ManualFormat(Math.Pow(2, answer));
                }
                else
                {
                    SubnetsText.Text = "0";
                }
                answer = Math.Pow(2, (32 - SubnetTrackBar.Value)) - 2;
                if (answer < 0)
                {
                    answer = 0;
                }
                HostsPerSubnetText.Text = ManualFormat(answer);
            }
            else
            {
                NetworksText.Text = "0";
                NetworkBitsText.Text = SubnetTrackBar.Value.ToString();
                HostBitsText.Text = (32 - SubnetTrackBar.Value).ToString();
                HostBits2Text.Text = (32 - SubnetTrackBar.Value).ToString();
                SubnetBitsText.Text = (SubnetTrackBar.Value - ipAddress.ClassBits).ToString();
                SubnetsText.Text = "0";
                HostBitsText.Text = "0";
                HostBits2Text.Text = "0";
                HostsPerSubnetText.Text = "0";
                HostsText.Text = "0";
            }
            switch (SubnetTrackBar.Value)
            {
                case 0:
                    Mask1Text.Text = "0";
                    Mask2Text.Text = "0";
                    Mask3Text.Text = "0";
                    Mask4Text.Text = "0";
                    break;
                case 1:
                    Mask1Text.Text = "128";
                    Mask2Text.Text = "0";
                    Mask3Text.Text = "0";
                    Mask4Text.Text = "0";
                    break;
                case 2:
                    Mask1Text.Text = "192";
                    Mask2Text.Text = "0";
                    Mask3Text.Text = "0";
                    Mask4Text.Text = "0";
                    break;
                case 3:
                    Mask1Text.Text = "224";
                    Mask2Text.Text = "0";
                    Mask3Text.Text = "0";
                    Mask4Text.Text = "0";
                    break;
                case 4:
                    Mask1Text.Text = "240";
                    Mask2Text.Text = "0";
                    Mask3Text.Text = "0";
                    Mask4Text.Text = "0";
                    break;
                case 5:
                    Mask1Text.Text = "248";
                    Mask2Text.Text = "0";
                    Mask3Text.Text = "0";
                    Mask4Text.Text = "0";
                    break;
                case 6:
                    Mask1Text.Text = "252";
                    Mask2Text.Text = "0";
                    Mask3Text.Text = "0";
                    Mask4Text.Text = "0";
                    break;
                case 7:
                    Mask1Text.Text = "254";
                    Mask2Text.Text = "0";
                    Mask3Text.Text = "0";
                    Mask4Text.Text = "0";
                    break;
                case 8:
                    Mask1Text.Text = "255";
                    Mask2Text.Text = "0";
                    Mask3Text.Text = "0";
                    Mask4Text.Text = "0";
                    break;
                case 9:
                    Mask1Text.Text = "255";
                    Mask2Text.Text = "128";
                    Mask3Text.Text = "0";
                    Mask4Text.Text = "0";
                    break;
                case 10:
                    Mask1Text.Text = "255";
                    Mask2Text.Text = "192";
                    Mask3Text.Text = "0";
                    Mask4Text.Text = "0";
                    break;
                case 11:
                    Mask1Text.Text = "255";
                    Mask2Text.Text = "224";
                    Mask3Text.Text = "0";
                    Mask4Text.Text = "0";
                    break;
                case 12:
                    Mask1Text.Text = "255";
                    Mask2Text.Text = "240";
                    Mask3Text.Text = "0";
                    Mask4Text.Text = "0";
                    break;
                case 13:
                    Mask1Text.Text = "255";
                    Mask2Text.Text = "248";
                    Mask3Text.Text = "0";
                    Mask4Text.Text = "0";
                    break;
                case 14:
                    Mask1Text.Text = "255";
                    Mask2Text.Text = "252";
                    Mask3Text.Text = "0";
                    Mask4Text.Text = "0";
                    break;
                case 15:
                    Mask1Text.Text = "255";
                    Mask2Text.Text = "254";
                    Mask3Text.Text = "0";
                    Mask4Text.Text = "0";
                    break;
                case 16:
                    Mask1Text.Text = "255";
                    Mask2Text.Text = "255";
                    Mask3Text.Text = "0";
                    Mask4Text.Text = "0";
                    break;
                case 17:
                    Mask1Text.Text = "255";
                    Mask2Text.Text = "255";
                    Mask3Text.Text = "128";
                    Mask4Text.Text = "0";
                    break;
                case 18:
                    Mask1Text.Text = "255";
                    Mask2Text.Text = "255";
                    Mask3Text.Text = "192";
                    Mask4Text.Text = "0";
                    break;
                case 19:
                    Mask1Text.Text = "255";
                    Mask2Text.Text = "255";
                    Mask3Text.Text = "224";
                    Mask4Text.Text = "0";
                    break;
                case 20:
                    Mask1Text.Text = "255";
                    Mask2Text.Text = "255";
                    Mask3Text.Text = "240";
                    Mask4Text.Text = "0";
                    break;
                case 21:
                    Mask1Text.Text = "255";
                    Mask2Text.Text = "255";
                    Mask3Text.Text = "248";
                    Mask4Text.Text = "0";
                    break;
                case 22:
                    Mask1Text.Text = "255";
                    Mask2Text.Text = "255";
                    Mask3Text.Text = "252";
                    Mask4Text.Text = "0";
                    break;
                case 23:
                    Mask1Text.Text = "255";
                    Mask2Text.Text = "255";
                    Mask3Text.Text = "254";
                    Mask4Text.Text = "0";
                    break;
                case 24:
                    Mask1Text.Text = "255";
                    Mask2Text.Text = "255";
                    Mask3Text.Text = "255";
                    Mask4Text.Text = "0";
                    break;
                case 25:
                    Mask1Text.Text = "255";
                    Mask2Text.Text = "255";
                    Mask3Text.Text = "255";
                    Mask4Text.Text = "128";
                    break;
                case 26:
                    Mask1Text.Text = "255";
                    Mask2Text.Text = "255";
                    Mask3Text.Text = "255";
                    Mask4Text.Text = "192";
                    break;
                case 27:
                    Mask1Text.Text = "255";
                    Mask2Text.Text = "255";
                    Mask3Text.Text = "255";
                    Mask4Text.Text = "224";
                    break;
                case 28:
                    Mask1Text.Text = "255";
                    Mask2Text.Text = "255";
                    Mask3Text.Text = "255";
                    Mask4Text.Text = "240";
                    break;
                case 29:
                    Mask1Text.Text = "255";
                    Mask2Text.Text = "255";
                    Mask3Text.Text = "255";
                    Mask4Text.Text = "248";
                    break;
                case 30:
                    Mask1Text.Text = "255";
                    Mask2Text.Text = "255";
                    Mask3Text.Text = "255";
                    Mask4Text.Text = "252";
                    break;
                case 31:
                    Mask1Text.Text = "255";
                    Mask2Text.Text = "255";
                    Mask3Text.Text = "255";
                    Mask4Text.Text = "254";
                    break;
                case 32:
                    Mask1Text.Text = "255";
                    Mask2Text.Text = "255";
                    Mask3Text.Text = "255";
                    Mask4Text.Text = "255";
                    break;
            }
        }

        private void SubnetButton_Click(object sender, EventArgs e)
        {
            if (SubnetTrackBar.Value < SubnetTrackBar.Maximum)
            {
                SubnetTrackBar.Value += 1;
            }
        }

        private void CidrCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ipAddress.ClassBits == 0)
            {
                CidrCombo.SelectedIndex = 0;
                return;
            }
            SubnetTrackBar.Value = CidrCombo.SelectedIndex;
        }

        private void IP4Text_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back & IP4Text.Text == "")
            {
                IP3Text.Focus();
            }
            if (e.KeyCode == Keys.Left & IP4Text.SelectionStart == 0)
            {
                IP3Text.Focus();
                IP3Text.SelectionStart = IP3Text.TextLength;
            }
        }

        private void IP3Text_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back & IP3Text.Text == "")
            {
                IP2Text.Focus();
            }
            if (e.KeyCode == Keys.Left & IP3Text.SelectionStart == 0)
            {
                IP2Text.Focus();
                IP2Text.SelectionStart = IP2Text.TextLength;
            }
            if (e.KeyCode == Keys.Right & IP3Text.Text.Length > 0 & IP3Text.SelectionStart == IP3Text.TextLength)
            {
                IP4Text.Focus();
                IP4Text.SelectionStart = 0;
            }
        }

        private void IP2Text_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back & IP2Text.Text == "")
            {
                IP1Text.Focus();
            }
            if (e.KeyCode == Keys.Left & IP2Text.SelectionStart == 0)
            {
                IP1Text.Focus();
                IP1Text.SelectionStart = IP1Text.TextLength;

            }
            if (e.KeyCode == Keys.Right & IP2Text.Text.Length > 0 & IP2Text.SelectionStart == IP2Text.TextLength)
            {
                IP3Text.Focus();
                IP3Text.SelectionStart = 0;
            }
        }

        private bool formLoading = false;

        private void SubnetForm_Load(object sender, EventArgs e)
        {
            if (CidrCombo.Items.Count > 0)
            {
                CidrCombo.SelectedIndex = 0;
            }

            object? tmp;
            string? tmpstr = "";
            try
            {
                tmp = Registry.GetValue(keyName, "Ipmin", "1");
                if (tmp != null)
                {
                    tmpstr = tmp.ToString();
                    IpMinimized = (tmpstr == "0") ? false : true;
                }
                else
                {
                    IpMinimized = false;
                }
                tmp = Registry.GetValue(keyName, "Maskmin", "1");
                if (tmp != null)
                {
                    tmpstr = tmp.ToString();
                    MaskMinimized = (tmpstr == "0") ? false : true;
                }
                else
                {
                    MaskMinimized = false;
                }
                tmp = Registry.GetValue(keyName, "Subnetmin", "1");
                if (tmp != null)
                {
                    tmpstr = tmp.ToString();
                    SubnetMinimized = (tmpstr == "0") ? false : true;
                }
                else
                {
                    SubnetMinimized = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            formLoading = true;
            ToggleIP();
            ToggleMask();
            ToggleSubnet();
            UpdateFormHeight();
            Screen thisScreen = Screen.FromControl(this);

            if (thisScreen != null)
            {
                int newLeft = (thisScreen.WorkingArea.Width / 2) - (this.Width / 2);
                int newTop = (thisScreen.WorkingArea.Height / 2) - (this.Height / 2);
                this.Location = new Point(newLeft, newTop);
            }
            formLoading = false;
        }

        private void ShowNetworksButton_Click(object sender, EventArgs e)
        {
            if (ipAddress.ClassBits > 0)
            {
                ReportForm frm = new ReportForm(ipAddress, defaultMask, subnetMask1);
                this.Hide();
                frm.ShowDialog();
                this.Show();
                this.Activate();
            }
        }

        private void IP1Text_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right & IP1Text.TextLength > 0 & IP1Text.SelectionStart == IP1Text.TextLength)
            {
                IP2Text.Focus();
                IP2Text.SelectionStart = 0;
            }
        }

        private void IpCollapseLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ToggleIP();
            UpdateFormHeight();
        }

        private void ToggleIP()
        {
            if (IpMinimized)
            {
                double factor = (double)this.DeviceDpi / 96.0;

                // Apply scaling to your hardcoded 'base' size
                IpSectionGroup.Height = (int)(200 * factor);
                //IpSectionGroup.Height = 200;
                int newY = IpSectionGroup.Location.Y + IpSectionGroup.Height + 15;
                MaskSectionGroup.Location = new Point(25, newY);
                newY = MaskSectionGroup.Location.Y + MaskSectionGroup.Height + 15;
                SubnetSectionGroup.Location = new Point(25, newY);
                IpCollapseLabel.Text = "--";
                if (!formLoading)
                {
                    Registry.SetValue(keyName, "Ipmin", "1");
                }
                IpMinimized = false;
            }
            else
            {
                double factor = (double)this.DeviceDpi / 96.0;

                // Apply scaling to your hardcoded 'base' size
                IpSectionGroup.Height = (int)(90 * factor);
                //IpSectionGroup.Height = 90;
                int newY = IpSectionGroup.Location.Y + IpSectionGroup.Height + 15;
                MaskSectionGroup.Location = new Point(25, newY);
                newY = MaskSectionGroup.Location.Y + MaskSectionGroup.Height + 15;
                SubnetSectionGroup.Location = new Point(25, newY);
                IpCollapseLabel.Text = "+";
                if (!formLoading)
                {
                    Registry.SetValue(keyName, "Ipmin", "0");
                }
                IpMinimized = true;
            }
        }

        private void MaskCollapseLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ToggleMask();
            UpdateFormHeight();
        }

        private void ToggleMask()
        {
            if (MaskMinimized)
            {
                double factor = (double)this.DeviceDpi / 96.0;

                // Apply scaling to your hardcoded 'base' size
                MaskSectionGroup.Height = (int)(294 * factor);
                //MaskSectionGroup.Height = 285;
                int newY = (MaskSectionGroup.Location.Y + MaskSectionGroup.Height) + 15;
                SubnetSectionGroup.Location = new Point(25, newY);
                MaskCollapseLabel.Text = "--";
                if (!formLoading)
                {
                    Registry.SetValue(keyName, "Maskmin", "1");
                }
                MaskMinimized = false;
            }
            else
            {
                double factor = (double)this.DeviceDpi / 96.0;

                // Apply scaling to your hardcoded 'base' size
                MaskSectionGroup.Height = (int)(143 * factor);
                //MaskSectionGroup.Height = 141;
                int newY = (MaskSectionGroup.Location.Y + MaskSectionGroup.Height) + 15;
                SubnetSectionGroup.Location = new Point(25, newY);
                MaskCollapseLabel.Text = "+";
                if (!formLoading)
                {
                    Registry.SetValue(keyName, "Maskmin", "0");
                }
                MaskMinimized = true;
            }
        }

        private void ToggleSubnet()
        {
            if (SubnetMinimized)
            {
                double factor = (double)this.DeviceDpi / 96.0;

                // Apply scaling to your hardcoded 'base' size
                SubnetSectionGroup.Height = (int)(318 * factor);
                //SubnetSectionGroup.Height = 318;
                SubnetCollapseLabel.Text = "--";

                if (!formLoading)
                {
                    Registry.SetValue(keyName, "Subnetmin", "1");
                }
                SubnetMinimized = false;
            }
            else
            {
                double factor = (double)this.DeviceDpi / 96.0;

                // Apply scaling to your hardcoded 'base' size
                SubnetSectionGroup.Height = (int)(178 * factor);
                //SubnetSectionGroup.Height = 178;
                SubnetCollapseLabel.Text = "+";
                if (!formLoading)
                {
                    Registry.SetValue(keyName, "Subnetmin", "0");
                }
                SubnetMinimized = true;
            }
        }

        private void SubnetCollapseLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ToggleSubnet();
            UpdateFormHeight();
        }

        private void UpdateFormHeight()
        {
            double factor = (double)this.DeviceDpi / 96.0;

            int verticalSpace = (int)(35 * factor);

            int tmpHeight = (IpSectionGroup.Height + verticalSpace) + (MaskSectionGroup.Height + verticalSpace) + (SubnetSectionGroup.Height + verticalSpace);
            tmpHeight += HeadingOffset;
            Screen currentScreen = Screen.FromControl(this);
            if (currentScreen != null)
            {
                if (tmpHeight > currentScreen.WorkingArea.Height)
                {
                    tmpHeight = currentScreen.WorkingArea.Height;
                    this.AutoScroll = true;
                }
            }
            // Apply scaling to your hardcoded 'base' size
            this.Height = tmpHeight;
            //this.Height = tmpHeight;
        }

        Point lastPoint;

        private void ClassFull_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void ClassFull_MouseMove(object sender, MouseEventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
                return;
            if (e.Button == MouseButtons.Left)
            {
                this.Left += (e.X - lastPoint.X);
                this.Top += (e.Y - lastPoint.Y);
            }
        }
    }
}
