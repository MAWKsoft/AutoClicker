using System;
using System.Runtime.InteropServices;

namespace AutoClicker
{
    internal class HotKey
    {
        [DllImport("user32.dll")]
        public static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vlc);

        [DllImport("user32.dll")]
        public static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        public const int VK_F1 = 0x70;
        public const int VK_F2 = 0x71;
        public const int VK_F5 = 0x74;

        // List of virtual key codes
        // https://docs.microsoft.com/en-us/windows/win32/inputdev/virtual-key-codes

    }
}