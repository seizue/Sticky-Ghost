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
    public partial class Notification : Form
    {
        public Notification(string _message, AlertType type)
        {
            InitializeComponent();

            message.Text = _message;
            switch (type)
            {
                case AlertType.success:
                    this.BackColor = Color.FromArgb(0, 179, 147);
                    break;
                case AlertType.info:
                    this.BackColor = Color.FromArgb(74, 84, 89);
                    ProgressBar.BackColor = Color.FromArgb(75, 82, 85);
                    ProgressBar2.BackColor = Color.FromArgb(55, 63, 66);
                    BtnClose.Image = Sticky_Ghost.Properties.Resources.Multiply_24px3;
                    panel1.BackColor = Color.FromArgb(78, 84, 97); //Notification Border #1
                    panel2.BackColor = Color.FromArgb(78, 84, 97); //Notification Border #2
                    panel3.BackColor = Color.FromArgb(78, 84, 97); //Notification Border #3
                    break;
             
             //Reserved//      
                case AlertType.warning:
           
                    break;
             //Reserved//
            }
        }

 
        /// <param name="_message">The message.</param>
        /// <param name="type">The type.</param>
        public static void Show(string message, AlertType type)
        {
            new Sticky_Ghost.Notification(message, type).Show();
        }

        private void Notification_Load(object sender, EventArgs e)
        {
            //set position to top left...
            this.Top = -1 * (this.Height);
            this.Left = Screen.PrimaryScreen.Bounds.Width - this.Width - 60;

            show.Start();
        }

         public enum AlertType
        {
            success, info , warning
        }

        private void timeout_Tick(object sender, EventArgs e)
        {
            closealert.Start();
        }

        int interval = 0;

        private void show_Tick(object sender, EventArgs e)
        {
            

            if (this.Top < 60)
            {
                this.Top += interval; // drop the alert
                interval += 2; // double the speed
            }
            else
            {
                show.Stop();
            }
        }

        private void closealert_Tick(object sender, EventArgs e)
        {
            if (this.Opacity > 0)
            {
                this.Opacity -= 0.2; //reduce opacity to zero
            }
            else
            {
                this.Close(); //then close
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            closealert.Start();
        }

        private void PGtimer_Tick(object sender, EventArgs e)
        {   
            //ProgressBar2 - main ProgressBar
            //Timer for ProgressBar 
            ProgressBar2.Width += 6;

            if (ProgressBar2.Width >= 256)
            {
                closealert.Start();
            }
        }
    }
}

//End of Code 
//Credits to Kim too Flex for his custom alert / notification Tutorial
