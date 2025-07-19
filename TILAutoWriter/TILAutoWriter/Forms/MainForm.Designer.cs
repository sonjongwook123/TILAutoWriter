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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblAnalysisStatus = new System.Windows.Forms.Label();
            this.btnStartAnalysis = new System.Windows.Forms.Button();
            this.dtpAnalysisEndTime = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.chkAutoStart = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnLoadBannerImage = new System.Windows.Forms.Button();
            this.txtBannerImage = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtGeminiApiKey = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtChatGptApiKey = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTistoryApiKey = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnRemoveTag = new System.Windows.Forms.Button();
            this.btnAddTag = new System.Windows.Forms.Button();
            this.txtNewTag = new System.Windows.Forms.TextBox();
            this.lstTags = new System.Windows.Forms.ListBox();
            this.txtTags = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnAddEncouragement = new System.Windows.Forms.Button();
            this.btnAddRetrospection = new System.Windows.Forms.Button();
            this.btnAddImageBlock = new System.Windows.Forms.Button();
            this.btnAddContentBlock = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnPublish = new System.Windows.Forms.Button();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblAnalysisStatus);
            this.panel1.Controls.Add(this.btnStartAnalysis);
            this.panel1.Controls.Add(this.dtpAnalysisEndTime);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.chkAutoStart);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(534, 60);
            this.panel1.TabIndex = 0;
            // 
            // lblAnalysisStatus
            // 
            this.lblAnalysisStatus.AutoSize = true;
            this.lblAnalysisStatus.Location = new System.Drawing.Point(12, 35);
            this.lblAnalysisStatus.Name = "lblAnalysisStatus";
            this.lblAnalysisStatus.Size = new System.Drawing.Size(69, 12);
            this.lblAnalysisStatus.TabIndex = 4;
            this.lblAnalysisStatus.Text = "분석 대기 중";
            // 
            // btnStartAnalysis
            // 
            this.btnStartAnalysis.Location = new System.Drawing.Point(447, 5);
            this.btnStartAnalysis.Name = "btnStartAnalysis";
            this.btnStartAnalysis.Size = new System.Drawing.Size(75, 23);
            this.btnStartAnalysis.TabIndex = 3;
            this.btnStartAnalysis.Text = "분석 시작";
            this.btnStartAnalysis.UseVisualStyleBackColor = true;
            this.btnStartAnalysis.Click += new System.EventHandler(this.btnStartAnalysis_Click);
            // 
            // dtpAnalysisEndTime
            // 
            this.dtpAnalysisEndTime.CustomFormat = "HH:mm";
            this.dtpAnalysisEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpAnalysisEndTime.Location = new System.Drawing.Point(341, 7);
            this.dtpAnalysisEndTime.Name = "dtpAnalysisEndTime";
            this.dtpAnalysisEndTime.ShowUpDown = true;
            this.dtpAnalysisEndTime.Size = new System.Drawing.Size(100, 21);
            this.dtpAnalysisEndTime.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(276, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "분석 종료:";
            // 
            // chkAutoStart
            // 
            this.chkAutoStart.AutoSize = true;
            this.chkAutoStart.Location = new System.Drawing.Point(12, 9);
            this.chkAutoStart.Name = "chkAutoStart";
            this.chkAutoStart.Size = new System.Drawing.Size(172, 16);
            this.chkAutoStart.TabIndex = 0;
            this.chkAutoStart.Text = "프로그램 시작 시 분석 시작";
            this.chkAutoStart.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnLoadBannerImage);
            this.panel2.Controls.Add(this.txtBannerImage);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 60);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(534, 40);
            this.panel2.TabIndex = 1;
            // 
            // btnLoadBannerImage
            // 
            this.btnLoadBannerImage.Location = new System.Drawing.Point(447, 8);
            this.btnLoadBannerImage.Name = "btnLoadBannerImage";
            this.btnLoadBannerImage.Size = new System.Drawing.Size(75, 23);
            this.btnLoadBannerImage.TabIndex = 2;
            this.btnLoadBannerImage.Text = "불러오기";
            this.btnLoadBannerImage.UseVisualStyleBackColor = true;
            this.btnLoadBannerImage.Click += new System.EventHandler(this.btnLoadBannerImage_Click);
            // 
            // txtBannerImage
            // 
            this.txtBannerImage.Location = new System.Drawing.Point(90, 9);
            this.txtBannerImage.Name = "txtBannerImage";
            this.txtBannerImage.Size = new System.Drawing.Size(351, 21);
            this.txtBannerImage.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "배너 이미지:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtGeminiApiKey);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.txtChatGptApiKey);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.txtTistoryApiKey);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 100);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(534, 90);
            this.panel3.TabIndex = 2;
            // 
            // txtGeminiApiKey
            // 
            this.txtGeminiApiKey.Location = new System.Drawing.Point(90, 62);
            this.txtGeminiApiKey.Name = "txtGeminiApiKey";
            this.txtGeminiApiKey.Size = new System.Drawing.Size(432, 21);
            this.txtGeminiApiKey.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "Gemini API키:";
            // 
            // txtChatGptApiKey
            // 
            this.txtChatGptApiKey.Location = new System.Drawing.Point(90, 35);
            this.txtChatGptApiKey.Name = "txtChatGptApiKey";
            this.txtChatGptApiKey.Size = new System.Drawing.Size(432, 21);
            this.txtChatGptApiKey.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "ChatGPT API키:";
            // 
            // txtTistoryApiKey
            // 
            this.txtTistoryApiKey.Location = new System.Drawing.Point(90, 8);
            this.txtTistoryApiKey.Name = "txtTistoryApiKey";
            this.txtTistoryApiKey.Size = new System.Drawing.Size(432, 21);
            this.txtTistoryApiKey.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tistory API키:";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnRemoveTag);
            this.panel4.Controls.Add(this.btnAddTag);
            this.panel4.Controls.Add(this.txtNewTag);
            this.panel4.Controls.Add(this.lstTags);
            this.panel4.Controls.Add(this.txtTags);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 190);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(534, 120);
            this.panel4.TabIndex = 3;
            // 
            // btnRemoveTag
            // 
            this.btnRemoveTag.Location = new System.Drawing.Point(447, 35);
            this.btnRemoveTag.Name = "btnRemoveTag";
            this.btnRemoveTag.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveTag.TabIndex = 5;
            this.btnRemoveTag.Text = "태그 제거";
            this.btnRemoveTag.UseVisualStyleBackColor = true;
            this.btnRemoveTag.Click += new System.EventHandler(this.btnRemoveTag_Click);
            // 
            // btnAddTag
            // 
            this.btnAddTag.Location = new System.Drawing.Point(447, 6);
            this.btnAddTag.Name = "btnAddTag";
            this.btnAddTag.Size = new System.Drawing.Size(75, 23);
            this.btnAddTag.TabIndex = 4;
            this.btnAddTag.Text = "태그 추가";
            this.btnAddTag.UseVisualStyleBackColor = true;
            this.btnAddTag.Click += new System.EventHandler(this.btnAddTag_Click);
            // 
            // txtNewTag
            // 
            this.txtNewTag.Location = new System.Drawing.Point(341, 7);
            this.txtNewTag.Name = "txtNewTag";
            this.txtNewTag.Size = new System.Drawing.Size(100, 21);
            this.txtNewTag.TabIndex = 3;
            // 
            // lstTags
            // 
            this.lstTags.FormattingEnabled = true;
            this.lstTags.ItemHeight = 12;
            this.lstTags.Location = new System.Drawing.Point(90, 35);
            this.lstTags.Name = "lstTags";
            this.lstTags.Size = new System.Drawing.Size(351, 76);
            this.lstTags.TabIndex = 2;
            // 
            // txtTags
            // 
            this.txtTags.Location = new System.Drawing.Point(90, 8);
            this.txtTags.Name = "txtTags";
            this.txtTags.ReadOnly = true;
            this.txtTags.Size = new System.Drawing.Size(351, 21);
            this.txtTags.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "태그:";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnAddEncouragement);
            this.panel5.Controls.Add(this.btnAddRetrospection);
            this.panel5.Controls.Add(this.btnAddImageBlock);
            this.panel5.Controls.Add(this.btnAddContentBlock);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 310);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(534, 40);
            this.panel5.TabIndex = 4;
            // 
            // btnAddEncouragement
            // 
            this.btnAddEncouragement.Location = new System.Drawing.Point(249, 5);
            this.btnAddEncouragement.Name = "btnAddEncouragement";
            this.btnAddEncouragement.Size = new System.Drawing.Size(75, 30);
            this.btnAddEncouragement.TabIndex = 3;
            this.btnAddEncouragement.Text = "응원 추가";
            this.btnAddEncouragement.UseVisualStyleBackColor = true;
            this.btnAddEncouragement.Click += new System.EventHandler(this.btnAddEncouragement_Click);
            // 
            // btnAddRetrospection
            // 
            this.btnAddRetrospection.Location = new System.Drawing.Point(168, 5);
            this.btnAddRetrospection.Name = "btnAddRetrospection";
            this.btnAddRetrospection.Size = new System.Drawing.Size(75, 30);
            this.btnAddRetrospection.TabIndex = 2;
            this.btnAddRetrospection.Text = "회고 추가";
            this.btnAddRetrospection.UseVisualStyleBackColor = true;
            this.btnAddRetrospection.Click += new System.EventHandler(this.btnAddRetrospection_Click);
            // 
            // btnAddImageBlock
            // 
            this.btnAddImageBlock.Location = new System.Drawing.Point(87, 5);
            this.btnAddImageBlock.Name = "btnAddImageBlock";
            this.btnAddImageBlock.Size = new System.Drawing.Size(75, 30);
            this.btnAddImageBlock.TabIndex = 1;
            this.btnAddImageBlock.Text = "이미지 추가";
            this.btnAddImageBlock.UseVisualStyleBackColor = true;
            this.btnAddImageBlock.Click += new System.EventHandler(this.btnAddImageBlock_Click);
            // 
            // btnAddContentBlock
            // 
            this.btnAddContentBlock.Location = new System.Drawing.Point(6, 5);
            this.btnAddContentBlock.Name = "btnAddContentBlock";
            this.btnAddContentBlock.Size = new System.Drawing.Size(75, 30);
            this.btnAddContentBlock.TabIndex = 0;
            this.btnAddContentBlock.Text = "내용 추가";
            this.btnAddContentBlock.UseVisualStyleBackColor = true;
            this.btnAddContentBlock.Click += new System.EventHandler(this.btnAddContentBlock_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btnPublish);
            this.panel6.Controls.Add(this.txtTitle);
            this.panel6.Controls.Add(this.label7);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 350);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(534, 60);
            this.panel6.TabIndex = 5;
            // 
            // btnPublish
            // 
            this.btnPublish.Location = new System.Drawing.Point(447, 30);
            this.btnPublish.Name = "btnPublish";
            this.btnPublish.Size = new System.Drawing.Size(75, 23);
            this.btnPublish.TabIndex = 2;
            this.btnPublish.Text = "글 업로드";
            this.btnPublish.UseVisualStyleBackColor = true;
            this.btnPublish.Click += new System.EventHandler(this.btnPublish_Click);
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(90, 7);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(432, 21);
            this.txtTitle.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 0;
            this.label7.Text = "제목:";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 410);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(534, 251);
            this.flowLayoutPanel1.TabIndex = 6;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 661);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.Text = "내일배움캠프 TIL 작성기";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
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
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox chkAutoStart;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnLoadBannerImage;
        private System.Windows.Forms.TextBox txtBannerImage;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtTistoryApiKey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGeminiApiKey;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtChatGptApiKey;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnRemoveTag;
        private System.Windows.Forms.Button btnAddTag;
        private System.Windows.Forms.TextBox txtNewTag;
        private System.Windows.Forms.ListBox lstTags;
        private System.Windows.Forms.TextBox txtTags;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnAddEncouragement;
        private System.Windows.Forms.Button btnAddRetrospection;
        private System.Windows.Forms.Button btnAddImageBlock;
        private System.Windows.Forms.Button btnAddContentBlock;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnPublish;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.DateTimePicker dtpAnalysisEndTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnStartAnalysis;
        private System.Windows.Forms.Label lblAnalysisStatus;
    }
}