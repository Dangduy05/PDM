namespace PDMcustom
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.labelVersion = new System.Windows.Forms.Label();
            this.labelForgotPassword = new System.Windows.Forms.Label();
            this.LoginPanel = new System.Windows.Forms.Panel();
            this.labelStatus = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.chkSaveLogin = new System.Windows.Forms.CheckBox();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.Minimize_Box = new System.Windows.Forms.PictureBox();
            this.btnClick = new System.Windows.Forms.PictureBox();
            this.panel2 = new PDMcustom.Controls.Panel();
            this.picHide = new FontAwesome.Sharp.IconPictureBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.picShow = new FontAwesome.Sharp.IconPictureBox();
            this.panel1 = new PDMcustom.Controls.Panel();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.btnLogin = new PDMcustom.Controls.Button();
            this.LoginPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimize_Box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClick)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picShow)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelVersion
            // 
            this.labelVersion.BackColor = System.Drawing.Color.White;
            this.labelVersion.Location = new System.Drawing.Point(0, 615);
            this.labelVersion.Margin = new System.Windows.Forms.Padding(0);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Padding = new System.Windows.Forms.Padding(8, 0, 15, 0);
            this.labelVersion.Size = new System.Drawing.Size(481, 25);
            this.labelVersion.TabIndex = 13;
            this.labelVersion.Text = "Version";
            this.labelVersion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelForgotPassword
            // 
            this.labelForgotPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelForgotPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelForgotPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(94)))), ((int)(((byte)(160)))));
            this.labelForgotPassword.Location = new System.Drawing.Point(2, 476);
            this.labelForgotPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelForgotPassword.Name = "labelForgotPassword";
            this.labelForgotPassword.Size = new System.Drawing.Size(477, 49);
            this.labelForgotPassword.TabIndex = 5;
            this.labelForgotPassword.Text = "Không thể đăng nhập?";
            this.labelForgotPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelForgotPassword.Click += new System.EventHandler(this.labelForgotPassword_Click);
            // 
            // LoginPanel
            // 
            this.LoginPanel.BackColor = System.Drawing.Color.White;
            this.LoginPanel.Controls.Add(this.labelStatus);
            this.LoginPanel.Controls.Add(this.panel2);
            this.LoginPanel.Controls.Add(this.panel1);
            this.LoginPanel.Controls.Add(this.btnLogin);
            this.LoginPanel.Controls.Add(this.pictureBox1);
            this.LoginPanel.Controls.Add(this.chkSaveLogin);
            this.LoginPanel.Controls.Add(this.picLogo);
            this.LoginPanel.Controls.Add(this.labelForgotPassword);
            this.LoginPanel.Location = new System.Drawing.Point(0, 32);
            this.LoginPanel.Margin = new System.Windows.Forms.Padding(0);
            this.LoginPanel.Name = "LoginPanel";
            this.LoginPanel.Size = new System.Drawing.Size(481, 583);
            this.LoginPanel.TabIndex = 14;
            // 
            // labelStatus
            // 
            this.labelStatus.BackColor = System.Drawing.Color.White;
            this.labelStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F);
            this.labelStatus.ForeColor = System.Drawing.Color.Red;
            this.labelStatus.Location = new System.Drawing.Point(30, 356);
            this.labelStatus.Margin = new System.Windows.Forms.Padding(0);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Padding = new System.Windows.Forms.Padding(8, 0, 15, 0);
            this.labelStatus.Size = new System.Drawing.Size(419, 25);
            this.labelStatus.TabIndex = 17;
            this.labelStatus.Text = "Status: Waiting for connection";
            this.labelStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(410, 25);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // chkSaveLogin
            // 
            this.chkSaveLogin.AutoSize = true;
            this.chkSaveLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.chkSaveLogin.Location = new System.Drawing.Point(38, 321);
            this.chkSaveLogin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkSaveLogin.Name = "chkSaveLogin";
            this.chkSaveLogin.Size = new System.Drawing.Size(201, 24);
            this.chkSaveLogin.TabIndex = 9;
            this.chkSaveLogin.Text = "Lưu thông tin đăng nhập";
            this.chkSaveLogin.UseVisualStyleBackColor = true;
            this.chkSaveLogin.CheckedChanged += new System.EventHandler(this.chkSaveLogin_CheckedChanged);
            // 
            // picLogo
            // 
            this.picLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picLogo.Image = global::PDMcustom.Properties.Resources.app_foreground;
            this.picLogo.Location = new System.Drawing.Point(140, 64);
            this.picLogo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(200, 64);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 8;
            this.picLogo.TabStop = false;
            // 
            // Minimize_Box
            // 
            this.Minimize_Box.BackColor = System.Drawing.Color.Transparent;
            this.Minimize_Box.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Minimize_Box.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Minimize_Box.Image = ((System.Drawing.Image)(resources.GetObject("Minimize_Box.Image")));
            this.Minimize_Box.Location = new System.Drawing.Point(417, 0);
            this.Minimize_Box.Margin = new System.Windows.Forms.Padding(0);
            this.Minimize_Box.Name = "Minimize_Box";
            this.Minimize_Box.Size = new System.Drawing.Size(32, 32);
            this.Minimize_Box.TabIndex = 16;
            this.Minimize_Box.TabStop = false;
            // 
            // btnClick
            // 
            this.btnClick.BackColor = System.Drawing.Color.Transparent;
            this.btnClick.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClick.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClick.Image = ((System.Drawing.Image)(resources.GetObject("btnClick.Image")));
            this.btnClick.Location = new System.Drawing.Point(449, 0);
            this.btnClick.Margin = new System.Windows.Forms.Padding(0);
            this.btnClick.Name = "btnClick";
            this.btnClick.Size = new System.Drawing.Size(32, 32);
            this.btnClick.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnClick.TabIndex = 15;
            this.btnClick.TabStop = false;
            this.btnClick.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.BorderColor = System.Drawing.Color.Black;
            this.panel2.BorderRadius = 20;
            this.panel2.BorderSize = 0;
            this.panel2.Controls.Add(this.picHide);
            this.panel2.Controls.Add(this.tbPassword);
            this.panel2.Controls.Add(this.picShow);
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(30, 262);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(420, 49);
            this.panel2.TabIndex = 16;
            this.panel2.TextColor = System.Drawing.Color.White;
            // 
            // picHide
            // 
            this.picHide.BackColor = System.Drawing.Color.WhiteSmoke;
            this.picHide.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picHide.BackgroundImage")));
            this.picHide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picHide.IconChar = FontAwesome.Sharp.IconChar.None;
            this.picHide.IconColor = System.Drawing.Color.White;
            this.picHide.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.picHide.IconSize = 30;
            this.picHide.Location = new System.Drawing.Point(382, 8);
            this.picHide.Margin = new System.Windows.Forms.Padding(2);
            this.picHide.Name = "picHide";
            this.picHide.Size = new System.Drawing.Size(30, 32);
            this.picHide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHide.TabIndex = 2;
            this.picHide.TabStop = false;
            this.picHide.Click += new System.EventHandler(this.btnHide_Click);
            // 
            // tbPassword
            // 
            this.tbPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPassword.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.tbPassword.ForeColor = System.Drawing.Color.DarkGray;
            this.tbPassword.Location = new System.Drawing.Point(8, 14);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(2);
            this.tbPassword.MinimumSize = new System.Drawing.Size(240, 30);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '●';
            this.tbPassword.Size = new System.Drawing.Size(374, 20);
            this.tbPassword.TabIndex = 2;
            this.tbPassword.Text = "●●●●●●●●";
            this.tbPassword.Enter += new System.EventHandler(this.tbPassword_Enter);
            this.tbPassword.Leave += new System.EventHandler(this.tbPassword_Leave);
            // 
            // picShow
            // 
            this.picShow.BackColor = System.Drawing.Color.Transparent;
            this.picShow.BackgroundImage = global::PDMcustom.Properties.Resources.eye;
            this.picShow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picShow.ForeColor = System.Drawing.Color.Transparent;
            this.picShow.IconChar = FontAwesome.Sharp.IconChar.None;
            this.picShow.IconColor = System.Drawing.Color.Transparent;
            this.picShow.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.picShow.IconSize = 30;
            this.picShow.Location = new System.Drawing.Point(382, 8);
            this.picShow.Margin = new System.Windows.Forms.Padding(2);
            this.picShow.Name = "picShow";
            this.picShow.Size = new System.Drawing.Size(30, 32);
            this.picShow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picShow.TabIndex = 3;
            this.picShow.TabStop = false;
            this.picShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.BorderColor = System.Drawing.Color.Black;
            this.panel1.BorderRadius = 30;
            this.panel1.BorderSize = 0;
            this.panel1.Controls.Add(this.tbUsername);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(30, 179);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(420, 49);
            this.panel1.TabIndex = 15;
            this.panel1.TextColor = System.Drawing.Color.White;
            // 
            // tbUsername
            // 
            this.tbUsername.AccessibleName = "";
            this.tbUsername.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.tbUsername.ForeColor = System.Drawing.Color.DarkGray;
            this.tbUsername.Location = new System.Drawing.Point(8, 14);
            this.tbUsername.Margin = new System.Windows.Forms.Padding(2);
            this.tbUsername.MinimumSize = new System.Drawing.Size(113, 30);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(404, 20);
            this.tbUsername.TabIndex = 1;
            this.tbUsername.Text = "Email";
            this.tbUsername.Enter += new System.EventHandler(this.tbUsername_Enter);
            this.tbUsername.Leave += new System.EventHandler(this.tbUsername_Leave);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnLogin.BackgroundColor = System.Drawing.Color.DeepSkyBlue;
            this.btnLogin.BorderColor = System.Drawing.Color.Black;
            this.btnLogin.BorderRadius = 20;
            this.btnLogin.BorderSize = 0;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(30, 390);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(420, 49);
            this.btnLogin.TabIndex = 14;
            this.btnLogin.Text = "Đăng nhập";
            this.btnLogin.TextColor = System.Drawing.Color.White;
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(480, 640);
            this.ControlBox = false;
            this.Controls.Add(this.Minimize_Box);
            this.Controls.Add(this.btnClick);
            this.Controls.Add(this.labelVersion);
            this.Controls.Add(this.LoginPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.LoginPanel.ResumeLayout(false);
            this.LoginPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimize_Box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClick)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picShow)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label labelForgotPassword;
        private System.Windows.Forms.Panel LoginPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox chkSaveLogin;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.PictureBox Minimize_Box;
        private System.Windows.Forms.PictureBox btnClick;
        private Controls.Button btnLogin;
        private Controls.Panel panel2;
        private Controls.Panel panel1;
        private FontAwesome.Sharp.IconPictureBox picShow;
        private FontAwesome.Sharp.IconPictureBox picHide;
        private System.Windows.Forms.Label labelStatus;
        public System.Windows.Forms.TextBox tbUsername;
    }
}