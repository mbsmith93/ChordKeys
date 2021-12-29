using Microsoft.Win32;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChordKeysUninstaller
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            RegistryKey registryKey = Registry.CurrentUser.OpenSubKey
                ("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            string exeLocation = (string)registryKey.GetValue("ChordKeys");
            string installationDirectory = Path.GetDirectoryName(exeLocation);
            Directory.Delete(installationDirectory, true);
            registryKey.DeleteValue("ChordKeys", false);
            Application.Run(new FinishDialogue());
        }
    }
}
