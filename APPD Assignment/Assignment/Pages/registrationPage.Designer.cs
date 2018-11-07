namespace Assignment
{
    partial class registrationPage
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(registrationPage));
            this.menuBar = new System.Windows.Forms.Panel();
            this.menuTitle = new System.Windows.Forms.Label();
            this.minimizeBtn = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.Button();
            this.backColorCombox = new System.Windows.Forms.ComboBox();
            this.backColorBtn = new System.Windows.Forms.Button();
            this.registerLogo = new System.Windows.Forms.Label();
            this.premiumTxt = new System.Windows.Forms.Label();
            this.isPremiumBtn = new System.Windows.Forms.Button();
            this.isFreeBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.backBtnToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.isPremiumToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuBar.SuspendLayout();
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
            this.menuBar.Size = new System.Drawing.Size(700, 30);
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
            this.menuTitle.Size = new System.Drawing.Size(173, 21);
            this.menuTitle.TabIndex = 3;
            this.menuTitle.Text = "deTour - Registration Page";
            this.menuTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // minimizeBtn
            // 
            this.minimizeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(72)))), ((int)(((byte)(105)))));
            this.minimizeBtn.FlatAppearance.BorderSize = 0;
            this.minimizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeBtn.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold);
            this.minimizeBtn.ForeColor = System.Drawing.Color.Black;
            this.minimizeBtn.Location = new System.Drawing.Point(610, 5);
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
            this.closeBtn.Location = new System.Drawing.Point(655, 5);
            this.closeBtn.Margin = new System.Windows.Forms.Padding(0);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(40, 20);
            this.closeBtn.TabIndex = 1;
            this.closeBtn.Text = "✖";
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // backColorCombox
            // 
            this.backColorCombox.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backColorCombox.FormattingEnabled = true;
            this.backColorCombox.Items.AddRange(new object[] {
            "Downy SW",
            "White",
            "Gray"});
            this.backColorCombox.Location = new System.Drawing.Point(518, 416);
            this.backColorCombox.Name = "backColorCombox";
            this.backColorCombox.Size = new System.Drawing.Size(89, 22);
            this.backColorCombox.TabIndex = 4;
            this.backColorCombox.Text = "Theme Color";
            // 
            // backColorBtn
            // 
            this.backColorBtn.BackColor = System.Drawing.Color.White;
            this.backColorBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backColorBtn.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Bold);
            this.backColorBtn.Location = new System.Drawing.Point(613, 415);
            this.backColorBtn.Name = "backColorBtn";
            this.backColorBtn.Size = new System.Drawing.Size(75, 23);
            this.backColorBtn.TabIndex = 6;
            this.backColorBtn.Text = "Change";
            this.backColorBtn.UseVisualStyleBackColor = false;
            this.backColorBtn.Click += new System.EventHandler(this.backColorBtn_Click);
            // 
            // registerLogo
            // 
            this.registerLogo.AutoSize = true;
            this.registerLogo.Image = ((System.Drawing.Image)(resources.GetObject("registerLogo.Image")));
            this.registerLogo.Location = new System.Drawing.Point(102, 221);
            this.registerLogo.Name = "registerLogo";
            this.registerLogo.Size = new System.Drawing.Size(505, 260);
            this.registerLogo.TabIndex = 7;
            this.registerLogo.Text = resources.GetString("registerLogo.Text");
            // 
            // premiumTxt
            // 
            this.premiumTxt.AutoSize = true;
            this.premiumTxt.Font = new System.Drawing.Font("Leelawadee UI Semilight", 30F);
            this.premiumTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(58)))), ((int)(((byte)(86)))));
            this.premiumTxt.Location = new System.Drawing.Point(59, 79);
            this.premiumTxt.Name = "premiumTxt";
            this.premiumTxt.Size = new System.Drawing.Size(592, 54);
            this.premiumTxt.TabIndex = 8;
            this.premiumTxt.Text = "Want to be a premium member?";
            // 
            // isPremiumBtn
            // 
            this.isPremiumBtn.Font = new System.Drawing.Font("Leelawadee UI Semilight", 30F);
            this.isPremiumBtn.Location = new System.Drawing.Point(105, 163);
            this.isPremiumBtn.Name = "isPremiumBtn";
            this.isPremiumBtn.Size = new System.Drawing.Size(201, 64);
            this.isPremiumBtn.TabIndex = 9;
            this.isPremiumBtn.Text = "Yes";
            this.isPremiumBtn.UseVisualStyleBackColor = true;
            this.isPremiumBtn.Click += new System.EventHandler(this.isPremiumBtn_Click);
            // 
            // isFreeBtn
            // 
            this.isFreeBtn.Font = new System.Drawing.Font("Leelawadee UI Semilight", 30F);
            this.isFreeBtn.Location = new System.Drawing.Point(389, 163);
            this.isFreeBtn.Name = "isFreeBtn";
            this.isFreeBtn.Size = new System.Drawing.Size(201, 64);
            this.isFreeBtn.TabIndex = 10;
            this.isFreeBtn.Text = "No";
            this.isFreeBtn.UseVisualStyleBackColor = true;
            this.isFreeBtn.Click += new System.EventHandler(this.isFreeBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.FlatAppearance.BorderSize = 0;
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBtn.Font = new System.Drawing.Font("Cooper Black", 50F, System.Drawing.FontStyle.Bold);
            this.backBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(58)))), ((int)(((byte)(86)))));
            this.backBtn.Location = new System.Drawing.Point(-6, 6);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(91, 76);
            this.backBtn.TabIndex = 11;
            this.backBtn.Text = "←";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // backBtnToolTip
            // 
            this.backBtnToolTip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(58)))), ((int)(((byte)(86)))));
            this.backBtnToolTip.ToolTipTitle = "Back Button";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(241, 446);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 12;
            // 
            // isPremiumToolTip
            // 
            this.isPremiumToolTip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(58)))), ((int)(((byte)(86)))));
            this.isPremiumToolTip.ToolTipTitle = "Yes, I want to be a premium member.";
            // 
            // registrationPage
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(245)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(700, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.isFreeBtn);
            this.Controls.Add(this.isPremiumBtn);
            this.Controls.Add(this.premiumTxt);
            this.Controls.Add(this.backColorBtn);
            this.Controls.Add(this.backColorCombox);
            this.Controls.Add(this.menuBar);
            this.Controls.Add(this.registerLogo);
            this.Controls.Add(this.backBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "registrationPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registration";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.registerPage_FormClosing);
            this.menuBar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel menuBar;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Button minimizeBtn;
        private System.Windows.Forms.ComboBox backColorCombox;
        private System.Windows.Forms.Button backColorBtn;
        private System.Windows.Forms.Label menuTitle;
        private System.Windows.Forms.Label registerLogo;
        private System.Windows.Forms.Label premiumTxt;
        private System.Windows.Forms.Button isPremiumBtn;
        private System.Windows.Forms.Button isFreeBtn;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.ToolTip backBtnToolTip;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolTip isPremiumToolTip;
    }
}

