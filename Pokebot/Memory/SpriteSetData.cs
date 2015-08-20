using Pokebot.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokebot.Memory {
    public class SpriteSetData {

        private const byte MovementStationary = 0x00ff;
        private const byte MovementRandom = 0x00fe;

        public int Index;
        public int AddressHead;

        public MemoryTracker PictureID,
            MovementStatus,
            SpriteImageIndex,
            YPositionDelta,
            YPositionPixels,
            XPositionDelta,
            XPositionPixels,
            IntraAnimationFrameCounter,
            AnimationFrameCounter,
            FacingDirection,
            WalkAnimationCounter,
            YDisplacement,
            XDisplacement,
            YPositionSteps,
            XPositionSteps,
            MovementByte,
            GrassRelated,
            MovementDelay;

        public SpriteSetData(int index) {
            Index = index;
            // WRam starts at 0xC000
            AddressHead = 0x0100 + (index * 0x0010);

            PictureID = t(AddressHead);
            MovementStatus = t(AddressHead + 0x0001);
            SpriteImageIndex = t(AddressHead + 0x0002);
            YPositionDelta = t(AddressHead + 0x0003);
            YPositionPixels = t(AddressHead + 0x0004);
            XPositionDelta = t(AddressHead + 0x0005);
            XPositionPixels = t(AddressHead + 0x0006);
            IntraAnimationFrameCounter = t(AddressHead + 0x0007);
            AnimationFrameCounter = t(AddressHead + 0x0008);
            FacingDirection = t(AddressHead + 0x0009);

            WalkAnimationCounter = t(AddressHead + 0x0100);
            // 0x0101 does nothing
            YDisplacement = t(AddressHead + 0x0102);
            XDisplacement = t(AddressHead + 0x0103);
            YPositionSteps = t(AddressHead + 0x0104);
            XPositionSteps = t(AddressHead + 0x0105);
            MovementByte = t(AddressHead + 0x0106);
            GrassRelated = t(AddressHead + 0x0107);
            MovementDelay = t(AddressHead + 0x0108);
        }

        private MemoryTracker t(int address) {
            return SessionData.Memory.GetTracker(address); 
        }

        public override string ToString() {
            if(PictureID.LastValue > 0) {
                return string.Format("{0} - Sprite {1}: Position ({2},{3})", Index, PictureID.LastValue, PositionX, PositionY);
            }
            return string.Format("{0}", Index);
        }

        public int PositionX {
            get {
                return XPositionSteps.LastValue - 4;
            }
        }

        public int PositionY {
            get {
                return YPositionSteps.LastValue - 4;
            }
        }

        public bool IsRandomMovement {
            get {
                return MovementByte.LastValue == MovementRandom;
            }
        }
    }
}
