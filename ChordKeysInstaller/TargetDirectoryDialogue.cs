using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChordKeysInstaller
{
    public partial class TargetDirectoryDialogue : Form
    {
        public bool cancelled = true;
        public string targetDirectory = "";

        public TargetDirectoryDialogue()
        {
            InitializeComponent();
        }

        private void TargetDirectoryInstallButton_Click(object sender, EventArgs e)
        {
            cancelled = false;
            targetDirectory = TargetDirectoryTextBox.Text;
            Close();
        }

        private void TargetDirectoryCancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
