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

        public const int PlayerXPosition = 0xD362 - WRamOffset;
        public const int PlayerYPosition = 0xD361 - WRamOffset;

        public const int CurrentMapID = 0xD35E - WRamOffset;

        public const int MapTextPointerA = 0xD36C - WRamOffset;
        public const int MapTextPointerB = 0xD36D - WRamOffset;

        public const int PlayerPictureID = 0x0100; // 0xC100
        public const int PlayerMovementStatus = 0x0101; // 0xC101
        public const int PlayerSpriteImageIndex = 0x0102; // 0xC102
        public const int PlayerYScreenPosDelta = 0x0103; // 0xC103
        public const int PlayerYScreenPos = 0x0104; // 0xC104
        public const int PlayerXScreenPosDelta = 0x0105; // 0xC105
        public const int PlayerXScreenPos = 0x0106; // 0xC106
    }
}
