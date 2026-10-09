using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPSubnet
{
    public class IpAddressFormat
    {
        private int m_Octet1;
        private int m_Octet2;
        private int m_Octet3;
        private int m_Octet4;

        private string m_Octet1Binary;
        private string m_Octet2Binary;
        private string m_Octet3Binary;
        private string m_Octet4Binary;

        public string Class;
        public int ClassBits;

        private const string ALL_ZEROS = "00000000";

        public IpAddressFormat()
        {
            this.m_Octet1 = 0;
            this.m_Octet2 = 0;
            this.m_Octet3 = 0;
            this.m_Octet4 = 0;

            this.m_Octet1Binary = ALL_ZEROS;
            this.m_Octet2Binary = ALL_ZEROS;
            this.m_Octet3Binary = ALL_ZEROS;
            this.m_Octet4Binary = ALL_ZEROS;

            this.Class = string.Empty;
            this.ClassBits = 0;
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

        public int Octet1
        {
            get
            {
                return m_Octet1;
            }
            set
            {
                m_Octet1 = value;
                m_Octet1Binary = Convert.ToString(m_Octet1, 2).PadLeft(8, '0');
            }
        }

        public int Octet2
        {
            get
            {
                return m_Octet2;
            }
            set
            {
                m_Octet2 = value;
                m_Octet2Binary = Convert.ToString(m_Octet2, 2).PadLeft(8, '0');
            }
        }

        public int Octet3
        {
            get
            {
                return m_Octet3;
            }
            set
            {
                m_Octet3 = value;
                m_Octet3Binary = Convert.ToString(m_Octet3, 2).PadLeft(8, '0');
            }
        }

        public int Octet4
        {
            get
            {
                return m_Octet4;
            }
            set
            {
                m_Octet4 = value;
                m_Octet4Binary = Convert.ToString(m_Octet4, 2).PadLeft(8, '0');
            }
        }

        public IpAddressFormat(int Octet1Param, int Octet2Param, int Octet3Param, int Octet4Param)
        {
            this.m_Octet1 = Octet1Param;
            this.m_Octet2 = Octet2Param;
            this.m_Octet3 = Octet3Param;
            this.m_Octet4 = Octet4Param;

            this.m_Octet1Binary = ALL_ZEROS;
            this.m_Octet2Binary = ALL_ZEROS;
            this.m_Octet3Binary = ALL_ZEROS;
            this.m_Octet4Binary = ALL_ZEROS;

            this.Class = string.Empty;
            this.ClassBits = 0;
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
