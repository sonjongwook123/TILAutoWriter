namespace TILAutoPublisher
{
    partial class MainForm
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
            this.panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblAnalysisStatus = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnStartAnalysis = new Guna.UI2.WinForms.Guna2Button();
            this.dtpAnalysisEndTime = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.chkAutoStart = new Guna.UI2.WinForms.Guna2CheckBox();
            this.panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.flpBannerPreviews = new System.Windows.Forms.FlowLayoutPanel();
            this.btnLoadBannerImage = new Guna.UI2.WinForms.Guna2Button();
            this.txtBannerImage = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.txtGeminiApiKey = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtChatGptApiKey = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtTistoryPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.label8 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtTistoryId = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.panel4 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnRemoveTag = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddTag = new Guna.UI2.WinForms.Guna2Button();
            this.txtNewTag = new Guna.UI2.WinForms.Guna2TextBox();
            this.flpTags = new System.Windows.Forms.FlowLayoutPanel();
            this.txtTags = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.panel5 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnAddEncouragement = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddRetrospection = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddImageBlock = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddContentBlock = new Guna.UI2.WinForms.Guna2Button();
            this.panel6 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnPublish = new Guna.UI2.WinForms.Guna2Button();
            this.txtTitle = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pbBanner = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.pnlScrollableContent = new Guna.UI2.WinForms.Guna2Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBanner)).BeginInit();
            this.pnlScrollableContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderRadius = 8;
            this.panel1.Controls.Add(this.lblAnalysisStatus);
            this.panel1.Controls.Add(this.btnStartAnalysis);
            this.panel1.Controls.Add(this.dtpAnalysisEndTime);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.chkAutoStart);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.FillColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(15);
            this.panel1.ShadowDecoration.Color = System.Drawing.Color.LightGray;
            this.panel1.ShadowDecoration.Depth = 10;
            this.panel1.ShadowDecoration.Enabled = true;
            this.panel1.Size = new System.Drawing.Size(1079, 140);
            this.panel1.TabIndex = 1;
            // 
            // lblAnalysisStatus
            // 
            this.lblAnalysisStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblAnalysisStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnalysisStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblAnalysisStatus.Location = new System.Drawing.Point(19, 90);
            this.lblAnalysisStatus.Name = "lblAnalysisStatus";
            this.lblAnalysisStatus.Size = new System.Drawing.Size(86, 22);
            this.lblAnalysisStatus.TabIndex = 4;
            this.lblAnalysisStatus.Text = "분석 대기 중";
            // 
            // btnStartAnalysis
            // 
            this.btnStartAnalysis.BorderRadius = 5;
            this.btnStartAnalysis.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnStartAnalysis.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnStartAnalysis.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnStartAnalysis.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnStartAnalysis.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnStartAnalysis.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartAnalysis.ForeColor = System.Drawing.Color.White;
            this.btnStartAnalysis.Location = new System.Drawing.Point(591, 40);
            this.btnStartAnalysis.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnStartAnalysis.Name = "btnStartAnalysis";
            this.btnStartAnalysis.Size = new System.Drawing.Size(120, 35);
            this.btnStartAnalysis.TabIndex = 3;
            this.btnStartAnalysis.Text = "분석 시작";
            this.btnStartAnalysis.Click += new System.EventHandler(this.btnStartAnalysis_Click);
            // 
            // dtpAnalysisEndTime
            // 
            this.dtpAnalysisEndTime.BorderColor = System.Drawing.Color.LightGray;
            this.dtpAnalysisEndTime.BorderRadius = 5;
            this.dtpAnalysisEndTime.Checked = true;
            this.dtpAnalysisEndTime.CustomFormat = "HH:mm";
            this.dtpAnalysisEndTime.FillColor = System.Drawing.Color.White;
            this.dtpAnalysisEndTime.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpAnalysisEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpAnalysisEndTime.Location = new System.Drawing.Point(443, 44);
            this.dtpAnalysisEndTime.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpAnalysisEndTime.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpAnalysisEndTime.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpAnalysisEndTime.Name = "dtpAnalysisEndTime";
            this.dtpAnalysisEndTime.ShowUpDown = true;
            this.dtpAnalysisEndTime.Size = new System.Drawing.Size(140, 27);
            this.dtpAnalysisEndTime.TabIndex = 2;
            this.dtpAnalysisEndTime.Value = new System.DateTime(2025, 7, 20, 1, 45, 10, 0);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(267, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 22);
            this.label4.TabIndex = 1;
            this.label4.Text = "분석 종료 시각 (HH:MM):";
            // 
            // chkAutoStart
            // 
            this.chkAutoStart.AutoSize = true;
            this.chkAutoStart.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkAutoStart.CheckedState.BorderRadius = 0;
            this.chkAutoStart.CheckedState.BorderThickness = 0;
            this.chkAutoStart.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkAutoStart.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAutoStart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.chkAutoStart.Location = new System.Drawing.Point(19, 45);
            this.chkAutoStart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkAutoStart.Name = "chkAutoStart";
            this.chkAutoStart.Size = new System.Drawing.Size(212, 24);
            this.chkAutoStart.TabIndex = 0;
            this.chkAutoStart.Text = "프로그램 시작 시 분석 시작";
            this.chkAutoStart.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkAutoStart.UncheckedState.BorderRadius = 0;
            this.chkAutoStart.UncheckedState.BorderThickness = 0;
            this.chkAutoStart.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkAutoStart.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BorderRadius = 8;
            this.panel2.Controls.Add(this.flpBannerPreviews);
            this.panel2.Controls.Add(this.btnLoadBannerImage);
            this.panel2.Controls.Add(this.txtBannerImage);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.FillColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(0, 140);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(15);
            this.panel2.ShadowDecoration.Color = System.Drawing.Color.LightGray;
            this.panel2.ShadowDecoration.Depth = 10;
            this.panel2.ShadowDecoration.Enabled = true;
            this.panel2.Size = new System.Drawing.Size(1079, 160);
            this.panel2.TabIndex = 2;
            // 
            // flpBannerPreviews
            // 
            this.flpBannerPreviews.AutoScroll = true;
            this.flpBannerPreviews.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpBannerPreviews.Location = new System.Drawing.Point(16, 60);
            this.flpBannerPreviews.Name = "flpBannerPreviews";
            this.flpBannerPreviews.Size = new System.Drawing.Size(1054, 80);
            this.flpBannerPreviews.TabIndex = 3;
            this.flpBannerPreviews.WrapContents = false;
            // 
            // btnLoadBannerImage
            // 
            this.btnLoadBannerImage.BorderRadius = 5;
            this.btnLoadBannerImage.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLoadBannerImage.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLoadBannerImage.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLoadBannerImage.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLoadBannerImage.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnLoadBannerImage.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadBannerImage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLoadBannerImage.Location = new System.Drawing.Point(950, 15);
            this.btnLoadBannerImage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLoadBannerImage.Name = "btnLoadBannerImage";
            this.btnLoadBannerImage.Size = new System.Drawing.Size(120, 35);
            this.btnLoadBannerImage.TabIndex = 2;
            this.btnLoadBannerImage.Text = "불러오기";
            this.btnLoadBannerImage.Click += new System.EventHandler(this.btnLoadBannerImage_Click);
            // 
            // txtBannerImage
            // 
            this.txtBannerImage.BorderRadius = 5;
            this.txtBannerImage.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBannerImage.DefaultText = "";
            this.txtBannerImage.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBannerImage.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBannerImage.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBannerImage.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBannerImage.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBannerImage.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBannerImage.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBannerImage.Location = new System.Drawing.Point(116, 18);
            this.txtBannerImage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBannerImage.Name = "txtBannerImage";
            this.txtBannerImage.PlaceholderText = "";
            this.txtBannerImage.SelectedText = "";
            this.txtBannerImage.Size = new System.Drawing.Size(820, 27);
            this.txtBannerImage.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(16, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 22);
            this.label5.TabIndex = 0;
            this.label5.Text = "배너 이미지:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BorderRadius = 8;
            this.panel3.Controls.Add(this.txtGeminiApiKey);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.txtChatGptApiKey);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.txtTistoryPassword);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.txtTistoryId);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.FillColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(0, 300);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(15);
            this.panel3.ShadowDecoration.Color = System.Drawing.Color.LightGray;
            this.panel3.ShadowDecoration.Depth = 10;
            this.panel3.ShadowDecoration.Enabled = true;
            this.panel3.Size = new System.Drawing.Size(1079, 240);
            this.panel3.TabIndex = 3;
            // 
            // txtGeminiApiKey
            // 
            this.txtGeminiApiKey.BorderRadius = 5;
            this.txtGeminiApiKey.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGeminiApiKey.DefaultText = "";
            this.txtGeminiApiKey.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtGeminiApiKey.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtGeminiApiKey.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGeminiApiKey.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGeminiApiKey.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGeminiApiKey.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtGeminiApiKey.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGeminiApiKey.Location = new System.Drawing.Point(180, 180);
            this.txtGeminiApiKey.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtGeminiApiKey.Name = "txtGeminiApiKey";
            this.txtGeminiApiKey.PasswordChar = '●';
            this.txtGeminiApiKey.PlaceholderText = "";
            this.txtGeminiApiKey.SelectedText = "";
            this.txtGeminiApiKey.Size = new System.Drawing.Size(890, 27);
            this.txtGeminiApiKey.TabIndex = 7;
            this.txtGeminiApiKey.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(19, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "Gemini API Key:";
            // 
            // txtChatGptApiKey
            // 
            this.txtChatGptApiKey.BorderRadius = 5;
            this.txtChatGptApiKey.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtChatGptApiKey.DefaultText = "";
            this.txtChatGptApiKey.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtChatGptApiKey.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtChatGptApiKey.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtChatGptApiKey.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtChatGptApiKey.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtChatGptApiKey.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtChatGptApiKey.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtChatGptApiKey.Location = new System.Drawing.Point(180, 130);
            this.txtChatGptApiKey.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtChatGptApiKey.Name = "txtChatGptApiKey";
            this.txtChatGptApiKey.PasswordChar = '●';
            this.txtChatGptApiKey.PlaceholderText = "";
            this.txtChatGptApiKey.SelectedText = "";
            this.txtChatGptApiKey.Size = new System.Drawing.Size(890, 27);
            this.txtChatGptApiKey.TabIndex = 5;
            this.txtChatGptApiKey.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(19, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "ChatGPT API Key:";
            // 
            // txtTistoryPassword
            // 
            this.txtTistoryPassword.BorderRadius = 5;
            this.txtTistoryPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTistoryPassword.DefaultText = "";
            this.txtTistoryPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTistoryPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTistoryPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTistoryPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTistoryPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTistoryPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTistoryPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTistoryPassword.Location = new System.Drawing.Point(180, 80);
            this.txtTistoryPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTistoryPassword.Name = "txtTistoryPassword";
            this.txtTistoryPassword.PasswordChar = '●';
            this.txtTistoryPassword.PlaceholderText = "";
            this.txtTistoryPassword.SelectedText = "";
            this.txtTistoryPassword.Size = new System.Drawing.Size(890, 27);
            this.txtTistoryPassword.TabIndex = 3;
            this.txtTistoryPassword.UseSystemPasswordChar = true;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label8.Location = new System.Drawing.Point(19, 83);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(130, 22);
            this.label8.TabIndex = 2;
            this.label8.Text = "티스토리 비밀번호:";
            // 
            // txtTistoryId
            // 
            this.txtTistoryId.BorderRadius = 5;
            this.txtTistoryId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTistoryId.DefaultText = "";
            this.txtTistoryId.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTistoryId.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTistoryId.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTistoryId.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTistoryId.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTistoryId.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTistoryId.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTistoryId.Location = new System.Drawing.Point(180, 30);
            this.txtTistoryId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTistoryId.Name = "txtTistoryId";
            this.txtTistoryId.PlaceholderText = "";
            this.txtTistoryId.SelectedText = "";
            this.txtTistoryId.Size = new System.Drawing.Size(890, 27);
            this.txtTistoryId.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(19, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "티스토리 아이디:";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.BorderRadius = 8;
            this.panel4.Controls.Add(this.btnRemoveTag);
            this.panel4.Controls.Add(this.btnAddTag);
            this.panel4.Controls.Add(this.txtNewTag);
            this.panel4.Controls.Add(this.flpTags);
            this.panel4.Controls.Add(this.txtTags);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.FillColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(0, 540);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(15);
            this.panel4.ShadowDecoration.Color = System.Drawing.Color.LightGray;
            this.panel4.ShadowDecoration.Depth = 10;
            this.panel4.ShadowDecoration.Enabled = true;
            this.panel4.Size = new System.Drawing.Size(1079, 290);
            this.panel4.TabIndex = 4;
            // 
            // btnRemoveTag
            // 
            this.btnRemoveTag.BorderRadius = 5;
            this.btnRemoveTag.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRemoveTag.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRemoveTag.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRemoveTag.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRemoveTag.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnRemoveTag.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveTag.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRemoveTag.Location = new System.Drawing.Point(950, 243);
            this.btnRemoveTag.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRemoveTag.Name = "btnRemoveTag";
            this.btnRemoveTag.Size = new System.Drawing.Size(120, 35);
            this.btnRemoveTag.TabIndex = 6;
            this.btnRemoveTag.Text = "태그 삭제";
            this.btnRemoveTag.Click += new System.EventHandler(this.btnRemoveTag_Click);
            // 
            // btnAddTag
            // 
            this.btnAddTag.BorderRadius = 5;
            this.btnAddTag.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddTag.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddTag.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddTag.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddTag.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnAddTag.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTag.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAddTag.Location = new System.Drawing.Point(822, 243);
            this.btnAddTag.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddTag.Name = "btnAddTag";
            this.btnAddTag.Size = new System.Drawing.Size(120, 35);
            this.btnAddTag.TabIndex = 5;
            this.btnAddTag.Text = "태그 추가";
            this.btnAddTag.Click += new System.EventHandler(this.btnAddTag_Click);
            // 
            // txtNewTag
            // 
            this.txtNewTag.BorderRadius = 5;
            this.txtNewTag.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNewTag.DefaultText = "";
            this.txtNewTag.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNewTag.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNewTag.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNewTag.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNewTag.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNewTag.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNewTag.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNewTag.Location = new System.Drawing.Point(19, 246);
            this.txtNewTag.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNewTag.Name = "txtNewTag";
            this.txtNewTag.PlaceholderText = "새 태그 입력";
            this.txtNewTag.SelectedText = "";
            this.txtNewTag.Size = new System.Drawing.Size(790, 27);
            this.txtNewTag.TabIndex = 3;
            // 
            // flpTags
            // 
            this.flpTags.AutoScroll = true;
            this.flpTags.BackColor = System.Drawing.Color.WhiteSmoke;
            this.flpTags.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpTags.Location = new System.Drawing.Point(19, 75);
            this.flpTags.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.flpTags.Name = "flpTags";
            this.flpTags.Padding = new System.Windows.Forms.Padding(5);
            this.flpTags.Size = new System.Drawing.Size(1050, 164);
            this.flpTags.TabIndex = 4;
            // 
            // txtTags
            // 
            this.txtTags.BorderRadius = 5;
            this.txtTags.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTags.DefaultText = "";
            this.txtTags.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTags.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTags.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTags.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTags.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTags.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTags.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTags.Location = new System.Drawing.Point(116, 30);
            this.txtTags.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTags.Name = "txtTags";
            this.txtTags.PlaceholderText = "";
            this.txtTags.ReadOnly = true;
            this.txtTags.SelectedText = "";
            this.txtTags.Size = new System.Drawing.Size(954, 27);
            this.txtTags.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(16, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 22);
            this.label6.TabIndex = 0;
            this.label6.Text = "태그:";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.BorderRadius = 8;
            this.panel5.Controls.Add(this.btnAddEncouragement);
            this.panel5.Controls.Add(this.btnAddRetrospection);
            this.panel5.Controls.Add(this.btnAddImageBlock);
            this.panel5.Controls.Add(this.btnAddContentBlock);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.FillColor = System.Drawing.Color.White;
            this.panel5.Location = new System.Drawing.Point(0, 830);
            this.panel5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(15);
            this.panel5.ShadowDecoration.Color = System.Drawing.Color.LightGray;
            this.panel5.ShadowDecoration.Depth = 10;
            this.panel5.ShadowDecoration.Enabled = true;
            this.panel5.Size = new System.Drawing.Size(1079, 80);
            this.panel5.TabIndex = 5;
            // 
            // btnAddEncouragement
            // 
            this.btnAddEncouragement.BorderRadius = 5;
            this.btnAddEncouragement.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddEncouragement.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddEncouragement.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddEncouragement.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddEncouragement.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnAddEncouragement.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddEncouragement.ForeColor = System.Drawing.Color.White;
            this.btnAddEncouragement.Location = new System.Drawing.Point(780, 20);
            this.btnAddEncouragement.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddEncouragement.Name = "btnAddEncouragement";
            this.btnAddEncouragement.Size = new System.Drawing.Size(180, 40);
            this.btnAddEncouragement.TabIndex = 3;
            this.btnAddEncouragement.Text = "격려 메시지 추가";
            this.btnAddEncouragement.Click += new System.EventHandler(this.btnAddEncouragement_Click);
            // 
            // btnAddRetrospection
            // 
            this.btnAddRetrospection.BorderRadius = 5;
            this.btnAddRetrospection.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddRetrospection.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddRetrospection.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddRetrospection.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddRetrospection.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnAddRetrospection.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddRetrospection.ForeColor = System.Drawing.Color.White;
            this.btnAddRetrospection.Location = new System.Drawing.Point(580, 20);
            this.btnAddRetrospection.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddRetrospection.Name = "btnAddRetrospection";
            this.btnAddRetrospection.Size = new System.Drawing.Size(180, 40);
            this.btnAddRetrospection.TabIndex = 2;
            this.btnAddRetrospection.Text = "회고 블록 추가";
            this.btnAddRetrospection.Click += new System.EventHandler(this.btnAddRetrospection_Click);
            // 
            // btnAddImageBlock
            // 
            this.btnAddImageBlock.BorderRadius = 5;
            this.btnAddImageBlock.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddImageBlock.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddImageBlock.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddImageBlock.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddImageBlock.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnAddImageBlock.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddImageBlock.ForeColor = System.Drawing.Color.White;
            this.btnAddImageBlock.Location = new System.Drawing.Point(380, 20);
            this.btnAddImageBlock.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddImageBlock.Name = "btnAddImageBlock";
            this.btnAddImageBlock.Size = new System.Drawing.Size(180, 40);
            this.btnAddImageBlock.TabIndex = 1;
            this.btnAddImageBlock.Text = "이미지 블록 추가";
            this.btnAddImageBlock.Click += new System.EventHandler(this.btnAddImageBlock_Click);
            // 
            // btnAddContentBlock
            // 
            this.btnAddContentBlock.BorderRadius = 5;
            this.btnAddContentBlock.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddContentBlock.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddContentBlock.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddContentBlock.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddContentBlock.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnAddContentBlock.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddContentBlock.ForeColor = System.Drawing.Color.White;
            this.btnAddContentBlock.Location = new System.Drawing.Point(180, 20);
            this.btnAddContentBlock.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddContentBlock.Name = "btnAddContentBlock";
            this.btnAddContentBlock.Size = new System.Drawing.Size(180, 40);
            this.btnAddContentBlock.TabIndex = 0;
            this.btnAddContentBlock.Text = "콘텐츠 블록 추가";
            this.btnAddContentBlock.Click += new System.EventHandler(this.btnAddContentBlock_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Transparent;
            this.panel6.BorderRadius = 8;
            this.panel6.Controls.Add(this.btnPublish);
            this.panel6.Controls.Add(this.txtTitle);
            this.panel6.Controls.Add(this.label7);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.FillColor = System.Drawing.Color.White;
            this.panel6.Location = new System.Drawing.Point(0, 910);
            this.panel6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel6.Name = "panel6";
            this.panel6.Padding = new System.Windows.Forms.Padding(15);
            this.panel6.ShadowDecoration.Color = System.Drawing.Color.LightGray;
            this.panel6.ShadowDecoration.Depth = 10;
            this.panel6.ShadowDecoration.Enabled = true;
            this.panel6.Size = new System.Drawing.Size(1079, 80);
            this.panel6.TabIndex = 6;
            // 
            // btnPublish
            // 
            this.btnPublish.BorderRadius = 5;
            this.btnPublish.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPublish.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPublish.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPublish.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPublish.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnPublish.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPublish.ForeColor = System.Drawing.Color.White;
            this.btnPublish.Location = new System.Drawing.Point(950, 20);
            this.btnPublish.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPublish.Name = "btnPublish";
            this.btnPublish.Size = new System.Drawing.Size(120, 35);
            this.btnPublish.TabIndex = 2;
            this.btnPublish.Text = "발행하기";
            this.btnPublish.Click += new System.EventHandler(this.btnPublish_Click);
            // 
            // txtTitle
            // 
            this.txtTitle.BorderRadius = 5;
            this.txtTitle.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTitle.DefaultText = "";
            this.txtTitle.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTitle.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTitle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTitle.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTitle.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTitle.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTitle.Location = new System.Drawing.Point(116, 23);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.PlaceholderText = "";
            this.txtTitle.SelectedText = "";
            this.txtTitle.Size = new System.Drawing.Size(820, 27);
            this.txtTitle.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(16, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 22);
            this.label7.TabIndex = 0;
            this.label7.Text = "제목:";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 990);
            this.flowLayoutPanel1.MinimumSize = new System.Drawing.Size(0, 50);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1079, 50);
            this.flowLayoutPanel1.TabIndex = 7;
            // 
            // pbBanner
            // 
            this.pbBanner.Dock = System.Windows.Forms.DockStyle.Top;
            this.pbBanner.Image = global::TILAutoWriter.Properties.Resources.BannerImage;
            this.pbBanner.ImageRotate = 0F;
            this.pbBanner.Location = new System.Drawing.Point(0, 0);
            this.pbBanner.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbBanner.Name = "pbBanner";
            this.pbBanner.Padding = new System.Windows.Forms.Padding(0, 40, 0, 0);
            this.pbBanner.Size = new System.Drawing.Size(1100, 160);
            this.pbBanner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbBanner.TabIndex = 0;
            this.pbBanner.TabStop = false;
            this.pbBanner.Click += new System.EventHandler(this.pbBanner_Click);
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 10;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // guna2ShadowForm1
            // 
            this.guna2ShadowForm1.BorderRadius = 10;
            this.guna2ShadowForm1.ShadowColor = System.Drawing.Color.DimGray;
            this.guna2ShadowForm1.TargetForm = this;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(985, 6);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 30);
            this.guna2ControlBox1.TabIndex = 8;
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.guna2ControlBox2.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox2.Location = new System.Drawing.Point(1036, 6);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.Size = new System.Drawing.Size(45, 30);
            this.guna2ControlBox2.TabIndex = 9;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("나눔바른고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(16, 12);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(104, 19);
            this.guna2HtmlLabel1.TabIndex = 3;
            this.guna2HtmlLabel1.Text = "Til 작성 프로그램";
            this.guna2HtmlLabel1.Click += new System.EventHandler(this.guna2HtmlLabel1_Click);
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this.pbBanner;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // pnlScrollableContent
            // 
            this.pnlScrollableContent.AutoScroll = true;
            this.pnlScrollableContent.Controls.Add(this.flowLayoutPanel1);
            this.pnlScrollableContent.Controls.Add(this.panel6);
            this.pnlScrollableContent.Controls.Add(this.panel5);
            this.pnlScrollableContent.Controls.Add(this.panel4);
            this.pnlScrollableContent.Controls.Add(this.panel3);
            this.pnlScrollableContent.Controls.Add(this.panel2);
            this.pnlScrollableContent.Controls.Add(this.panel1);
            this.pnlScrollableContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlScrollableContent.Location = new System.Drawing.Point(0, 160);
            this.pnlScrollableContent.Name = "pnlScrollableContent";
            this.pnlScrollableContent.Size = new System.Drawing.Size(1100, 890);
            this.pnlScrollableContent.TabIndex = 10;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(1100, 1050);
            this.Controls.Add(this.pnlScrollableContent);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.guna2ControlBox2);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.pbBanner);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.Text = "내일배움캠프 TIL 작성기";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBanner)).EndInit();
            this.pnlScrollableContent.ResumeLayout(false);
            this.pnlScrollableContent.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel panel1;
        private Guna.UI2.WinForms.Guna2CheckBox chkAutoStart;
        private Guna.UI2.WinForms.Guna2Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel flpBannerPreviews; // Added
        private Guna.UI2.WinForms.Guna2Button btnLoadBannerImage;
        private Guna.UI2.WinForms.Guna2TextBox txtBannerImage;
        private Guna.UI2.WinForms.Guna2HtmlLabel label5;
        private Guna.UI2.WinForms.Guna2Panel panel3;
        private Guna.UI2.WinForms.Guna2TextBox txtTistoryId;
        private Guna.UI2.WinForms.Guna2HtmlLabel label1;
        private Guna.UI2.WinForms.Guna2TextBox txtGeminiApiKey;
        private Guna.UI2.WinForms.Guna2HtmlLabel label3;
        private Guna.UI2.WinForms.Guna2TextBox txtChatGptApiKey;
        private Guna.UI2.WinForms.Guna2HtmlLabel label2;
        private Guna.UI2.WinForms.Guna2Panel panel4;
        private Guna.UI2.WinForms.Guna2Button btnRemoveTag;
        private Guna.UI2.WinForms.Guna2Button btnAddTag;
        private Guna.UI2.WinForms.Guna2TextBox txtNewTag;
        private System.Windows.Forms.FlowLayoutPanel flpTags;
        private Guna.UI2.WinForms.Guna2TextBox txtTags;
        private Guna.UI2.WinForms.Guna2HtmlLabel label6;
        private Guna.UI2.WinForms.Guna2Panel panel5;
        private Guna.UI2.WinForms.Guna2Button btnAddEncouragement;
        private Guna.UI2.WinForms.Guna2Button btnAddRetrospection;
        private Guna.UI2.WinForms.Guna2Button btnAddImageBlock;
        private Guna.UI2.WinForms.Guna2Button btnAddContentBlock;
        private Guna.UI2.WinForms.Guna2Panel panel6;
        private Guna.UI2.WinForms.Guna2Button btnPublish;
        private Guna.UI2.WinForms.Guna2TextBox txtTitle;
        private Guna.UI2.WinForms.Guna2HtmlLabel label7;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpAnalysisEndTime;
        private Guna.UI2.WinForms.Guna2HtmlLabel label4;
        private Guna.UI2.WinForms.Guna2Button btnStartAnalysis;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblAnalysisStatus;
        private Guna.UI2.WinForms.Guna2PictureBox pbBanner;
        private Guna.UI2.WinForms.Guna2TextBox txtTistoryPassword;
        private Guna.UI2.WinForms.Guna2HtmlLabel label8;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2Panel pnlScrollableContent;
    }
}