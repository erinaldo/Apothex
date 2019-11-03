using System;
using System.Windows.Forms;
using System.Threading;
using Zek.Core;

namespace Apothex
{
    public partial class SplashScreen : Form
    {
        // Threading
        private static SplashScreen frmSplash;
        private static Thread thread;

        // Fade in and out.
        private double opacityIncrement = 0.05;
        private double opacityDecrement = 0.08;
        private const int timerInterval = 50;

        // Status and progress bar
        static string status;

        public SplashScreen()
        {
            InitializeComponent();

            lblVersion.Text = AssemblyHelper.ApplicationVersion;
            Opacity = .00;
            timer.Start();
            ClientSize = BackgroundImage.Size;
        }

        // A static method to create the thread and 
        // launch the SplashScreen.
        public static void ShowSplashScreen()
        {
            // Make sure it's only launched once.
            if (frmSplash != null)
                return;

            thread = new Thread(new ThreadStart(ShowForm));
            thread.IsBackground = true;
            //thread.ApartmentState = ApartmentState.STA;
            thread.Start();
        }


        // A property returning the splash screen instance
        public static SplashScreen SplashForm
        {
            get
            {
                return frmSplash;
            }
        }

        // A private entry point for the thread.
        private static void ShowForm()
        {
            frmSplash = new SplashScreen();
            Application.Run(frmSplash);
        }

        // A static method to close the SplashScreen
        static public void CloseForm()
        {
            if (frmSplash != null && !frmSplash.IsDisposed)
            {
                // Make it start going away.
                frmSplash.opacityIncrement = -frmSplash.opacityDecrement;
            }
            thread = null;	// we don't need these any more.
            frmSplash = null;
        }

        // A static method to set the status and update the reference.
        public static void SetStatus(string newStatus)
        {
            status = newStatus;
        }

        // Close the form if they double click on it.
        private void SplashScreen_DoubleClick(object sender, EventArgs e)
        {
            CloseForm();
        }

        // Tick Event handler for the Timer control.  Handle fade in and fade out.  Also
        // handle the smoothed progress bar.
        private void timer_Tick(object sender, EventArgs e)
        {
            //lblStatus.Text = ms_sStatus;

            if (Opacity >= 1d)
            {
                Thread.Sleep(2000);
                CloseForm();
            }

            if (opacityIncrement > 0)
            {
                if (Opacity < 1d)
                    Opacity += opacityIncrement;
            }
            else
            {
                if (Opacity > 0d)
                    Opacity += opacityIncrement;
                else
                    Close();
            }
        }


    }
}
