namespace PDMcustom.ChildForm
{
    partial class Attachment
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
            this.flpAttachment = new System.Windows.Forms.FlowLayoutPanel();
            this.btnDrive = new System.Windows.Forms.Button();
            this.btnOneDrive = new System.Windows.Forms.Button();
            this.btnLocal = new System.Windows.Forms.Button();
            this.flpAttachment.SuspendLayout();
            this.SuspendLayout();
            // 
            // flpAttachment
            // 
            this.flpAttachment.BackColor = System.Drawing.SystemColors.ControlDark;
            this.flpAttachment.Controls.Add(this.btnDrive);
            this.flpAttachment.Controls.Add(this.btnOneDrive);
            this.flpAttachment.Controls.Add(this.btnLocal);
            this.flpAttachment.Location = new System.Drawing.Point(0, 0);
            this.flpAttachment.Margin = new System.Windows.Forms.Padding(2);
            this.flpAttachment.Name = "flpAttachment";
            this.flpAttachment.Size = new System.Drawing.Size(208, 146);
            this.flpAttachment.TabIndex = 48;
            this.flpAttachment.Visible = false;
            // 
            // btnDrive
            // 
            this.btnDrive.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnDrive.FlatAppearance.BorderSize = 0;
            this.btnDrive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDrive.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDrive.ForeColor = System.Drawing.Color.Black;
            this.btnDrive.Image = global::PDMcustom.Properties.Resources.drive;
            this.btnDrive.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDrive.Location = new System.Drawing.Point(0, 0);
            this.btnDrive.Margin = new System.Windows.Forms.Padding(0);
            this.btnDrive.Name = "btnDrive";
            this.btnDrive.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btnDrive.Size = new System.Drawing.Size(208, 49);
            this.btnDrive.TabIndex = 2;
            this.btnDrive.Text = "     Google Drive";
            this.btnDrive.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDrive.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDrive.UseVisualStyleBackColor = false;
            // 
            // btnOneDrive
            // 
            this.btnOneDrive.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnOneDrive.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnOneDrive.FlatAppearance.BorderSize = 0;
            this.btnOneDrive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOneDrive.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOneDrive.ForeColor = System.Drawing.Color.Black;
            this.btnOneDrive.Image = global::PDMcustom.Properties.Resources.cloud;
            this.btnOneDrive.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOneDrive.Location = new System.Drawing.Point(0, 49);
            this.btnOneDrive.Margin = new System.Windows.Forms.Padding(0);
            this.btnOneDrive.Name = "btnOneDrive";
            this.btnOneDrive.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnOneDrive.Size = new System.Drawing.Size(208, 49);
            this.btnOneDrive.TabIndex = 3;
            this.btnOneDrive.Text = "     OneDrive";
            this.btnOneDrive.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOneDrive.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOneDrive.UseVisualStyleBackColor = false;
            // 
            // btnLocal
            // 
            this.btnLocal.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnLocal.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnLocal.FlatAppearance.BorderSize = 0;
            this.btnLocal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLocal.ForeColor = System.Drawing.Color.Black;
            this.btnLocal.Image = global::PDMcustom.Properties.Resources.display;
            this.btnLocal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLocal.Location = new System.Drawing.Point(0, 98);
            this.btnLocal.Margin = new System.Windows.Forms.Padding(0);
            this.btnLocal.Name = "btnLocal";
            this.btnLocal.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnLocal.Size = new System.Drawing.Size(208, 49);
            this.btnLocal.TabIndex = 4;
            this.btnLocal.Text = "     Thiết bị";
            this.btnLocal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLocal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLocal.UseVisualStyleBackColor = false;
            this.btnLocal.Click += new System.EventHandler(this.btnLocal_Click);
            // 
            // Attachment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(208, 146);
            this.Controls.Add(this.flpAttachment);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Attachment";
            this.Text = "Attachment";
            this.flpAttachment.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpAttachment;
        private System.Windows.Forms.Button btnDrive;
        private System.Windows.Forms.Button btnOneDrive;
        private System.Windows.Forms.Button btnLocal;
    }
}