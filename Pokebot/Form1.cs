using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using Pokebot.Memory;
using Pokebot.Utility;
using Pokebot.Bot;

namespace Pokebot {
    public partial class Form1 : Form {
        MemoryTracker m_TalkTrackerA, m_TalkTrackerB, m_MapIDTracker;
        BindingList<SpriteSetData> m_SpriteData;


        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            SessionData.Memory = new MemoryTools();
            SessionData.Memory.OnMemoryChanged += OnMemoryChanged;
            SessionData.Memory.CheckForNewDump();

            SessionData.Bot = new PokemonRedBot();
            SessionData.Bot.InitTrackers();

            m_TalkTrackerA = SessionData.Memory.GetTracker(MemoryAddresses.TalkingA);
            m_TalkTrackerB = SessionData.Memory.GetTracker(MemoryAddresses.TalkingB);

            m_MapIDTracker = SessionData.Memory.GetTracker(MemoryAddresses.CurrentMapID);

            m_SpriteData = new BindingList<SpriteSetData>();
            for(int i = 0; i < 16; i++) {
                m_SpriteData.Add(new SpriteSetData(i));
            }
            list_Sprites.DataSource = m_SpriteData;

            StartWRAMListener();
            VBAController.BringToFront();
        }

        private void StartWRAMListener() {
            Timer t = new Timer() { Enabled = true, Interval = Constants.WRamCheckInterval };
            t.Tick += UpdateWRAMFile;

            t = new Timer() { Enabled = true, Interval = Constants.WRamRefreshTime };
            t.Tick += DumpWRAMFile;
        }

        private void DumpWRAMFile(object sender, EventArgs e) {
            if (SessionData.IsAutoTracking) {
                VBAController.MemDump();
            }
        }

        private void UpdateWRAMFile(object sender, EventArgs e) {
            SessionData.Memory.CheckForNewDump();
        }

        private void OnMemoryChanged() {
            listBox1.Items.Clear();
            List<int> keys = SessionData.Memory.MemoryTrackers.Keys.ToList();
            keys.Sort();
            for (int i = 0; i < keys.Count; i++) {
                var tracker = SessionData.Memory.MemoryTrackers[keys[i]];
                if (tracker.Displaying) {
                    listBox1.Items.Add(tracker);
                }
            }
            SessionData.Bot.Update();
            list_Sprites.RefreshItems();

            lbl_TalkingState.Text = SessionData.Bot.Talking.ToString();
        }

        private void UpdateTalking() {
            

            txt_PlayerPositionX.Text = SessionData.Bot.PlayerXPosition.ToString();
            txt_PlayerPositionY.Text = SessionData.Bot.PlayerYPosition.ToString();
            txt_MapID.Text = m_MapIDTracker.LastValue.ToString();
        }

        public bool IsTalking() {
            return m_TalkTrackerA.LastValue != 3 || m_TalkTrackerB.LastValue != 1;
        }

        // List A Remove All
        private void button1_Click(object sender, EventArgs e) {
            foreach (var tracker in listBox1.Items) {
                var mTracker = tracker as MemoryTracker;
                if (mTracker != null) {
                    mTracker.Displaying = false;
                }
            }
            listBox1.Items.Clear();
        }

        // List A Remove
        private void button5_Click(object sender, EventArgs e) {
            if (listBox1.SelectedItem != null) {
                var mTracker = listBox1.SelectedItem as MemoryTracker;
                if (mTracker != null) {
                    mTracker.Displaying = false;
                    OnMemoryChanged();
                }
            }
        }

        // List B Add
        private void button2_Click(object sender, EventArgs e) {
            if (listBox1.SelectedItem != null) {
                var mTracker = listBox1.SelectedItem as MemoryTracker;
                if (mTracker != null) {
                    listBox2.Items.Add(mTracker);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e) {
            if (listBox2.SelectedItem != null) {
                listBox2.Items.Remove(listBox2.SelectedItem);
            }
        }

        private void btn_RemoveChanged_Click(object sender, EventArgs e) {
            for (int i = listBox1.Items.Count - 1; i >= 0; i--) {
                var mTracker = listBox1.Items[i] as MemoryTracker;
                if (mTracker != null) {
                    if (mTracker.Values.Count >= 2) {
                        if (mTracker.Values[mTracker.Values.Count - 2] != mTracker.Values[mTracker.Values.Count - 1]) {
                            mTracker.Displaying = false;
                            listBox1.Items.RemoveAt(i);
                        }
                    }
                }
            }
        }

        private void btn_RemoveSame_Click(object sender, EventArgs e) {
            for (int i = listBox1.Items.Count - 1; i >= 0; i--) {
                var mTracker = listBox1.Items[i] as MemoryTracker;
                if (mTracker != null) {
                    if (mTracker.Values.Count >= 2) {
                        if (mTracker.Values[mTracker.Values.Count - 2] == mTracker.Values[mTracker.Values.Count - 1]) {
                            mTracker.Displaying = false;
                            listBox1.Items.RemoveAt(i);
                        }
                    }
                }
            }
        }

        private void toolStripSplitButton1_ButtonClick(object sender, EventArgs e) {

        }

        private void button4_Click(object sender, EventArgs e) {
            listBox2.Items.Clear();
        }
    }
}
