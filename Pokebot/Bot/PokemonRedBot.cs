using Pokebot.Memory;
using Pokebot.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokebot.Bot {
    public class PokemonRedBot {

        // =-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
        #region Enums
        // =-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=

        public enum TalkState { Not, Begin, Middle, End }

        #endregion

        // =-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
        #region Trackers
        // =-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=

        private MemoryTracker m_PositionXTracker, m_PositionYTracker;
        private MemoryTracker m_TalkTrackerA, m_TalkTrackerB;

        #endregion

        // =-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
        #region Access
        // =-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=

        public int PlayerXPosition { get { return m_PositionXTracker.LastValue; } }
        public int PlayerYPosition { get { return m_PositionYTracker.LastValue; } }
        public bool TalkingA { get { return m_TalkTrackerA.LastValue == 3; } }
        public bool TalkingB { get { return m_TalkTrackerB.LastValue == 3; } }

        public TalkState Talking {
            get {
                if (!TalkingA && !TalkingB) {
                    return TalkState.End;
                } else if (TalkingA && !TalkingB) {
                    return TalkState.Not;
                } else if (!TalkingA && TalkingB) {
                    return TalkState.Middle;
                } else if (TalkingA && TalkingB) {
                    return TalkState.Begin;
                }

                return TalkState.Not;
            }
        }

        #endregion

        public void InitTrackers() {
            m_PositionXTracker = GetT(MemoryAddresses.PlayerXPosition);
            m_PositionYTracker = GetT(MemoryAddresses.PlayerYPosition);

            m_TalkTrackerA = GetT(MemoryAddresses.TalkingA);
            m_TalkTrackerB = GetT(MemoryAddresses.TalkingB);
        }

        public void Update() {
            if(Talking == TalkState.Middle || Talking == TalkState.End) {
                VBAController.UserControl_B();
            }
        }

        private MemoryTracker GetT(int address) {
            return SessionData.Memory.GetTracker(address);
        }
    }
}
