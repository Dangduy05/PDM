namespace PDMcustom.ChildForm
{
    partial class Classify
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelFilter = new System.Windows.Forms.Panel();
            this.cbUnapproved = new System.Windows.Forms.CheckBox();
            this.cbApproved = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbApproving = new System.Windows.Forms.CheckBox();
            this.cbProjectProcess = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.cbExpiryDate = new System.Windows.Forms.CheckBox();
            this.cbReleaseDate = new System.Windows.Forms.CheckBox();
            this.cbUploadDate = new System.Windows.Forms.CheckBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.btnFilter = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btvView = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panelFilter.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panelFilter);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.btnFilter);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.btvView);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1268, 834);
            this.panel1.TabIndex = 4;
            // 
            // panelFilter
            // 
            this.panelFilter.Controls.Add(this.cbUnapproved);
            this.panelFilter.Controls.Add(this.cbApproved);
            this.panelFilter.Controls.Add(this.label1);
            this.panelFilter.Controls.Add(this.cbApproving);
            this.panelFilter.Controls.Add(this.cbProjectProcess);
            this.panelFilter.Controls.Add(this.checkBox7);
            this.panelFilter.Controls.Add(this.cbExpiryDate);
            this.panelFilter.Controls.Add(this.cbReleaseDate);
            this.panelFilter.Controls.Add(this.cbUploadDate);
            this.panelFilter.Location = new System.Drawing.Point(418, 103);
            this.panelFilter.Margin = new System.Windows.Forms.Padding(2);
            this.panelFilter.Name = "panelFilter";
            this.panelFilter.Size = new System.Drawing.Size(315, 160);
            this.panelFilter.TabIndex = 8;
            this.panelFilter.Visible = false;
            // 
            // cbUnapproved
            // 
            this.cbUnapproved.AutoSize = true;
            this.cbUnapproved.Location = new System.Drawing.Point(12, 33);
            this.cbUnapproved.Margin = new System.Windows.Forms.Padding(2);
            this.cbUnapproved.Name = "cbUnapproved";
            this.cbUnapproved.Size = new System.Drawing.Size(111, 17);
            this.cbUnapproved.TabIndex = 1;
            this.cbUnapproved.Text = "Dự án chưa duyệt";
            this.cbUnapproved.UseVisualStyleBackColor = true;
            // 
            // cbApproved
            // 
            this.cbApproved.AutoSize = true;
            this.cbApproved.Location = new System.Drawing.Point(12, 54);
            this.cbApproved.Margin = new System.Windows.Forms.Padding(2);
            this.cbApproved.Name = "cbApproved";
            this.cbApproved.Size = new System.Drawing.Size(100, 17);
            this.cbApproved.TabIndex = 3;
            this.cbApproved.Text = "Dự án đã duyệt";
            this.cbApproved.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cài đặt danh sách hiển thị <<Tìm dự án>>";
            // 
            // cbApproving
            // 
            this.cbApproving.AutoSize = true;
            this.cbApproving.Location = new System.Drawing.Point(12, 76);
            this.cbApproving.Margin = new System.Windows.Forms.Padding(2);
            this.cbApproving.Name = "cbApproving";
            this.cbApproving.Size = new System.Drawing.Size(112, 17);
            this.cbApproving.TabIndex = 5;
            this.cbApproving.Text = "Dự án đang duyệt";
            this.cbApproving.UseVisualStyleBackColor = true;
            // 
            // cbProjectProcess
            // 
            this.cbProjectProcess.AutoSize = true;
            this.cbProjectProcess.Location = new System.Drawing.Point(167, 97);
            this.cbProjectProcess.Margin = new System.Windows.Forms.Padding(2);
            this.cbProjectProcess.Name = "cbProjectProcess";
            this.cbProjectProcess.Size = new System.Drawing.Size(102, 17);
            this.cbProjectProcess.TabIndex = 8;
            this.cbProjectProcess.Text = "Giai đoạn dự án";
            this.cbProjectProcess.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Location = new System.Drawing.Point(12, 97);
            this.checkBox7.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(99, 17);
            this.checkBox7.TabIndex = 7;
            this.checkBox7.Text = "Loại hình dự án";
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // cbExpiryDate
            // 
            this.cbExpiryDate.AutoSize = true;
            this.cbExpiryDate.Location = new System.Drawing.Point(167, 76);
            this.cbExpiryDate.Margin = new System.Windows.Forms.Padding(2);
            this.cbExpiryDate.Name = "cbExpiryDate";
            this.cbExpiryDate.Size = new System.Drawing.Size(93, 17);
            this.cbExpiryDate.TabIndex = 6;
            this.cbExpiryDate.Text = "Ngày kết thúc";
            this.cbExpiryDate.UseVisualStyleBackColor = true;
            // 
            // cbReleaseDate
            // 
            this.cbReleaseDate.AutoSize = true;
            this.cbReleaseDate.Location = new System.Drawing.Point(167, 33);
            this.cbReleaseDate.Margin = new System.Windows.Forms.Padding(2);
            this.cbReleaseDate.Name = "cbReleaseDate";
            this.cbReleaseDate.Size = new System.Drawing.Size(102, 17);
            this.cbReleaseDate.TabIndex = 2;
            this.cbReleaseDate.Text = "Ngày phát hành";
            this.cbReleaseDate.UseVisualStyleBackColor = true;
            // 
            // cbUploadDate
            // 
            this.cbUploadDate.AutoSize = true;
            this.cbUploadDate.Location = new System.Drawing.Point(167, 54);
            this.cbUploadDate.Margin = new System.Windows.Forms.Padding(2);
            this.cbUploadDate.Name = "cbUploadDate";
            this.cbUploadDate.Size = new System.Drawing.Size(69, 17);
            this.cbUploadDate.TabIndex = 4;
            this.cbUploadDate.Text = "Ngày tạo";
            this.cbUploadDate.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1268, 60);
            this.panel3.TabIndex = 9;
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(688, 62);
            this.button4.Margin = new System.Windows.Forms.Padding(8);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(120, 41);
            this.button4.TabIndex = 6;
            this.button4.Text = "In";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Visible = false;
            // 
            // btnFilter
            // 
            this.btnFilter.FlatAppearance.BorderSize = 0;
            this.btnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilter.Image = global::PDMcustom.Properties.Resources.filter;
            this.btnFilter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFilter.Location = new System.Drawing.Point(554, 62);
            this.btnFilter.Margin = new System.Windows.Forms.Padding(8);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(120, 41);
            this.btnFilter.TabIndex = 5;
            this.btnFilter.Text = "Bộ lọc";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Image = global::PDMcustom.Properties.Resources.delete;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(418, 62);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(8);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(120, 41);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::PDMcustom.Properties.Resources.update;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(284, 62);
            this.button1.Margin = new System.Windows.Forms.Padding(8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 41);
            this.button1.TabIndex = 3;
            this.button1.Text = "Sửa";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Image = global::PDMcustom.Properties.Resources.add;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(148, 62);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(8);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(120, 41);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btvView
            // 
            this.btvView.FlatAppearance.BorderSize = 0;
            this.btvView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btvView.Image = global::PDMcustom.Properties.Resources.eye;
            this.btvView.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btvView.Location = new System.Drawing.Point(14, 62);
            this.btvView.Margin = new System.Windows.Forms.Padding(8);
            this.btvView.Name = "btvView";
            this.btvView.Size = new System.Drawing.Size(120, 41);
            this.btvView.TabIndex = 1;
            this.btvView.Text = "Xem";
            this.btvView.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(49, 136);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1168, 636);
            this.dataGridView1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(342, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "label2";
            // 
            // Classify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1268, 834);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Classify";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Classify";
            this.panel1.ResumeLayout(false);
            this.panelFilter.ResumeLayout(false);
            this.panelFilter.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelFilter;
        private System.Windows.Forms.CheckBox cbUnapproved;
        private System.Windows.Forms.CheckBox cbApproved;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbApproving;
        private System.Windows.Forms.CheckBox cbProjectProcess;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.CheckBox cbExpiryDate;
        private System.Windows.Forms.CheckBox cbReleaseDate;
        private System.Windows.Forms.CheckBox cbUploadDate;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btvView;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
    }
}