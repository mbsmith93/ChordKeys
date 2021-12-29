using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration.Install;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace ChordKeys
{
    [RunInstaller(true)]
    public partial class ChordKeysInstaller : System.Configuration.Install.Installer
    {
        public ChordKeysInstaller()
        {
            InitializeComponent();
            this.Committed += new InstallEventHandler(MyInstaller_Committed);
        }
        private void MyInstaller_Committed(object sender, InstallEventArgs e)
        {
            Directory.SetCurrentDirectory(Path.GetDirectoryName
            (Assembly.GetExecutingAssembly().Location));
            Process.Start(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\ChordKeys.exe");
        }
    }
}
