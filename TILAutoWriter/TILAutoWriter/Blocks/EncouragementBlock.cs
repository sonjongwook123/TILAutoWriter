using System;
using System.Windows.Forms;

namespace TILAutoPublisher
{
    public partial class EncouragementBlock : UserControl, IBlock
    {
        public event EventHandler OnRemove;
        public event EventHandler OnMoveUp;
        public event EventHandler OnMoveDown;

        public string EncouragementMessage
        {
            get => txtEncouragement.Text;
            set => txtEncouragement.Text = value;
        }

        public EncouragementBlock()
        {
            InitializeComponent();
        }

        public string GetHtml()
        {
            if (string.IsNullOrWhiteSpace(txtEncouragement.Text)) return "";
            return $"<div class='encouragement-block'><p style='font-weight:bold; color:#2c3e50;'>{txtEncouragement.Text}</p></div>";
        }

        private void btnChangeMessage_Click(object sender, EventArgs e)
        {
            using (var dialog = new EncouragementMessageDialog(txtEncouragement.Text))
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    txtEncouragement.Text = dialog.SelectedMessage;
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
            this.txtEncouragement = new System.Windows.Forms.TextBox();
            this.btnChangeMessage = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtEncouragement
            // 
            this.txtEncouragement.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEncouragement.Location = new System.Drawing.Point(3, 4);
            this.txtEncouragement.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEncouragement.Multiline = true;
            this.txtEncouragement.Name = "txtEncouragement";
            this.txtEncouragement.Size = new System.Drawing.Size(963, 62);
            this.txtEncouragement.TabIndex = 0;
            // 
            // btnChangeMessage
            // 
            this.btnChangeMessage.Location = new System.Drawing.Point(3, 74);
            this.btnChangeMessage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnChangeMessage.Name = "btnChangeMessage";
            this.btnChangeMessage.Size = new System.Drawing.Size(114, 29);
            this.btnChangeMessage.TabIndex = 1;
            this.btnChangeMessage.Text = "메시지 변경";
            this.btnChangeMessage.UseVisualStyleBackColor = true;
            this.btnChangeMessage.Click += new System.EventHandler(this.btnChangeMessage_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemove.Location = new System.Drawing.Point(881, 74);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(86, 29);
            this.btnRemove.TabIndex = 2;
            this.btnRemove.Text = "삭제";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnUp
            // 
            this.btnUp.Location = new System.Drawing.Point(125, 74);
            this.btnUp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(46, 29);
            this.btnUp.TabIndex = 3;
            this.btnUp.Text = "↑";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnDown
            // 
            this.btnDown.Location = new System.Drawing.Point(177, 74);
            this.btnDown.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(46, 29);
            this.btnDown.TabIndex = 4;
            this.btnDown.Text = "↓";
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // EncouragementBlock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnChangeMessage);
            this.Controls.Add(this.txtEncouragement);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "EncouragementBlock";
            this.Size = new System.Drawing.Size(970, 106);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.TextBox txtEncouragement;
        private System.Windows.Forms.Button btnChangeMessage;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnDown;
    }
}