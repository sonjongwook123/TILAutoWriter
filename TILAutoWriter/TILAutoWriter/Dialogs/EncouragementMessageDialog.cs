using System;
using System.Windows.Forms;

namespace TILAutoPublisher
{
    public partial class EncouragementMessageDialog : Form
    {
        public string SelectedMessage { get; private set; }

        public EncouragementMessageDialog(string currentMessage)
        {
            InitializeComponent();
            SelectedMessage = currentMessage;
            txtCustomMessage.Text = currentMessage;
            LoadMessages();
        }

        private void LoadMessages()
        {
            // 기본 응원 메시지 목록
            string[] messages = {
                "오늘도 수고했어! 조금씩이라도 꾸준히 하다보면 분명 좋은 결과가 있을 거야!",
                "지금의 노력은 결코 헛되지 않아. 내일은 오늘보다 더 나은 내가 될 거야!",
                "한 걸음 한 걸음이 중요해. 지금의 작은 성장이 모여 큰 결과를 만들 거예요!",
                "힘들 때도 있겠지만, 포기하지 않는 당신이 이미 대단한 사람이에요!",
                "코딩은 마라톤이에요. 지치지 말고 천천히, 하지만 꾸준히 나아가봐요!",
                "실패는 성공의 어머니라고 하죠. 오늘의 실수가 내일의 성공을 만듭니다!",
                "당신의 노력은 결코 헛되지 않아요. 오늘도 화이팅!",
                "조금씩이라도 매일 배우는 습관, 그것이 진정한 성공의 비결이에요!",
                "지금의 고민은 더 나은 개발자로 성장하는 과정일 뿐이에요!",
                "오늘의 작은 성취도 자축해주세요. 당신은 계속 성장하고 있어요!"
            };

            listMessages.Items.AddRange(messages);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtCustomMessage.Text))
            {
                SelectedMessage = txtCustomMessage.Text;
                DialogResult = DialogResult.OK;
            }
            else if (listMessages.SelectedItem != null)
            {
                SelectedMessage = listMessages.SelectedItem.ToString();
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("메시지를 선택하거나 입력해주세요.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void listMessages_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listMessages.SelectedItem != null)
            {
                txtCustomMessage.Text = listMessages.SelectedItem.ToString();
            }
        }

        private void InitializeComponent()
        {
            this.listMessages = new System.Windows.Forms.ListBox();
            this.txtCustomMessage = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listMessages
            // 
            this.listMessages.FormattingEnabled = true;
            this.listMessages.ItemHeight = 12;
            this.listMessages.Location = new System.Drawing.Point(12, 25);
            this.listMessages.Name = "listMessages";
            this.listMessages.Size = new System.Drawing.Size(360, 100);
            this.listMessages.TabIndex = 0;
            this.listMessages.SelectedIndexChanged += new System.EventHandler(this.listMessages_SelectedIndexChanged);
            // 
            // txtCustomMessage
            // 
            this.txtCustomMessage.Location = new System.Drawing.Point(12, 146);
            this.txtCustomMessage.Multiline = true;
            this.txtCustomMessage.Name = "txtCustomMessage";
            this.txtCustomMessage.Size = new System.Drawing.Size(360, 60);
            this.txtCustomMessage.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "기본 응원 메시지 목록";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "직접 메시지 입력:";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(216, 212);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "확인";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(297, 212);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "취소";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // EncouragementMessageDialog
            // 
            this.ClientSize = new System.Drawing.Size(384, 241);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCustomMessage);
            this.Controls.Add(this.listMessages);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EncouragementMessageDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "응원 메시지 선택";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.ListBox listMessages;
        private System.Windows.Forms.TextBox txtCustomMessage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
    }
}