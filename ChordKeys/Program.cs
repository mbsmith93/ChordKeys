using System;
using System.Windows.Forms;

namespace ChordKeys
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            KeyboardHook.Init();
            Application.Run();
        }
    }
}
