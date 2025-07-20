using System;
using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;

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
            this.SizeChanged += EncouragementBlock_SizeChanged;
            AdjustLayoutForCurrentSize();
            // Ensure buttons are visible
            btnChangeMessage.Visible = true;
            btnRemove.Visible = true;
            btnUp.Visible = true;
            btnDown.Visible = true;
        }

        private void EncouragementBlock_SizeChanged(object sender, EventArgs e)
        {
            AdjustLayoutForCurrentSize();
        }

        private void AdjustLayoutForCurrentSize()
        {
            // Adjust the width of the textbox to match the panel's inner width
            int padding = 15; // Match panelContainer padding
            txtEncouragement.Width = panelContainer.Width - (2 * padding);
            txtEncouragement.Location = new Point(padding, padding); // Align with panel padding

            // Adjust button positions based on the new width
            btnRemove.Location = new Point(panelContainer.Width - btnRemove.Width - padding, 80);
            btnUp.Location = new Point(143, 80);
            btnDown.Location = new Point(195, 80);
            btnChangeMessage.Location = new Point(padding, 80);
        }

        public string GetHtml()
        {
            if (string.IsNullOrWhiteSpace(txtEncouragement.Text)) return "";
            return $"<div class='encouragement-block' style='background-color: #F8F8F8; padding: 15px; border-radius: 8px; box-shadow: 0 2px 4px rgba(0,0,0,0.1);'>" +
                   $"<p style='font-weight:bold; color:#0078CC; font-size:16px; margin:0;'>{txtEncouragement.Text}</p>" +
                   $"</div>";
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
            this.panelContainer = new Guna.UI2.WinForms.Guna2Panel();
            this.txtEncouragement = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnChangeMessage = new Guna.UI2.WinForms.Guna2Button();
            this.btnRemove = new Guna.UI2.WinForms.Guna2Button();
            this.btnUp = new Guna.UI2.WinForms.Guna2Button();
            this.btnDown = new Guna.UI2.WinForms.Guna2Button();
            this.panelContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelContainer
            // 
            this.panelContainer.BackColor = System.Drawing.Color.Transparent;
            this.panelContainer.BorderRadius = 8;
            this.panelContainer.Controls.Add(this.txtEncouragement);
            this.panelContainer.Controls.Add(this.btnChangeMessage);
            this.panelContainer.Controls.Add(this.btnRemove);
            this.panelContainer.Controls.Add(this.btnUp);
            this.panelContainer.Controls.Add(this.btnDown);
            this.panelContainer.FillColor = System.Drawing.Color.White;
            this.panelContainer.Location = new System.Drawing.Point(0, 0);
            this.panelContainer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Padding = new System.Windows.Forms.Padding(15);
            this.panelContainer.ShadowDecoration.Color = System.Drawing.Color.LightGray;
            this.panelContainer.ShadowDecoration.Depth = 10;
            this.panelContainer.ShadowDecoration.Enabled = true;
            this.panelContainer.Size = new System.Drawing.Size(1079, 130);
            this.panelContainer.TabIndex = 0;
            // 
            // txtEncouragement
            // 
            this.txtEncouragement.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEncouragement.BorderRadius = 5;
            this.txtEncouragement.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEncouragement.DefaultText = "";
            this.txtEncouragement.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtEncouragement.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEncouragement.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEncouragement.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEncouragement.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEncouragement.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEncouragement.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.txtEncouragement.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEncouragement.Location = new System.Drawing.Point(15, 15);
            this.txtEncouragement.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEncouragement.Multiline = true;
            this.txtEncouragement.Name = "txtEncouragement";
            this.txtEncouragement.PlaceholderText = "";
            this.txtEncouragement.SelectedText = "";
            this.txtEncouragement.Size = new System.Drawing.Size(1049, 60);
            this.txtEncouragement.TabIndex = 0;
            // 
            // btnChangeMessage
            // 
            this.btnChangeMessage.BorderRadius = 5;
            this.btnChangeMessage.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnChangeMessage.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnChangeMessage.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnChangeMessage.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnChangeMessage.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnChangeMessage.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeMessage.ForeColor = System.Drawing.Color.White;
            this.btnChangeMessage.Location = new System.Drawing.Point(15, 80);
            this.btnChangeMessage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnChangeMessage.Name = "btnChangeMessage";
            this.btnChangeMessage.Size = new System.Drawing.Size(120, 35);
            this.btnChangeMessage.TabIndex = 1;
            this.btnChangeMessage.Text = "메시지 변경";
            this.btnChangeMessage.Click += new System.EventHandler(this.btnChangeMessage_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemove.BorderRadius = 5;
            this.btnRemove.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRemove.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRemove.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRemove.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRemove.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnRemove.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRemove.Location = new System.Drawing.Point(944, 80);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(120, 35);
            this.btnRemove.TabIndex = 2;
            this.btnRemove.Text = "삭제";
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnUp
            // 
            this.btnUp.BorderRadius = 5;
            this.btnUp.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUp.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUp.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUp.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnUp.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnUp.Location = new System.Drawing.Point(143, 80);
            this.btnUp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(46, 35);
            this.btnUp.TabIndex = 3;
            this.btnUp.Text = "↑";
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnDown
            // 
            this.btnDown.BorderRadius = 5;
            this.btnDown.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDown.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDown.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDown.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDown.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnDown.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDown.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDown.Location = new System.Drawing.Point(195, 80);
            this.btnDown.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(46, 35);
            this.btnDown.TabIndex = 4;
            this.btnDown.Text = "↓";
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // EncouragementBlock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panelContainer);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "EncouragementBlock";
            this.Size = new System.Drawing.Size(1079, 130);
            this.panelContainer.ResumeLayout(false);
            this.panelContainer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private Guna.UI2.WinForms.Guna2Panel panelContainer;
        private Guna.UI2.WinForms.Guna2TextBox txtEncouragement;
        private Guna.UI2.WinForms.Guna2Button btnChangeMessage;
        private Guna.UI2.WinForms.Guna2Button btnRemove;
        private Guna.UI2.WinForms.Guna2Button btnUp;
        private Guna.UI2.WinForms.Guna2Button btnDown;
    }
}