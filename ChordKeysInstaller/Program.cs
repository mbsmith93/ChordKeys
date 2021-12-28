using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChordKeysInstaller
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
            TargetDirectoryDialogue targetDirectoryDialogue = new TargetDirectoryDialogue();
            Application.Run(targetDirectoryDialogue);
            if (targetDirectoryDialogue.cancelled)
            {
                return;
            }
            string targetDirectory = targetDirectoryDialogue.targetDirectory;
            if (targetDirectory[targetDirectory.Length - 1] == '\\')
            {
                targetDirectory = targetDirectory.Substring(0, targetDirectory.Length - 1);
            }
            PleaseWaitDialogue pleaseWaitDialogue = new PleaseWaitDialogue();
            pleaseWaitDialogue.Show();
            System.IO.Directory.CreateDirectory(targetDirectory);
            File.WriteAllBytes(targetDirectory + "\\ChordKeys.exe", Properties.Resources.ChordKeys);
            RegistryKey registryKey = Registry.CurrentUser.OpenSubKey
                ("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            registryKey.SetValue("ChordKeys", targetDirectory + "\\ChordKeys.exe");
            pleaseWaitDialogue.Close();
            FinishDialogue finishDialogue = new FinishDialogue();
            Application.Run(finishDialogue);
        }
    }
}
