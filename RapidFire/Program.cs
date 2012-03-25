using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace RapidFire
{
    static class Program
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(long dwFlags, long dx, long dy, long cButtons, long dwExtraInfo);

        public const int MOUSEEVENTF_LEFTDOWN = 0x02;
        public const int MOUSEEVENTF_LEFTUP = 0x04;
        public const int MOUSEEVENTF_RIGHTDOWN = 0x08;
        public const int MOUSEEVENTF_RIGHTUP = 0x10;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain());
        }

        /// <summary>
        /// Clicks the mouse at whatever its current position is
        /// </summary>
        public static void DoMouseClick(bool useLeftButton)
        {
            DoMouseClick(Cursor.Position.X, Cursor.Position.Y, useLeftButton);
        }

        /// <summary>
        /// Clicks the mouse at the specified position
        /// </summary>
        public static void DoMouseClick(int x, int y, bool useLeftButton)
        {
            Cursor.Position = new System.Drawing.Point(x, y);

            if (useLeftButton)
            {
                mouse_event(MOUSEEVENTF_LEFTDOWN, x, y, 0, 0);
                System.Threading.Thread.Sleep(20);
                mouse_event(MOUSEEVENTF_LEFTUP, x, y, 0, 0);
            }
            else
            {
                mouse_event(MOUSEEVENTF_RIGHTDOWN, x, y, 0, 0);
                System.Threading.Thread.Sleep(20);
                mouse_event(MOUSEEVENTF_RIGHTUP, x, y, 0, 0);
            }
        }
    }
}
