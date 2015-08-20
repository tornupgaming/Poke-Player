using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokebot.Utility {
    public class MemoryAddresses {

        public const int WRamOffset = 0xC000;

        public const int TalkingA = 0xD0B7 - WRamOffset;
        public const int TalkingB = 0xD358 - WRamOffset;



        public const int CurrentMapID = 0x135E;
        public const int CurrentTileBlockMapViewPointerA = 0x135F;
        public const int CurrentTileBlockMapViewPointerB = 0x1360;
        public const int PlayerYPosition = 0x1361;
        public const int PlayerXPosition = 0x1362;

        public const int CurrentMapHeight = 0x1368;
        public const int CurrentMapWidth = 0x1369;

        public const int CurrentMapDataPointerA = 0x136A;
        public const int CurrentMapDataPointerB = 0x136B;

        public const int MapTextPointerA = 0xD36C - WRamOffset;
        public const int MapTextPointerB = 0xD36D - WRamOffset;


    }
}
