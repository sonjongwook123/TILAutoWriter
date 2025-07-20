using Guna.UI2.WinForms; // Guna.UI2.WinForms 네임스페이스 추가
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
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
using static Guna.UI2.WinForms.Suite.Descriptions;

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
            InitializeDefaultTags(); // 이 메서드 내에서 flpTags를 초기화합니다.
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
            UpdateFlowLayoutPanelTags(); // flpTags를 업데이트하는 새로운 메서드 호출
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
                    txtTistoryId.Text = settings.ContainsKey("TistoryId") ? settings["TistoryId"] : "";
                    txtTistoryPassword.Text = settings.ContainsKey("TistoryPassword") ? settings["TistoryPassword"] : "";
                    txtChatGptApiKey.Text = settings.ContainsKey("ChatGptApiKey") ? settings["ChatGptApiKey"] : "";
                    txtGeminiApiKey.Text = settings.ContainsKey("GeminiApiKey") ? settings["GeminiApiKey"] : "";
                    dtpAnalysisEndTime.Value = settings.ContainsKey("AnalysisEndTime") ? DateTime.Parse(settings["AnalysisEndTime"]) : DateTime.Now.AddHours(12);
                    chkAutoStart.Checked = settings.ContainsKey("AutoStart") && bool.Parse(settings["AutoStart"]);

                    // 태그 로드 (콤마로 구분된 문자열을 List<string>으로 변환)
                    if (settings.ContainsKey("CustomTags"))
                    {
                        customTags = settings["CustomTags"].Split(',').Select(s => s.Trim()).Where(s => !string.IsNullOrEmpty(s)).ToList();
                        UpdateFlowLayoutPanelTags(); // 로드된 태그로 UI 업데이트
                    }
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
                    { "TistoryId", txtTistoryId.Text },
                    { "TistoryPassword", txtTistoryPassword.Text },
                    { "ChatGptApiKey", txtChatGptApiKey.Text },
                    { "GeminiApiKey", txtGeminiApiKey.Text },
                    { "AnalysisEndTime", dtpAnalysisEndTime.Value.ToString() },
                    { "AutoStart", chkAutoStart.Checked.ToString() },
                    { "CustomTags", string.Join(",", customTags) } // 태그 저장 (콤마로 구분된 문자열로)
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
            var sections = analysisResult.Split(new[] { "\n\n" }, StringSplitOptions.RemoveEmptyEntries);

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

        /// <summary>
        /// customTags 리스트를 기반으로 flpTags (FlowLayoutPanel)에 태그 버튼을 동적으로 생성합니다.
        /// </summary>
        private void UpdateFlowLayoutPanelTags()
        {
            flpTags.Controls.Clear(); // 기존 태그 버튼 모두 제거
            foreach (var tag in customTags)
            {
                AddTagButtonToFlowLayoutPanel(tag);
            }
            UpdateTagsTextBox(); // txtTags 업데이트
        }

        /// <summary>
        /// FlowLayoutPanel에 새로운 태그 버튼을 추가하는 헬퍼 메서드.
        /// </summary>
        /// <param name="tagText">추가할 태그 텍스트입니다.</param>
        private void AddTagButtonToFlowLayoutPanel(string tagText)
        {
            Guna2Button tagButton = new Guna2Button();
            tagButton.Text = tagText;
            tagButton.FillColor = System.Drawing.Color.LightBlue; // 기본 색상
            tagButton.ForeColor = System.Drawing.Color.Black;
            tagButton.BorderRadius = 8; // 부드러운 모서리
            tagButton.Margin = new Padding(5); // 버튼 간 간격
            tagButton.AutoSize = true; // 텍스트 길이에 따라 자동 크기 조정
            tagButton.Padding = new Padding(10, 5, 10, 5); // 내부 여백

            // 태그 선택/해제 상태를 위한 Tag 속성 사용 (bool)
            tagButton.Tag = false; // 기본적으로 선택되지 않은 상태

            tagButton.Click += TagButton_Click; // 클릭 이벤트 핸들러 연결
            flpTags.Controls.Add(tagButton);
        }

        /// <summary>
        /// 태그 버튼 클릭 시 선택/해제 상태를 토글합니다.
        /// </summary>
        private void TagButton_Click(object sender, EventArgs e)
        {
            Guna2Button clickedButton = sender as Guna2Button;
            if (clickedButton != null)
            {
                bool isSelected = (bool)clickedButton.Tag;
                clickedButton.Tag = !isSelected; // 상태 토글

                if (!isSelected) // 선택됨
                {
                    clickedButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204))))); // 선택 색상
                    clickedButton.ForeColor = System.Drawing.Color.White;
                }
                else // 해제됨
                {
                    clickedButton.FillColor = System.Drawing.Color.LightBlue; // 기본 색상
                    clickedButton.ForeColor = System.Drawing.Color.Black;
                }
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

            if (string.IsNullOrWhiteSpace(txtTistoryId.Text))
            {
                MessageBox.Show("티스토리 아이디를 입력해주세요.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtTistoryPassword.Text))
            {
                MessageBox.Show("티스토리 비밀번호를 입력해주세요.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            if (!string.IsNullOrWhiteSpace(txtBannerImage.Text))
            {
                // 로컬 파일 경로를 티스토리 업로드 가능한 URL로 변환하는 로직 필요
                // 여기서는 예시로 로컬 경로를 직접 사용 (실제 서비스에서는 이미지 업로드 API 필요)
                string imageUrl = Path.GetFileName(txtBannerImage.Text); // 간단한 파일 이름만 사용
                html.AppendLine($"<p><img src='{imageUrl}' alt='배너 이미지' style='max-width:100%;'/></p>");
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
            if (customTags.Any()) // customTags 리스트 사용
            {
                html.AppendLine("<div class='tags'>");
                foreach (var tag in customTags)
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
                // 실제 티스토리 API 호출 로직 구현 필요
                // 예: OAuth2 인증, 블로그 ID 조회, 글 작성 API 호출 등
                // 이 부분은 외부 라이브러리 (예: Tistory API SDK) 또는 직접 HTTP 요청으로 구현해야 합니다.

                // 임시로 성공 반환
                await Task.Delay(2000); // 2초 대기
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"티스토리 업로드 중 오류 발생: {ex.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
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
            string newTag = txtNewTag.Text.Trim();
            if (!string.IsNullOrWhiteSpace(newTag) && !customTags.Contains(newTag))
            {
                customTags.Add(newTag);
                AddTagButtonToFlowLayoutPanel(newTag); // FlowLayoutPanel에 버튼 추가
                UpdateTagsTextBox(); // txtTags 업데이트
                txtNewTag.Text = "";
            }
            else if (customTags.Contains(newTag))
            {
                MessageBox.Show("이미 존재하는 태그입니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnRemoveTag_Click(object sender, EventArgs e)
        {
            List<string> tagsToRemove = new List<string>();
            List<Guna2Button> buttonsToRemove = new List<Guna2Button>();

            // flpTags 내의 컨트롤들을 순회하며 선택된 태그 찾기
            foreach (Control control in flpTags.Controls)
            {
                if (control is Guna2Button button && (bool)button.Tag == true) // Tag 속성이 true인 (선택된) 버튼
                {
                    tagsToRemove.Add(button.Text);
                    buttonsToRemove.Add(button);
                }
            }

            if (tagsToRemove.Any())
            {
                foreach (string tag in tagsToRemove)
                {
                    customTags.Remove(tag);
                }
                foreach (Guna2Button button in buttonsToRemove)
                {
                    flpTags.Controls.Remove(button);
                    button.Dispose(); // 메모리 해제
                }
                UpdateTagsTextBox(); // txtTags 업데이트
            }
            else
            {
                MessageBox.Show("삭제할 태그를 선택해주세요.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

            LoadBannerPreviews();
        }

        private void LoadBannerPreviews()
        {
            flpBannerPreviews.Controls.Clear(); // Clear existing controls if any

            for (int i = 1; i <= 26; i++)
            {
                Guna.UI2.WinForms.Guna2PictureBox pb = new Guna.UI2.WinForms.Guna2PictureBox();
                pb.Size = new System.Drawing.Size(100, 60); // Set desired preview size
                pb.SizeMode = PictureBoxSizeMode.Zoom; // Or PictureBoxSizeMode.StretchImage, etc.
                pb.Cursor = Cursors.Hand;
                pb.Tag = $"BannerImage{i}"; // Store the resource name or a path if loaded from file system

                // Load image from resources.
                // Replace "TILAutoWriter.Properties.Resources" with your actual resource namespace if different.
                Image img = (Image)TILAutoWriter.Properties.Resources.ResourceManager.GetObject($"BannerImage{i}");
                if (img != null)
                {
                    pb.Image = img;
                }
                else
                {
                    // Handle case where image resource is not found (e.g., set a placeholder or log an error)
                    Console.WriteLine($"Warning: BannerImage{i} not found in resources.");
                }

                pb.Click += (s, e) =>
                {
                    // Open the preview form when a thumbnail is clicked
                    using (ImagePreviewForm previewForm = new ImagePreviewForm(pb.Image, pb.Tag.ToString()))
                    {
                        if (previewForm.ShowDialog() == DialogResult.OK)
                        {
                            // If "Select" was clicked in the preview form
                            txtBannerImage.Text = previewForm.SelectedImageIdentifier;
                        }
                    }
                };

                flpBannerPreviews.Controls.Add(pb);
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

        // 사용되지 않는 이벤트 핸들러는 제거하거나 필요에 따라 주석 처리
        private void panel1_Paint(object sender, PaintEventArgs e) { }
        private void pictureBox1_Click(object sender, EventArgs e) { }
        private void panel6_Paint(object sender, PaintEventArgs e) { }
        private void panel1_Paint_1(object sender, PaintEventArgs e) { }
        private void lblAnalysisStatus_Click(object sender, EventArgs e) { }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {

        }

        private void pbBanner_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }
        // lstTags_SelectedIndexChanged 이벤트 핸들러는 더 이상 필요 없으므로 제거
    }
}