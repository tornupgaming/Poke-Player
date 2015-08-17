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

namespace Pokebot
{
    public partial class Form1 : Form
    {
        private const int WRamRefreshRate = 2000;
        private const int WRamCheckInterval = 5;
        MemoryTools m_MemoryTools;

        MemoryTracker m_TalkTrackerA, m_TalkTrackerB;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            m_MemoryTools = new MemoryTools();
            m_MemoryTools.OnMemoryChanged += OnMemoryChanged;
            m_MemoryTools.CheckForNewDump();

            m_TalkTrackerA = m_MemoryTools.GetTracker(4279);
            m_TalkTrackerB = m_MemoryTools.GetTracker(4952);

            StartWRAMListener();
            VBAController.BringToFront();
        }

        private void StartWRAMListener()
        {
            Timer t = new Timer() { Enabled = true, Interval = WRamCheckInterval };
            t.Tick += UpdateWRAMFile;

            t = new Timer() { Enabled = true, Interval = WRamRefreshRate };
            t.Tick += DumpWRAMFile;
        }

        private void DumpWRAMFile(object sender, EventArgs e)
        {
            VBAController.MemDump();
        }

        private void UpdateWRAMFile(object sender, EventArgs e)
        {
            m_MemoryTools.CheckForNewDump();
        }

        private void OnMemoryChanged()
        {
            listBox1.Items.Clear();
            List<int> keys = m_MemoryTools.MemoryTrackers.Keys.ToList();
            keys.Sort();
            for (int i = 0; i < keys.Count; i++)
            {
                var tracker = m_MemoryTools.MemoryTrackers[keys[i]];
                if (tracker.Displaying)
                {
                    listBox1.Items.Add(tracker);
                }
            }
            UpdateTalking();
        }

        private void UpdateTalking()
        {
            if (IsTalking())
            {
                //VBAController.UserControl_A();
            }
        }

        public bool IsTalking()
        {
            return m_TalkTrackerA.LastValue != 3 || m_TalkTrackerB.LastValue != 1;
        }

        // List A Remove All
        private void button1_Click(object sender, EventArgs e)
        {
            foreach (var tracker in listBox1.Items)
            {
                var mTracker = tracker as MemoryTracker;
                if (mTracker != null)
                {
                    mTracker.Displaying = false;
                }
            }
            listBox1.Items.Clear();
        }

        // List A Remove
        private void button5_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                var mTracker = listBox1.SelectedItem as MemoryTracker;
                if (mTracker != null)
                {
                    mTracker.Displaying = false;
                    OnMemoryChanged();
                }
            }
        }

        // List B Add
        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                var mTracker = listBox1.SelectedItem as MemoryTracker;
                if (mTracker != null)
                {
                    listBox2.Items.Add(mTracker);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedItem != null)
            {
                listBox2.Items.Remove(listBox2.SelectedItem);
            }
        }

        private void btn_RemoveChanged_Click(object sender, EventArgs e)
        {
            for(int i = listBox1.Items.Count - 1; i >= 0; i--)
            {
                var mTracker = listBox1.Items[i] as MemoryTracker;
                if (mTracker != null)
                {
                    if(mTracker.Values.Count >= 2)
                    {
                        if(mTracker.Values[mTracker.Values.Count - 2] != mTracker.Values[mTracker.Values.Count - 1])
                        {
                            mTracker.Displaying = false;
                            listBox1.Items.RemoveAt(i);
                        }
                    }
                }
            }
        }

        private void btn_RemoveSame_Click(object sender, EventArgs e)
        {
            for (int i = listBox1.Items.Count - 1; i >= 0; i--)
            {
                var mTracker = listBox1.Items[i] as MemoryTracker;
                if (mTracker != null)
                {
                    if (mTracker.Values.Count >= 2)
                    {
                        if (mTracker.Values[mTracker.Values.Count - 2] == mTracker.Values[mTracker.Values.Count - 1])
                        {
                            mTracker.Displaying = false;
                            listBox1.Items.RemoveAt(i);
                        }
                    }
                }
            }
        }

        private void toolStripSplitButton1_ButtonClick(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
        }
    }
}
