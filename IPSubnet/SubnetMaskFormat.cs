using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPSubnet
{
    public class SubnetMaskFormat
    {
        private int m_Octet1;
        private int m_Octet2;
        private int m_Octet3;
        private int m_Octet4;

        private int m_WildcardOctet1;
        private int m_WildcardOctet2;
        private int m_WildcardOctet3;
        private int m_WildcardOctet4;

        private string m_Octet1Binary;
        private string m_Octet2Binary;
        private string m_Octet3Binary;
        private string m_Octet4Binary;

        private int m_Bits;
        private int m_BlockSize;
        private int m_MagicNumber;
        private int m_InterestingByte;

        public int Octet1
        {
            get { return m_Octet1; }
            set
            {
                m_Octet1 = value;
                m_WildcardOctet1 = 255 - m_Octet1;
                m_Octet1Binary = Convert.ToString(m_Octet1, 2).PadLeft(8, '0');
            }
        }

        public int Octet2
        {
            get { return m_Octet2; }
            set
            {
                m_Octet2 = value;
                m_WildcardOctet2 = 255 - m_Octet2;
                m_Octet2Binary = Convert.ToString(m_Octet2, 2).PadLeft(8, '0');
            }
        }

        public int Octet3
        {
            get { return m_Octet3; }
            set
            {
                m_Octet3 = value;
                m_WildcardOctet3 = 255 - m_Octet3;
                m_Octet3Binary = Convert.ToString(m_Octet3, 2).PadLeft(8, '0');
            }
        }

        public int Octet4
        {
            get { return m_Octet4; }
            set
            {
                m_Octet4 = value;
                m_WildcardOctet4 = 255 - m_Octet4;
                m_Octet4Binary = Convert.ToString(m_Octet4, 2).PadLeft(8, '0');
            }
        }

        public int WildcardOctet1
        {
            get { return m_WildcardOctet1; }
        }

        public int WildcardOctet2
        {
            get { return m_WildcardOctet2; }
        }

        public int WildcardOctet3
        {
            get { return m_WildcardOctet3; }
        }

        public int WildcardOctet4
        {
            get { return m_WildcardOctet4; }
        }

        public string Octet1Binary
        {
            get { return m_Octet1Binary; }
        }

        public string Octet2Binary
        {
            get { return m_Octet2Binary; }
        }

        public string Octet3Binary
        {
            get { return m_Octet3Binary; }
        }

        public string Octet4Binary
        {
            get { return m_Octet4Binary; }
        }

        public int MagicNumber { get { return m_MagicNumber; } }
        public int InterestingByte { get { return m_InterestingByte; } }

        public int BlockSize
        { get { return m_BlockSize; } }

        public int Bits
        {
            get { return m_Bits; }
            set
            {
                m_Bits = value;
                m_InterestingByte = 0;
                if (this.m_Octet1 >= 128 && this.m_Octet1 <= 255)
                {
                    m_InterestingByte += 1;
                }
                if (this.m_Octet1 == 255)
                {
                    m_InterestingByte += 1;
                }
                if (this.m_Octet2 == 255)
                {
                    m_InterestingByte += 1;
                }
                if (this.m_Octet3 == 255)
                {
                    m_InterestingByte += 1;
                }
                switch (m_InterestingByte)
                {
                    case 1:
                        m_MagicNumber = 256 - this.m_Octet1;
                        break;
                    case 2:
                        m_MagicNumber = 256 - this.m_Octet2;
                        break;
                    case 3:
                        m_MagicNumber = 256 - this.m_Octet3;
                        break;
                    case 4:
                        m_MagicNumber = 256 - this.m_Octet4;
                        break;
                }
                int hostbits = 32 - m_Bits;
                if (hostbits <= 0)
                {
                    m_BlockSize = 0;
                }
                else
                {
                    double tmp2 = Math.Pow(2, hostbits);
                    if (tmp2 < 0)
                    {
                        m_BlockSize = 0;
                    }
                    m_BlockSize = (int)tmp2;
                    if (m_BlockSize < 0)
                    {
                        m_BlockSize = 0;
                    }
                }
            }
        }


        private const string ALL_ZEROS = "00000000";

        public SubnetMaskFormat()
        {
            m_Octet1 = 0;
            m_Octet2 = 0;
            m_Octet3 = 0;
            m_Octet4 = 0;

            m_WildcardOctet1 = 255 - m_Octet1;
            m_WildcardOctet2 = 255 - m_Octet2;
            m_WildcardOctet3 = 255 - m_Octet3;
            m_WildcardOctet4 = 255 - m_Octet4;

            m_Octet1Binary = ALL_ZEROS;
            m_Octet2Binary = ALL_ZEROS;
            m_Octet3Binary = ALL_ZEROS;
            m_Octet4Binary = ALL_ZEROS;

            Bits = 0;
        }

        public string ToWildcard()
        {
            return $"{m_WildcardOctet1}.{m_WildcardOctet2}.{m_WildcardOctet3}.{m_WildcardOctet4}";
        }

        public string ToBinary()
        {
            return $"{m_Octet1Binary}.{m_Octet2Binary}.{m_Octet3Binary}.{m_Octet4Binary}";
        }

        public override string ToString()
        {
            return $"{m_Octet1}.{m_Octet2}.{m_Octet3}.{m_Octet4}";
        }
    }
}
