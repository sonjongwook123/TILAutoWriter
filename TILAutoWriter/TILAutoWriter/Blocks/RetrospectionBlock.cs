using System;
using System.Text;
using System.Windows.Forms;

namespace TILAutoPublisher
{
    public partial class RetrospectionBlock : UserControl, IBlock
    {
        public event EventHandler OnRemove;
        public event EventHandler OnMoveUp;
        public event EventHandler OnMoveDown;

        public string ContentText
        {
            get => txtRetrospection.Text;
            set => txtRetrospection.Text = value;
        }

        public int ImmersionHours
        {
            get => (int)numImmersionHours.Value;
            set => numImmersionHours.Value = value;
        }

        public string TomorrowPlan
        {
            get => txtTomorrowPlan.Text;
            set => txtTomorrowPlan.Text = value;
        }

        public RetrospectionBlock()
        {
            InitializeComponent();
        }

        public string GetHtml()
        {
            StringBuilder html = new StringBuilder();
            html.AppendLine("<div class='retrospection-block'>");
            html.AppendLine("<h3>오늘의 회고</h3>");
            
            if (!string.IsNullOrWhiteSpace(txtRetrospection.Text))
            {
                html.AppendLine($"<p>{txtRetrospection.Text.Replace("\n", "<br/>")}</p>");
            }

            html.AppendLine("<ul>");
            html.AppendLine($"<li>몰입 시간: {numImmersionHours.Value}시간</li>");
            
            if (!string.IsNullOrWhiteSpace(txtTomorrowPlan.Text))
            {
                html.AppendLine($"<li>내일 계획: {txtTomorrowPlan.Text.Replace("\n", "<br/>")}</li>");
            }
            
            html.AppendLine("</ul>");
            html.AppendLine("</div>");
            return html.ToString();
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
            this.txtRetrospection = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numImmersionHours = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTomorrowPlan = new System.Windows.Forms.TextBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numImmersionHours)).BeginInit();
            this.SuspendLayout();
            // 
            // txtRetrospection
            // 
            this.txtRetrospection.AcceptsReturn = true;
            this.txtRetrospection.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRetrospection.Location = new System.Drawing.Point(3, 4);
            this.txtRetrospection.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtRetrospection.Multiline = true;
            this.txtRetrospection.Name = "txtRetrospection";
            this.txtRetrospection.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRetrospection.Size = new System.Drawing.Size(963, 99);
            this.txtRetrospection.TabIndex = 0;
            this.txtRetrospection.TextChanged += new System.EventHandler(this.txtRetrospection_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(3, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "몰입 시간:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(3, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "내일 계획:";
            // 
            // numImmersionHours
            // 
            this.numImmersionHours.Location = new System.Drawing.Point(89, 105);
            this.numImmersionHours.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numImmersionHours.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.numImmersionHours.Name = "numImmersionHours";
            this.numImmersionHours.Size = new System.Drawing.Size(57, 25);
            this.numImmersionHours.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(153, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "시간";
            // 
            // txtTomorrowPlan
            // 
            this.txtTomorrowPlan.AcceptsReturn = true;
            this.txtTomorrowPlan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTomorrowPlan.Location = new System.Drawing.Point(89, 136);
            this.txtTomorrowPlan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTomorrowPlan.Multiline = true;
            this.txtTomorrowPlan.Name = "txtTomorrowPlan";
            this.txtTomorrowPlan.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtTomorrowPlan.Size = new System.Drawing.Size(877, 99);
            this.txtTomorrowPlan.TabIndex = 5;
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemove.Location = new System.Drawing.Point(881, 244);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(86, 29);
            this.btnRemove.TabIndex = 6;
            this.btnRemove.Text = "삭제";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnUp
            // 
            this.btnUp.Location = new System.Drawing.Point(3, 244);
            this.btnUp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(46, 29);
            this.btnUp.TabIndex = 7;
            this.btnUp.Text = "↑";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnDown
            // 
            this.btnDown.Location = new System.Drawing.Point(56, 244);
            this.btnDown.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(46, 29);
            this.btnDown.TabIndex = 8;
            this.btnDown.Text = "↓";
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // RetrospectionBlock
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.txtTomorrowPlan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numImmersionHours);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRetrospection);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "RetrospectionBlock";
            this.Size = new System.Drawing.Size(970, 276);
            ((System.ComponentModel.ISupportInitialize)(this.numImmersionHours)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.TextBox txtRetrospection;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numImmersionHours;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTomorrowPlan;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnDown;

        private void txtRetrospection_TextChanged(object sender, EventArgs e)
        {

        }
    }
}