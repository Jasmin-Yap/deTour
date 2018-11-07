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
using System.Data.SqlClient;

namespace Assignment
{
    public partial class loginPage : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int leftRect, int topRect, int rightRect, int bottomRect, int widthEllipse, int heightEllipse);


        public loginPage()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 10, 10));

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

        private void loginPage_FormClosing(object sender, FormClosingEventArgs e)
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

        private void backBtn_Click(object sender, EventArgs e)
        {
            welcomePage welcome = new welcomePage();
            welcome.Show();
            Visible = false;
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string username = usernameText.Text.Trim(); //prevent user from spacing trim front and end
            string password = passwordText.Text.Trim(); //prevent user from spacing trim front and end
            bool login = false;

            //for wishlist reference
            TourChoice.UnameVar = username;
            try
            {
                if (username.Equals(""))
                {
                    MessageBox.Show("Please enter your username!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); //error if username is blank
                }
                else

                {
                    if (password.Equals(""))
                    {
                        MessageBox.Show("Please enter your password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); //error if username is blank
                    }
                    else
                    {
                        foreach (User u in UserData.getUserInfo(" WHERE UserName='" + username + "' AND UserPassword='" + password + "'"))
                        {
                            if (u.userUsername.Equals(username) && u.userPassword.Equals(password))
                            {
                                login = true;
                            }
                        }

                        if (login == true)
                        {
                            MainWindow MW = new MainWindow();
                            MW.Show();
                            Visible = false;
                        }
                        else
                        {
                            MessageBox.Show("Please enter a valid username/password", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
