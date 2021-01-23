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
    public partial class Main : Form
    {
       
        public Main()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.ResizeRedraw, true);
        }


        const uint WM_NCHITTEST = 0x0084, WM_MOUSEMOVE = 0x0200,
                    HTLEFT = 10, HTRIGHT = 11, HTBOTTOMRIGHT = 17,
                    HTBOTTOM = 15, HTBOTTOMLEFT = 16, HTTOP = 12,
                    HTTOPLEFT = 13, HTTOPRIGHT = 14;
        Size formSize;
        Point screenPoint;
        Point clientPoint;
        Dictionary<uint, Rectangle> boxes;
        const int RHS = 10; // RESIZE_HANDLE_SIZE
        bool handled;

        protected override void WndProc(ref Message m)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                base.WndProc(ref m);
                return;
            }

            handled = false;
            if (m.Msg == WM_NCHITTEST || m.Msg == WM_MOUSEMOVE)
            {
                formSize = this.Size;
                screenPoint = new Point(m.LParam.ToInt32());
                clientPoint = this.PointToClient(screenPoint);

                boxes = new Dictionary<uint, Rectangle>() {
                {HTBOTTOMLEFT, new Rectangle(0, formSize.Height - RHS, RHS, RHS)},
                {HTBOTTOM, new Rectangle(RHS, formSize.Height - RHS, formSize.Width - 2*RHS, RHS)},
                {HTBOTTOMRIGHT, new Rectangle(formSize.Width - RHS, formSize.Height - RHS, RHS, RHS)},
                {HTRIGHT, new Rectangle(formSize.Width - RHS, RHS, RHS, formSize.Height - 2*RHS)},
                {HTTOPRIGHT, new Rectangle(formSize.Width - RHS, 0, RHS, RHS) },
                {HTTOP, new Rectangle(RHS, 0, formSize.Width - 2*RHS, RHS) },
                {HTTOPLEFT, new Rectangle(0, 0, RHS, RHS) },
                {HTLEFT, new Rectangle(0, RHS, RHS, formSize.Height - 2*RHS) }
            };

                foreach (var hitBox in boxes)
                {
                    if (hitBox.Value.Contains(clientPoint))
                    {
                        m.Result = (IntPtr)hitBox.Key;
                        handled = true;
                        break;
                    }
                }
            }

            if (!handled)
                base.WndProc(ref m);
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            //Close the  Application
            this.Close();
        }

        private void BtnMaximize_Click(object sender, EventArgs e)
        {

            //Makes the Application in Maximized State
            if (WindowState == FormWindowState.Normal)
            {
                this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
                this.WindowState = FormWindowState.Maximized;

            }
            else
            {
                //Brings back the application in Normal State
                WindowState = FormWindowState.Normal;        
            }
        }

        private void BtnMinimize_Click(object sender, EventArgs e)
        {

            //Makes the application in Minimized State
            this.WindowState = FormWindowState.Minimized;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            //Properties.Settings.Default.Save();
            CurrentFont = Settings.currentfont;
            txtText.Text = Properties.Settings.Default.textName;
            reloadPreviousLocation();
            PanelTopColor.BackColor = Properties.Settings.Default.myColor;
            this.Width = Properties.Settings.Default.WindowWidth;
            this.Height = Properties.Settings.Default.WindowHeight;
            PanelNavbar.BackColor = Properties.Settings.Default.PanelNavbarTheme;
            this.BackColor = Properties.Settings.Default.Main;
            txtText.BackColor = Properties.Settings.Default.TextColor;
            Navbarline.BackColor = Properties.Settings.Default.NavbarLineColor;

            WDBorder1.BackColor = Properties.Settings.Default.WDBorder1Color;
            WDBorder2.BackColor = Properties.Settings.Default.WDBorder2Color;
            WDBorder3.BackColor = Properties.Settings.Default.WDBorder3Color;

            NavbarSideline1.BackColor = Properties.Settings.Default.NavbarSideline1Color;
            NavbarSideline2.BackColor = Properties.Settings.Default.NavbarSideline2Color;

            panelSepa1.BackColor = Properties.Settings.Default.panelSepa;
            panelSepa2.BackColor = Properties.Settings.Default.panelSepa;
            panelSepa3.BackColor = Properties.Settings.Default.panelSepa;
            panelSepa4.BackColor = Properties.Settings.Default.panelSepa;

            BtnMinimize.BackColor = Properties.Settings.Default.BtnMinimize_BC;
            BtnMinimize.IdleLineColor = Properties.Settings.Default.BtnMinimize_ILC;
            BtnMinimize.IdleFillColor = Properties.Settings.Default.BtnClose_IFC;
            BtnMinimize.ActiveLineColor = Properties.Settings.Default.BtnMinimize_ALC;

            BtnClose.BackColor = Properties.Settings.Default.BtnClose_BC;
            BtnClose.IdleLineColor = Properties.Settings.Default.BtnClose_ILC;
            BtnClose.IdleFillColor = Properties.Settings.Default.BtnClose_IFC;
            BtnClose.ActiveLineColor = Properties.Settings.Default.BtnClose_ALC;
            txtText.ForeColor = Properties.Settings.Default.FontColor;

            PanelMenu.BackColor = Properties.Settings.Default.PanelMenu;
            COPanel.BackColor = Properties.Settings.Default.COPanel;
            PanelTheme.BackColor = Properties.Settings.Default.PanelTheme;

            BtnPin.Normalcolor = Properties.Settings.Default.BtnNormalCo;
            BtnPin.Activecolor = Properties.Settings.Default.BtnActiveCo;
            BtnPin.OnHovercolor = Properties.Settings.Default.BtnOnhoverCo;
            BtnPin.Textcolor = Properties.Settings.Default.BtnTextCo;
            BtnPin.OnHoverTextColor = Properties.Settings.Default.BtnOnhoverTextCo;

            BtnChangeColor.Normalcolor = Properties.Settings.Default.BtnNormalCo;
            BtnChangeColor.Activecolor = Properties.Settings.Default.BtnActiveCo;
            BtnChangeColor.OnHovercolor = Properties.Settings.Default.BtnOnhoverCo;
            BtnChangeColor.Textcolor = Properties.Settings.Default.BtnTextCo;
            BtnChangeColor.OnHoverTextColor = Properties.Settings.Default.BtnOnhoverTextCo;

            BtnCO.Normalcolor = Properties.Settings.Default.BtnNormalCo;
            BtnCO.Activecolor = Properties.Settings.Default.BtnActiveCo;
            BtnCO.OnHovercolor = Properties.Settings.Default.BtnOnhoverCo;
            BtnCO.Textcolor = Properties.Settings.Default.BtnTextCo;
            BtnCO.OnHoverTextColor = Properties.Settings.Default.BtnOnhoverTextCo;

            BtnFont.Normalcolor = Properties.Settings.Default.BtnNormalCo;
            BtnFont.Activecolor = Properties.Settings.Default.BtnActiveCo;
            BtnFont.OnHovercolor = Properties.Settings.Default.BtnOnhoverCo;
            BtnFont.Textcolor = Properties.Settings.Default.BtnTextCo;
            BtnFont.OnHoverTextColor = Properties.Settings.Default.BtnOnhoverTextCo;

            BtnOpenFile.Normalcolor = Properties.Settings.Default.BtnNormalCo;
            BtnOpenFile.Activecolor = Properties.Settings.Default.BtnActiveCo;
            BtnOpenFile.OnHovercolor = Properties.Settings.Default.BtnOnhoverCo;
            BtnOpenFile.Textcolor = Properties.Settings.Default.BtnTextCo;
            BtnOpenFile.OnHoverTextColor = Properties.Settings.Default.BtnOnhoverTextCo;

            BtnSaveAs.Normalcolor = Properties.Settings.Default.BtnNormalCo;
            BtnSaveAs.Activecolor = Properties.Settings.Default.BtnActiveCo;
            BtnSaveAs.OnHovercolor = Properties.Settings.Default.BtnOnhoverCo;
            BtnSaveAs.Textcolor = Properties.Settings.Default.BtnTextCo;
            BtnSaveAs.OnHoverTextColor = Properties.Settings.Default.BtnOnhoverTextCo;

            BtnSettings.Normalcolor = Properties.Settings.Default.BtnNormalCo;
            BtnSettings.Activecolor = Properties.Settings.Default.BtnActiveCo;
            BtnSettings.OnHovercolor = Properties.Settings.Default.BtnOnhoverCo;
            BtnSettings.Textcolor = Properties.Settings.Default.BtnTextCo;
            BtnSettings.OnHoverTextColor = Properties.Settings.Default.BtnOnhoverTextCo;

            BtnTheme.Normalcolor = Properties.Settings.Default.BtnNormalCo;
            BtnTheme.Activecolor = Properties.Settings.Default.BtnActiveCo;
            BtnTheme.OnHovercolor = Properties.Settings.Default.BtnOnhoverCo;
            BtnTheme.Textcolor = Properties.Settings.Default.BtnTextCo;
            BtnTheme.OnHoverTextColor = Properties.Settings.Default.BtnOnhoverTextCo;

            ButtonDT.Normalcolor = Properties.Settings.Default.BtnNormalCo;
            ButtonDT.Activecolor = Properties.Settings.Default.BtnActiveCo;
            ButtonDT.OnHovercolor = Properties.Settings.Default.BtnOnhoverCo;
            ButtonDT.Textcolor = Properties.Settings.Default.BtnTextCo;
            ButtonDT.OnHoverTextColor = Properties.Settings.Default.BtnOnhoverTextCo;

            ButtonWD.Normalcolor = Properties.Settings.Default.BtnNormalCo;
            ButtonWD.Activecolor = Properties.Settings.Default.BtnActiveCo;
            ButtonWD.OnHovercolor = Properties.Settings.Default.BtnOnhoverCo;
            ButtonWD.Textcolor = Properties.Settings.Default.BtnTextCo;
            ButtonWD.OnHoverTextColor = Properties.Settings.Default.BtnOnhoverTextCo;

            BtnCloseCO.BackColor = Properties.Settings.Default.BtnClose_BC;
            BtnCloseCO.IdleLineColor = Properties.Settings.Default.BtnClose_ILC;
            BtnCloseCO.IdleFillColor = Properties.Settings.Default.BtnClose_IFC;
            BtnCloseCO.ActiveLineColor = Properties.Settings.Default.BtnClose_ALC;

            BtnThemeOptionClose.BackColor = Properties.Settings.Default.BtnClose_BC;
            BtnThemeOptionClose.IdleLineColor = Properties.Settings.Default.BtnClose_ILC;
            BtnThemeOptionClose.IdleFillColor = Properties.Settings.Default.BtnClose_IFC;
            BtnThemeOptionClose.ActiveLineColor = Properties.Settings.Default.BtnClose_ALC;

            panelMenuBorder1.BackColor = Properties.Settings.Default.panelSepa;
            panelMenuBorder2.BackColor = Properties.Settings.Default.panelSepa;
            panelMenuBorder3.BackColor = Properties.Settings.Default.panelSepa;
            panelMenuBorder4.BackColor = Properties.Settings.Default.panelSepa;

            panelCOBorder1.BackColor = Properties.Settings.Default.panelSepa;
            panelCOBorder2.BackColor = Properties.Settings.Default.panelSepa;
            panelCOBorder3.BackColor = Properties.Settings.Default.panelSepa;

            panelCOSeparator1.BackColor = Properties.Settings.Default.panelSepa;
            panelCOSeparator2.BackColor = Properties.Settings.Default.panelSepa;

            panelThemeMainSepa.BackColor = Properties.Settings.Default.panelSepa;
            panelThemeSepa.BackColor = Properties.Settings.Default.panelSepa;

            panelTOBorder1.BackColor = Properties.Settings.Default.panelSepa;
            panelTOBorder2.BackColor = Properties.Settings.Default.panelSepa;
            panelTOBorder3.BackColor = Properties.Settings.Default.panelSepa;
        }


        private void reloadPreviousLocation()
        {
            //allowing us to reload the previous location of the app
            if ((ModifierKeys & Keys.Shift) == 0)
            {
                string initLocation = Properties.Settings.Default.InitialLocation;
                Point il = new Point(0, 0);

                {
                    string[] parts = initLocation.Split(',');
                    if (parts.Length >= 2)
                    {
                        il = new Point(int.Parse(parts[0]), int.Parse(parts[1]));
                    }

                }

                Location = il;
            }

        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Act as a Triger to save the changes in the app into default. 
            if ((ModifierKeys & Keys.Shift) == 0)
            {
                Point location = Location;

                if (WindowState != FormWindowState.Normal)
                {
                    location = RestoreBounds.Location;

                }
                string initLocation = string.Join(",", location.X, location.Y);
                Properties.Settings.Default.InitialLocation = initLocation;
                Properties.Settings.Default.Save();
            }
        }

        private void BtnSaveAs_Click(object sender, EventArgs e)
        {
            //Shows save file dialog in order to save the file
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Text Files(*.txt) |*.txt";
            if (save.ShowDialog() == DialogResult.OK)
            {
                System.IO.StreamWriter sw = new System.IO.StreamWriter(save.FileName);
                sw.Write(txtText.Text);
                sw.Close();
                Notification.Show(" File has been saved!", Notification.AlertType.success);
            }

            else
            {
                Notification.Show(" No file has been save!", Notification.AlertType.info);
            }

        }

        private void BtnPin_Click(object sender, EventArgs e)
        {
            //Minimize or bring the width of the panel menu into 0, incase they want to bring back the app on Top of all forms

            if (PanelMenu.Width == 270)
            {
                PanelMenu.Visible = false;
             
                PanelMenu.Width = 0;
            }

            authenticateForm();
        }

        private void authenticateForm()
        {
            //Authentication for allowing us to Pinned or bring back the App into Top of all forms
            if (Properties.Settings.Default.formTop != true)
            {
                Properties.Settings.Default.formTop = true;
                Properties.Settings.Default.Save();
                this.TopMost = Properties.Settings.Default.formTop;
                Notification.Show("Sticky Ghost has been pinned!", Notification.AlertType.success);
                BtnPin.ButtonText = "     Unpin sticky note";
               
            }
            else
            {
                Properties.Settings.Default.formTop = false;
                Properties.Settings.Default.Save();
                this.TopMost = Properties.Settings.Default.formTop;
                Notification.Show("Sticky Ghost has been unpinned!", Notification.AlertType.info);
                BtnPin.ButtonText = "     Pin sticky note";
            }

        }

        private void BtnChangeColor_Click(object sender, EventArgs e)
        {
            //Shows the Color options for upbar
            if (cDialog.ShowDialog() == DialogResult.OK)
            {
                PanelTopColor.BackColor = cDialog.Color;
                Properties.Settings.Default.myColor = cDialog.Color;
                Properties.Settings.Default.Save();
                Notification.Show("Upbar color has been changed!", Notification.AlertType.success);
            }

            else
            {
                Notification.Show("No changes has been made!", Notification.AlertType.info);
            }

            COPanel.Visible = false;
            COPanel.Width = 0;
            PanelMenu.Visible = false;
            PanelMenu.Width = 0;
            PanelTheme.Visible = false;
            PanelTheme.Width = 0;
        }

        private void BtnMenu_Click(object sender, EventArgs e)
        {
            //Makes the Panel Menu into 270 width
            if (PanelMenu.Width == 0)
            {
                PanelMenu.Visible = false;
                PanelMenu.Width = 270;
                PanelAnimator.ShowSync(PanelMenu);
             
            }
            else
            {
                //Brings back the Panel Menu into 0 width
                PanelMenu.Visible = false;
                PanelMenu.Width = 0;
                COPanel.Visible = false;
                COPanel.Width = 0;
            }
        }
    


        private void txtText_TextChanged(object sender, EventArgs e)
        {
            //Save the data's into default once the user start writing in text area
            Properties.Settings.Default.textName = txtText.Text;
            Properties.Settings.Default.Save();
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            
            Properties.Settings.Default.textName = txtText.Text;
            Properties.Settings.Default.WindowWidth = this.Width;
            Properties.Settings.Default.WindowHeight = this.Height;
            Properties.Settings.Default.PanelNavbarTheme = PanelNavbar.BackColor;
            Properties.Settings.Default.Main = this.BackColor;
            Properties.Settings.Default.TextColor = txtText.BackColor;
            Properties.Settings.Default.NavbarLineColor = Navbarline.BackColor;

            Properties.Settings.Default.WDBorder1Color = WDBorder1.BackColor;
            Properties.Settings.Default.WDBorder2Color = WDBorder2.BackColor;
            Properties.Settings.Default.WDBorder3Color = WDBorder3.BackColor;

            Properties.Settings.Default.NavbarSideline1Color = NavbarSideline1.BackColor;
            Properties.Settings.Default.NavbarSideline2Color = NavbarSideline2.BackColor;

            Properties.Settings.Default.BtnMinimize_BC = BtnMinimize.BackColor;
            Properties.Settings.Default.BtnMinimize_ILC = BtnMinimize.IdleLineColor;
            Properties.Settings.Default.BtnMinimize_IFC = BtnMinimize.IdleFillColor;
            Properties.Settings.Default.BtnMinimize_ALC = BtnMinimize.ActiveLineColor;

            Properties.Settings.Default.BtnClose_BC = BtnClose.BackColor;
            Properties.Settings.Default.BtnClose_ILC = BtnClose.IdleLineColor;
            Properties.Settings.Default.BtnClose_IFC = BtnClose.IdleFillColor;
            Properties.Settings.Default.BtnClose_ALC = BtnClose.ActiveLineColor;

            Properties.Settings.Default.PanelMenu = PanelMenu.BackColor;
            Properties.Settings.Default.COPanel = COPanel.BackColor;
            Properties.Settings.Default.PanelTheme = PanelTheme.BackColor;

            Properties.Settings.Default.BtnNormalCo = BtnPin.Normalcolor;
            Properties.Settings.Default.BtnActiveCo = BtnPin.Activecolor;
            Properties.Settings.Default.BtnOnhoverCo = BtnPin.OnHovercolor;
            Properties.Settings.Default.BtnTextCo = BtnPin.Textcolor;
            Properties.Settings.Default.BtnOnhoverTextCo = BtnPin.OnHoverTextColor;

            Properties.Settings.Default.BtnNormalCo = BtnCO.Normalcolor;
            Properties.Settings.Default.BtnActiveCo = BtnCO.Activecolor;
            Properties.Settings.Default.BtnOnhoverCo = BtnCO.OnHovercolor;
            Properties.Settings.Default.BtnTextCo = BtnCO.Textcolor;
            Properties.Settings.Default.BtnOnhoverTextCo = BtnCO.OnHoverTextColor;

            Properties.Settings.Default.BtnNormalCo = BtnChangeColor.Normalcolor;
            Properties.Settings.Default.BtnActiveCo = BtnChangeColor.Activecolor;
            Properties.Settings.Default.BtnOnhoverCo = BtnChangeColor.OnHovercolor;
            Properties.Settings.Default.BtnTextCo = BtnChangeColor.Textcolor;
            Properties.Settings.Default.BtnOnhoverTextCo = BtnChangeColor.OnHoverTextColor;

            Properties.Settings.Default.BtnNormalCo = BtnFont.Normalcolor;
            Properties.Settings.Default.BtnActiveCo = BtnFont.Activecolor;
            Properties.Settings.Default.BtnOnhoverCo = BtnFont.OnHovercolor;
            Properties.Settings.Default.BtnTextCo = BtnFont.Textcolor;
            Properties.Settings.Default.BtnOnhoverTextCo = BtnFont.OnHoverTextColor;

            Properties.Settings.Default.BtnNormalCo = BtnOpenFile.Normalcolor;
            Properties.Settings.Default.BtnActiveCo = BtnOpenFile.Activecolor;
            Properties.Settings.Default.BtnOnhoverCo = BtnOpenFile.OnHovercolor;
            Properties.Settings.Default.BtnTextCo = BtnOpenFile.Textcolor;
            Properties.Settings.Default.BtnOnhoverTextCo = BtnOpenFile.OnHoverTextColor;

            Properties.Settings.Default.BtnNormalCo = BtnSaveAs.Normalcolor;
            Properties.Settings.Default.BtnActiveCo = BtnSaveAs.Activecolor;
            Properties.Settings.Default.BtnOnhoverCo = BtnSaveAs.OnHovercolor;
            Properties.Settings.Default.BtnTextCo = BtnSaveAs.Textcolor;
            Properties.Settings.Default.BtnOnhoverTextCo = BtnSaveAs.OnHoverTextColor;

            Properties.Settings.Default.BtnNormalCo = BtnSettings.Normalcolor;
            Properties.Settings.Default.BtnActiveCo = BtnSettings.Activecolor;
            Properties.Settings.Default.BtnOnhoverCo = BtnSettings.OnHovercolor;
            Properties.Settings.Default.BtnTextCo = BtnSettings.Textcolor;
            Properties.Settings.Default.BtnOnhoverTextCo = BtnSettings.OnHoverTextColor;

            Properties.Settings.Default.BtnNormalCo = BtnTheme.Normalcolor;
            Properties.Settings.Default.BtnActiveCo = BtnTheme.Activecolor;
            Properties.Settings.Default.BtnOnhoverCo = BtnTheme.OnHovercolor;
            Properties.Settings.Default.BtnTextCo = BtnTheme.Textcolor;
            Properties.Settings.Default.BtnOnhoverTextCo = BtnTheme.OnHoverTextColor;

            Properties.Settings.Default.BtnNormalCo = ButtonDT.Normalcolor;
            Properties.Settings.Default.BtnActiveCo = ButtonDT.Activecolor;
            Properties.Settings.Default.BtnOnhoverCo = ButtonDT.OnHovercolor;
            Properties.Settings.Default.BtnTextCo = ButtonDT.Textcolor;
            Properties.Settings.Default.BtnOnhoverTextCo = ButtonDT.OnHoverTextColor;

            Properties.Settings.Default.BtnNormalCo = ButtonWD.Normalcolor;
            Properties.Settings.Default.BtnActiveCo = ButtonWD.Activecolor;
            Properties.Settings.Default.BtnOnhoverCo = ButtonWD.OnHovercolor;
            Properties.Settings.Default.BtnTextCo = ButtonWD.Textcolor;
            Properties.Settings.Default.BtnOnhoverTextCo = ButtonWD.OnHoverTextColor;

            Properties.Settings.Default.BtnClose_BC = BtnCloseCO.BackColor;
            Properties.Settings.Default.BtnClose_ILC = BtnCloseCO.IdleLineColor;
            Properties.Settings.Default.BtnClose_IFC = BtnCloseCO.IdleFillColor;
            Properties.Settings.Default.BtnClose_ALC = BtnCloseCO.ActiveLineColor;

            Properties.Settings.Default.BtnClose_BC = BtnThemeOptionClose.BackColor;
            Properties.Settings.Default.BtnClose_ILC = BtnThemeOptionClose.IdleLineColor;
            Properties.Settings.Default.BtnClose_IFC = BtnThemeOptionClose.IdleFillColor;
            Properties.Settings.Default.BtnClose_ALC = BtnThemeOptionClose.ActiveLineColor;

            Properties.Settings.Default.panelSepa = panelMenuBorder1.BackColor;
            Properties.Settings.Default.panelSepa = panelMenuBorder2.BackColor;
            Properties.Settings.Default.panelSepa = panelMenuBorder3.BackColor;
            Properties.Settings.Default.panelSepa = panelMenuBorder4.BackColor;

            Properties.Settings.Default.panelSepa = panelSepa1.BackColor;
            Properties.Settings.Default.panelSepa = panelSepa2.BackColor;
            Properties.Settings.Default.panelSepa = panelSepa3.BackColor;
            Properties.Settings.Default.panelSepa = panelSepa4.BackColor;

            Properties.Settings.Default.panelSepa = panelCOBorder1.BackColor;
            Properties.Settings.Default.panelSepa = panelCOBorder2.BackColor;
            Properties.Settings.Default.panelSepa = panelCOBorder3.BackColor;

            Properties.Settings.Default.panelSepa = panelCOSeparator1.BackColor;
            Properties.Settings.Default.panelSepa = panelCOSeparator1.BackColor;

            Properties.Settings.Default.panelSepa = panelThemeMainSepa.BackColor;
            Properties.Settings.Default.panelSepa = panelThemeSepa.BackColor;

            Properties.Settings.Default.panelSepa = panelTOBorder1.BackColor;
            Properties.Settings.Default.panelSepa = panelTOBorder2.BackColor;
            Properties.Settings.Default.panelSepa = panelTOBorder3.BackColor;

            Properties.Settings.Default.FontColor = txtText.ForeColor;
            
            Properties.Settings.Default.Save();
          
        }

        private void BtnSettings_Click(object sender, EventArgs e)
        {
            
            GeneralSettings f2 = new GeneralSettings();
            f2.ShowDialog();

            COPanel.Visible = false;
            COPanel.Width = 0;
            PanelMenu.Visible = false;
            PanelMenu.Width = 0;
            PanelTheme.Visible = false;
            PanelTheme.Width = 0;
        }

    

        private void BtnFont_Click(object sender, EventArgs e)
        {
            //Changes Font, Font Style and Font Size according to user preferrence
            var FontDialog = new FontDialog();
            FontDialog.Font = CurrentFont;
            if (FontDialog.ShowDialog(this) != DialogResult.OK) return;
            CurrentFont = FontDialog.Font;
            Notification.Show("Font has been changed!", Notification.AlertType.success);
            
            COPanel.Visible = false;
            COPanel.Width = 0;
            PanelMenu.Visible = false;
            PanelMenu.Width = 0;
            PanelTheme.Visible = false;
            PanelTheme.Width = 0;
        }

        //For Font Option
        private static Properties.Settings Settings
        {
            get { return Properties.Settings.Default; }

        }

        private void PanelNavbar_MouseHover(object sender, EventArgs e)
        {
            COPanel.Visible = false;
            COPanel.Width = 0;
            PanelMenu.Visible = false;
            PanelMenu.Width = 0;
            PanelTheme.Visible = false;
            PanelTheme.Width = 0;
        }

        private Font CurrentFont
        {
            get
            {
                return Settings.currentfont;
            }
            set
            {
                txtText.Font = Settings.currentfont = value;
                Settings.Save();

            }
        }

        private void BtnCO_Click(object sender, EventArgs e)
        {
            COPanel.Visible = true;
            COPanel.Width = 270;
        }

        private void BtnCloseCO_Click(object sender, EventArgs e)
        {
            COPanel.Visible = false;
            COPanel.Width = 0;
        }

        private void BtnTheme_Click(object sender, EventArgs e)
        {
            COPanel.Visible = false;
            COPanel.Width = 0;
            PanelMenu.Visible = false;
            PanelMenu.Width = 0;
            PanelTheme.Visible = true;
            PanelTheme.Width = 323;
        }

        private void txtText_Click(object sender, EventArgs e)
        {
            COPanel.Visible = false;
            COPanel.Width = 0;
            PanelMenu.Visible = false;
            PanelMenu.Width = 0;
            PanelTheme.Visible = false;
            PanelTheme.Width = 0;
        }

        private void BtnThemeOptionClose_Click(object sender, EventArgs e)
        {
            PanelTheme.Visible = false;
            PanelTheme.Width = 0;
        }

        private void ButtonDT_Click(object sender, EventArgs e)
        {
            //Default Theme
            PanelNavbar.BackColor = Color.FromArgb(41, 40, 40);
            this.BackColor = Color.FromArgb(37, 37, 36);
            txtText.BackColor = Color.FromArgb(37, 37, 36);
            Navbarline.BackColor = Color.FromArgb(45, 45, 46);

            WDBorder1.BackColor = Color.FromArgb(44, 44, 43);
            WDBorder2.BackColor = Color.FromArgb(44, 44, 43);
            WDBorder3.BackColor = Color.FromArgb(44, 44, 43);

            NavbarSideline1.BackColor = Color.FromArgb(44, 44, 43);
            NavbarSideline2.BackColor = Color.FromArgb(44, 44, 43);

            BtnMinimize.BackColor = Color.FromArgb(41, 40, 40);
            BtnMinimize.IdleLineColor = Color.FromArgb(41, 40, 40);
            BtnMinimize.IdleFillColor = Color.FromArgb(59, 59, 59);
            BtnMinimize.ActiveLineColor = Color.FromArgb(24, 100, 38);

            BtnClose.BackColor = Color.FromArgb(41, 40, 40);
            BtnClose.IdleLineColor = Color.FromArgb(41, 40, 40);
            BtnClose.IdleFillColor = Color.FromArgb(59, 59, 59);
            BtnClose.ActiveLineColor = Color.FromArgb(111, 31, 49);

            txtText.ForeColor = Color.FromArgb(169, 169, 169);
            BtnMenu.Image = Sticky_Ghost.Properties.Resources.Term_48px11;

            //PanelMenu
            PanelMenu.BackColor = Color.FromArgb(40, 40, 40);

            BtnPin.Normalcolor = Color.FromArgb(40, 40, 40);
            BtnPin.Activecolor = Color.FromArgb(40, 40, 40);
            BtnPin.OnHovercolor = Color.FromArgb(55, 55, 55);
            BtnPin.Textcolor = Color.FromArgb(211, 211, 211);
            BtnPin.OnHoverTextColor = Color.FromArgb(255, 255, 255);

            BtnCO.Normalcolor = Color.FromArgb(40, 40, 40);
            BtnCO.Activecolor = Color.FromArgb(40, 40, 40);
            BtnCO.OnHovercolor = Color.FromArgb(55, 55, 55);
            BtnCO.Textcolor = Color.FromArgb(211, 211, 211);
            BtnCO.OnHoverTextColor = Color.FromArgb(255, 255, 255);

            BtnSaveAs.Normalcolor = Color.FromArgb(40, 40, 40);
            BtnSaveAs.Activecolor = Color.FromArgb(40, 40, 40);
            BtnSaveAs.OnHovercolor = Color.FromArgb(55, 55, 55);
            BtnSaveAs.Textcolor = Color.FromArgb(211, 211, 211);
            BtnSaveAs.OnHoverTextColor = Color.FromArgb(255, 255, 255);

            BtnOpenFile.Normalcolor = Color.FromArgb(40, 40, 40);
            BtnOpenFile.Activecolor = Color.FromArgb(40, 40, 40);
            BtnOpenFile.OnHovercolor = Color.FromArgb(55, 55, 55);
            BtnOpenFile.Textcolor = Color.FromArgb(211, 211, 211);
            BtnOpenFile.OnHoverTextColor = Color.FromArgb(255, 255, 255);

            BtnSettings.Normalcolor = Color.FromArgb(40, 40, 40);
            BtnSettings.Activecolor = Color.FromArgb(40, 40, 40);
            BtnSettings.OnHovercolor = Color.FromArgb(55, 55, 55);
            BtnSettings.Textcolor = Color.FromArgb(211, 211, 211);
            BtnSettings.OnHoverTextColor = Color.FromArgb(255, 255, 255);

            panelMenuBorder1.BackColor = Color.FromArgb(50, 50, 50);
            panelMenuBorder2.BackColor = Color.FromArgb(50, 50, 50);
            panelMenuBorder3.BackColor = Color.FromArgb(50, 50, 50);
            panelMenuBorder4.BackColor = Color.FromArgb(50, 50, 50);

            panelSepa1.BackColor = Color.FromArgb(50, 50, 50);
            panelSepa2.BackColor = Color.FromArgb(50, 50, 50);
            panelSepa3.BackColor = Color.FromArgb(50, 50, 50);
            panelSepa4.BackColor = Color.FromArgb(50, 50, 50);

            //COPanel
            COPanel.BackColor = Color.FromArgb(40, 40, 40);

            BtnFont.Normalcolor = Color.FromArgb(40, 40, 40);
            BtnFont.Activecolor = Color.FromArgb(40, 40, 40);
            BtnFont.OnHovercolor = Color.FromArgb(55, 55, 55);
            BtnFont.Textcolor = Color.FromArgb(211, 211, 211);
            BtnFont.OnHoverTextColor = Color.FromArgb(255, 255, 255);

            BtnChangeColor.Normalcolor = Color.FromArgb(40, 40, 40);
            BtnChangeColor.Activecolor = Color.FromArgb(40, 40, 40);
            BtnChangeColor.OnHovercolor = Color.FromArgb(55, 55, 55);
            BtnChangeColor.Textcolor = Color.FromArgb(211, 211, 211);
            BtnChangeColor.OnHoverTextColor = Color.FromArgb(255, 255, 255);

            BtnTheme.Normalcolor = Color.FromArgb(40, 40, 40);
            BtnTheme.Activecolor = Color.FromArgb(40, 40, 40);
            BtnTheme.OnHovercolor = Color.FromArgb(55, 55, 55);
            BtnTheme.Textcolor = Color.FromArgb(211, 211, 211);
            BtnTheme.OnHoverTextColor = Color.FromArgb(255, 255, 255);

            panelCOSeparator1.BackColor = Color.FromArgb(50, 50, 50);
            panelCOSeparator2.BackColor = Color.FromArgb(50, 50, 50);

            panelCOBorder1.BackColor = Color.FromArgb(50, 50, 50);
            panelCOBorder2.BackColor = Color.FromArgb(50, 50, 50);
            panelCOBorder3.BackColor = Color.FromArgb(50, 50, 50);

            COText.ForeColor = Color.FromArgb(105, 105, 105);

            BtnCloseCO.BackColor = Color.FromArgb(40, 40, 40);
            BtnCloseCO.IdleLineColor = Color.FromArgb(44, 45, 45);
            BtnCloseCO.IdleFillColor = Color.FromArgb(63, 63, 63);
            BtnCloseCO.ActiveLineColor = Color.FromArgb(111, 31, 49);

            // PanelTheme
            PanelTheme.BackColor = Color.FromArgb(40, 40, 40);
            panelThemeSepa.BackColor = Color.FromArgb(42, 42, 42);
            TOText.ForeColor = Color.FromArgb(105, 105, 105);

            ButtonDT.Normalcolor = Color.FromArgb(40, 40, 40);
            ButtonDT.Activecolor = Color.FromArgb(40, 40, 40);
            ButtonDT.OnHovercolor = Color.FromArgb(40, 40, 40);
            ButtonDT.Textcolor = Color.FromArgb(128, 128, 128);
            ButtonDT.OnHoverTextColor = Color.FromArgb(255, 255, 255);

            ButtonWD.Normalcolor = Color.FromArgb(40, 40, 40);
            ButtonWD.Activecolor = Color.FromArgb(40, 40, 40);
            ButtonWD.OnHovercolor = Color.FromArgb(40, 40, 40);
            ButtonWD.Textcolor = Color.FromArgb(128, 128, 128);
            ButtonWD.OnHoverTextColor = Color.FromArgb(255, 255, 255);

            BtnThemeOptionClose.BackColor = Color.FromArgb(40, 40, 40);
            BtnThemeOptionClose.IdleLineColor = Color.FromArgb(46, 46, 46);
            BtnThemeOptionClose.IdleFillColor = Color.FromArgb(61, 61, 61);
            BtnThemeOptionClose.ActiveLineColor = Color.FromArgb(111, 31, 49);

            panelTOBorder1.BackColor = Color.FromArgb(50, 50, 50);
            panelTOBorder2.BackColor = Color.FromArgb(50, 50, 50);
            panelTOBorder3.BackColor = Color.FromArgb(50, 50, 50);

            panelThemeMainSepa.BackColor = Color.FromArgb(60, 60, 60);


            PanelTheme.Visible = false;
            PanelTheme.Width = 0;
            Notification.Show("Theme has been changed!", Notification.AlertType.success);
        }

        private void ButtonWD_Click(object sender, EventArgs e)
        {
           //Theme for Dream White
           //Main
            PanelNavbar.BackColor = Color.FromArgb(255, 255, 255);

            this.BackColor = Color.FromArgb(251, 251, 251);
            txtText.BackColor = Color.FromArgb(251, 251, 251);
            Navbarline.BackColor = Color.FromArgb(245, 244, 244);

            WDBorder1.BackColor = Color.FromArgb(220, 220, 220);
            WDBorder2.BackColor = Color.FromArgb(220, 220, 220);
            WDBorder3.BackColor = Color.FromArgb(220, 220, 220);

            NavbarSideline1.BackColor = Color.FromArgb(220, 220, 220);
            NavbarSideline2.BackColor = Color.FromArgb(220, 220, 220);

            BtnMinimize.BackColor = Color.FromArgb(255, 255, 255);
            BtnMinimize.IdleLineColor = Color.FromArgb(229, 229, 229);
            BtnMinimize.IdleFillColor = Color.FromArgb(212, 212, 212);
            BtnMinimize.ActiveLineColor = Color.FromArgb(109, 185, 123);

            BtnClose.BackColor = Color.FromArgb(255, 255, 255);
            BtnClose.IdleLineColor = Color.FromArgb(229, 229, 229);
            BtnClose.IdleFillColor = Color.FromArgb(212, 212, 212);
            BtnClose.ActiveLineColor = Color.FromArgb(196, 116, 134);

            txtText.ForeColor = Color.FromArgb(100, 100, 100);

            //PanelMenu
            PanelMenu.BackColor = Color.FromArgb(255, 255, 255);

            BtnPin.Normalcolor = Color.FromArgb(255, 255, 255);
            BtnPin.Activecolor = Color.FromArgb(255, 255, 255);
            BtnPin.OnHovercolor = Color.FromArgb(222, 222, 222);
            BtnPin.Textcolor = Color.FromArgb(100, 100, 100);
            BtnPin.OnHoverTextColor = Color.FromArgb(100, 100, 100);

            BtnCO.Normalcolor = Color.FromArgb(255, 255, 255);
            BtnCO.Activecolor = Color.FromArgb(255, 255, 255);
            BtnCO.OnHovercolor = Color.FromArgb(222, 222, 222);
            BtnCO.Textcolor = Color.FromArgb(100, 100, 100);
            BtnCO.OnHoverTextColor = Color.FromArgb(100, 100, 100);

            BtnSaveAs.Normalcolor = Color.FromArgb(255, 255, 255);
            BtnSaveAs.Activecolor = Color.FromArgb(255, 255, 255);
            BtnSaveAs.OnHovercolor = Color.FromArgb(222, 222, 222);
            BtnSaveAs.Textcolor = Color.FromArgb(100, 100, 100);
            BtnSaveAs.OnHoverTextColor = Color.FromArgb(100, 100, 100);

            BtnOpenFile.Normalcolor = Color.FromArgb(255, 255, 255);
            BtnOpenFile.Activecolor = Color.FromArgb(255, 255, 255);
            BtnOpenFile.OnHovercolor = Color.FromArgb(222, 222, 222);
            BtnOpenFile.Textcolor = Color.FromArgb(100, 100, 100);
            BtnOpenFile.OnHoverTextColor = Color.FromArgb(100, 100, 100);

            BtnSettings.Normalcolor = Color.FromArgb(255, 255, 255);
            BtnSettings.Activecolor = Color.FromArgb(255, 255, 255);
            BtnSettings.OnHovercolor = Color.FromArgb(222, 222, 222);
            BtnSettings.Textcolor = Color.FromArgb(100, 100, 100);
            BtnSettings.OnHoverTextColor = Color.FromArgb(100, 100, 100);

            panelMenuBorder1.BackColor = Color.FromArgb(245, 245, 245);
            panelMenuBorder2.BackColor = Color.FromArgb(245, 245, 245);
            panelMenuBorder3.BackColor = Color.FromArgb(245, 245, 245);
            panelMenuBorder4.BackColor = Color.FromArgb(245, 245, 245);

            panelSepa1.BackColor = Color.FromArgb(245, 245, 245);
            panelSepa2.BackColor = Color.FromArgb(245, 245, 245);
            panelSepa3.BackColor = Color.FromArgb(245, 245, 245);
            panelSepa4.BackColor = Color.FromArgb(245, 245, 245);

            //COPanel
            COPanel.BackColor = Color.FromArgb(255, 255, 255);

            BtnFont.Normalcolor = Color.FromArgb(255, 255, 255);
            BtnFont.Activecolor = Color.FromArgb(255, 255, 255);
            BtnFont.OnHovercolor = Color.FromArgb(222, 222, 222);
            BtnFont.Textcolor = Color.FromArgb(100, 100, 100);
            BtnFont.OnHoverTextColor = Color.FromArgb(100, 100, 100);

            BtnChangeColor.Normalcolor = Color.FromArgb(255, 255, 255);
            BtnChangeColor.Activecolor = Color.FromArgb(255, 255, 255);
            BtnChangeColor.OnHovercolor = Color.FromArgb(222, 222, 222);
            BtnChangeColor.Textcolor = Color.FromArgb(100, 100, 100);
            BtnChangeColor.OnHoverTextColor = Color.FromArgb(100, 100, 100);

            BtnTheme.Normalcolor = Color.FromArgb(255, 255, 255);
            BtnTheme.Activecolor = Color.FromArgb(255, 255, 255);
            BtnTheme.OnHovercolor = Color.FromArgb(222, 222, 222);
            BtnTheme.Textcolor = Color.FromArgb(100, 100, 100);
            BtnTheme.OnHoverTextColor = Color.FromArgb(100, 100, 100);

            panelCOSeparator1.BackColor = Color.FromArgb(245, 245, 245);
            panelCOSeparator2.BackColor = Color.FromArgb(245, 245, 245);

            panelCOBorder1.BackColor = Color.FromArgb(245, 245, 245);
            panelCOBorder2.BackColor = Color.FromArgb(245, 245, 245);
            panelCOBorder3.BackColor = Color.FromArgb(245, 245, 245);

            COText.ForeColor = Color.FromArgb(186, 188, 188);
            BtnCloseCO.BackColor = Color.FromArgb(255, 255, 255);
            BtnCloseCO.IdleLineColor = Color.FromArgb(229, 229, 229);
            BtnCloseCO.IdleFillColor = Color.FromArgb(212, 212, 212);
            BtnCloseCO.ActiveLineColor = Color.FromArgb(196, 116, 134);

            // PanelTheme
            PanelTheme.BackColor = Color.FromArgb(255, 255, 255);
            panelThemeSepa.BackColor = Color.FromArgb(245, 245, 245);
            TOText.ForeColor = Color.FromArgb(186, 188, 188);

            ButtonDT.Normalcolor = Color.FromArgb(255, 255, 255);
            ButtonDT.Activecolor = Color.FromArgb(255, 255, 255);
            ButtonDT.OnHovercolor = Color.FromArgb(255, 255, 255);
            ButtonDT.Textcolor = Color.FromArgb(100, 100, 100);
            ButtonDT.OnHoverTextColor = Color.FromArgb(162, 163, 163);

            ButtonWD.Normalcolor = Color.FromArgb(255, 255, 255);
            ButtonWD.Activecolor = Color.FromArgb(255, 255, 255);
            ButtonWD.OnHovercolor = Color.FromArgb(255, 255, 255);
            ButtonWD.Textcolor = Color.FromArgb(100, 100, 100);
            ButtonWD.OnHoverTextColor = Color.FromArgb(162, 163, 163);

            BtnThemeOptionClose.BackColor = Color.FromArgb(255, 255, 255);
            BtnThemeOptionClose.IdleLineColor = Color.FromArgb(229, 229, 229);
            BtnThemeOptionClose.IdleFillColor = Color.FromArgb(212, 212, 212);
            BtnThemeOptionClose.ActiveLineColor = Color.FromArgb(196, 116, 134);

            panelTOBorder1.BackColor = Color.FromArgb(245, 245, 245);
            panelTOBorder2.BackColor = Color.FromArgb(245, 245, 245);
            panelTOBorder3.BackColor = Color.FromArgb(245, 245, 245);

            panelThemeMainSepa.BackColor = Color.FromArgb(220, 220, 220);

            PanelTheme.Visible = false;
            PanelTheme.Width = 0;
            Notification.Show("Theme has been changed!", Notification.AlertType.success);
        }

        private void BtnOpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Text Files (*.txt) |*.txt";
            if (open.ShowDialog() == DialogResult.OK)
            {
                System.IO.StreamReader sr = new System.IO.StreamReader(open.FileName);
                txtText.Text = sr.ReadToEnd();
                sr.Close();
            }

            COPanel.Visible = false;
            COPanel.Width = 0;
            PanelMenu.Visible = false;
            PanelMenu.Width = 0;
            PanelTheme.Visible = false;
            PanelTheme.Width = 0;
        }
    }
}
