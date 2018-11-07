namespace Assignment
{
    partial class tourDetailPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tourDetailPage));
            this.menuBar = new System.Windows.Forms.Panel();
            this.menuTitle = new System.Windows.Forms.Label();
            this.minimizeBtn = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.Button();
            this.tourPriceLbl = new System.Windows.Forms.Label();
            this.tourRegionLbl = new System.Windows.Forms.Label();
            this.tourLocationLbl = new System.Windows.Forms.Label();
            this.tourImagePB = new System.Windows.Forms.PictureBox();
            this.tourNameLbl = new System.Windows.Forms.Label();
            this.tourItineraryText = new System.Windows.Forms.TextBox();
            this.tourHotelCombox = new System.Windows.Forms.ComboBox();
            this.tourHotelLbl = new System.Windows.Forms.Label();
            this.tourQuantityNumeric = new System.Windows.Forms.NumericUpDown();
            this.tourQuantityLbl = new System.Windows.Forms.Label();
            this.tourAddCartBtn = new System.Windows.Forms.Button();
            this.tourAddWishlistBtn = new System.Windows.Forms.Button();
            this.tourDatesLbl = new System.Windows.Forms.Label();
            this.menuBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tourImagePB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tourQuantityNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // menuBar
            // 
            this.menuBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(58)))), ((int)(((byte)(86)))));
            this.menuBar.Controls.Add(this.menuTitle);
            this.menuBar.Controls.Add(this.minimizeBtn);
            this.menuBar.Controls.Add(this.closeBtn);
            this.menuBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.menuBar.Location = new System.Drawing.Point(0, 0);
            this.menuBar.Name = "menuBar";
            this.menuBar.Size = new System.Drawing.Size(625, 30);
            this.menuBar.TabIndex = 0;
            this.menuBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.menuBar_MouseDown);
            // 
            // menuTitle
            // 
            this.menuTitle.Font = new System.Drawing.Font("Leelawadee UI Semilight", 12F);
            this.menuTitle.ForeColor = System.Drawing.Color.White;
            this.menuTitle.Image = ((System.Drawing.Image)(resources.GetObject("menuTitle.Image")));
            this.menuTitle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menuTitle.Location = new System.Drawing.Point(5, 4);
            this.menuTitle.Name = "menuTitle";
            this.menuTitle.Size = new System.Drawing.Size(155, 21);
            this.menuTitle.TabIndex = 3;
            this.menuTitle.Text = "deTour - Welcome";
            this.menuTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // minimizeBtn
            // 
            this.minimizeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(72)))), ((int)(((byte)(105)))));
            this.minimizeBtn.FlatAppearance.BorderSize = 0;
            this.minimizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeBtn.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold);
            this.minimizeBtn.ForeColor = System.Drawing.Color.Black;
            this.minimizeBtn.Location = new System.Drawing.Point(536, 6);
            this.minimizeBtn.Margin = new System.Windows.Forms.Padding(0);
            this.minimizeBtn.Name = "minimizeBtn";
            this.minimizeBtn.Size = new System.Drawing.Size(40, 20);
            this.minimizeBtn.TabIndex = 2;
            this.minimizeBtn.Text = "–";
            this.minimizeBtn.UseVisualStyleBackColor = false;
            this.minimizeBtn.Click += new System.EventHandler(this.minimizeBtn_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(72)))), ((int)(((byte)(105)))));
            this.closeBtn.FlatAppearance.BorderSize = 0;
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.closeBtn.ForeColor = System.Drawing.Color.Black;
            this.closeBtn.Location = new System.Drawing.Point(581, 6);
            this.closeBtn.Margin = new System.Windows.Forms.Padding(0);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(40, 20);
            this.closeBtn.TabIndex = 1;
            this.closeBtn.Text = "✖";
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // tourPriceLbl
            // 
            this.tourPriceLbl.AutoSize = true;
            this.tourPriceLbl.Font = new System.Drawing.Font("Leelawadee UI Semilight", 13F);
            this.tourPriceLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(58)))), ((int)(((byte)(86)))));
            this.tourPriceLbl.Location = new System.Drawing.Point(12, 387);
            this.tourPriceLbl.Name = "tourPriceLbl";
            this.tourPriceLbl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tourPriceLbl.Size = new System.Drawing.Size(114, 30);
            this.tourPriceLbl.TabIndex = 25;
            this.tourPriceLbl.Text = "Price Label";
            // 
            // tourRegionLbl
            // 
            this.tourRegionLbl.AutoSize = true;
            this.tourRegionLbl.Font = new System.Drawing.Font("Leelawadee UI Semilight", 13F);
            this.tourRegionLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(58)))), ((int)(((byte)(86)))));
            this.tourRegionLbl.Location = new System.Drawing.Point(12, 364);
            this.tourRegionLbl.Name = "tourRegionLbl";
            this.tourRegionLbl.Size = new System.Drawing.Size(136, 30);
            this.tourRegionLbl.TabIndex = 23;
            this.tourRegionLbl.Text = "Region Label";
            // 
            // tourLocationLbl
            // 
            this.tourLocationLbl.AutoSize = true;
            this.tourLocationLbl.Font = new System.Drawing.Font("Leelawadee UI Semilight", 13F);
            this.tourLocationLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(58)))), ((int)(((byte)(86)))));
            this.tourLocationLbl.Location = new System.Drawing.Point(12, 341);
            this.tourLocationLbl.Name = "tourLocationLbl";
            this.tourLocationLbl.Size = new System.Drawing.Size(144, 30);
            this.tourLocationLbl.TabIndex = 22;
            this.tourLocationLbl.Text = "Country Label";
            // 
            // tourImagePB
            // 
            this.tourImagePB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(245)))), ((int)(((byte)(230)))));
            this.tourImagePB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tourImagePB.Location = new System.Drawing.Point(9, 42);
            this.tourImagePB.Name = "tourImagePB";
            this.tourImagePB.Size = new System.Drawing.Size(605, 249);
            this.tourImagePB.TabIndex = 21;
            this.tourImagePB.TabStop = false;
            // 
            // tourNameLbl
            // 
            this.tourNameLbl.AutoSize = true;
            this.tourNameLbl.Font = new System.Drawing.Font("Leelawadee UI Semilight", 25F, System.Drawing.FontStyle.Bold);
            this.tourNameLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(58)))), ((int)(((byte)(86)))));
            this.tourNameLbl.Location = new System.Drawing.Point(9, 295);
            this.tourNameLbl.Name = "tourNameLbl";
            this.tourNameLbl.Size = new System.Drawing.Size(352, 57);
            this.tourNameLbl.TabIndex = 20;
            this.tourNameLbl.Text = "Tour Name Label";
            // 
            // tourItineraryText
            // 
            this.tourItineraryText.Font = new System.Drawing.Font("Leelawadee UI Semilight", 9F);
            this.tourItineraryText.Location = new System.Drawing.Point(12, 442);
            this.tourItineraryText.Multiline = true;
            this.tourItineraryText.Name = "tourItineraryText";
            this.tourItineraryText.ReadOnly = true;
            this.tourItineraryText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tourItineraryText.Size = new System.Drawing.Size(602, 171);
            this.tourItineraryText.TabIndex = 26;
            // 
            // tourHotelCombox
            // 
            this.tourHotelCombox.Font = new System.Drawing.Font("Leelawadee UI Semilight", 14F);
            this.tourHotelCombox.FormattingEnabled = true;
            this.tourHotelCombox.Items.AddRange(new object[] {
            "-",
            "5 Stars",
            "4 Stars",
            "3 Stars",
            "2 Stars",
            "1 Stars"});
            this.tourHotelCombox.Location = new System.Drawing.Point(448, 364);
            this.tourHotelCombox.Name = "tourHotelCombox";
            this.tourHotelCombox.Size = new System.Drawing.Size(165, 39);
            this.tourHotelCombox.TabIndex = 46;
            this.tourHotelCombox.Text = "-";
            this.tourHotelCombox.SelectedIndexChanged += new System.EventHandler(this.tourHotelCombox_SelectedIndexChanged);
            // 
            // tourHotelLbl
            // 
            this.tourHotelLbl.AutoSize = true;
            this.tourHotelLbl.Font = new System.Drawing.Font("Leelawadee UI Semilight", 15.75F);
            this.tourHotelLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(58)))), ((int)(((byte)(86)))));
            this.tourHotelLbl.Location = new System.Drawing.Point(374, 363);
            this.tourHotelLbl.Name = "tourHotelLbl";
            this.tourHotelLbl.Size = new System.Drawing.Size(86, 37);
            this.tourHotelLbl.TabIndex = 45;
            this.tourHotelLbl.Text = "Hotel:";
            // 
            // tourQuantityNumeric
            // 
            this.tourQuantityNumeric.Font = new System.Drawing.Font("Leelawadee UI Semilight", 14F);
            this.tourQuantityNumeric.Location = new System.Drawing.Point(448, 403);
            this.tourQuantityNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.tourQuantityNumeric.Name = "tourQuantityNumeric";
            this.tourQuantityNumeric.Size = new System.Drawing.Size(166, 39);
            this.tourQuantityNumeric.TabIndex = 47;
            this.tourQuantityNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // tourQuantityLbl
            // 
            this.tourQuantityLbl.AutoSize = true;
            this.tourQuantityLbl.Font = new System.Drawing.Font("Leelawadee UI Semilight", 15.75F);
            this.tourQuantityLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(58)))), ((int)(((byte)(86)))));
            this.tourQuantityLbl.Location = new System.Drawing.Point(344, 401);
            this.tourQuantityLbl.Name = "tourQuantityLbl";
            this.tourQuantityLbl.Size = new System.Drawing.Size(124, 37);
            this.tourQuantityLbl.TabIndex = 48;
            this.tourQuantityLbl.Text = "Quantity:";
            // 
            // tourAddCartBtn
            // 
            this.tourAddCartBtn.FlatAppearance.BorderSize = 0;
            this.tourAddCartBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tourAddCartBtn.Font = new System.Drawing.Font("Leelawadee UI Semilight", 15.75F);
            this.tourAddCartBtn.Image = ((System.Drawing.Image)(resources.GetObject("tourAddCartBtn.Image")));
            this.tourAddCartBtn.Location = new System.Drawing.Point(551, 299);
            this.tourAddCartBtn.Name = "tourAddCartBtn";
            this.tourAddCartBtn.Size = new System.Drawing.Size(60, 59);
            this.tourAddCartBtn.TabIndex = 49;
            this.tourAddCartBtn.UseVisualStyleBackColor = true;
            this.tourAddCartBtn.Click += new System.EventHandler(this.tourAddCartBtn_Click);
            // 
            // tourAddWishlistBtn
            // 
            this.tourAddWishlistBtn.FlatAppearance.BorderSize = 0;
            this.tourAddWishlistBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tourAddWishlistBtn.Font = new System.Drawing.Font("Leelawadee UI Semilight", 15.75F);
            this.tourAddWishlistBtn.Image = ((System.Drawing.Image)(resources.GetObject("tourAddWishlistBtn.Image")));
            this.tourAddWishlistBtn.Location = new System.Drawing.Point(486, 299);
            this.tourAddWishlistBtn.Name = "tourAddWishlistBtn";
            this.tourAddWishlistBtn.Size = new System.Drawing.Size(59, 59);
            this.tourAddWishlistBtn.TabIndex = 50;
            this.tourAddWishlistBtn.UseVisualStyleBackColor = true;
            this.tourAddWishlistBtn.Click += new System.EventHandler(this.tourAddWishlistBtn_Click);
            // 
            // tourDatesLbl
            // 
            this.tourDatesLbl.AutoSize = true;
            this.tourDatesLbl.Font = new System.Drawing.Font("Leelawadee UI Semilight", 13F);
            this.tourDatesLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(58)))), ((int)(((byte)(86)))));
            this.tourDatesLbl.Location = new System.Drawing.Point(12, 410);
            this.tourDatesLbl.Name = "tourDatesLbl";
            this.tourDatesLbl.Size = new System.Drawing.Size(113, 30);
            this.tourDatesLbl.TabIndex = 51;
            this.tourDatesLbl.Text = "Date Label";
            // 
            // tourDetailPage
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(245)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(625, 625);
            this.Controls.Add(this.tourDatesLbl);
            this.Controls.Add(this.tourLocationLbl);
            this.Controls.Add(this.tourAddWishlistBtn);
            this.Controls.Add(this.tourAddCartBtn);
            this.Controls.Add(this.tourQuantityLbl);
            this.Controls.Add(this.tourQuantityNumeric);
            this.Controls.Add(this.tourHotelCombox);
            this.Controls.Add(this.tourHotelLbl);
            this.Controls.Add(this.tourItineraryText);
            this.Controls.Add(this.tourRegionLbl);
            this.Controls.Add(this.tourImagePB);
            this.Controls.Add(this.tourNameLbl);
            this.Controls.Add(this.menuBar);
            this.Controls.Add(this.tourPriceLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "tourDetailPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "d";
            this.menuBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tourImagePB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tourQuantityNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel menuBar;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Button minimizeBtn;
        private System.Windows.Forms.Label menuTitle;
        private System.Windows.Forms.Label tourPriceLbl;
        private System.Windows.Forms.Label tourRegionLbl;
        private System.Windows.Forms.Label tourLocationLbl;
        private System.Windows.Forms.PictureBox tourImagePB;
        private System.Windows.Forms.Label tourNameLbl;
        private System.Windows.Forms.TextBox tourItineraryText;
        private System.Windows.Forms.ComboBox tourHotelCombox;
        private System.Windows.Forms.Label tourHotelLbl;
        private System.Windows.Forms.NumericUpDown tourQuantityNumeric;
        private System.Windows.Forms.Label tourQuantityLbl;
        private System.Windows.Forms.Button tourAddCartBtn;
        private System.Windows.Forms.Button tourAddWishlistBtn;
        private System.Windows.Forms.Label tourDatesLbl;
    }
}

