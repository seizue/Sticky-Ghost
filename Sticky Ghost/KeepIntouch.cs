﻿using System;
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
    public partial class KeepIntouch : UserControl
    {
        public KeepIntouch()
        {
            InitializeComponent();
        }

        private void BtnGithub_Click(object sender, EventArgs e)
        {
            {
                System.Diagnostics.Process.Start("https://github.com/seizue");
            }
        }
    }
}
