using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sticky_Ghost
{
    public partial class GeneralSettings : Form
    {
        public GeneralSettings()
        {
            InitializeComponent();
        }

        private void GeneralSettings_Load(object sender, EventArgs e)
        {

        }

        private void BtnSupport_Click(object sender, EventArgs e)
        {
            indicator.Height = BtnSupport.Height;
            indicator.Top = BtnSupport.Top;

            support1.Visible = false;
            support1.BringToFront();
            animator1.ShowSync(support1);
        }

        private void BtnChangeLog_Click(object sender, EventArgs e)
        {
            indicator.Height = BtnChangeLog.Height;
            indicator.Top = BtnChangeLog.Top;

            changeLog1.Visible = false;
            changeLog1.BringToFront();
            animator1.ShowSync(changeLog1);
        }

        private void BtnAbout_Click(object sender, EventArgs e)
        {
            indicator.Height = BtnAbout.Height;
            indicator.Top = BtnAbout.Top;

            about1.Visible = false;
            about1.BringToFront();
            animator1.ShowSync(about1);
        }

        private void BtnOpenSource_Click(object sender, EventArgs e)
        {
            indicator.Height = BtnOpenSource.Height;
            indicator.Top = BtnOpenSource.Top;

            openSource1.Visible = false;
            openSource1.BringToFront();
            animator1.ShowSync(openSource1);
        }

        private void BtnKeepIntouch_Click(object sender, EventArgs e)
        {
            indicator.Height = BtnKeepIntouch.Height;
            indicator.Top = BtnKeepIntouch.Top;

            keepIntouch1.Visible = false;
            keepIntouch1.BringToFront();
            animator1.ShowSync(keepIntouch1);
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Variables for form dragging
        private int mouseStartX, mouseStartY;
        private int formStartX, formStartY;
        private bool isDragging = false;

        private void panel3_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                //Move Form
                this.Location = new Point(formStartX + MousePosition.X - mouseStartX, formStartY + MousePosition.Y - mouseStartY);
            }
        }

        private void panel3_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
          
        }
    

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            mouseStartX = MousePosition.X;
            mouseStartY = MousePosition.Y;
            formStartX = this.Location.X;
            formStartY = this.Location.Y;
            isDragging = true;
        } 
    }
}
