using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sticky_Ghost
{
    public partial class OpenSource : UserControl
    {
        public OpenSource()
        {
            InitializeComponent();
        }

        private void BtnSC_Click(object sender, EventArgs e)
        {
            {
                System.Diagnostics.Process.Start("https://github.com/seizue/Sticky-Ghost");
            }
        }
    }
}
