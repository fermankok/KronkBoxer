using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.IO;

namespace KronkBoxer
{
    public partial class FrmMain : Form
    {
        [DllImport("user32.dll")]
        private static extern
        bool ShowWindowAsync(IntPtr hWnd, int nCmdShow);

        private const int SW_HIDE = 0;
        private const int SW_SHOWNORMAL = 1;
        private const int SW_SHOWMINIMIZED = 2;
        private const int SW_SHOWMAXIMIZED = 3;
        private const int SW_SHOWNOACTIVATE = 4;
        private const int SW_RESTORE = 9;
        private const int SW_SHOWDEFAULT = 10;

        private const int GWL_STYLE = -16;              //hex constant for style changing
        private const int WS_BORDER = 0x00800000;       //window with border
        private const int WS_CAPTION = 0x00C00000;      //window with a title bar
        private const int WS_SYSMENU = 0x00080000;      //window with no borders etc.
        private const int WS_MINIMIZEBOX = 0x00020000;  //window with 

        private static bool ShowWindow(Process _Process, int nCmdShow)
        {
            return ShowWindowAsync(_Process.MainWindowHandle, nCmdShow);
        }
        [DllImport("USER32.DLL")]
        public static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);

        [DllImport("user32.dll", SetLastError = true)]
        private static extern uint SetParent(IntPtr hWndChild, IntPtr hWndNewParent);

        [DllImport("user32.dll")]
        public static extern IntPtr PostMessage(IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam);

        Process process1;
        Process process2;

        public FrmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadProcessInControl("C:/Users/Alec/Desktop/rotmg.swf", this.splitTop.Panel1);
            LoadProcessInControl("C:/Users/Alec/Desktop/rotmg.swf", this.splitTop.Panel2);
            keysToSend.Add((Keys)Enum.Parse(typeof(Keys), "Enter", true));
        }

        public void LoadProcessInControl(string _Process, Control _Control)
        {
            System.Diagnostics.Process p = System.Diagnostics.Process.Start(_Process);
            p.WaitForInputIdle();
            SetParent(p.MainWindowHandle, _Control.Handle);
            

            SetWindowLong(p.MainWindowHandle, GWL_STYLE, WS_SYSMENU);
            ShowWindow(p, SW_SHOWMAXIMIZED);

            if (process1 == null)
                process1 = p;
            else
                process2 = p;
        }

        private void splitContainer1_Panel1_Resize(object sender, EventArgs e)
        {
            if (process1 != null)
            {
                ShowWindow(process1, SW_SHOWNORMAL);
                ShowWindow(process1, SW_SHOWMAXIMIZED);
            }
        }

        static readonly List<Keys> keysToSend = new List<Keys>() { Keys.W, Keys.A, Keys.S, Keys.D };

        const uint WM_KEYDOWN = 0x100;
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (keysToSend.Contains(e.KeyCode))
            {
                PostMessage(process1.MainWindowHandle, WM_KEYDOWN, ((IntPtr)e.KeyCode), (IntPtr)0);
                PostMessage(process2.MainWindowHandle, WM_KEYDOWN, ((IntPtr)e.KeyCode), (IntPtr)0);
            }
        }
        const uint WM_KEYUP = 0x101;
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (keysToSend.Contains(e.KeyCode))
            {
                PostMessage(process1.MainWindowHandle, WM_KEYUP, ((IntPtr)e.KeyCode), (IntPtr)0);
                PostMessage(process2.MainWindowHandle, WM_KEYUP, ((IntPtr)e.KeyCode), (IntPtr)0);
            }
        }

        private void splitContainer1_Panel1_Resize_1(object sender, EventArgs e)
        {
            if (process1 != null)
            {
                ShowWindow(process1, SW_SHOWNORMAL);
                ShowWindow(process1, SW_SHOWMAXIMIZED);
            }
        }

        private void splitContainer1_Panel2_Resize(object sender, EventArgs e)
        {
            if (process2 != null)
            {
                ShowWindow(process2, SW_SHOWNORMAL);
                ShowWindow(process2, SW_SHOWMAXIMIZED);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            process1.Kill();
            process2.Kill();
        }
    }
}
