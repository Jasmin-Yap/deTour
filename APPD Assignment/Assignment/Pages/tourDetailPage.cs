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
    public partial class tourDetailPage : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int leftRect, int topRect, int rightRect, int bottomRect, int widthEllipse, int heightEllipse);


        public tourDetailPage()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 10, 10));

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

            //if hotel was chosen in refined search
            tourHotelCombox.SelectedIndex = TourChoice.tourHotelStars;
            
            List<Tour> t = TourCollection.GetTour("select * from Tour");
            foreach (Tour x in t)
            {
                if (x.Name.Equals(TourChoice.tourChosen))
                {
                    tourNameLbl.Text = x.Name;
                    tourLocationLbl.Text = x.Country + ", " + x.State;
                    tourRegionLbl.Text = x.Region;
                    tourPriceLbl.Text = TourChoice.tourPrice + "/pax";
                    tourDatesLbl.Text = "Dates: " + x.StartDate.ToString("d/M/yyyy") + " - " + x.EndDate.ToString("d/M/yyyy");
                    tourItineraryText.Text = File.ReadAllText(".\\Tour Details\\" + x.Itinerary + ".txt");
                }
            }

            string imageSrc = "";
            if (tourNameLbl.Text.Contains("JB's"))
            {
                imageSrc = ".\\Tour Images\\JB.JPG";
            }
            else if (tourNameLbl.Text.Contains("Malaysia's Hottest"))
            {
                imageSrc = ".\\Tour Images\\KL.JPG";
            }
            else if (tourNameLbl.Text.Contains("Metropolitan Port"))
            {
                imageSrc = ".\\Tour Images\\Surabaya.JPG";
            }
            else if (tourNameLbl.Text.Contains("Historical Capital"))
            {
                imageSrc = ".\\Tour Images\\jakarta.JPG";
            }
            else if (tourNameLbl.Text.Contains("Busy Busan"))
            {
                imageSrc = ".\\Tour Images\\Busan.JPG";
            }
            else if (tourNameLbl.Text.Contains("Modern Metropolis"))
            {
                imageSrc = ".\\Tour Images\\Seoul.JPG";
            }
            else if (tourNameLbl.Text.Contains("The Old Capital"))
            {
                imageSrc = ".\\Tour Images\\Kyoto.JPG";
            }
            else if (tourNameLbl.Text.Contains("Modern but Traditional"))
            {
                imageSrc = ".\\Tour Images\\tokyo.JPG";
            }
            else if (tourNameLbl.Text.Contains("The Presidential Palace"))
            {
                imageSrc = ".\\Tour Images\\washington-dc.JPG";
            }
            else if (tourNameLbl.Text.Contains("Surfs-Up in Hollywood"))
            {
                imageSrc = ".\\Tour Images\\Hollywood.JPG";
            }
            else if (tourNameLbl.Text.Contains("Fine-Artisan"))
            {
                imageSrc = ".\\Tour Images\\Montreal.JPG";
            }
            else if (tourNameLbl.Text.Contains("Winter Wonderland"))
            {
                imageSrc = ".\\Tour Images\\ottawa.JPG";
            }
            else if (tourNameLbl.Text.Contains("The Kingdom Awakens"))
            {
                imageSrc = ".\\Tour Images\\Dublin.JPG";
            }
            else if (tourNameLbl.Text.Contains("Culture of the Capital"))
            {
                imageSrc = ".\\Tour Images\\Dublin.JPG";
            }
            else if (tourNameLbl.Text.Contains("The Sinking City"))
            {
                imageSrc = ".\\Tour Images\\venice.JPG";
            }
            else if (tourNameLbl.Text.Contains("For the Romantics"))
            {
                imageSrc = ".\\Tour Images\\paris.JPG";
            }

            tourImagePB.Image = Image.FromFile(imageSrc);
            tourImagePB.SizeMode = PictureBoxSizeMode.StretchImage;

        }

        private void tourHotelCombox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (TourChoice.tourHotelStars != tourHotelCombox.SelectedIndex)
            {
                TourChoice.tourHotelStars = tourHotelCombox.SelectedIndex;
                List<Tour> t = TourCollection.GetTour("select * from Tour");
                foreach (Tour x in t)
                {
                    if (x.Name.Equals(TourChoice.tourChosen))
                    {
                        tourPriceLbl.Text = String.Format("Price: ${0}/pax", TourChoice.calcTotal(x.Price));
                    }
                }
            }
            tourPriceLbl.Refresh();
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

        private void tourAddWishlistBtn_Click(object sender, EventArgs e)
        {
            
            TourCollection.ToWishlist(tourNameLbl.Text);

            MessageBox.Show("Tour successfully saved to wishlist!", "Wishlist added!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void tourAddCartBtn_Click(object sender, EventArgs e)
        {
            //Changes made here
            string cartItemPrice = tourPriceLbl.Text.Substring(8);
            cartItemPrice = cartItemPrice.Remove(cartItemPrice.Length - 4);
            if (!tourHotelCombox.Text.Equals("-"))
            {
                TourCollection.InsertCart(tourNameLbl.Text, cartItemPrice, tourQuantityNumeric.Value.ToString(), tourHotelCombox.Text.Substring(0,1));

                MessageBox.Show("Tour successfully added to cart!", "Cart item added!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else MessageBox.Show("Please input the type of hotel you wish to stay in.");
        }
    }
}
