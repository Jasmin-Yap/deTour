namespace Assignment
{
    partial class loginPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginPage));
            this.menuBar = new System.Windows.Forms.Panel();
            this.menuTitle = new System.Windows.Forms.Label();
            this.minimizeBtn = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.Button();
            this.backColorCombox = new System.Windows.Forms.ComboBox();
            this.backColorBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.usernameLbl = new System.Windows.Forms.Label();
            this.passwordLbl = new System.Windows.Forms.Label();
            this.usernameText = new System.Windows.Forms.TextBox();
            this.passwordText = new System.Windows.Forms.TextBox();
            this.loginBtn = new System.Windows.Forms.Button();
            this.loginLbl = new System.Windows.Forms.Label();
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
            this.menuTitle.Size = new System.Drawing.Size(133, 21);
            this.menuTitle.TabIndex = 3;
            this.menuTitle.Text = "deTour - Log In";
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
            // backBtn
            // 
            this.backBtn.FlatAppearance.BorderSize = 0;
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBtn.Font = new System.Drawing.Font("Cooper Black", 50F, System.Drawing.FontStyle.Bold);
            this.backBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(58)))), ((int)(((byte)(86)))));
            this.backBtn.Location = new System.Drawing.Point(-6, 6);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(91, 76);
            this.backBtn.TabIndex = 12;
            this.backBtn.Text = "←";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // usernameLbl
            // 
            this.usernameLbl.AutoSize = true;
            this.usernameLbl.Font = new System.Drawing.Font("Leelawadee UI Semilight", 25F);
            this.usernameLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(58)))), ((int)(((byte)(86)))));
            this.usernameLbl.Location = new System.Drawing.Point(74, 154);
            this.usernameLbl.Name = "usernameLbl";
            this.usernameLbl.Size = new System.Drawing.Size(175, 46);
            this.usernameLbl.TabIndex = 13;
            this.usernameLbl.Text = "Username:";
            // 
            // passwordLbl
            // 
            this.passwordLbl.AutoSize = true;
            this.passwordLbl.Font = new System.Drawing.Font("Leelawadee UI Semilight", 25F);
            this.passwordLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(58)))), ((int)(((byte)(86)))));
            this.passwordLbl.Location = new System.Drawing.Point(83, 219);
            this.passwordLbl.Name = "passwordLbl";
            this.passwordLbl.Size = new System.Drawing.Size(166, 46);
            this.passwordLbl.TabIndex = 14;
            this.passwordLbl.Text = "Password:";
            // 
            // usernameText
            // 
            this.usernameText.Font = new System.Drawing.Font("Leelawadee UI Semilight", 25F);
            this.usernameText.Location = new System.Drawing.Point(255, 148);
            this.usernameText.Name = "usernameText";
            this.usernameText.Size = new System.Drawing.Size(360, 52);
            this.usernameText.TabIndex = 15;
            // 
            // passwordText
            // 
            this.passwordText.Font = new System.Drawing.Font("Leelawadee UI Semilight", 25F);
            this.passwordText.Location = new System.Drawing.Point(255, 216);
            this.passwordText.Name = "passwordText";
            this.passwordText.PasswordChar = '*';
            this.passwordText.Size = new System.Drawing.Size(360, 52);
            this.passwordText.TabIndex = 16;
            // 
            // loginBtn
            // 
            this.loginBtn.Font = new System.Drawing.Font("Leelawadee UI Semilight", 30F, System.Drawing.FontStyle.Bold);
            this.loginBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(58)))), ((int)(((byte)(86)))));
            this.loginBtn.Location = new System.Drawing.Point(227, 319);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(246, 67);
            this.loginBtn.TabIndex = 17;
            this.loginBtn.Text = "Log In";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // loginLbl
            // 
            this.loginLbl.AutoSize = true;
            this.loginLbl.Font = new System.Drawing.Font("Leelawadee UI Semilight", 35F, System.Drawing.FontStyle.Bold);
            this.loginLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(58)))), ((int)(((byte)(86)))));
            this.loginLbl.Location = new System.Drawing.Point(216, 55);
            this.loginLbl.Name = "loginLbl";
            this.loginLbl.Size = new System.Drawing.Size(285, 62);
            this.loginLbl.TabIndex = 18;
            this.loginLbl.Text = "Log-In Page";
            // 
            // loginPage
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(245)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(700, 450);
            this.Controls.Add(this.loginLbl);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.passwordText);
            this.Controls.Add(this.usernameText);
            this.Controls.Add(this.passwordLbl);
            this.Controls.Add(this.usernameLbl);
            this.Controls.Add(this.backColorBtn);
            this.Controls.Add(this.backColorCombox);
            this.Controls.Add(this.menuBar);
            this.Controls.Add(this.backBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "loginPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Log In Page";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.loginPage_FormClosing);
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
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Label usernameLbl;
        private System.Windows.Forms.Label passwordLbl;
        private System.Windows.Forms.TextBox usernameText;
        private System.Windows.Forms.TextBox passwordText;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Label loginLbl;
    }
}

