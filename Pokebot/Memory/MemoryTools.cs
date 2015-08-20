using Pokebot.Utility;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokebot.Memory
{
    public class MemoryTools
    {
        private const int MaxDumps = 3;

        public List<WRamFile> RecentMemoryDumps = new List<WRamFile>();
        public Dictionary<int, MemoryTracker> MemoryTrackers = new Dictionary<int, MemoryTracker>();

        public const string FileLocation = "emu/cgb_wram.bin";

        private bool m_Dirty;
        private bool m_RequiresSort;

        public Action OnDumpRead;
        public Action OnMemoryChanged;

        public WRamFile LatestDump
        {
            get
            {
                if (RecentMemoryDumps.Count <= 0)
                {
                    return null;
                }
                return RecentMemoryDumps[RecentMemoryDumps.Count - 1];
            }
        }

        public void CheckForNewDump()
        {
            if (LatestDump != null)
            {
                if (LatestDump.LastWriteTime != File.GetLastWriteTime(FileLocation))
                {
                    AddDump();
                }
            }
            else
            {
                AddDump();
            }
        }

        public void AddDump()
        {
            try {
                RecentMemoryDumps.Add(new WRamFile(FileLocation));
            } catch (Exception e) {
                Debug.Log("WRam file unable to load");
                return;
            }
            while (RecentMemoryDumps.Count > MaxDumps)
            {
                RecentMemoryDumps.RemoveAt(0);
            }
            if (RecentMemoryDumps.Count >= 2)
            {
                var mostRecent = RecentMemoryDumps[RecentMemoryDumps.Count - 1];
                var SecondMostRecent = RecentMemoryDumps[RecentMemoryDumps.Count - 2];
                for (int i = 0; i < mostRecent.RawData.Length; i++)
                {
                    if (mostRecent.RawData[i] != SecondMostRecent.RawData[i])
                    {
                        MemoryChanged(i, SecondMostRecent.RawData[i], mostRecent.RawData[i]);
                    }
                }
            }
            if (m_Dirty)
            {
                if (m_RequiresSort)
                {
                    
                }
                if (OnMemoryChanged != null)
                {
                    OnMemoryChanged();
                }
            }
            if (OnDumpRead != null)
            {
                OnDumpRead();
            }

        }

        public MemoryTracker GetTracker(int address)
        {
            if (MemoryTrackers.ContainsKey(address))
            {
                return MemoryTrackers[address];
            }
            var newTracker = new MemoryTracker() { Address = address, Tracking = true, Displaying = true, Values = new List<byte>() };
            newTracker.Values.Add(LatestDump.ValueAtAddress(address));
            MemoryTrackers.Add(address, newTracker);
            return newTracker;            
        }

        private void MemoryChanged(int address, byte from, byte to)
        {
            if (MemoryTrackers.ContainsKey(address))
            {
                MemoryTrackers[address].Values.Add(to);
            }
            else
            {
                MemoryTrackers.Add(address, new MemoryTracker() { Address = address, Tracking = true, Displaying = true, Values = new List<byte>(new byte[] { from, to }) });
                m_RequiresSort = true;
            }
            m_Dirty = true;
        }
    }
}
