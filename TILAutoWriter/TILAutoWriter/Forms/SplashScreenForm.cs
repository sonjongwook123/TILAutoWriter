using System;
using System.Drawing;
using System.Windows.Forms;

namespace TILAutoPublisher
{
    public partial class SplashScreenForm : Form
    {
        private Timer fadeInTimer;   // Timer for the fade-in effect
        private Timer displayTimer;  // Timer for controlling the total display duration (before fade-out starts)
        private Timer fadeOutTimer;  // Timer for the fade-out effect

        private const int TotalDisplayDurationMs = 3000; // Total time the splash screen is visible (including fade-in/out)
        private const int FadeIntervalMs = 50;           // Interval for opacity changes
        private const double OpacityStep = 0.05;         // Amount to change opacity by each interval

        public SplashScreenForm()
        {
            InitializeComponent(); // Ensure this is properly wired to the designer for a real project

            // Basic form setup
            this.FormBorderStyle = FormBorderStyle.None; // No border or title bar
            this.StartPosition = FormStartPosition.CenterScreen; // Center on screen
            this.Size = new Size(450, 450); // Set fixed size

            // Set background image from resources.
            // IMPORTANT: Ensure 'SplashImage' is added to your project's resources (e.g., in Project Properties -> Resources).
            // If not found, this line will cause an error or the image won't display.
            this.BackgroundImage = TILAutoWriter.Properties.Resources.SplashImage;
            this.BackgroundImageLayout = ImageLayout.Stretch; // Stretch image to fill the form
            this.Opacity = 0; // Start completely transparent for fade-in

            // Initialize and start the fade-in timer
            fadeInTimer = new Timer();
            fadeInTimer.Interval = FadeIntervalMs;
            fadeInTimer.Tick += FadeIn_Tick;
            fadeInTimer.Start();

            // Initialize and start the display timer. This timer will trigger the fade-out.
            displayTimer = new Timer();
            displayTimer.Interval = TotalDisplayDurationMs;
            displayTimer.Tick += DisplayTimer_Tick;
            displayTimer.Start(); // Start this timer when the form is initialized

            // Initialize the fade-out timer, but don't start it yet
            fadeOutTimer = new Timer();
            fadeOutTimer.Interval = FadeIntervalMs;
            fadeOutTimer.Tick += FadeOut_Tick;
        }

        /// <summary>
        /// Handles the tick event for the fade-in timer.
        /// Gradually increases the form's opacity until it's fully opaque.
        /// </summary>
        private void FadeIn_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1)
            {
                this.Opacity += OpacityStep;
            }
            else
            {
                // Once fully opaque, stop the fade-in timer
                fadeInTimer.Stop();
            }
        }

        /// <summary>
        /// Handles the tick event for the display timer.
        /// This timer determines how long the splash screen is shown before starting to fade out.
        /// </summary>
        private void DisplayTimer_Tick(object sender, EventArgs e)
        {
            displayTimer.Stop(); // Stop the display timer once its duration is met

            // Start the fade-out process
            fadeOutTimer.Start();
        }

        /// <summary>
        /// Handles the tick event for the fade-out timer.
        /// Gradually decreases the form's opacity until it's completely transparent, then closes the form.
        /// </summary>
        private void FadeOut_Tick(object sender, EventArgs e)
        {
            if (this.Opacity > 0)
            {
                this.Opacity -= OpacityStep;
            }
            else
            {
                // Once completely transparent, stop the fade-out timer and close the form
                fadeOutTimer.Stop();
                this.DialogResult = DialogResult.OK; // Set a dialog result for the calling code
                this.Close(); // Close the splash screen form
            }
        }

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// In a real project, this is typically auto-generated in SplashScreenForm.Designer.cs.
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            //
            // SplashScreenForm
            //
            this.ClientSize = new System.Drawing.Size(450, 450); // Set client size
            this.Name = "SplashScreenForm"; // Set form name
            this.ResumeLayout(false); // Resume layout logic
        }
    }
}
