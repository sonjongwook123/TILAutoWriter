using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace TILAutoPublisher
{
    public partial class ImageBlock : UserControl, IBlock
    {
        public event EventHandler OnRemove;
        public event EventHandler OnMoveUp;
        public event EventHandler OnMoveDown;

        private string imagePath = "";

        public string ImagePath
        {
            get => imagePath;
            set
            {
                imagePath = value;
                UpdateImagePreview();
            }
        }

        public ImageBlock()
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
                }
                catch
                {
                    picImage.Image = null;
                    lblImageName.Text = "이미지 로드 실패";
                }
            }
            else
            {
                picImage.Image = null;
                lblImageName.Text = "이미지 없음";
            }
        }

        public string GetHtml()
        {
            if (string.IsNullOrEmpty(imagePath)) return "";
            return $"<div class='image-block'><img src='{imagePath}' alt='이미지' style='max-width:100%;'/></div>";
        }

        private void btnChangeImage_Click(object sender, EventArgs e)
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
            this.picImage = new System.Windows.Forms.PictureBox();
            this.lblImageName = new System.Windows.Forms.Label();
            this.btnChangeImage = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).BeginInit();
            this.SuspendLayout();
            // 
            // picImage
            // 
            this.picImage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picImage.Location = new System.Drawing.Point(3, 3);
            this.picImage.Name = "picImage";
            this.picImage.Size = new System.Drawing.Size(494, 250);
            this.picImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picImage.TabIndex = 0;
            this.picImage.TabStop = false;
            // 
            // lblImageName
            // 
            this.lblImageName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblImageName.AutoSize = true;
            this.lblImageName.Location = new System.Drawing.Point(350, 256);
            this.lblImageName.Name = "lblImageName";
            this.lblImageName.Size = new System.Drawing.Size(69, 12);
            this.lblImageName.TabIndex = 1;
            this.lblImageName.Text = "이미지 없음";
            // 
            // btnChangeImage
            // 
            this.btnChangeImage.Location = new System.Drawing.Point(3, 256);
            this.btnChangeImage.Name = "btnChangeImage";
            this.btnChangeImage.Size = new System.Drawing.Size(75, 23);
            this.btnChangeImage.TabIndex = 2;
            this.btnChangeImage.Text = "이미지 변경";
            this.btnChangeImage.UseVisualStyleBackColor = true;
            this.btnChangeImage.Click += new System.EventHandler(this.btnChangeImage_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemove.Location = new System.Drawing.Point(422, 256);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = "삭제";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnUp
            // 
            this.btnUp.Location = new System.Drawing.Point(84, 256);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(40, 23);
            this.btnUp.TabIndex = 4;
            this.btnUp.Text = "↑";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnDown
            // 
            this.btnDown.Location = new System.Drawing.Point(130, 256);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(40, 23);
            this.btnDown.TabIndex = 5;
            this.btnDown.Text = "↓";
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // ImageBlock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnChangeImage);
            this.Controls.Add(this.lblImageName);
            this.Controls.Add(this.picImage);
            this.Name = "ImageBlock";
            this.Size = new System.Drawing.Size(500, 282);
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.PictureBox picImage;
        private System.Windows.Forms.Label lblImageName;
        private System.Windows.Forms.Button btnChangeImage;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnDown;
    }
}