using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChordKeys
{
    public class HiddenForm : Form
    {
        public HiddenForm()
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Size = new System.Drawing.Size(0, 0);
            this.ShowInTaskbar = false;
            this.Hide();
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
        }
    }
}
