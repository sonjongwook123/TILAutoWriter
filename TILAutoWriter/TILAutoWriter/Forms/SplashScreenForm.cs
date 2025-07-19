using System;
using System.Drawing;
using System.Windows.Forms;

namespace TILAutoPublisher
{
    public partial class SplashScreenForm : Form
    {
        public SplashScreenForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Size = new Size(450, 450);
            this.BackgroundImage = Properties.Resources.splash_image; // 리소스에 추가해야 함
            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.Opacity = 0;
            
            Timer fadeInTimer = new Timer();
            fadeInTimer.Interval = 50;
            fadeInTimer.Tick += (s, args) =>
            {
                if (this.Opacity < 1)
                    this.Opacity += 0.05;
                else
                    fadeInTimer.Stop();
            };
            fadeInTimer.Start();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            this.ClientSize = new System.Drawing.Size(450, 450);
            this.Name = "SplashScreenForm";
            this.ResumeLayout(false);
        }
    }
}