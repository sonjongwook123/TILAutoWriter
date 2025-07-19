using System;
using System.Windows.Forms;

namespace TILAutoPublisher
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            // 시작 화면 표시
            var splashScreen = new SplashScreenForm();
            splashScreen.Show();
            Application.DoEvents();
            System.Threading.Thread.Sleep(2000); // 2초간 스플래시 화면 표시
            splashScreen.Close();
            
            Application.Run(new MainForm());
        }
    }
}