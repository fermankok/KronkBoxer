using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Windows.Forms;

namespace KronkBoxer
{
    public static class Native
    {
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

        private const uint WM_KEYDOWN = 0x100;
        private const uint WM_KEYUP = 0x101;

        [DllImport("USER32.DLL")]
        public static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);

        [DllImport("user32.dll", SetLastError = true)]
        private static extern uint SetParent(IntPtr hWndChild, IntPtr hWndNewParent);

        [DllImport("user32.dll")]
        public static extern IntPtr PostMessage(IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam);

        [DllImport("user32.dll")]
        private static extern bool ShowWindowAsync(IntPtr hWnd, int nCmdShow);

        private static bool ShowWindow(Process _Process, int nCmdShow)
        {
            return ShowWindowAsync(_Process.MainWindowHandle, nCmdShow);
        }

        public static Process LoadProcessInControl(string _Process, Control _Control)
        {
            Process p = Process.Start(_Process);
            p.WaitForInputIdle();
            SetParent(p.MainWindowHandle, _Control.Handle);

            SetWindowLong(p.MainWindowHandle, GWL_STYLE, WS_SYSMENU);
            ShowWindow(p, SW_SHOWMAXIMIZED);

            return p;
        }

        public static void ReMaximize(Process p)
        {
            ShowWindow(p, SW_SHOWNORMAL);
            ShowWindow(p, SW_SHOWMAXIMIZED);
        }

        public static void SendUp(Process p, Keys k)
        {
            PostMessage(p.MainWindowHandle, WM_KEYUP, ((IntPtr)k), (IntPtr)0);
        }

        public static void SendDown(Process p, Keys k)
        {
            PostMessage(p.MainWindowHandle, WM_KEYDOWN, ((IntPtr)k), (IntPtr)0);
        }
    }
}
