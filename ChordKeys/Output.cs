using System;
using System.Runtime.InteropServices;

namespace ChordKeys
{
    internal static class Output
    {
        internal static void SendKeyDown(string s)
        {
            INPUT[] inputs = new INPUT[]
            {
                new INPUT
                {
                    type = EINPUT.KEYBOARD,
                    U = new UINPUT
                    {
                        ki = new KEYBDINPUT
                        {
                            wVk = (VirtualKeyShort)0x08,  // backspace key code
                            wScan = (ScanCodeShort)0,
                            dwFlags = 0,
                            dwExtraInfo = (UIntPtr)0
                        }
                    }
                },
                new INPUT
                {
                    type = EINPUT.KEYBOARD,
                    U = new UINPUT
                    {
                        ki = new KEYBDINPUT
                        {
                            wVk = (VirtualKeyShort)0x08,  // backspace key code
                            wScan = (ScanCodeShort)0,
                            dwFlags = KEYEVENTF.KEYUP,
                            dwExtraInfo = (UIntPtr)0
                        }
                    }
                },
                new INPUT
                {
                    type = EINPUT.KEYBOARD,
                    U = new UINPUT
                    {
                        ki = new KEYBDINPUT
                        {
                            wVk = 0,
                            wScan = (ScanCodeShort)s[0],
                            dwFlags = KEYEVENTF.UNICODE,
                            dwExtraInfo = (UIntPtr)0
                        }
                    }
                }
            };
            SendInput((uint)inputs.Length, inputs, Marshal.SizeOf(typeof(INPUT)));
        }

        internal static void SendKeyHeld(string s)
        {
            INPUT[] inputs = new INPUT[]
            {
                new INPUT
                {
                    type = EINPUT.KEYBOARD,
                    U = new UINPUT
                    {
                        ki = new KEYBDINPUT
                        {
                            wVk = 0,
                            wScan = (ScanCodeShort)s[0],
                            dwFlags = KEYEVENTF.UNICODE,
                            dwExtraInfo = (UIntPtr)0
                        }
                    }
                }
            };
            SendInput((uint)inputs.Length, inputs, Marshal.SizeOf(typeof(INPUT)));
        }

        internal static void SendKeyUp(string s)
        {
            INPUT[] inputs = new INPUT[]
            {new INPUT
                {
                    type = EINPUT.KEYBOARD,
                    U = new UINPUT
                    {
                        ki = new KEYBDINPUT
                        {
                            wVk = 0,
                            wScan = (ScanCodeShort)s[0],
                            dwFlags = KEYEVENTF.UNICODE | KEYEVENTF.KEYUP,
                            dwExtraInfo = (UIntPtr)0
                        }
                    }
                }
            };
            SendInput((uint)inputs.Length, inputs, Marshal.SizeOf(typeof(INPUT)));
        }

        [DllImport("user32", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern uint SendInput(uint nInputs,
            [MarshalAs(UnmanagedType.LPArray), In] INPUT[] pInputs, int cbSize);
    }
}
