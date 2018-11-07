using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Globalization;

namespace Assignment
{
    public partial class registerFree : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int leftRect, int topRect, int rightRect, int bottomRect, int widthEllipse, int heightEllipse);


        public registerFree()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 10, 10));
            backBtnToolTip.SetToolTip(backBtn, "Brings you to the previous page.");

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

            passEDText.MinDate = DateTime.Now;
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

        private void registerForeigner_FormClosing(object sender, FormClosingEventArgs e)
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
            registrationPage registration = new registrationPage();
            registration.Show();
            Visible = false;
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string salution;
                string pattern = @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" + @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$";
                string name = nameText.Text.Trim(); //prevent user from spacing trim front and end
                string username = usernameText.Text.Trim(); //prevent user from spacing trim front and end
                string password = passwordText.Text.Trim(); //prevent user from spacing trim front and end
                string repassword = repasswordText.Text.Trim(); //prevent user from spacing trim front and end
                string passNo = passNoText.Text.Trim(); //prevent user from spacing trim front and end
                DateTime passED = Convert.ToDateTime(passEDText.Text.Trim()); //prevent user from spacing trim front and end
                string phoneNo = phoneNoText.Text.Trim(); //prevent user from spacing trim front and end
                string email = emailText.Text.Trim(); //prevent user from spacing trim front and end
                string address = addressText.Text.Trim(); //prevent user from spacing trim front and end
                string zipCd = zipCdText.Text.Trim(); //prevent user from spacing trim front and end
                
                bool repeat = false;

                if (mrRadioButton.Checked == true)
                {
                    salution = "Mr";
                }
                else if (mrsRadioButton.Checked == true)
                {
                    salution = "Mrs";
                }
                else if (mdmRadioButton.Checked == true)
                {
                    salution = "Mdm";
                }
                else if (msRadioButton.Checked == true)
                {
                    salution = "Ms";
                }
                else
                {
                    salution = "";
                }

                if (agreeCB.Checked == true)
                {
                    if (salution.Equals(""))
                    {
                        MessageBox.Show("Please select your salution!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); //error if salution not checked
                    }
                    else
                    {
                        if (name.Equals(""))
                        {
                            MessageBox.Show("Please enter your name!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); //error if name is blank
                        }
                        else
                        {
                            if (username.Equals(""))
                            {
                                MessageBox.Show("Please enter your username!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); //error if username is blank
                            }
                            else
                            {
                                if (password.Equals(""))
                                {
                                    MessageBox.Show("Please enter your password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); //error if password is blank
                                }
                                else
                                {
                                    if (repassword.Equals(password))
                                    {
                                        if (passNo.Equals(""))
                                        {
                                            MessageBox.Show("Please enter your IC!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); //error if passNo is blank
                                        }
                                        else
                                        {
                                            if (phoneNo.Equals(""))
                                            {
                                                MessageBox.Show("Please enter your phone number!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); //error if phNo is blank
                                            }
                                            else
                                            {
                                                if (email.Equals(""))
                                                {
                                                    MessageBox.Show("Please enter your email!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); //error if email is blank
                                                }
                                                else
                                                {
                                                    if (Regex.IsMatch(email, pattern))
                                                    {
                                                        if (address.Equals(""))
                                                        {
                                                            MessageBox.Show("Please enter your address!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); //error if address is blank
                                                        }
                                                        else
                                                        {
                                                            if (zipCd.Equals(""))
                                                            {
                                                                MessageBox.Show("Please enter your zip code!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); //error if zipCd is blank
                                                            }
                                                            else
                                                            {
                                                                foreach (User u in UserData.getUserInfo(""))
                                                                {
                                                                    if (username.Equals(u.userUsername))
                                                                    {
                                                                        MessageBox.Show("Unfortunately, the desired username has been used.\nPlease use a new one.", "Username taken up!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                                        repeat = true;
                                                                    }
                                                                    else if (email.Equals(u.userEmail))
                                                                    {
                                                                        MessageBox.Show("Unfortunately, the desired email has been used.\nPlease use a new one.", "Email taken up!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                                        repeat = true;
                                                                    }
                                                                }

                                                                if (repeat == false)
                                                                {
                                                                    UserData.createUser('F', salution, name, username, password, address, Convert.ToInt32(zipCd), passNo, passED, Convert.ToInt32(phoneNo), email, 0);
                                                                    MessageBox.Show("Registration completed!\nPlease login your account to book tours!", "Successful!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                                                                    this.Hide();
                                                                    welcomePage welcome = new welcomePage();
                                                                    welcome.Show();
                                                                }
                                                            }
                                                        }
                                                    }
                                                    else
                                                    {
                                                        MessageBox.Show("Please enter a valid email!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); //error if email is not valid
                                                    }
                                                }
                                            }


                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Please re-enter your password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); //error if password != re
                                    }
                                }
                            }
                        }

                    }
                }
                else
                {
                    MessageBox.Show("Registration is only available when you acknowledge the ToS!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); //error if ToS not checked
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void phoneNoText_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void zipCdText_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            zipCdText.MaxLength = 6;
        }

        private void passNoText_KeyPress(object sender, KeyPressEventArgs e)
        {
            passNoText.MaxLength = 9;
        }

        private void ToS_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string[] tos = System.IO.File.ReadAllLines("termsofServices.txt");
            string tosPolicy = "";
            foreach (string line in tos)
            {
                tosPolicy += line + "\n";
            }
            MessageBox.Show(tosPolicy, "Terms of Services");
        }
    }
}

