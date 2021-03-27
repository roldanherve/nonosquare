using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace NonoSquare
{
    public partial class SplashScreen : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
            (
               int nLeftRect,     // x-coordinate of upper-left corner
               int nTopRect,      // y-coordinate of upper-left corner
               int nRightRect,    // x-coordinate of lower-right corner
               int nBottomRect,   // y-coordinate of lower-right corner
               int nWidthEllipse, // height of ellipse
               int nHeightEllipse // width of ellipse
            );

        
        public SplashScreen()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void fadeinForm(object sender, EventArgs e)
        {
            if(Opacity == 1)
            {
                fadeIn.Stop();
                delay.Start();
            }
            Opacity += .2;
        }

        private void showForm(object sender, EventArgs e)
        {
            delay.Stop();
            fadeOut.Start();
        }

        private void fadeoutForm(object sender, EventArgs e)
        {
            if (Opacity == 0)
            {
                this.Hide();
                fadeOut.Stop();
                this.Close();
            }
            Opacity -= .2;
        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {

        }
    }
}
