using System;
using System.Runtime.InteropServices;

namespace ChordKeys
{
    internal enum WM : int
    {
        INPUTLANGCHANGEREQUEST = 0x50,
        KEYDOWN = 0x100,
        KEYUP = 0x101,
        CHAR = 0x102,
        SYSKEYDOWN = 0x104,
        SYSKEYUP = 0x105,
        MOUSEMOVE = 0x200,
        MOUSELEAVE = 0x2A3,
    };

    internal enum EINPUT : uint
    {
        MOUSE = 0,
        KEYBOARD = 1,
        HARDWARE = 2,
    }

    [Flags]
    internal enum KEYEVENTF : uint
    {
        EXTENDEDKEY = 0x0001,
        KEYUP = 0x0002,
        UNICODE = 0x0004,
        SCANCODE = 0x0008,
    }

    [Flags]
    internal enum MOUSEEVENTF : uint
    {
        // Not needed
    }

    internal enum VirtualKeyShort : short
    {
    }

    internal enum ScanCodeShort : short
    {
    }

    [StructLayout(LayoutKind.Sequential)]
    internal struct INPUT
    {
        internal EINPUT type;
        internal UINPUT U;
    }

    [StructLayout(LayoutKind.Explicit)]
    internal struct UINPUT
    {
        // All union members need to be included, because they contribute
        // to the final size of struct INPUT.
        [FieldOffset(0)]
        internal MOUSEINPUT mi;
        [FieldOffset(0)]
        internal KEYBDINPUT ki;
        [FieldOffset(0)]
        internal HARDWAREINPUT hi;
    }

    [StructLayout(LayoutKind.Sequential)]
    internal struct MOUSEINPUT
    {
        internal int dx, dy, mouseData;
        internal MOUSEEVENTF dwFlags;
        internal uint time;
        internal UIntPtr dwExtraInfo;
    }

    [StructLayout(LayoutKind.Sequential)]
    internal struct KEYBDINPUT
    {
        internal VirtualKeyShort wVk;
        internal ScanCodeShort wScan;
        internal KEYEVENTF dwFlags;
        internal int time;
        internal UIntPtr dwExtraInfo;
    }

    [StructLayout(LayoutKind.Sequential)]
    internal struct HARDWAREINPUT
    {
        internal int uMsg;
        internal short wParamL, wParamH;
    }

    public enum VK : int
    {
    }

    internal enum SC : uint
    {
    };

    [Flags]
    internal enum LLKHF : uint
    {
        EXTENDED = 0x01,
        LOWER_IL_INJECTED = 0x02,
        INJECTED = 0x10,
        ALTDOWN = 0x20,
        UP = 0x80,
    };

    [StructLayout(LayoutKind.Sequential)]
    internal struct KBDLLHOOKSTRUCT
    {
        internal VK vk;
        public SC sc;
        public LLKHF flags;
        public int time;
        public IntPtr dwExtraInfo;
    }

}
