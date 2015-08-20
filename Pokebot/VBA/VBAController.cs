using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pokebot
{
    public class VBAController
    {
        // =-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
        #region Imports
        // =-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=

        [DllImport("USER32.DLL", CharSet = CharSet.Unicode)]
        public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("USER32.DLL")]
        public static extern bool SetForegroundWindow(IntPtr hWnd);

        [DllImport("USER32.DLL")]
        public static extern int GetClassName(IntPtr hWnd, StringBuilder lpClassName, int nMaxCount);

        #endregion

        // =-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
        #region Key Stroke Class
        // =-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=

        public class KeyStroke {
            public char key;
            public bool press;
        }

        #endregion

        // =-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
        #region Vars
        // =-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=

        private const int InputInterval = 40;

        private static Timer m_InputTimer;
        private static List<KeyStroke> m_PendingKeyStrokes = new List<KeyStroke>();

        #endregion

        // =-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
        #region Interface
        // =-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=

        public static void BringToFront()
        {
            WindowsAPI.SwitchWindow(GetVBAWindow());
        }

        public static void UserControl_Left()
        {
            BringToFront();
            QueueUpDown('a');
        }

        public static void UserControl_Up()
        {
            BringToFront();
            QueueUpDown('w');
        }

        public static void UserControl_Right()
        {
            BringToFront();
            QueueUpDown('d');
        }

        public static void UserControl_Down()
        {
            BringToFront();
            QueueUpDown('s');
        }

        public static void UserControl_A()
        {
            BringToFront();
            QueueUpDown('z');
        }

        public static void UserControl_B()
        {
            BringToFront();
            QueueUpDown('x');
        }

        public static void UserControl_Start()
        {
            BringToFront();
            QueueUpDown('m');
        }

        public static void UserControl_Select()
        {
            BringToFront();
            QueueUpDown('n');
        }

        public static void MemDump()
        {
            BringToFront();
            SendKeys.Send(".");
            SendKeys.Flush();
        }

        #endregion

        // =-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
        #region Keystroke Management
        // =-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=

        private static void QueueUpDown(char kKey)
        {
            QueueKey(new KeyStroke() { key = kKey, press = true });
            QueueKey(new KeyStroke() { key = kKey, press = false });
        }

        private static void QueueKey(KeyStroke ks)
        {
            InitKeystrokeTimer();
            m_PendingKeyStrokes.Add(ks);
        }

        private static void InitKeystrokeTimer()
        {
            if (m_InputTimer == null)
            {
                m_InputTimer = new Timer() { Enabled = true, Interval = InputInterval };
                m_InputTimer.Tick += ProcessKeyStroke;
            }
        }

        private static void ProcessKeyStroke(object sender, EventArgs e)
        {
            if(m_PendingKeyStrokes.Count > 0)
            {
                KeyStroke s = m_PendingKeyStrokes[0];
                m_PendingKeyStrokes.RemoveAt(0);
                PressKey(s.key, s.press);
            }
        }


        #endregion

        // =-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
        #region Win32
        // =-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=

        private static void PressKey(char ch, bool press)
        {
            byte vk = WindowsAPI.VkKeyScan(ch);
            ushort scanCode = (ushort)WindowsAPI.MapVirtualKey(vk, 0);
            
            if (press)
                KeyDown(scanCode);
            else
                KeyUp(scanCode);
        }

        private static void KeyDown(ushort scanCode)
        {
            INPUT[] inputs = new INPUT[1];
            inputs[0].type = WindowsAPI.INPUT_KEYBOARD;
            inputs[0].ki.dwFlags = 0;
            inputs[0].ki.wScan = (ushort)(scanCode & 0xff);

            uint intReturn = WindowsAPI.SendInput(1, inputs, System.Runtime.InteropServices.Marshal.SizeOf(inputs[0]));
            if (intReturn != 1)
            {
                throw new Exception("Could not send key: " + scanCode);
            }
            else
            {
                Console.WriteLine("Sent key down: " + scanCode);
            }

        }

        private static void KeyUp(ushort scanCode)
        {
            INPUT[] inputs = new INPUT[1];
            inputs[0].type = WindowsAPI.INPUT_KEYBOARD;
            inputs[0].ki.wScan = scanCode;
            inputs[0].ki.dwFlags = WindowsAPI.KEYEVENTF_KEYUP;
            uint intReturn = WindowsAPI.SendInput(1, inputs, System.Runtime.InteropServices.Marshal.SizeOf(inputs[0]));
            if (intReturn != 1)
            {
                throw new Exception("Could not send key: " + scanCode);
            }
            else
            {
                Console.WriteLine("Sent key up: " + scanCode);
            }
        }

        private static IntPtr GetVBAWindow()
        {
            var processes = Process.GetProcessesByName("VisualBoyAdvance");
            if (processes.Length <= 0)
            {
                Console.WriteLine("Could not find window handle");
            }
            return processes[0].MainWindowHandle;
        }

        #endregion
    }
}
