using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace ChordKeys
{
    public static class KeyboardHook
    {
        private const int WH_KEYBOARD_LL = 13;

        private static HookProc _hook;
        private static IntPtr _hookID = IntPtr.Zero;
        private static long _counterInterval = 0;
        private static long _lastCount = 0;
        private static string _lastKeyName = "";
        private static bool _chordHeld = false;
        private static string _chordName = "";
        private static ChordDictionary _dict;

        private delegate int HookProc(int code, WM wParam, IntPtr lParam);

        public static void Init()
        {
            // Set up key hook.
            _hook = HookCallback;
            using (Process curProcess = Process.GetCurrentProcess())
            using (ProcessModule curModule = curProcess.MainModule)
                _hookID = SetWindowsHookEx(WH_KEYBOARD_LL, _hook,
                GetModuleHandle(curModule.ModuleName), 0);

            // Set up timer.
            long targetIntervalMillis = 30;
            double targetFreq = 1000.0 / (double)targetIntervalMillis;
            QueryPerformanceFrequency(out long counterFreq);
            _counterInterval = (long)(counterFreq / targetFreq);
            QueryPerformanceCounter(out _lastCount);
            _dict = new ChordDictionary();
        }

        private static int HookCallback(int code, WM wParam, IntPtr lParam)
        {
            if (code >= 0 && (wParam == WM.KEYDOWN || wParam == WM.KEYUP))
            {
                if (!_dict.GetKeyName(lParam, out string keyName))
                {
                    return CallNextHookEx(_hookID, code, wParam, lParam);
                }
                if (_chordHeld == true && keyName.Equals(_lastKeyName))
                {
                    if (wParam == WM.KEYDOWN)
                    {
                        Output.SendKeyHeld(_chordName);
                    }
                    else
                    {
                        Output.SendKeyUp(_chordName);
                        _chordHeld = false;
                    }
                    return -1;
                }
                if (wParam == WM.KEYDOWN)
                {
                    if (!QueryPerformanceCounter(out long count))
                    {
                        return CallNextHookEx(_hookID, code, wParam, lParam);
                    }
                    if (count - _lastCount <= _counterInterval)
                    {
                        if (_dict.Lookup(keyName, _lastKeyName, out string s))
                        {
                            _lastKeyName = keyName;
                            _chordHeld = true;
                            _chordName = s;
                            Output.SendKeyDown(s);
                            // Return non-zero value to indicate we handled the keystroke.
                            return -1;
                        }
                    }
                    _lastCount = count;
                    _lastKeyName = keyName;
                }
            }
            return CallNextHookEx(_hookID, code, wParam, lParam);
        }

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr SetWindowsHookEx(int idHook,
            HookProc lpfn, IntPtr hMod, uint dwThreadId);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool UnhookWindowsHookEx(IntPtr hhk);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern int CallNextHookEx(IntPtr hhk, int nCode,
            WM wParam, IntPtr lParam);

        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr GetModuleHandle(string lpModuleName);

        [DllImport("Kernel32.dll")]
        private static extern bool QueryPerformanceCounter(out long lpPerformanceCount);

        [DllImport("Kernel32.dll")]
        private static extern bool QueryPerformanceFrequency(out long lpFrequency);
    }
}
