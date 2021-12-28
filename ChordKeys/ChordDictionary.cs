using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace ChordKeys
{
    public class ChordDictionary
    {
        private readonly Dictionary<Tuple<string, string>, string> _dict = new Dictionary<Tuple<string, string>, string>();
        public ChordDictionary()
        {
            string script = Properties.Resources.DefaultChordKeyScript;
            char[] separators = { '\n', '\r' };
            string[] lines = script.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            foreach (string line in lines)
            {
                string x = line[0].ToString();
                string y = line[1].ToString();
                string z = line[4].ToString();
                if (String.Compare(x, y) < 0)
                {
                    _dict.Add(new Tuple<string, string>(x, y), z);
                }
                else
                {
                    _dict.Add(new Tuple<string, string>(y, x), z);
                }
            }
        }

        internal bool GetKeyName(IntPtr lParam, out string name)
        {
            KBDLLHOOKSTRUCT lpval = (KBDLLHOOKSTRUCT)Marshal.PtrToStructure(lParam, typeof(KBDLLHOOKSTRUCT));
            if ((lpval.flags & LLKHF.INJECTED) != 0)
            {
                name = "";
                return false;
            }
            byte[] keyState = new byte[256];
            // Workaround for Windows oddity; GetKeyboardState() gives the wrong results until GetKeyState() is called.
            GetKeyState(0x10);
            if (0 == GetKeyboardState(keyState))
            {
                name = "";
                return false;
            }
            const int buflen = 4;
            byte[] buf = new byte[2 * buflen];
            int ret = ToUnicode(lpval.vk, lpval.sc, keyState, buf, buflen, (LLKHF)0);
            if (ret > 0 && ret < buflen)
            {
                name = Encoding.Unicode.GetString(buf, 0, ret * 2);
                return true;
            }
            name = "";
            return false;
        }
        
        internal bool Lookup(string x, string y, out string z)
        {
            if (String.Compare(x, y) < 0)
            {
                return _dict.TryGetValue(new Tuple<string, string>(x, y), out z);
            }
            else
            {
                return _dict.TryGetValue(new Tuple<string, string>(y, x), out z);
            }
        }

        [DllImport("user32", CharSet = CharSet.Auto)]
        static extern int ToUnicode(VK wVirtKey, SC wScanCode,
                                             byte[] lpKeyState, byte[] pwszBuff,
                                             int cchBuff, LLKHF flags);
        [DllImport("user32", CharSet = CharSet.Auto)]
        public static extern int GetKeyboardState(byte[] lpKeyState);
        [DllImport("user32", CharSet = CharSet.Auto)]
        public static extern short GetKeyState(int nVirtKey);
    }
}

