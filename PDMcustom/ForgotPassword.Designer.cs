namespace PDMcustom
{
    partial class ForgotPassword
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
            this.labelFP = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.panelForgotPassword = new System.Windows.Forms.Panel();
            this.btnReturnLogin = new System.Windows.Forms.Button();
            this.iconLock1 = new System.Windows.Forms.PictureBox();
            this.labelError = new System.Windows.Forms.Label();
            this.btnReturnFP = new System.Windows.Forms.Button();
            this.panelVerifyCode = new System.Windows.Forms.Panel();
            this.iconLock0 = new System.Windows.Forms.PictureBox();
            this.labelError1 = new System.Windows.Forms.Label();
            this.labelEnterVerifyCode = new System.Windows.Forms.Label();
            this.Minimize_Box = new System.Windows.Forms.PictureBox();
            this.btnClick = new System.Windows.Forms.PictureBox();
            this.btnVerifyCode = new PDMcustom.Controls.Button();
            this.panelUsername = new PDMcustom.Controls.Panel();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.panel1 = new PDMcustom.Controls.Panel();
            this.tbVerifyCode = new System.Windows.Forms.TextBox();
            this.btnSendAgain = new PDMcustom.Controls.Button();
            this.btnConfirm = new PDMcustom.Controls.Button();
            this.panelForgotPassword.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconLock1)).BeginInit();
            this.panelVerifyCode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconLock0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimize_Box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClick)).BeginInit();
            this.panelUsername.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelFP
            // 
            this.labelFP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.labelFP.Location = new System.Drawing.Point(0, 195);
            this.labelFP.Name = "labelFP";
            this.labelFP.Size = new System.Drawing.Size(480, 30);
            this.labelFP.TabIndex = 17;
            this.labelFP.Text = "QUÊN MẬT KHẨU";
            this.labelFP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelDescription
            // 
            this.labelDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.labelDescription.Location = new System.Drawing.Point(96, 220);
            this.labelDescription.MaximumSize = new System.Drawing.Size(291, 48);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(291, 48);
            this.labelDescription.TabIndex = 18;
            this.labelDescription.Text = "Nhập email của bạn để được gửi mã xác nhận thay đổi mật khẩu";
            this.labelDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelForgotPassword
            // 
            this.panelForgotPassword.BackColor = System.Drawing.Color.White;
            this.panelForgotPassword.Controls.Add(this.btnVerifyCode);
            this.panelForgotPassword.Controls.Add(this.panelUsername);
            this.panelForgotPassword.Controls.Add(this.btnReturnLogin);
            this.panelForgotPassword.Controls.Add(this.iconLock1);
            this.panelForgotPassword.Controls.Add(this.labelError);
            this.panelForgotPassword.Controls.Add(this.labelFP);
            this.panelForgotPassword.Controls.Add(this.labelDescription);
            this.panelForgotPassword.Location = new System.Drawing.Point(0, 32);
            this.panelForgotPassword.Name = "panelForgotPassword";
            this.panelForgotPassword.Size = new System.Drawing.Size(480, 608);
            this.panelForgotPassword.TabIndex = 19;
            // 
            // btnReturnLogin
            // 
            this.btnReturnLogin.BackColor = System.Drawing.Color.Gainsboro;
            this.btnReturnLogin.FlatAppearance.BorderSize = 0;
            this.btnReturnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturnLogin.Location = new System.Drawing.Point(0, 572);
            this.btnReturnLogin.Margin = new System.Windows.Forms.Padding(0);
            this.btnReturnLogin.Name = "btnReturnLogin";
            this.btnReturnLogin.Size = new System.Drawing.Size(480, 36);
            this.btnReturnLogin.TabIndex = 25;
            this.btnReturnLogin.Text = "Quay lại";
            this.btnReturnLogin.UseVisualStyleBackColor = false;
            this.btnReturnLogin.Click += new System.EventHandler(this.btnReturnLogin_Click);
            // 
            // iconLock1
            // 
            this.iconLock1.BackColor = System.Drawing.Color.Transparent;
            this.iconLock1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.iconLock1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.iconLock1.Image = global::PDMcustom.Properties.Resources.lock_icon;
            this.iconLock1.Location = new System.Drawing.Point(160, 32);
            this.iconLock1.Name = "iconLock1";
            this.iconLock1.Size = new System.Drawing.Size(160, 160);
            this.iconLock1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconLock1.TabIndex = 23;
            this.iconLock1.TabStop = false;
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelError.ForeColor = System.Drawing.Color.Red;
            this.labelError.Location = new System.Drawing.Point(30, 365);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(115, 16);
            this.labelError.TabIndex = 22;
            this.labelError.Text = "Error goes here";
            // 
            // btnReturnFP
            // 
            this.btnReturnFP.BackColor = System.Drawing.Color.Gainsboro;
            this.btnReturnFP.FlatAppearance.BorderSize = 0;
            this.btnReturnFP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturnFP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturnFP.Location = new System.Drawing.Point(0, 572);
            this.btnReturnFP.Name = "btnReturnFP";
            this.btnReturnFP.Size = new System.Drawing.Size(480, 36);
            this.btnReturnFP.TabIndex = 26;
            this.btnReturnFP.Text = "Quay lại";
            this.btnReturnFP.UseVisualStyleBackColor = false;
            this.btnReturnFP.Click += new System.EventHandler(this.btnReturnFP_Click);
            // 
            // panelVerifyCode
            // 
            this.panelVerifyCode.BackColor = System.Drawing.Color.White;
            this.panelVerifyCode.Controls.Add(this.panel1);
            this.panelVerifyCode.Controls.Add(this.btnSendAgain);
            this.panelVerifyCode.Controls.Add(this.btnConfirm);
            this.panelVerifyCode.Controls.Add(this.iconLock0);
            this.panelVerifyCode.Controls.Add(this.btnReturnFP);
            this.panelVerifyCode.Controls.Add(this.labelError1);
            this.panelVerifyCode.Controls.Add(this.labelEnterVerifyCode);
            this.panelVerifyCode.Location = new System.Drawing.Point(0, 32);
            this.panelVerifyCode.Margin = new System.Windows.Forms.Padding(0);
            this.panelVerifyCode.Name = "panelVerifyCode";
            this.panelVerifyCode.Size = new System.Drawing.Size(480, 608);
            this.panelVerifyCode.TabIndex = 21;
            // 
            // iconLock0
            // 
            this.iconLock0.BackColor = System.Drawing.Color.Transparent;
            this.iconLock0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.iconLock0.Location = new System.Drawing.Point(160, 32);
            this.iconLock0.Name = "iconLock0";
            this.iconLock0.Size = new System.Drawing.Size(160, 160);
            this.iconLock0.TabIndex = 24;
            this.iconLock0.TabStop = false;
            // 
            // labelError1
            // 
            this.labelError1.AutoSize = true;
            this.labelError1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelError1.ForeColor = System.Drawing.Color.Red;
            this.labelError1.Location = new System.Drawing.Point(29, 317);
            this.labelError1.Name = "labelError1";
            this.labelError1.Size = new System.Drawing.Size(115, 16);
            this.labelError1.TabIndex = 22;
            this.labelError1.Text = "Error goes here";
            this.labelError1.Visible = false;
            // 
            // labelEnterVerifyCode
            // 
            this.labelEnterVerifyCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.labelEnterVerifyCode.Location = new System.Drawing.Point(0, 195);
            this.labelEnterVerifyCode.Name = "labelEnterVerifyCode";
            this.labelEnterVerifyCode.Size = new System.Drawing.Size(480, 29);
            this.labelEnterVerifyCode.TabIndex = 17;
            this.labelEnterVerifyCode.Text = "NHẬP MÃ XÁC NHẬN";
            this.labelEnterVerifyCode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Minimize_Box
            // 
            this.Minimize_Box.BackColor = System.Drawing.Color.Transparent;
            this.Minimize_Box.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Minimize_Box.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Minimize_Box.Image = global::PDMcustom.Properties.Resources.minimize;
            this.Minimize_Box.Location = new System.Drawing.Point(416, 0);
            this.Minimize_Box.Margin = new System.Windows.Forms.Padding(0);
            this.Minimize_Box.Name = "Minimize_Box";
            this.Minimize_Box.Size = new System.Drawing.Size(32, 32);
            this.Minimize_Box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Minimize_Box.TabIndex = 23;
            this.Minimize_Box.TabStop = false;
            // 
            // btnClick
            // 
            this.btnClick.BackColor = System.Drawing.Color.Transparent;
            this.btnClick.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClick.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClick.Image = global::PDMcustom.Properties.Resources.close;
            this.btnClick.Location = new System.Drawing.Point(448, 0);
            this.btnClick.Margin = new System.Windows.Forms.Padding(0);
            this.btnClick.Name = "btnClick";
            this.btnClick.Size = new System.Drawing.Size(32, 32);
            this.btnClick.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnClick.TabIndex = 22;
            this.btnClick.TabStop = false;
            // 
            // btnVerifyCode
            // 
            this.btnVerifyCode.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnVerifyCode.BackgroundColor = System.Drawing.Color.DeepSkyBlue;
            this.btnVerifyCode.BorderColor = System.Drawing.Color.Black;
            this.btnVerifyCode.BorderRadius = 20;
            this.btnVerifyCode.BorderSize = 0;
            this.btnVerifyCode.FlatAppearance.BorderSize = 0;
            this.btnVerifyCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerifyCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.8F, System.Drawing.FontStyle.Bold);
            this.btnVerifyCode.ForeColor = System.Drawing.Color.White;
            this.btnVerifyCode.Location = new System.Drawing.Point(30, 390);
            this.btnVerifyCode.Name = "btnVerifyCode";
            this.btnVerifyCode.Size = new System.Drawing.Size(420, 60);
            this.btnVerifyCode.TabIndex = 27;
            this.btnVerifyCode.Text = "GỬI MÃ QUA EMAIL";
            this.btnVerifyCode.TextColor = System.Drawing.Color.White;
            this.btnVerifyCode.UseVisualStyleBackColor = false;
            this.btnVerifyCode.Click += new System.EventHandler(this.SendVerificationCode_button_Click);
            // 
            // panelUsername
            // 
            this.panelUsername.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelUsername.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.panelUsername.BorderColor = System.Drawing.Color.Black;
            this.panelUsername.BorderRadius = 30;
            this.panelUsername.BorderSize = 0;
            this.panelUsername.Controls.Add(this.tbUsername);
            this.panelUsername.ForeColor = System.Drawing.Color.White;
            this.panelUsername.Location = new System.Drawing.Point(30, 300);
            this.panelUsername.Margin = new System.Windows.Forms.Padding(2);
            this.panelUsername.Name = "panelUsername";
            this.panelUsername.Size = new System.Drawing.Size(420, 60);
            this.panelUsername.TabIndex = 26;
            this.panelUsername.TextColor = System.Drawing.Color.White;
            // 
            // tbUsername
            // 
            this.tbUsername.AccessibleName = "";
            this.tbUsername.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.tbUsername.ForeColor = System.Drawing.Color.DarkGray;
            this.tbUsername.Location = new System.Drawing.Point(14, 19);
            this.tbUsername.Margin = new System.Windows.Forms.Padding(2);
            this.tbUsername.MinimumSize = new System.Drawing.Size(113, 30);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(404, 20);
            this.tbUsername.TabIndex = 1;
            this.tbUsername.Text = "Email";
            this.tbUsername.Enter += new System.EventHandler(this.tbUsername_Enter);
            this.tbUsername.Leave += new System.EventHandler(this.tbUsername_Leave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.BorderColor = System.Drawing.Color.Black;
            this.panel1.BorderRadius = 30;
            this.panel1.BorderSize = 0;
            this.panel1.Controls.Add(this.tbVerifyCode);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(30, 242);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(420, 60);
            this.panel1.TabIndex = 27;
            this.panel1.TextColor = System.Drawing.Color.White;
            // 
            // tbVerifyCode
            // 
            this.tbVerifyCode.AccessibleName = "";
            this.tbVerifyCode.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbVerifyCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbVerifyCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.tbVerifyCode.ForeColor = System.Drawing.Color.DarkGray;
            this.tbVerifyCode.Location = new System.Drawing.Point(2, 19);
            this.tbVerifyCode.Margin = new System.Windows.Forms.Padding(2);
            this.tbVerifyCode.MinimumSize = new System.Drawing.Size(113, 30);
            this.tbVerifyCode.Name = "tbVerifyCode";
            this.tbVerifyCode.Size = new System.Drawing.Size(416, 20);
            this.tbVerifyCode.TabIndex = 1;
            this.tbVerifyCode.Text = "NHẬP MÃ XÁC NHẬN";
            this.tbVerifyCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbVerifyCode.Enter += new System.EventHandler(this.tbVerifyCode_Enter);
            this.tbVerifyCode.Leave += new System.EventHandler(this.tbVerifyCode_Leave);
            // 
            // btnSendAgain
            // 
            this.btnSendAgain.BackColor = System.Drawing.Color.Silver;
            this.btnSendAgain.BackgroundColor = System.Drawing.Color.Silver;
            this.btnSendAgain.BorderColor = System.Drawing.Color.Black;
            this.btnSendAgain.BorderRadius = 20;
            this.btnSendAgain.BorderSize = 0;
            this.btnSendAgain.FlatAppearance.BorderSize = 0;
            this.btnSendAgain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSendAgain.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.8F, System.Drawing.FontStyle.Bold);
            this.btnSendAgain.ForeColor = System.Drawing.Color.White;
            this.btnSendAgain.Location = new System.Drawing.Point(30, 429);
            this.btnSendAgain.Name = "btnSendAgain";
            this.btnSendAgain.Size = new System.Drawing.Size(420, 60);
            this.btnSendAgain.TabIndex = 29;
            this.btnSendAgain.Text = "Gửi lại mã";
            this.btnSendAgain.TextColor = System.Drawing.Color.White;
            this.btnSendAgain.UseVisualStyleBackColor = false;
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnConfirm.BackgroundColor = System.Drawing.Color.DeepSkyBlue;
            this.btnConfirm.BorderColor = System.Drawing.Color.Black;
            this.btnConfirm.BorderRadius = 20;
            this.btnConfirm.BorderSize = 0;
            this.btnConfirm.FlatAppearance.BorderSize = 0;
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.8F, System.Drawing.FontStyle.Bold);
            this.btnConfirm.ForeColor = System.Drawing.Color.White;
            this.btnConfirm.Location = new System.Drawing.Point(30, 360);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(420, 60);
            this.btnConfirm.TabIndex = 28;
            this.btnConfirm.Text = "XÁC NHẬN";
            this.btnConfirm.TextColor = System.Drawing.Color.White;
            this.btnConfirm.UseVisualStyleBackColor = false;
            // 
            // ForgotPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(480, 640);
            this.Controls.Add(this.Minimize_Box);
            this.Controls.Add(this.btnClick);
            this.Controls.Add(this.panelForgotPassword);
            this.Controls.Add(this.panelVerifyCode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ForgotPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.ForgotPassword_Load);
            this.panelForgotPassword.ResumeLayout(false);
            this.panelForgotPassword.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconLock1)).EndInit();
            this.panelVerifyCode.ResumeLayout(false);
            this.panelVerifyCode.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconLock0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimize_Box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClick)).EndInit();
            this.panelUsername.ResumeLayout(false);
            this.panelUsername.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label labelFP;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Panel panelForgotPassword;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.Panel panelVerifyCode;
        private System.Windows.Forms.Label labelError1;
        private System.Windows.Forms.Label labelEnterVerifyCode;
        private System.Windows.Forms.PictureBox iconLock1;
        private System.Windows.Forms.PictureBox iconLock0;
        private System.Windows.Forms.Button btnReturnFP;
        private System.Windows.Forms.Button btnReturnLogin;
        private Controls.Panel panelUsername;
        private System.Windows.Forms.TextBox tbUsername;
        private Controls.Button btnVerifyCode;
        private Controls.Button btnSendAgain;
        private Controls.Button btnConfirm;
        private Controls.Panel panel1;
        private System.Windows.Forms.TextBox tbVerifyCode;
        private System.Windows.Forms.PictureBox Minimize_Box;
        private System.Windows.Forms.PictureBox btnClick;
    }
}