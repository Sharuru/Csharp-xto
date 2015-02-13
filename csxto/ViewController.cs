using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace ViewController
{
    public class ViewController
    {
        public static readonly int HWND_BROADCAST = 0xffff;
        public static readonly int WM_SHOWME = RegisterWindowMessage("WM_SHOWME");

        [DllImport("user32.dll")]
        public static extern int RegisterWindowMessage(string message);

        [DllImport("user32.dll")]
        public static extern bool PostMessage(IntPtr hwnd, int msg, IntPtr wparam, IntPtr lparam);

    }
}
