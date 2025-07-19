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

            using (var splashScreen = new SplashScreenForm())
            {
                // ShowDialog will block until the splash screen closes itself
                // (e.g., by setting DialogResult and calling Close())
                splashScreen.ShowDialog();
            }

            Application.Run(new MainForm());
        }
    }
}