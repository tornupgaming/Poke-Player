using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokebot
{
    public class PRedWRam : WRamFile
    {
        private const string MemLocPlayerX = "D362";
        private const string MemLocPlayerY = "D361";
        private const string MemLocMapNumber = "D35E";

        public PRedWRam(string location) : base(location)
        {
           
        }

        private void ProcessPRedData()
        {
            PrintVar("X", MemLocPlayerX);
            PrintVar("Y", MemLocPlayerX);
            PrintVar("Map Number", MemLocMapNumber);
        }

        private void PrintVar(string var, string address)
        {
            Console.WriteLine(var + ": " + ValueAtAddress(address));
        }
    }
}
