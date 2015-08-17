using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokebot.Memory
{
    public class MemoryTracker
    {
        public string Name;
        public int Address;
        public List<byte> Values;
        public bool Tracking;
        public bool Displaying;
        public byte LastValue
        {
            get { return Values[Values.Count - 1]; }
        }
        public override string ToString()
        {
            return string.Format("Tracker [{0}]: {1}", Address, LastValue);
        }
    }
}
