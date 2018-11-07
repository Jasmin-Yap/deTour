using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using System.Threading;
using System.Collections.Generic;

namespace Assignment
{
    public partial class MainWindow : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        private string userEmail;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int leftRect, int topRect, int rightRect, int bottomRect, int widthEllipse, int heightEllipse);


        public MainWindow()
        {
            //  Window properties
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
                welcomeTab.BackColor = Color.FromArgb(255, 255, 255);
                profileTab.BackColor = Color.FromArgb(255, 255, 255);
                tourTab.BackColor = Color.FromArgb(255, 255, 255);
                cartTab.BackColor = Color.FromArgb(255, 255, 255);
                wishlistTab.BackColor = Color.FromArgb(255, 255, 255);
                faqTab.BackColor = Color.FromArgb(255, 255, 255);
                contactusTab.BackColor = Color.FromArgb(255, 255, 255);
            }
            else if (Class.BackgroundColor.chosenColor.Equals("Gray"))
            {
                this.BackColor = Color.FromArgb(232, 232, 232);
                welcomeTab.BackColor = Color.FromArgb(232, 232, 232);
                profileTab.BackColor = Color.FromArgb(232, 232, 232);
                tourTab.BackColor = Color.FromArgb(232, 232, 232);
                cartTab.BackColor = Color.FromArgb(232, 232, 232);
                wishlistTab.BackColor = Color.FromArgb(232, 232, 232);
                faqTab.BackColor = Color.FromArgb(232, 232, 232);
                contactusTab.BackColor = Color.FromArgb(232, 232, 232);
            }
            else
            {
                this.BackColor = Color.FromArgb(247, 245, 230);
                welcomeTab.BackColor = Color.FromArgb(247, 245, 230);
                profileTab.BackColor = Color.FromArgb(247, 245, 230);
                tourTab.BackColor = Color.FromArgb(247, 245, 230);
                cartTab.BackColor = Color.FromArgb(247, 245, 230);
                wishlistTab.BackColor = Color.FromArgb(247, 245, 230);
                faqTab.BackColor = Color.FromArgb(247, 245, 230);
                contactusTab.BackColor = Color.FromArgb(247, 245, 230);
            }

            //  Home Page

            foreach (User u in UserData.getUserInfo(" WHERE UserName = '" + TourChoice.UnameVar + "'"))
            {
                //  Profile Detail Page
                welcomeUserLbl.Text = "Welcome " + Environment.NewLine + u.userName + "!";
                profilePDNameText.Text = u.userName;
                profilePDPasswordText.Text = u.userPassword;
                profilePDAddressText.Text = u.userAddress;
                profilePDZipCdText.Text = u.userZipCd.ToString();
                profilePDPassNoText.Text = u.userPassNo;
                profilePDPassEDText.Text = u.userPassED.ToString("d/M/yyyy");
                profilePDPhoneNoText.Text = u.userPhoneNo.ToString();
                profilePDEmailText.Text = u.userEmail;
                userEmail = u.userEmail;
                TourChoice.UpassVar = u.userPassword;

                // Contact Us Page
                cuNameText.Text = u.userName;
                cuEmailText.Text = u.userEmail;


                if (u.userAccountType.Equals('P'))
                {
                    foreach (DataRow dr in UserData.getPaymentInfo().Rows)
                    {
                        cardNameText.Text = dr["CardName"].ToString();
                        cardNoText.Text = dr["CardNo"].ToString();
                        cardEDDTP.Value = Convert.ToDateTime(dr["CardED"]);
                    }
                    CartPayment.ttlCost = 0.9;
                }
                else
                {
                    CartPayment.ttlCost = 1;
                }
            }

            profilePDPassEDText.MinDate = DateTime.Now;


            // Tour Page
            tourDateCombox.MinDate = DateTime.Now;

            //Cart Page
            cardEDDTP.MinDate = DateTime.Now;

        }

        private void refreshForm()
        {
            //Changes made here
            List<Tour> t = TourCollection.GetTour("select * from Tour");

            foreach (Tour x in t)
            {
                if (!x.TQuantity.Equals("0")) // to ensure that only available tours are loaded
                {
                    ListViewItem item = new ListViewItem(x.Name);
                    item.SubItems.Add("(" + x.Country + ", " + x.State + ")");
                    item.SubItems.Add(x.Region);
                    item.SubItems.Add(x.Summary);
                    item.SubItems.Add("Price: $" + x.Price);
                    tourListingLV.Items.Add(item);
                }
            }
        }

        // Window Properties

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

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
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
                welcomeTab.BackColor = Color.FromArgb(255, 255, 255);
                profileTab.BackColor = Color.FromArgb(255, 255, 255);
                tourTab.BackColor = Color.FromArgb(255, 255, 255);
                cartTab.BackColor = Color.FromArgb(255, 255, 255);
                wishlistTab.BackColor = Color.FromArgb(255, 255, 255);
                faqTab.BackColor = Color.FromArgb(255, 255, 255);
                contactusTab.BackColor = Color.FromArgb(255, 255, 255);
                Class.BackgroundColor.chosenColor = "White";
            }
            else if (backColorCombox.Text.Equals("Gray"))
            {
                this.BackColor = Color.FromArgb(232, 232, 232);
                welcomeTab.BackColor = Color.FromArgb(232, 232, 232);
                profileTab.BackColor = Color.FromArgb(232, 232, 232);
                tourTab.BackColor = Color.FromArgb(232, 232, 232);
                cartTab.BackColor = Color.FromArgb(232, 232, 232);
                wishlistTab.BackColor = Color.FromArgb(232, 232, 232);
                faqTab.BackColor = Color.FromArgb(232, 232, 232);
                contactusTab.BackColor = Color.FromArgb(232, 232, 232);
                Class.BackgroundColor.chosenColor = "Gray";
            }
            else
            {
                this.BackColor = Color.FromArgb(247, 245, 230);
                welcomeTab.BackColor = Color.FromArgb(247, 245, 230);
                profileTab.BackColor = Color.FromArgb(247, 245, 230);
                tourTab.BackColor = Color.FromArgb(247, 245, 230);
                cartTab.BackColor = Color.FromArgb(247, 245, 230);
                wishlistTab.BackColor = Color.FromArgb(247, 245, 230);
                faqTab.BackColor = Color.FromArgb(247, 245, 230);
                contactusTab.BackColor = Color.FromArgb(247, 245, 230);
                Class.BackgroundColor.chosenColor = "Downy SW";
            }
        }

        // Navigation bar

        private void homeBtn_Click(object sender, EventArgs e)
        {
            navigationBarPanel.Height = 0;
            navigationBarPanel.Top = 0;
            navigationTC.SelectTab(0);
            pageTitle.Text = ": Home Page";
        }

        private void profileBtn_Click(object sender, EventArgs e)
        {
            navigationBarPanel.Height = profileBtn.Height;
            navigationBarPanel.Top = profileBtn.Top;
            navigationTC.SelectTab(1);
            pageTitle.Text = ": " + TourChoice.UnameVar + "'s Profile Page";
        }

        private void tourBtn_Click(object sender, EventArgs e)
        {
            navigationBarPanel.Height = tourBtn.Height;
            navigationBarPanel.Top = tourBtn.Top;
            navigationTC.SelectTab(2);
            pageTitle.Text = ": Tour Page";
            refreshForm(); // to ensure that only available tours are loaded
        }

        private void cartBtn_Click(object sender, EventArgs e)
        {
            try
            {
                cartLV.Items.Clear();
                editCartItemsIndexCombox.Items.Clear();
                navigationBarPanel.Height = cartBtn.Height;
                navigationBarPanel.Top = cartBtn.Top;
                navigationTC.SelectTab(3);
                pageTitle.Text = ": Cart Page";
                double totalcostcart = 0;
                // Changes made here
                List<Tour> t = TourCollection.GetCart("Select c.TourID, TourName, TourState, Country, Region, Summary,Itinerary, c.Price, StartDate, EndDate, Duration,c.HotelStars, c.Quantity" +
                    " From Cart c, Tour t" +
                    " Where c.TourID = t.TourID AND UserName = '" + TourChoice.UnameVar + "'");
                int y = 1;
                foreach (Tour x in t)
                {
                    ListViewItem item = new ListViewItem("Item No. #" + y);
                    item.SubItems.Add(x.Name);
                    item.SubItems.Add("(" + x.Country + ", " + x.State + ")");
                    item.SubItems.Add(x.Region);
                    item.SubItems.Add("Price: $" + x.Price);
                    item.SubItems.Add("Hotel Stars: " + x.HotelStars);
                    item.SubItems.Add("Quantity: " + x.TQuantity);
                    totalcostcart += double.Parse(x.Price) * int.Parse(x.TQuantity);
                    cartLV.Items.Add(item);
                    y++;
                }
                int tIndex = y;
                
                for (int i = 1; i < tIndex; i++)
                {
                    editCartItemsIndexCombox.Items.Add(i);
                }

                ttlCartPriceNumText.Text = "$" + (totalcostcart * CartPayment.ttlCost).ToString();
                double totalcostgst = Convert.ToDouble(totalcostcart) * 1.07;
                ttlPriceNumText.Text = "$" + totalcostgst;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void wishlistBtn_Click(object sender, EventArgs e)
        {
            wishlistLV.Items.Clear();
            navigationBarPanel.Height = wishlistBtn.Height;
            navigationBarPanel.Top = wishlistBtn.Top;
            navigationTC.SelectTab(4);
            pageTitle.Text = ": Wishlist Page";

            //Changes made here
            List<Tour> t = TourCollection.GetTour("select w.TourID, TourName, TourState, Country, Region, Summary,Itinerary, Price, StartDate, EndDate, Duration, Quantity" +
                " from tour t, wishlist w" +
                " where t.TourId = w.TourID AND Username = '" + TourChoice.UnameVar + "'");

            foreach (Tour x in t)
            {
                ListViewItem item = new ListViewItem(x.Name);
                item.SubItems.Add("(" + x.Country + ", " + x.State + ")");
                item.SubItems.Add(x.Region);
                item.SubItems.Add(x.Summary);
                item.SubItems.Add("Price: $" + TourChoice.calcTotal(x.Price));
                wishlistLV.Items.Add(item);
            }

        }

        // Cart Tab

        private void editCartItemsIndexCombox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int Selected = editCartItemsIndexCombox.SelectedIndex + 1;
            int hotelIndex = 0;

            for (int i = 0; i < cartLV.Items.Count; i++)
            {
                TourChoice.ItemVar = Selected;

                if (TourChoice.ItemVar == Selected)
                {
                    
                    editCartItemsQtyNUD.Value = int.Parse(cartLV.Items[i].SubItems[6].Text.Substring(10));

                    if (cartLV.Items[i].SubItems[5].Text.Contains("Stars"))
                    {
                        hotelIndex = int.Parse(cartLV.Items[i].SubItems[5].Text.Substring(12));
                    }

                    switch (hotelIndex)
                    {
                        case 1:
                            editCartItemsHotelCombox.SelectedIndex = 5;
                            break;
                        case 2:
                            editCartItemsHotelCombox.SelectedIndex = 4;
                            break;
                        case 3:
                            editCartItemsHotelCombox.SelectedIndex = 3;
                            break;
                        case 4:
                            editCartItemsHotelCombox.SelectedIndex = 2;
                            break;
                        case 5:
                            editCartItemsHotelCombox.SelectedIndex = 1;
                            break;
                        default:
                            editCartItemsHotelCombox.SelectedIndex = 0;
                            break;
                    }
                }
            }
        }

        // Wishlist Tab
        private void wishlistLV_Click(object sender, EventArgs e)
        {
            TourChoice.tourChosen = wishlistLV.SelectedItems[0].Text;
            TourChoice.tourPrice = wishlistLV.SelectedItems[0].SubItems[4].Text;
            TourChoice.tourHotelStars = tourHotelCombox.SelectedIndex;
            tourDetailPage tourDetail = new tourDetailPage();
            tourDetail.Show();
            Visible = true;
        }

        private void faqBtn_Click(object sender, EventArgs e)
        {
            navigationBarPanel.Height = faqBtn.Height;
            navigationBarPanel.Top = faqBtn.Top;
            navigationTC.SelectTab(5);
            pageTitle.Text = ": FAQs Page";
        }

        private void contactusBtn_Click(object sender, EventArgs e)
        {
            navigationBarPanel.Height = contactusBtn.Height;
            navigationBarPanel.Top = contactusBtn.Top;
            navigationTC.SelectTab(6);
            pageTitle.Text = ": Contact Us Page";
        }

        // Contact Us Tab

        private void cuSubmitBtn_Click(object sender, EventArgs e)
        {
            string cuName = cuNameText.Text.Trim(); // prevent user from spacing trim front and end
            string cuEmail = cuEmailText.Text.Trim(); // prevent user from spacing trim front and end
            string cuMessage = cuMessageText.Text.Trim(); // prevent user from spacing trim front and end
            string pattern = @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" + @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$";

            if (cuName.Equals(""))
            {
                MessageBox.Show("Please enter your name.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error); // error if no name
            }
            else
            {
                if (cuEmail.Equals(""))
                {
                    MessageBox.Show("Please enter your email.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error); // error if no email
                }
                else
                {
                    if (Regex.IsMatch(cuEmail, pattern))
                    {
                        if (cuMessage.Equals(""))
                        {
                            MessageBox.Show("Please enter your message.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error); // error if no message
                        }
                        else
                        {
                            string newUser = cuName + "*" + cuEmail + "*" + cuMessage; // cuName, cuEmail, cuMessage
                            File.AppendAllText("responses.txt", newUser + Environment.NewLine);

                            MailMessage mail = new MailMessage();
                            SmtpClient server = new SmtpClient("smtp.live.com");
                            mail.From = new MailAddress("deTourBookingApplication@hotmail.com");
                            mail.To.Add(userEmail);
                            mail.Subject = "Message from " + cuName + " at " + cuEmail;
                            mail.Body = cuMessage;
                            server.Port = 587;
                            server.Credentials = new System.Net.NetworkCredential("deTourBookingApplication@hotmail.com", "whataredoing?");
                            server.EnableSsl = true;
                            server.Send(mail);
                            MessageBox.Show("Response has been sent! We will get back to you ASAP.\nThank you for your response!", "Successful!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                            navigationTC.SelectTab(0);
                            cuMessageText.Text = null;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter a valid email.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error); // error if email not valid
                    }
                }
            }
        }

        // FAQs Tab

        private void faqcuBtn_Click(object sender, EventArgs e)
        {
            navigationBarPanel.Height = contactusBtn.Height;
            navigationBarPanel.Top = contactusBtn.Top;
            navigationTC.SelectTab(6);
            pageTitle.Text = ": Contact Us Page";
        }

        // Profile Tab

        private void profileEnterBtn_Click(object sender, EventArgs e)
        {
            if (profileEnterText.Text.Equals(TourChoice.UpassVar))
            {
                MessageBox.Show("Successful!", "Procceed to Profile Page", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                profileSelectPanel.Visible = true;
            }
            else
            {
                MessageBox.Show("Please try again.", "Wrong Password!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void profileSelectOHBtn_Click(object sender, EventArgs e)
        {
            profileOHPanel.Visible = true;
            profilePDPanel.Visible = false;
            profileOHPanel.BringToFront();
        }

        private void profileSelectPDBtn_Click(object sender, EventArgs e)
        {
            profilePDPanel.Visible = true;
            profileOHPanel.Visible = false;
        }

        private void profilePDBackBtn_Click(object sender, EventArgs e)
        {
            profilePDPanel.Visible = false;
        }

        private void profileOHBackBtn_Click(object sender, EventArgs e)
        {
            profileOHPanel.Visible = false;
        }

        private void profilePDChangeBtn_Click(object sender, EventArgs e)
        {
            UserData.UpdateUser(profilePDNameText.Text, profilePDPasswordText.Text, profilePDAddressText.Text, profilePDZipCdText.Text,
                profilePDPassNoText.Text, Convert.ToDateTime(profilePDPassEDText.Value), profilePDPhoneNoText.Text, profilePDEmailText.Text);
            MessageBox.Show("Your credential(s) has/have been changed.", "Successful!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void profilePDPhoneNoText_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            profilePDPhoneNoText.MaxLength = 8;
        }

        private void profilePDZipCdText_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            profilePDZipCdText.MaxLength = 6;
        }

        private void profilePDPassNoText_KeyPress(object sender, KeyPressEventArgs e)
        {
            profilePDPassNoText.MaxLength = 9;
        }

        private void profileOHText_VisibleChanged(object sender, EventArgs e)
        {
            profileOHText.Text = receiptText.Text;
        }

        // Tour Tab

        private void tourListingLV_Click(object sender, EventArgs e)
        {
            TourChoice.tourChosen = tourListingLV.SelectedItems[0].Text;
            TourChoice.tourPrice = tourListingLV.SelectedItems[0].SubItems[4].Text;
            TourChoice.tourHotelStars = tourHotelCombox.SelectedIndex;
            tourDetailPage tourDetail = new tourDetailPage();
            tourDetail.Show();
            Visible = true;
        }

        private void tourCountryCombox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = tourCountryCombox.SelectedItem.ToString();

            /* Choose the correct region */
            if (selected.Contains("Malaysia") || selected.Contains("Indonesia"))
            {
                tourRegionCombox.SelectedIndex = 1;
            }
            else if (selected.Contains("Japan") || selected.Contains("South Korea"))
            {
                tourRegionCombox.SelectedIndex = 2;
            }
            else if (selected.Contains("USA") || selected.Contains("Canada"))
            {
                tourRegionCombox.SelectedIndex = 3;
            }
            else if (selected.Contains("Ireland") || selected.Contains("Italy") || selected.Contains("France"))
            {
                tourRegionCombox.SelectedIndex = 4;
            }
        }

        private void tourSearchBtn_Click(object sender, EventArgs e)
        {
            // Changes made here
            tourListingLV.Items.Clear();
            TourChoice.Country = tourCountryCombox.SelectedItem.ToString();
            TourChoice.Region = tourRegionCombox.SelectedItem.ToString();
            TourChoice.Date = tourDateCombox.Value.ToString("yyyy-MM-dd");
            TourChoice.Duration = tourDurationCombox.SelectedItem.ToString();
            TourChoice.tourHotelStars = tourHotelCombox.SelectedIndex;
            TourChoice.RegionCheck = tourRegionRB.Checked;
            TourChoice.CountryCheck = tourCountryRB.Checked;
            TourChoice.DateCheck = tourDateCB.Checked;
            TourChoice.DurationCheck = tourDurationCB.Checked;

            List<Tour> t = TourCollection.Refined();

            foreach (Tour x in t)
            {
                ListViewItem item = new ListViewItem(x.Name);
                item.SubItems.Add("(" + x.Country + ", " + x.State + ")");
                item.SubItems.Add(x.Region);
                item.SubItems.Add(x.Summary);
                item.SubItems.Add("Price : $" + TourChoice.calcTotal(x.Price));
                tourListingLV.Items.Add(item);
            }
        }

        private void tourResetBtn_Click(object sender, EventArgs e)
        {
            tourCountryCombox.SelectedIndex = 0;
            tourRegionCombox.SelectedIndex = 0;
            tourHotelCombox.SelectedIndex = 0;
            tourDurationCombox.SelectedIndex = 0;
            tourCountryRB.Checked = false;
            tourRegionRB.Checked = false;
            tourDateCB.Checked = false;
            tourDurationCB.Checked = false;
            tourListingLV.Items.Clear();
            
            refreshForm();
        }

        // Cart Tab

        private void editCartItemsRemoveLinkLbl_Click(object sender, EventArgs e)
        {
            //Changes made here
            int selected = editCartItemsIndexCombox.SelectedIndex;
            string lineinfo = cartLV.Items[selected].SubItems[1].Text;
            try
            {
                foreach (Tour t in TourCollection.GetCart("SELECT c.TourID, TourName, TourState, Country, Region, Summary,Itinerary, c.Price, StartDate, EndDate, Duration,c.HotelStars, c.Quantity" +
                    " From Cart c, Tour t" +
                    " Where c.TourID = t.TourID AND UserName = '" + TourChoice.UnameVar + "'"))
                {
                    if (t.Name.Equals(lineinfo))
                    {
                        TourCollection.DeletedRow(t.Name);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            editCartItemsIndexCombox.Text = "";
            cartBtn_Click(sender, e);
        }

        private void editCartItemsChangeBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string lineinfo = cartLV.Items[editCartItemsIndexCombox.SelectedIndex].SubItems[1].Text;
                TourChoice.starsChosen = int.Parse(editCartItemsHotelCombox.SelectedItem.ToString().Substring(0, 1));
                TourChoice.tourHotelStars = editCartItemsHotelCombox.SelectedIndex;
                TourChoice.QuantityChosen = int.Parse(editCartItemsQtyNUD.Value.ToString());

                //Changes made here
                try
                {
                    foreach (Tour t in TourCollection.GetTour("SELECT c.TourID, TourName, TourState, Country, Region, Summary,Itinerary, c.Price, StartDate, EndDate, Duration,c.HotelStars, c.Quantity" +
                    " From Cart c, Tour t" +
                    " Where c.TourID = t.TourID AND UserName = '" + TourChoice.UnameVar + "'"))
                    {
                        if (t.Name.Equals(lineinfo))
                        {
                            TourCollection.UpdateRow(t.Name);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            catch
            {
                MessageBox.Show("Please select an item to edit.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            editCartItemsIndexCombox.Text = "";
            cartBtn_Click(sender, e);

        }

        private void makePaymentBtn_Click(object sender, EventArgs e)
        {
            TourChoice.getIndex = cartLV.Items.Count;
            TourChoice.Cost = double.Parse(ttlCartPriceNumText.Text.Substring(1));
            string[] tourName = new string[TourChoice.getIndex];
            string[] quantity = new string[TourChoice.getIndex];
            string[] stars = new string[TourChoice.getIndex];
            string[] pricePaid = new string[TourChoice.getIndex];
            for (int i = 0; i < TourChoice.getIndex; i++)
            {
                tourName[i] = cartLV.Items[i].SubItems[1].Text;
                stars[i] = cartLV.Items[i].SubItems[5].Text.Substring(13, 1);
                quantity[i] = cartLV.Items[i].SubItems[6].Text.Substring(10, 1);
                pricePaid[i] = cartLV.Items[i].SubItems[4].Text.Substring(6);
            }

            try
            {
                if (cardNoText.Text.Equals(""))
                {
                    MessageBox.Show("Enter a valid Card Number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (cardNameText.Text.Equals(""))
                    {
                        MessageBox.Show("Enter a valid Card Name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (cardEDDTP.Text.Equals(""))
                        {
                            MessageBox.Show("Enter a valid Card Number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            if (cardCVVText.Text.Equals(""))
                            {
                                MessageBox.Show("Enter a valid Card Number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                CartPayment.Payable = false;
                            }
                            else
                            {
                                if (cartLV.Items.Count == 0)
                                {
                                    CartPayment.Payable = false;
                                    MessageBox.Show("Payment will only be valid if there is/are cart item(s).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                else
                                {
                                    CartPayment.Payable = true;
                                }
                            }
                        }

                    }
                }

                if (CartPayment.Payable == true)
                {
                    TourCollection.InsertBK(tourName, pricePaid, quantity, cardNoText.Text, stars);
                    cartBtn_Click(sender, e);
                    receiptPanel.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cardNoText_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            cardNoText.MaxLength = 16;
        }

        private void cardCVVText_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            cardNoText.MaxLength = 3;
        }

        private void receiptBackBtn_Click(object sender, EventArgs e)
        {
            receiptPanel.Visible = false;
        }

        private void receiptText_VisibleChanged(object sender, EventArgs e)
        {
            try
            {
                receiptText.Text = "";
                string payment = "";
                string txt = "";
                Random rnd = new Random();
                CartPayment.OrderNo = rnd.Next(1000, 9999);

                payment += "Card Name: " + cardNameText.Text + Environment.NewLine;
                payment += "Card No: " + cardNoText.Text + Environment.NewLine;
                payment += "Card Expiry Date: " + cardEDDTP.Text;

                receiptText.AppendText(Environment.NewLine);
                receiptText.Text = "Order No: " + CartPayment.OrderNo;
                receiptText.AppendText(Environment.NewLine);
                receiptText.Text += "Username: " + TourChoice.UnameVar;
                receiptText.AppendText(Environment.NewLine);
                receiptText.Text += payment;
                receiptText.AppendText(Environment.NewLine);
                receiptText.AppendText(Environment.NewLine);
                receiptText.Text += "Order Details:" + Environment.NewLine;

                foreach (Array a in TourCollection.getBookings())
                {
                    foreach (string s in a)
                    {
                        txt += s + "\r\n";
                    }
                    txt += "\r\n";
                }

                receiptText.Text += txt;

                receiptText.Text += "Total Cost: $" + TourChoice.Cost.ToString();
                profileOHText.Text = receiptText.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void receiptOKBtn_Click(object sender, EventArgs e)
        {
            homeBtn_Click(sender, e);
            cartLV.Items.Clear();
        }

        private void cartLV_Click(object sender, EventArgs e)
        {
            string x = "Item No. #";
            int endIndex = x.IndexOf('#') + 1;
            string selected = cartLV.SelectedItems[0].Text;
            int select = int.Parse(selected.Substring(endIndex)) - 1;
            editCartItemsIndexCombox.SelectedIndex = select;
        }
    }
}