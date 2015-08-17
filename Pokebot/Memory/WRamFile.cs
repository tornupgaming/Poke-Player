using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Pokebot
{
    public class WRamFile
    {
        public string Location;
        public DateTime LastWriteTime;
        private byte[] m_RawData;

        public byte[] RawData
        {
            get
            {
                return m_RawData;
            }
        }

        public WRamFile(string location)
        {
            Location = location;
            m_RawData = File.ReadAllBytes(Location);
            LastWriteTime = File.GetLastWriteTime(Location);
            Console.WriteLine(string.Format("WRamFile.new({0}): {1}", location, LastWriteTime));
        }

        public byte ValueAtAddress(int address)
        {
            return m_RawData[address];
        }

        public byte ValueAtAddress(string hexAddress)
        {
            int decValue = int.Parse(hexAddress, System.Globalization.NumberStyles.HexNumber) - int.Parse("C000", System.Globalization.NumberStyles.HexNumber);
            Console.WriteLine(string.Format("Hex:{0} / Dec:{1}", hexAddress, decValue));
            return m_RawData[decValue];
        }
    }
}
