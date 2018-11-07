namespace Assignment
{
    partial class welcomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(welcomePage));
            this.menuBar = new System.Windows.Forms.Panel();
            this.menuTitle = new System.Windows.Forms.Label();
            this.minimizeBtn = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.Button();
            this.welcomeLbl = new System.Windows.Forms.Label();
            this.loginBtn = new System.Windows.Forms.Button();
            this.registerBtn = new System.Windows.Forms.Button();
            this.backColorCombox = new System.Windows.Forms.ComboBox();
            this.backColorBtn = new System.Windows.Forms.Button();
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
            // welcomeLbl
            // 
            this.welcomeLbl.AutoSize = true;
            this.welcomeLbl.Font = new System.Drawing.Font("Leelawadee UI Semilight", 40F);
            this.welcomeLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(58)))), ((int)(((byte)(86)))));
            this.welcomeLbl.Location = new System.Drawing.Point(104, 50);
            this.welcomeLbl.Name = "welcomeLbl";
            this.welcomeLbl.Size = new System.Drawing.Size(491, 72);
            this.welcomeLbl.TabIndex = 1;
            this.welcomeLbl.Text = "Welcome to deTour";
            // 
            // loginBtn
            // 
            this.loginBtn.FlatAppearance.BorderSize = 0;
            this.loginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginBtn.Image = ((System.Drawing.Image)(resources.GetObject("loginBtn.Image")));
            this.loginBtn.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.loginBtn.Location = new System.Drawing.Point(62, 130);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(271, 271);
            this.loginBtn.TabIndex = 2;
            this.loginBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // registerBtn
            // 
            this.registerBtn.FlatAppearance.BorderSize = 0;
            this.registerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registerBtn.Image = ((System.Drawing.Image)(resources.GetObject("registerBtn.Image")));
            this.registerBtn.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.registerBtn.Location = new System.Drawing.Point(367, 130);
            this.registerBtn.Name = "registerBtn";
            this.registerBtn.Size = new System.Drawing.Size(271, 271);
            this.registerBtn.TabIndex = 3;
            this.registerBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.registerBtn.UseVisualStyleBackColor = true;
            this.registerBtn.Click += new System.EventHandler(this.registerBtn_Click);
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
            // welcomePage
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(245)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(700, 450);
            this.Controls.Add(this.backColorBtn);
            this.Controls.Add(this.backColorCombox);
            this.Controls.Add(this.registerBtn);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.welcomeLbl);
            this.Controls.Add(this.menuBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "welcomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.welcomePage_FormClosing);
            this.menuBar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel menuBar;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Button minimizeBtn;
        private System.Windows.Forms.Label welcomeLbl;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Button registerBtn;
        private System.Windows.Forms.ComboBox backColorCombox;
        private System.Windows.Forms.Button backColorBtn;
        private System.Windows.Forms.Label menuTitle;
    }
}

