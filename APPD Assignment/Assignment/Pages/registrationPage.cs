using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.IO;

namespace Assignment
{
    public partial class registrationPage: Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int leftRect, int topRect, int rightRect, int bottomRect, int widthEllipse, int heightEllipse);


        public registrationPage()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 10, 10));
            backBtnToolTip.SetToolTip(backBtn, "Brings you to the previous page.");
            isPremiumToolTip.SetToolTip(isPremiumBtn, "Grants you discount upon payment.");

            backColorCombox.Text = Class.BackgroundColor.chosenColor;

            if (backColorCombox.Text.Equals(""))
            {
                backColorCombox.Text = "Theme Color";
            }

            if (Class.BackgroundColor.chosenColor == "White")
            {
                this.BackColor = Color.FromArgb(255, 255, 255);
            }
            else if (Class.BackgroundColor.chosenColor.Equals("Gray"))
            {
                this.BackColor = Color.FromArgb(232, 232, 232);
            }
            else
            {
                this.BackColor = Color.FromArgb(247, 245, 230);
            }

        }

        private void menuBar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minimizeBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
        }

        private void registerPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult result = MessageBox.Show("Do you want to close the application?", "Farewell", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    Environment.Exit(1);
                }
                else
                {
                    e.Cancel = true;
                }
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void backColorBtn_Click(object sender, EventArgs e)
        {
            if (backColorCombox.Text == "White")
            {
                this.BackColor = Color.FromArgb(255, 255, 255);
                Class.BackgroundColor.chosenColor = "White";
            }
            else if (backColorCombox.Text.Equals("Gray"))
            {
                this.BackColor = Color.FromArgb(232, 232, 232);
                Class.BackgroundColor.chosenColor = "Gray";
            }
            else
            {
                this.BackColor = Color.FromArgb(247, 245, 230);
                Class.BackgroundColor.chosenColor = "Downy SW";
            }
        }

        private void isPremiumBtn_Click(object sender, EventArgs e)
        {
            registerPremium pr = new registerPremium();
            pr.Show();
            Visible = false;
        }

        private void isFreeBtn_Click(object sender, EventArgs e)
        {
            registerFree fr = new registerFree();
            fr.Show();
            Visible = false;
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            welcomePage welcome = new welcomePage();
            welcome.Show();
            Visible = false;
        }

    }
}
