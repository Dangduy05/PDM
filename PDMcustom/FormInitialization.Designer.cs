namespace PDMcustom
{
    partial class FormInitialization
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
            this.picForeground = new System.Windows.Forms.PictureBox();
            this.labelClock = new System.Windows.Forms.Label();
            this.timerClock = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picForeground)).BeginInit();
            this.SuspendLayout();
            // 
            // picForeground
            // 
            this.picForeground.BackColor = System.Drawing.Color.Transparent;
            this.picForeground.Image = global::PDMcustom.Properties.Resources.app_foreground;
            this.picForeground.Location = new System.Drawing.Point(280, 120);
            this.picForeground.Name = "picForeground";
            this.picForeground.Size = new System.Drawing.Size(240, 80);
            this.picForeground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picForeground.TabIndex = 0;
            this.picForeground.TabStop = false;
            this.picForeground.WaitOnLoad = true;
            // 
            // labelClock
            // 
            this.labelClock.AutoSize = true;
            this.labelClock.BackColor = System.Drawing.Color.Transparent;
            this.labelClock.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClock.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelClock.Location = new System.Drawing.Point(300, 300);
            this.labelClock.Name = "labelClock";
            this.labelClock.Size = new System.Drawing.Size(184, 69);
            this.labelClock.TabIndex = 1;
            this.labelClock.Text = "00:00";
            // 
            // timerClock
            // 
            this.timerClock.Enabled = true;
            this.timerClock.Interval = 10;
            this.timerClock.Tick += new System.EventHandler(this.timerClock_Tick);
            // 
            // FormInitialization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PDMcustom.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.ControlBox = false;
            this.Controls.Add(this.labelClock);
            this.Controls.Add(this.picForeground);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormInitialization";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Initialization_FormClosing);
            this.Load += new System.EventHandler(this.Form_Initialization_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picForeground)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picForeground;
        private System.Windows.Forms.Label labelClock;
        private System.Windows.Forms.Timer timerClock;
    }
}

