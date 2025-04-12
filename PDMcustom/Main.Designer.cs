namespace PDMcustom
{
    partial class Main
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
            this.flpSidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.dashboardButton = new System.Windows.Forms.Button();
            this.btnManageRecord = new System.Windows.Forms.Button();
            this.btnManageProject = new System.Windows.Forms.Button();
            this.flpVerifyDocument = new System.Windows.Forms.FlowLayoutPanel();
            this.btnApprovalProcess = new System.Windows.Forms.Button();
            this.btnApproval = new System.Windows.Forms.Button();
            this.btnApprovalConfig = new System.Windows.Forms.Button();
            this.btnApprovalHistory = new System.Windows.Forms.Button();
            this.btvVersion = new System.Windows.Forms.Button();
            this.btnNumberRule = new System.Windows.Forms.Button();
            this.btnNotification = new System.Windows.Forms.Button();
            this.btnTool = new System.Windows.Forms.Button();
            this.btnTool1 = new System.Windows.Forms.Button();
            this.btnClassify = new System.Windows.Forms.Button();
            this.flpUser = new System.Windows.Forms.FlowLayoutPanel();
            this.btnUser = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.panelManageProject = new System.Windows.Forms.Panel();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.btnClose = new FontAwesome.Sharp.IconButton();
            this.btnMinimize = new FontAwesome.Sharp.IconButton();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.labelProgram = new System.Windows.Forms.Label();
            this.flpSidebar.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.flpVerifyDocument.SuspendLayout();
            this.flpUser.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            this.panelDesktop.SuspendLayout();
            this.SuspendLayout();
            // 
            // flpSidebar
            // 
            this.flpSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(31)))), ((int)(((byte)(56)))));
            this.flpSidebar.Controls.Add(this.panel1);
            this.flpSidebar.Controls.Add(this.dashboardButton);
            this.flpSidebar.Controls.Add(this.btnManageRecord);
            this.flpSidebar.Controls.Add(this.btnManageProject);
            this.flpSidebar.Controls.Add(this.flpVerifyDocument);
            this.flpSidebar.Controls.Add(this.btvVersion);
            this.flpSidebar.Controls.Add(this.btnNumberRule);
            this.flpSidebar.Controls.Add(this.btnNotification);
            this.flpSidebar.Controls.Add(this.btnTool);
            this.flpSidebar.Controls.Add(this.btnTool1);
            this.flpSidebar.Controls.Add(this.btnClassify);
            this.flpSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.flpSidebar.Location = new System.Drawing.Point(0, 0);
            this.flpSidebar.Margin = new System.Windows.Forms.Padding(0);
            this.flpSidebar.MaximumSize = new System.Drawing.Size(288, 794);
            this.flpSidebar.MinimumSize = new System.Drawing.Size(48, 794);
            this.flpSidebar.Name = "flpSidebar";
            this.flpSidebar.Size = new System.Drawing.Size(288, 794);
            this.flpSidebar.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.picLogo);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(290, 50);
            this.panel1.TabIndex = 11;
            // 
            // picLogo
            // 
            this.picLogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.picLogo.Image = global::PDMcustom.Properties.Resources.app_foreground;
            this.picLogo.Location = new System.Drawing.Point(0, 0);
            this.picLogo.Margin = new System.Windows.Forms.Padding(0);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(144, 50);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 5;
            this.picLogo.TabStop = false;
            // 
            // dashboardButton
            // 
            this.dashboardButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dashboardButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(31)))), ((int)(((byte)(56)))));
            this.dashboardButton.FlatAppearance.BorderSize = 0;
            this.dashboardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dashboardButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.dashboardButton.ForeColor = System.Drawing.Color.White;
            this.dashboardButton.Image = global::PDMcustom.Properties.Resources.layout;
            this.dashboardButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dashboardButton.Location = new System.Drawing.Point(0, 50);
            this.dashboardButton.Margin = new System.Windows.Forms.Padding(0);
            this.dashboardButton.Name = "dashboardButton";
            this.dashboardButton.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.dashboardButton.Size = new System.Drawing.Size(288, 49);
            this.dashboardButton.TabIndex = 1;
            this.dashboardButton.Text = "     Trang chủ";
            this.dashboardButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dashboardButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.dashboardButton.UseVisualStyleBackColor = false;
            // 
            // btnManageRecord
            // 
            this.btnManageRecord.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnManageRecord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(31)))), ((int)(((byte)(56)))));
            this.btnManageRecord.FlatAppearance.BorderSize = 0;
            this.btnManageRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageRecord.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnManageRecord.Image = global::PDMcustom.Properties.Resources.user_managament;
            this.btnManageRecord.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageRecord.Location = new System.Drawing.Point(0, 99);
            this.btnManageRecord.Margin = new System.Windows.Forms.Padding(0);
            this.btnManageRecord.Name = "btnManageRecord";
            this.btnManageRecord.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.btnManageRecord.Size = new System.Drawing.Size(288, 49);
            this.btnManageRecord.TabIndex = 2;
            this.btnManageRecord.Text = "     Nhập liệu hồ sơ";
            this.btnManageRecord.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageRecord.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnManageRecord.UseVisualStyleBackColor = false;
            this.btnManageRecord.Click += new System.EventHandler(this.btnManageDocument_Click);
            // 
            // btnManageProject
            // 
            this.btnManageProject.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnManageProject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(31)))), ((int)(((byte)(56)))));
            this.btnManageProject.FlatAppearance.BorderSize = 0;
            this.btnManageProject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageProject.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnManageProject.Image = global::PDMcustom.Properties.Resources.chart;
            this.btnManageProject.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageProject.Location = new System.Drawing.Point(0, 148);
            this.btnManageProject.Margin = new System.Windows.Forms.Padding(0);
            this.btnManageProject.Name = "btnManageProject";
            this.btnManageProject.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.btnManageProject.Size = new System.Drawing.Size(288, 49);
            this.btnManageProject.TabIndex = 1;
            this.btnManageProject.Text = "     Nhập liệu dự án";
            this.btnManageProject.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageProject.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnManageProject.UseVisualStyleBackColor = false;
            this.btnManageProject.Click += new System.EventHandler(this.btnManageProject_Click);
            // 
            // flpVerifyDocument
            // 
            this.flpVerifyDocument.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.flpVerifyDocument.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(31)))), ((int)(((byte)(56)))));
            this.flpVerifyDocument.Controls.Add(this.btnApprovalProcess);
            this.flpVerifyDocument.Controls.Add(this.btnApproval);
            this.flpVerifyDocument.Controls.Add(this.btnApprovalConfig);
            this.flpVerifyDocument.Controls.Add(this.btnApprovalHistory);
            this.flpVerifyDocument.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.flpVerifyDocument.ForeColor = System.Drawing.Color.White;
            this.flpVerifyDocument.Location = new System.Drawing.Point(0, 197);
            this.flpVerifyDocument.Margin = new System.Windows.Forms.Padding(0);
            this.flpVerifyDocument.MaximumSize = new System.Drawing.Size(288, 171);
            this.flpVerifyDocument.MinimumSize = new System.Drawing.Size(288, 49);
            this.flpVerifyDocument.Name = "flpVerifyDocument";
            this.flpVerifyDocument.Size = new System.Drawing.Size(288, 49);
            this.flpVerifyDocument.TabIndex = 34;
            // 
            // btnApprovalProcess
            // 
            this.btnApprovalProcess.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnApprovalProcess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(31)))), ((int)(((byte)(56)))));
            this.btnApprovalProcess.FlatAppearance.BorderSize = 0;
            this.btnApprovalProcess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApprovalProcess.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.btnApprovalProcess.Image = global::PDMcustom.Properties.Resources.tasks;
            this.btnApprovalProcess.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnApprovalProcess.Location = new System.Drawing.Point(0, 0);
            this.btnApprovalProcess.Margin = new System.Windows.Forms.Padding(0);
            this.btnApprovalProcess.Name = "btnApprovalProcess";
            this.btnApprovalProcess.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.btnApprovalProcess.Size = new System.Drawing.Size(288, 49);
            this.btnApprovalProcess.TabIndex = 5;
            this.btnApprovalProcess.Text = "     Quy trình phê duyệt";
            this.btnApprovalProcess.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnApprovalProcess.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnApprovalProcess.UseVisualStyleBackColor = false;
            this.btnApprovalProcess.Click += new System.EventHandler(this.btnP_Click);
            // 
            // btnApproval
            // 
            this.btnApproval.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnApproval.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(31)))), ((int)(((byte)(56)))));
            this.btnApproval.FlatAppearance.BorderSize = 0;
            this.btnApproval.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApproval.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnApproval.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnApproval.Location = new System.Drawing.Point(0, 49);
            this.btnApproval.Margin = new System.Windows.Forms.Padding(0);
            this.btnApproval.Name = "btnApproval";
            this.btnApproval.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.btnApproval.Size = new System.Drawing.Size(288, 41);
            this.btnApproval.TabIndex = 4;
            this.btnApproval.Text = "     Phê duyệt hồ sơ";
            this.btnApproval.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnApproval.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnApproval.UseVisualStyleBackColor = false;
            // 
            // btnApprovalConfig
            // 
            this.btnApprovalConfig.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnApprovalConfig.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(31)))), ((int)(((byte)(56)))));
            this.btnApprovalConfig.FlatAppearance.BorderSize = 0;
            this.btnApprovalConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApprovalConfig.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnApprovalConfig.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnApprovalConfig.Location = new System.Drawing.Point(0, 90);
            this.btnApprovalConfig.Margin = new System.Windows.Forms.Padding(0);
            this.btnApprovalConfig.Name = "btnApprovalConfig";
            this.btnApprovalConfig.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.btnApprovalConfig.Size = new System.Drawing.Size(288, 41);
            this.btnApprovalConfig.TabIndex = 6;
            this.btnApprovalConfig.Text = "     Thiết lập quy trình phê duyệt";
            this.btnApprovalConfig.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnApprovalConfig.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnApprovalConfig.UseVisualStyleBackColor = false;
            // 
            // btnApprovalHistory
            // 
            this.btnApprovalHistory.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnApprovalHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(31)))), ((int)(((byte)(56)))));
            this.btnApprovalHistory.FlatAppearance.BorderSize = 0;
            this.btnApprovalHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApprovalHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnApprovalHistory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnApprovalHistory.Location = new System.Drawing.Point(0, 131);
            this.btnApprovalHistory.Margin = new System.Windows.Forms.Padding(0);
            this.btnApprovalHistory.Name = "btnApprovalHistory";
            this.btnApprovalHistory.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.btnApprovalHistory.Size = new System.Drawing.Size(288, 41);
            this.btnApprovalHistory.TabIndex = 7;
            this.btnApprovalHistory.Text = "     Lịch sử phê duyệt";
            this.btnApprovalHistory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnApprovalHistory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnApprovalHistory.UseVisualStyleBackColor = false;
            // 
            // btvVersion
            // 
            this.btvVersion.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btvVersion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(31)))), ((int)(((byte)(56)))));
            this.btvVersion.FlatAppearance.BorderSize = 0;
            this.btvVersion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btvVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btvVersion.ForeColor = System.Drawing.Color.White;
            this.btvVersion.Image = global::PDMcustom.Properties.Resources.versions;
            this.btvVersion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btvVersion.Location = new System.Drawing.Point(0, 246);
            this.btvVersion.Margin = new System.Windows.Forms.Padding(0);
            this.btvVersion.Name = "btvVersion";
            this.btvVersion.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.btvVersion.Size = new System.Drawing.Size(288, 49);
            this.btvVersion.TabIndex = 6;
            this.btvVersion.Text = "     Phiên bản và ngày\r\n     phát hành tài liệu";
            this.btvVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btvVersion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btvVersion.UseVisualStyleBackColor = false;
            this.btvVersion.Click += new System.EventHandler(this.btvVersion_Click);
            // 
            // btnNumberRule
            // 
            this.btnNumberRule.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnNumberRule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(31)))), ((int)(((byte)(56)))));
            this.btnNumberRule.FlatAppearance.BorderSize = 0;
            this.btnNumberRule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNumberRule.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNumberRule.ForeColor = System.Drawing.Color.White;
            this.btnNumberRule.Image = global::PDMcustom.Properties.Resources.book;
            this.btnNumberRule.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNumberRule.Location = new System.Drawing.Point(0, 295);
            this.btnNumberRule.Margin = new System.Windows.Forms.Padding(0);
            this.btnNumberRule.Name = "btnNumberRule";
            this.btnNumberRule.Size = new System.Drawing.Size(288, 49);
            this.btnNumberRule.TabIndex = 7;
            this.btnNumberRule.Text = "     Thiết lập quy tắc\r\n     đánh số văn bản";
            this.btnNumberRule.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNumberRule.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNumberRule.UseVisualStyleBackColor = false;
            this.btnNumberRule.Click += new System.EventHandler(this.btnNumberRule_Click);
            // 
            // btnNotification
            // 
            this.btnNotification.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnNotification.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(31)))), ((int)(((byte)(56)))));
            this.btnNotification.FlatAppearance.BorderSize = 0;
            this.btnNotification.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNotification.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNotification.ForeColor = System.Drawing.Color.White;
            this.btnNotification.Image = global::PDMcustom.Properties.Resources.notification;
            this.btnNotification.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNotification.Location = new System.Drawing.Point(0, 344);
            this.btnNotification.Margin = new System.Windows.Forms.Padding(0);
            this.btnNotification.Name = "btnNotification";
            this.btnNotification.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.btnNotification.Size = new System.Drawing.Size(288, 49);
            this.btnNotification.TabIndex = 3;
            this.btnNotification.Text = "     Thông báo";
            this.btnNotification.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNotification.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNotification.UseVisualStyleBackColor = false;
            // 
            // btnTool
            // 
            this.btnTool.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnTool.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(31)))), ((int)(((byte)(56)))));
            this.btnTool.FlatAppearance.BorderSize = 0;
            this.btnTool.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTool.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTool.ForeColor = System.Drawing.Color.White;
            this.btnTool.Image = global::PDMcustom.Properties.Resources.tool;
            this.btnTool.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTool.Location = new System.Drawing.Point(0, 393);
            this.btnTool.Margin = new System.Windows.Forms.Padding(0);
            this.btnTool.Name = "btnTool";
            this.btnTool.Size = new System.Drawing.Size(290, 49);
            this.btnTool.TabIndex = 8;
            this.btnTool.Text = "     Công cụ";
            this.btnTool.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTool.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTool.UseVisualStyleBackColor = false;
            this.btnTool.Click += new System.EventHandler(this.btnTool_Click);
            // 
            // btnTool1
            // 
            this.btnTool1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnTool1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(31)))), ((int)(((byte)(56)))));
            this.btnTool1.FlatAppearance.BorderSize = 0;
            this.btnTool1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTool1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTool1.ForeColor = System.Drawing.Color.White;
            this.btnTool1.Image = global::PDMcustom.Properties.Resources.toolbox;
            this.btnTool1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTool1.Location = new System.Drawing.Point(0, 442);
            this.btnTool1.Margin = new System.Windows.Forms.Padding(0);
            this.btnTool1.Name = "btnTool1";
            this.btnTool1.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.btnTool1.Size = new System.Drawing.Size(290, 49);
            this.btnTool1.TabIndex = 4;
            this.btnTool1.Text = "     Tích hợp công cụ";
            this.btnTool1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTool1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTool1.UseVisualStyleBackColor = false;
            // 
            // btnClassify
            // 
            this.btnClassify.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnClassify.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(31)))), ((int)(((byte)(56)))));
            this.btnClassify.FlatAppearance.BorderSize = 0;
            this.btnClassify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClassify.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClassify.ForeColor = System.Drawing.Color.White;
            this.btnClassify.Image = global::PDMcustom.Properties.Resources.tool;
            this.btnClassify.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClassify.Location = new System.Drawing.Point(0, 491);
            this.btnClassify.Margin = new System.Windows.Forms.Padding(0);
            this.btnClassify.Name = "btnClassify";
            this.btnClassify.Size = new System.Drawing.Size(290, 49);
            this.btnClassify.TabIndex = 35;
            this.btnClassify.Text = "     Phân loại";
            this.btnClassify.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClassify.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClassify.UseVisualStyleBackColor = false;
            this.btnClassify.Click += new System.EventHandler(this.button1_Click);
            // 
            // flpUser
            // 
            this.flpUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.flpUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(31)))), ((int)(((byte)(56)))));
            this.flpUser.Controls.Add(this.btnUser);
            this.flpUser.Controls.Add(this.btnSettings);
            this.flpUser.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp;
            this.flpUser.Location = new System.Drawing.Point(0, 796);
            this.flpUser.Margin = new System.Windows.Forms.Padding(0);
            this.flpUser.MaximumSize = new System.Drawing.Size(288, 88);
            this.flpUser.MinimumSize = new System.Drawing.Size(288, 88);
            this.flpUser.Name = "flpUser";
            this.flpUser.Size = new System.Drawing.Size(288, 88);
            this.flpUser.TabIndex = 3;
            // 
            // btnUser
            // 
            this.btnUser.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(31)))), ((int)(((byte)(56)))));
            this.btnUser.FlatAppearance.BorderSize = 0;
            this.btnUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUser.ForeColor = System.Drawing.Color.White;
            this.btnUser.Image = global::PDMcustom.Properties.Resources.user_dark;
            this.btnUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUser.Location = new System.Drawing.Point(0, 39);
            this.btnUser.Margin = new System.Windows.Forms.Padding(0);
            this.btnUser.Name = "btnUser";
            this.btnUser.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.btnUser.Size = new System.Drawing.Size(232, 49);
            this.btnUser.TabIndex = 35;
            this.btnUser.Text = "     Username";
            this.btnUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUser.UseVisualStyleBackColor = false;
            // 
            // btnSettings
            // 
            this.btnSettings.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(31)))), ((int)(((byte)(56)))));
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.Image = global::PDMcustom.Properties.Resources.settings;
            this.btnSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.Location = new System.Drawing.Point(232, 38);
            this.btnSettings.Margin = new System.Windows.Forms.Padding(0);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(50, 50);
            this.btnSettings.TabIndex = 35;
            this.btnSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSettings.UseVisualStyleBackColor = false;
            // 
            // panelManageProject
            // 
            this.panelManageProject.Location = new System.Drawing.Point(1292, 12);
            this.panelManageProject.Name = "panelManageProject";
            this.panelManageProject.Size = new System.Drawing.Size(200, 100);
            this.panelManageProject.TabIndex = 9;
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.panelTitleBar.Controls.Add(this.panelManageProject);
            this.panelTitleBar.Controls.Add(this.btnClose);
            this.panelTitleBar.Controls.Add(this.btnMinimize);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(288, 0);
            this.panelTitleBar.Margin = new System.Windows.Forms.Padding(0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(1268, 50);
            this.panelTitleBar.TabIndex = 10;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackgroundImage = global::PDMcustom.Properties.Resources.close_dark;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnClose.IconColor = System.Drawing.Color.Black;
            this.btnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClose.Location = new System.Drawing.Point(1218, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(0);
            this.btnClose.MaximumSize = new System.Drawing.Size(50, 50);
            this.btnClose.MinimumSize = new System.Drawing.Size(50, 50);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(50, 50);
            this.btnClose.TabIndex = 1;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.BackgroundImage = global::PDMcustom.Properties.Resources.minimize_dark;
            this.btnMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnMinimize.IconColor = System.Drawing.Color.Black;
            this.btnMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMinimize.Location = new System.Drawing.Point(1168, 0);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(0);
            this.btnMinimize.MaximumSize = new System.Drawing.Size(50, 50);
            this.btnMinimize.MinimumSize = new System.Drawing.Size(50, 50);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(50, 50);
            this.btnMinimize.TabIndex = 2;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelDesktop.Controls.Add(this.labelProgram);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(288, 50);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(1268, 834);
            this.panelDesktop.TabIndex = 11;
            // 
            // labelProgram
            // 
            this.labelProgram.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelProgram.AutoSize = true;
            this.labelProgram.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F);
            this.labelProgram.Location = new System.Drawing.Point(87, 344);
            this.labelProgram.Margin = new System.Windows.Forms.Padding(95, 344, 95, 344);
            this.labelProgram.Name = "labelProgram";
            this.labelProgram.Size = new System.Drawing.Size(1077, 146);
            this.labelProgram.TabIndex = 0;
            this.labelProgram.Text = "Phần Mềm Quản Lý Hồ Sơ và Dự Án\r\nVer.0";
            this.labelProgram.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1556, 884);
            this.ControlBox = false;
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.flpUser);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.flpSidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Main_MouseDown);
            this.flpSidebar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.flpVerifyDocument.ResumeLayout(false);
            this.flpUser.ResumeLayout(false);
            this.panelTitleBar.ResumeLayout(false);
            this.panelDesktop.ResumeLayout(false);
            this.panelDesktop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpSidebar;
        private System.Windows.Forms.Button dashboardButton;
        private FontAwesome.Sharp.IconButton btnClose;
        private System.Windows.Forms.Button btnManageRecord;
        private System.Windows.Forms.Button btnManageProject;
        private System.Windows.Forms.Button btnNotification;
        private System.Windows.Forms.Button btnNumberRule;
        private System.Windows.Forms.FlowLayoutPanel flpVerifyDocument;
        private System.Windows.Forms.Button btnApprovalProcess;
        private System.Windows.Forms.Button btnApproval;
        private System.Windows.Forms.Button btnApprovalConfig;
        private System.Windows.Forms.Button btvVersion;
        private System.Windows.Forms.Button btnTool;
        private System.Windows.Forms.Button btnTool1;
        private FontAwesome.Sharp.IconButton btnMinimize;
        private System.Windows.Forms.FlowLayoutPanel flpUser;
        private System.Windows.Forms.Button btnUser;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnApprovalHistory;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Panel panelManageProject;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Button btnClassify;
        private System.Windows.Forms.Label labelProgram;
    }
}