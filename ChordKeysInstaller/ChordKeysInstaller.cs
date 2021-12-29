using System.Collections;
using System.ComponentModel;
using System.Diagnostics;

namespace ChordKeysInstaller
{
    [RunInstaller(true)]
    public partial class ChordKeysInstaller : System.Configuration.Install.Installer
    {
        public ChordKeysInstaller()
        {
            InitializeComponent();
        }

        public override void Commit(IDictionary savedState)
        {
            base.Commit(savedState);
            string targetDir = Context.Parameters["TargetDir"];
            Process.Start(targetDir + "\\ChordKeys.exe");
        }
    }
}
