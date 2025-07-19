using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace TILAutoPublisher
{
    public partial class ContentBlock : UserControl, IBlock
    {
        public event EventHandler OnRemove;
        public event EventHandler OnMoveUp;
        public event EventHandler OnMoveDown;

        private string imagePath = "";

        public string ContentText
        {
            get => txtContent.Text;
            set => txtContent.Text = value;
        }

        public string ImagePath
        {
            get => imagePath;
            set
            {
                imagePath = value;
                UpdateImagePreview();
            }
        }

        public ContentBlock()
        {
            InitializeComponent();
        }

        private void UpdateImagePreview()
        {
            if (!string.IsNullOrEmpty(imagePath) && File.Exists(imagePath))
            {
                try
                {
                    picImage.Image = Image.FromFile(imagePath);
                    lblImageName.Text = Path.GetFileName(imagePath);
                    btnRemoveImage.Visible = true;
                }
                catch
                {
                    picImage.Image = null;
                    lblImageName.Text = "이미지 로드 실패";
                    btnRemoveImage.Visible = false;
                }
            }
            else
            {
                picImage.Image = null;
                lblImageName.Text = "이미지 없음";
                btnRemoveImage.Visible = false;
            }
        }

        public string GetHtml()
        {
            StringBuilder html = new StringBuilder();
            html.AppendLine("<div class='content-block'>");
            
            if (!string.IsNullOrWhiteSpace(txtContent.Text))
            {
                html.AppendLine($"<p>{txtContent.Text.Replace("\n", "<br/>")}</p>");
            }

            if (!string.IsNullOrEmpty(imagePath))
            {
                html.AppendLine($"<p><img src='{imagePath}' alt='이미지' style='max-width:100%;'/></p>");
            }

            html.AppendLine("</div>");
            return html.ToString();
        }

        private void btnAddImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files (*.bmp;*.jpg;*.jpeg;*.png)|*.bmp;*.jpg;*.jpeg;*.png";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    ImagePath = openFileDialog.FileName;
                }
            }
        }

        private void btnRemoveImage_Click(object sender, EventArgs e)
        {
            ImagePath = "";
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            OnRemove?.Invoke(this, EventArgs.Empty);
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            OnMoveUp?.Invoke(this, EventArgs.Empty);
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            OnMoveDown?.Invoke(this, EventArgs.Empty);
        }

        private void InitializeComponent()
        {
            this.txtContent = new System.Windows.Forms.TextBox();
            this.picImage = new System.Windows.Forms.PictureBox();
            this.lblImageName = new System.Windows.Forms.Label();
            this.btnAddImage = new System.Windows.Forms.Button();
            this.btnRemoveImage = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).BeginInit();
            this.SuspendLayout();
            // 
            // txtContent
            // 
            this.txtContent.AcceptsReturn = true;
            this.txtContent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtContent.Location = new System.Drawing.Point(3, 3);
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtContent.Size = new System.Drawing.Size(494, 100);
            this.txtContent.TabIndex = 0;
            // 
            // picImage
            // 
            this.picImage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picImage.Location = new System.Drawing.Point(3, 109);
            this.picImage.Name = "picImage";
            this.picImage.Size = new System.Drawing.Size(494, 150);
            this.picImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picImage.TabIndex = 1;
            this.picImage.TabStop = false;
            // 
            // lblImageName
            // 
            this.lblImageName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblImageName.AutoSize = true;
            this.lblImageName.Location = new System.Drawing.Point(350, 262);
            this.lblImageName.Name = "lblImageName";
            this.lblImageName.Size = new System.Drawing.Size(69, 12);
            this.lblImageName.TabIndex = 2;
            this.lblImageName.Text = "이미지 없음";
            // 
            // btnAddImage
            // 
            this.btnAddImage.Location = new System.Drawing.Point(3, 262);
            this.btnAddImage.Name = "btnAddImage";
            this.btnAddImage.Size = new System.Drawing.Size(75, 23);
            this.btnAddImage.TabIndex = 3;
            this.btnAddImage.Text = "이미지 추가";
            this.btnAddImage.UseVisualStyleBackColor = true;
            this.btnAddImage.Click += new System.EventHandler(this.btnAddImage_Click);
            // 
            // btnRemoveImage
            // 
            this.btnRemoveImage.Location = new System.Drawing.Point(84, 262);
            this.btnRemoveImage.Name = "btnRemoveImage";
            this.btnRemoveImage.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveImage.TabIndex = 4;
            this.btnRemoveImage.Text = "이미지 제거";
            this.btnRemoveImage.UseVisualStyleBackColor = true;
            this.btnRemoveImage.Visible = false;
            this.btnRemoveImage.Click += new System.EventHandler(this.btnRemoveImage_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemove.Location = new System.Drawing.Point(422, 262);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 5;
            this.btnRemove.Text = "삭제";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnUp
            // 
            this.btnUp.Location = new System.Drawing.Point(165, 262);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(40, 23);
            this.btnUp.TabIndex = 6;
            this.btnUp.Text = "↑";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnDown
            // 
            this.btnDown.Location = new System.Drawing.Point(211, 262);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(40, 23);
            this.btnDown.TabIndex = 7;
            this.btnDown.Text = "↓";
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // ContentBlock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnRemoveImage);
            this.Controls.Add(this.btnAddImage);
            this.Controls.Add(this.lblImageName);
            this.Controls.Add(this.picImage);
            this.Controls.Add(this.txtContent);
            this.Name = "ContentBlock";
            this.Size = new System.Drawing.Size(500, 288);
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.PictureBox picImage;
        private System.Windows.Forms.Label lblImageName;
        private System.Windows.Forms.Button btnAddImage;
        private System.Windows.Forms.Button btnRemoveImage;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnDown;
    }
}