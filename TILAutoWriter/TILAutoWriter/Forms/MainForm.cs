using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace TILAutoPublisher
{
    public partial class MainForm : Form
    {
        private NotifyIcon trayIcon;
        private ContextMenuStrip trayMenu;
        private bool isAnalyzing = false;
        private DateTime analysisStartTime;
        private DateTime analysisEndTime;
        private List<string> capturedInputs = new List<string>();
        private Timer analysisTimer;
        private Timer autoAnalysisTimer;
        private List<string> encouragementMessages = new List<string>();
        private List<string> customTags = new List<string>();

        public MainForm()
        {
            InitializeComponent();
            InitializeTrayIcon();
            InitializeEncouragementMessages();
            InitializeDefaultTags();
            SetupTimers();
            LoadSettings();
        }

        private void InitializeTrayIcon()
        {
            trayMenu = new ContextMenuStrip();
            trayMenu.Items.Add("프로그램 열기", null, OnShow);
            trayMenu.Items.Add("분석 시작/중지", null, OnToggleAnalysis);
            trayMenu.Items.Add("종료", null, OnExit);

            trayIcon = new NotifyIcon();
            trayIcon.Text = "TIL 자동 작성기";
            trayIcon.Icon = SystemIcons.Information;
            trayIcon.ContextMenuStrip = trayMenu;
            trayIcon.Visible = true;
            trayIcon.DoubleClick += OnShow;
        }

        private void InitializeEncouragementMessages()
        {
            encouragementMessages = new List<string>
            {
                "오늘도 수고했어! 조금씩이라도 꾸준히 하다보면 분명 좋은 결과가 있을 거야!",
                "지금의 노력은 결코 헛되지 않아. 내일은 오늘보다 더 나은 내가 될 거야!",
                "한 걸음 한 걸음이 중요해. 지금의 작은 성장이 모여 큰 결과를 만들 거예요!",
                "힘들 때도 있겠지만, 포기하지 않는 당신이 이미 대단한 사람이에요!",
                "코딩은 마라톤이에요. 지치지 말고 천천히, 하지만 꾸준히 나아가봐요!",
                "실패는 성공의 어머니라고 하죠. 오늘의 실수가 내일의 성공을 만듭니다!",
                "당신의 노력은 결코 헛되지 않아요. 오늘도 화이팅!",
                "조금씩이라도 매일 배우는 습관, 그것이 진정한 성공의 비결이에요!",
                "지금의 고민은 더 나은 개발자로 성장하는 과정일 뿐이에요!",
                "오늘의 작은 성취도 자축해주세요. 당신은 계속 성장하고 있어요!",
                "코딩은 문제 해결의 연속이에요. 포기하지 않는 마음이 중요해요!",
                "지금의 어려움은 잠시뿐이에요. 곧 해결책이 보일 거예요!",
                "당신의 코드는 점점 더 나아지고 있어요. 오늘도 수고했어요!",
                "배움에는 끝이 없어요. 오늘도 새로운 것을 알아가고 있어요!",
                "작은 성공도 축하해주세요. 그것이 큰 성공의 밑거름이 됩니다!",
                "코딩은 창의적인 작업이에요. 당신의 생각을 코드로 표현해보세요!",
                "오늘의 버그는 내일의 지혜가 됩니다. 포기하지 마세요!",
                "당신은 이미 멋진 개발자예요. 조금 더 자신감을 가져보세요!",
                "지금의 고민은 더 나은 코드를 위한 과정일 뿐이에요!",
                "오늘 배운 것이 내일의 성공을 만듭니다. 꾸준히 해봐요!",
                "코딩은 예술이에요. 당신만의 스타일을 만들어가세요!",
                "실수는 배움의 일부예요. 두려워하지 말고 도전해보세요!",
                "당신의 노력은 분명 빛을 발할 거예요. 오늘도 화이팅!",
                "문제가 생겼을 때가 진짜 배울 때예요. 포기하지 마세요!",
                "오늘의 작은 성공도 기뻐하세요. 그것이 동력이 됩니다!",
                "코딩은 인내심이 필요한 작업이에요. 천천히, 꾸준히 나아가세요!",
                "당신은 이미 성장하고 있어요. 오늘도 수고했어요!",
                "지금의 어려움은 잠시뿐이에요. 곧 해결될 거예요!",
                "오늘의 학습은 내일의 성공을 위한 발판이에요!",
                "당신의 코드는 점점 더 나아지고 있어요. 계속해보세요!",
                "문제 해결 능력은 개발자의 중요한 자산이에요. 계속 도전해보세요!",
                "오늘의 고민은 내일의 지혜가 됩니다. 포기하지 마세요!",
                "당신은 이미 훌륭한 개발자예요. 자신감을 가지세요!",
                "코딩은 창의력을 키우는 작업이에요. 즐겁게 접근해보세요!",
                "오늘의 작은 성공도 자랑스러워하세요. 그것이 동력이 됩니다!",
                "지금의 노력은 분명 결실을 맺을 거예요. 계속해보세요!",
                "문제가 생겼을 때가 진짜 배울 때예요. 두려워하지 마세요!",
                "당신의 성장은 분명합니다. 오늘도 수고했어요!",
                "코딩은 마라톤이에요. 지치지 말고 꾸준히 나아가세요!",
                "오늘의 작은 성취도 기뻐하세요. 그것이 모여 큰 성공을 만듭니다!",
                "당신은 이미 멋진 개발자예요. 조금 더 자신감을 가지세요!",
                "지금의 고민은 더 나은 코드를 위한 과정일 뿐이에요!",
                "오늘 배운 것이 내일의 성공을 만듭니다. 꾸준히 해봐요!",
                "코딩은 예술이에요. 당신만의 스타일을 만들어가세요!",
                "실수는 배움의 일부예요. 두려워하지 말고 도전해보세요!",
                "당신의 노력은 분명 빛을 발할 거예요. 오늘도 화이팅!",
                "문제가 생겼을 때가 진짜 배울 때예요. 포기하지 마세요!",
                "오늘의 작은 성공도 기뻐하세요. 그것이 동력이 됩니다!",
                "코딩은 인내심이 필요한 작업이에요. 천천히, 꾸준히 나아가세요!",
                "당신은 이미 성장하고 있어요. 오늘도 수고했어요!"
            };
        }

        private void InitializeDefaultTags()
        {
            customTags = new List<string> { "#내일배움캠프", "#스파르타내일배움캠프", "#스파르타내일배움캠프TIL" };
            UpdateTagsListBox();
        }

        private void SetupTimers()
        {
            analysisTimer = new Timer();
            analysisTimer.Interval = 1000; // 1초마다 체크
            analysisTimer.Tick += AnalysisTimer_Tick;

            autoAnalysisTimer = new Timer();
            autoAnalysisTimer.Interval = 3 * 60 * 60 * 1000; // 3시간마다
            autoAnalysisTimer.Tick += AutoAnalysisTimer_Tick;
        }

        private void LoadSettings()
        {
            // 설정 로드 로직 (API 키, 분석 시간 등)
            try
            {
                if (File.Exists("settings.json"))
                {
                    var settings = JsonConvert.DeserializeObject<Dictionary<string, string>>(File.ReadAllText("settings.json"));
                    txtTistoryApiKey.Text = settings.ContainsKey("TistoryApiKey") ? settings["TistoryApiKey"] : "";
                    txtChatGptApiKey.Text = settings.ContainsKey("ChatGptApiKey") ? settings["ChatGptApiKey"] : "";
                    txtGeminiApiKey.Text = settings.ContainsKey("GeminiApiKey") ? settings["GeminiApiKey"] : "";
                    dtpAnalysisEndTime.Value = settings.ContainsKey("AnalysisEndTime") ? DateTime.Parse(settings["AnalysisEndTime"]) : DateTime.Now.AddHours(12);
                    chkAutoStart.Checked = settings.ContainsKey("AutoStart") && bool.Parse(settings["AutoStart"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"설정 로드 중 오류 발생: {ex.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SaveSettings()
        {
            try
            {
                var settings = new Dictionary<string, string>
                {
                    { "TistoryApiKey", txtTistoryApiKey.Text },
                    { "ChatGptApiKey", txtChatGptApiKey.Text },
                    { "GeminiApiKey", txtGeminiApiKey.Text },
                    { "AnalysisEndTime", dtpAnalysisEndTime.Value.ToString() },
                    { "AutoStart", chkAutoStart.Checked.ToString() }
                };
                File.WriteAllText("settings.json", JsonConvert.SerializeObject(settings));
            }
            catch (Exception ex)
            {
                MessageBox.Show($"설정 저장 중 오류 발생: {ex.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OnShow(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        private void OnToggleAnalysis(object sender, EventArgs e)
        {
            if (isAnalyzing)
            {
                StopAnalysis();
            }
            else
            {
                StartAnalysis();
            }
        }

        private void OnExit(object sender, EventArgs e)
        {
            SaveSettings();
            trayIcon.Visible = false;
            Application.Exit();
        }

        private void StartAnalysis()
        {
            analysisStartTime = DateTime.Now;
            analysisEndTime = dtpAnalysisEndTime.Value;
            isAnalyzing = true;
            capturedInputs.Clear();
            btnStartAnalysis.Text = "분석 중지";
            trayMenu.Items[1].Text = "분석 중지";
            analysisTimer.Start();
            autoAnalysisTimer.Start();
            lblAnalysisStatus.Text = $"분석 중... ({analysisStartTime:HH:mm} ~ {analysisEndTime:HH:mm})";
            trayIcon.ShowBalloonTip(1000, "TIL 분석 시작", "입력 분석이 시작되었습니다.", ToolTipIcon.Info);
        }

        private void StopAnalysis()
        {
            isAnalyzing = false;
            btnStartAnalysis.Text = "분석 시작";
            trayMenu.Items[1].Text = "분석 시작";
            analysisTimer.Stop();
            autoAnalysisTimer.Stop();
            lblAnalysisStatus.Text = "분석 대기 중";
            trayIcon.ShowBalloonTip(1000, "TIL 분석 중지", "입력 분석이 중지되었습니다.", ToolTipIcon.Info);
        }

        private void AnalysisTimer_Tick(object sender, EventArgs e)
        {
            if (DateTime.Now >= analysisEndTime)
            {
                StopAnalysis();
                PerformFinalAnalysis();
            }
        }

        private void AutoAnalysisTimer_Tick(object sender, EventArgs e)
        {
            PerformTemporaryAnalysis();
        }

        private void PerformTemporaryAnalysis()
        {
            if (capturedInputs.Count == 0) return;

            string combinedText = string.Join("\n", capturedInputs);
            string analysisResult = AnalyzeWithAI(combinedText, isFinal: false);
            
            // 임시 분석 결과를 저장하거나 표시할 수 있음
            File.AppendAllText("temp_analysis.log", $"[{DateTime.Now:yyyy-MM-dd HH:mm}] 임시 분석 결과:\n{analysisResult}\n\n");
        }

        private void PerformFinalAnalysis()
        {
            if (capturedInputs.Count == 0) return;

            string combinedText = string.Join("\n", capturedInputs);
            string analysisResult = AnalyzeWithAI(combinedText, isFinal: true);
            
            // 최종 분석 결과로 TIL 작성
            GenerateTILFromAnalysis(analysisResult);
        }

        private string AnalyzeWithAI(string input, bool isFinal)
        {
            // 실제로는 API를 호출하지만 여기서는 간단한 예시만 제공
            string prompt = isFinal ? 
                "아래는 하루 동안의 작업 내용입니다. 이 내용을 바탕으로 TIL(Today I Learned) 블로그 글을 작성해주세요. 배운 점, 문제 해결 과정, 깨달은 점 등을 포함시켜주세요. 마지막에 스스로를 응원하는 말과 오늘의 회고(몰입도, 내일 계획)도 추가해주세요." :
                "아래는 지금까지의 작업 내용입니다. 간단히 요약하고 주요 학습 포인트를 알려주세요.";

            // 여기서 실제 API 호출이 이루어져야 함
            // 예: ChatGPT 또는 Gemini API 호출
            return $"{prompt}\n\n입력 내용:\n{input}\n\nAI 분석 결과: 이 부분은 실제 API 호출 결과로 대체되어야 합니다.";
        }

        private void GenerateTILFromAnalysis(string analysisResult)
        {
            // 분석 결과를 바탕으로 TIL 작성
            txtTitle.Text = $"[내배캠] {DateTime.Now:yyyy-MM-dd} TIL - {DateTime.Now.Day}일차";
            
            // 분석 결과를 블록으로 분할하여 추가
            var sections = analysisResult.Split(new[] {"\n\n"}, StringSplitOptions.RemoveEmptyEntries);
            
            foreach (var section in sections)
            {
                if (section.Contains("배운 점") || section.Contains("문제 해결"))
                {
                    AddContentBlock(section, "");
                }
                else if (section.Contains("회고"))
                {
                    AddRetrospectionBlock(section);
                }
            }
            
            // 랜덤 응원 메시지 추가
            AddEncouragementBlock();
            
            // 태그 추가
            UpdateTagsTextBox();
            
            this.Show();
            this.WindowState = FormWindowState.Normal;
            MessageBox.Show("TIL 작성을 완료했습니다. 내용을 확인하고 업로드해주세요.", "작성 완료", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void AddContentBlock(string content, string imagePath = "")
        {
            ContentBlock block = new ContentBlock();
            block.ContentText = content;
            block.ImagePath = imagePath;
            flowLayoutPanel1.Controls.Add(block);
            block.OnRemove += (sender, e) => flowLayoutPanel1.Controls.Remove((Control)sender);
            block.OnMoveUp += (sender, e) => MoveBlockUp((Control)sender);
            block.OnMoveDown += (sender, e) => MoveBlockDown((Control)sender);
        }

        private void AddImageBlock(string imagePath)
        {
            ImageBlock block = new ImageBlock();
            block.ImagePath = imagePath;
            flowLayoutPanel1.Controls.Add(block);
            block.OnRemove += (sender, e) => flowLayoutPanel1.Controls.Remove((Control)sender);
            block.OnMoveUp += (sender, e) => MoveBlockUp((Control)sender);
            block.OnMoveDown += (sender, e) => MoveBlockDown((Control)sender);
        }

        private void AddRetrospectionBlock(string content)
        {
            RetrospectionBlock block = new RetrospectionBlock();
            block.ContentText = content;
            flowLayoutPanel1.Controls.Add(block);
            block.OnRemove += (sender, e) => flowLayoutPanel1.Controls.Remove((Control)sender);
            block.OnMoveUp += (sender, e) => MoveBlockUp((Control)sender);
            block.OnMoveDown += (sender, e) => MoveBlockDown((Control)sender);
        }

        private void AddEncouragementBlock()
        {
            EncouragementBlock block = new EncouragementBlock();
            block.EncouragementMessage = encouragementMessages[new Random().Next(encouragementMessages.Count)];
            flowLayoutPanel1.Controls.Add(block);
            block.OnRemove += (sender, e) => flowLayoutPanel1.Controls.Remove((Control)sender);
            block.OnMoveUp += (sender, e) => MoveBlockUp((Control)sender);
            block.OnMoveDown += (sender, e) => MoveBlockDown((Control)sender);
        }

        private void MoveBlockUp(Control block)
        {
            int index = flowLayoutPanel1.Controls.IndexOf(block);
            if (index > 0)
            {
                flowLayoutPanel1.Controls.SetChildIndex(block, index - 1);
            }
        }

        private void MoveBlockDown(Control block)
        {
            int index = flowLayoutPanel1.Controls.IndexOf(block);
            if (index < flowLayoutPanel1.Controls.Count - 1)
            {
                flowLayoutPanel1.Controls.SetChildIndex(block, index + 1);
            }
        }

        private void UpdateTagsListBox()
        {
            lstTags.Items.Clear();
            foreach (var tag in customTags)
            {
                lstTags.Items.Add(tag);
            }
        }

        private void UpdateTagsTextBox()
        {
            txtTags.Text = string.Join(", ", customTags);
        }

        private async void btnPublish_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTitle.Text))
            {
                MessageBox.Show("제목을 입력해주세요.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtTistoryApiKey.Text))
            {
                MessageBox.Show("티스토리 API 키를 입력해주세요.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                btnPublish.Enabled = false;
                btnPublish.Text = "업로드 중...";
                Cursor = Cursors.WaitCursor;

                string content = GenerateHtmlContent();
                bool result = await PublishToTistory(txtTitle.Text, content);

                if (result)
                {
                    MessageBox.Show("성공적으로 업로드되었습니다!", "성공", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    trayIcon.ShowBalloonTip(1000, "업로드 완료", "TIL이 성공적으로 업로드되었습니다.", ToolTipIcon.Info);
                }
                else
                {
                    MessageBox.Show("업로드에 실패했습니다.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"업로드 중 오류 발생: {ex.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnPublish.Enabled = true;
                btnPublish.Text = "글 업로드";
                Cursor = Cursors.Default;
            }
        }

        private string GenerateHtmlContent()
        {
            StringBuilder html = new StringBuilder();
            
            // 배너 이미지 추가
            if (!string.IsNullOrWhiteSpace(txtBannerImage.Text)
            {
                html.AppendLine($"<p><img src='{txtBannerImage.Text}' alt='배너 이미지' style='max-width:100%;'/></p>");
            }

            // 각 블록의 HTML 생성
            foreach (Control control in flowLayoutPanel1.Controls)
            {
                if (control is IBlock block)
                {
                    html.AppendLine(block.GetHtml());
                }
            }

            // 태그 추가
            if (!string.IsNullOrWhiteSpace(txtTags.Text))
            {
                html.AppendLine("<div class='tags'>");
                foreach (var tag in txtTags.Text.Split(',').Select(t => t.Trim()).Where(t => !string.IsNullOrWhiteSpace(t)))
                {
                    html.AppendLine($"<span class='tag'>{tag}</span> ");
                }
                html.AppendLine("</div>");
            }

            return html.ToString();
        }

        private async Task<bool> PublishToTistory(string title, string content)
        {
            try
            {
                string url = $"https://www.tistory.com/apis/post/write?access_token={txtTistoryApiKey.Text}&output=json&blogName={GetBlogName()}&title={Uri.EscapeDataString(title)}&content={Uri.EscapeDataString(content)}&visibility=0&tag={Uri.EscapeDataString(txtTags.Text)}&category=0";

                using (HttpClient client = new HttpClient())
                {
                    var response = await client.GetAsync(url);
                    var responseContent = await response.Content.ReadAsStringAsync();

                    if (response.IsSuccessStatusCode)
                    {
                        var json = JObject.Parse(responseContent);
                        return json["tistory"]?["status"]?.ToString() == "200";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"티스토리 업로드 중 오류 발생: {ex.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }

        private string GetBlogName()
        {
            // 티스토리 API를 통해 블로그 이름을 가져오는 로직
            // 실제 구현에서는 API 호출이 필요
            return "myblog"; // 임시 값
        }

        private void btnAddContentBlock_Click(object sender, EventArgs e)
        {
            AddContentBlock("", "");
        }

        private void btnAddImageBlock_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files (*.bmp;*.jpg;*.jpeg;*.png)|*.bmp;*.jpg;*.jpeg;*.png";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    AddImageBlock(openFileDialog.FileName);
                }
            }
        }

        private void btnAddRetrospection_Click(object sender, EventArgs e)
        {
            AddRetrospectionBlock("");
        }

        private void btnAddEncouragement_Click(object sender, EventArgs e)
        {
            AddEncouragementBlock();
        }

        private void btnAddTag_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtNewTag.Text) && !customTags.Contains(txtNewTag.Text))
            {
                customTags.Add(txtNewTag.Text);
                UpdateTagsListBox();
                UpdateTagsTextBox();
                txtNewTag.Text = "";
            }
        }

        private void btnRemoveTag_Click(object sender, EventArgs e)
        {
            if (lstTags.SelectedItem != null)
            {
                customTags.Remove(lstTags.SelectedItem.ToString());
                UpdateTagsListBox();
                UpdateTagsTextBox();
            }
        }

        private void btnLoadBannerImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files (*.bmp;*.jpg;*.jpeg;*.png)|*.bmp;*.jpg;*.jpeg;*.png";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txtBannerImage.Text = openFileDialog.FileName;
                }
            }
        }

        private void btnStartAnalysis_Click(object sender, EventArgs e)
        {
            if (isAnalyzing)
            {
                StopAnalysis();
            }
            else
            {
                StartAnalysis();
            }
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                this.Hide();
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                this.Hide();
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (chkAutoStart.Checked)
            {
                StartAnalysis();
            }
        }

        protected override void WndProc(ref Message m)
        {
            // 키보드 후킹을 위한 코드 (실제 구현에서는 Windows API를 사용해야 함)
            base.WndProc(ref m);
            
            if (isAnalyzing)
            {
                // 키보드 입력 캡처 로직 (실제 구현에서는 더 복잡한 처리 필요)
            }
        }
    }
}