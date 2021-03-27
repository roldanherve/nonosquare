using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace NonoSquare
{
    public partial class StartUpScreen : Form
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

        public StartUpScreen()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void fadeinScreen(object sender, EventArgs e)
        {
            if(Opacity == 1)
            {
                fadeIn.Stop();
            }
            Opacity += .2;
        }

        private void fadeoutScreen(object sender, EventArgs e)
        {
            if (Opacity == 0)
            {
                this.Hide();
                fadeOut.Stop();
                MainScreen mainscreen = new MainScreen();
                mainscreen.ShowDialog();
                this.Close();
            }
            Opacity -= 2;
        }

        private void hoverStart(object sender, EventArgs e)
        {
            startButton.BackgroundImage = Properties.Resources.start_hover;
        }

        private void unhoverStart(object sender, EventArgs e)
        {
            startButton.BackgroundImage = Properties.Resources.start_nonhover;
        }

        private void gotoMainScreen(object sender, EventArgs e)
        {
            fadeOut.Start();
        }

        private void exitApplication(object sender, EventArgs e)
        {
            exitApp.Start();
        }

        private void closeApplication(object sender, EventArgs e)
        {
            if (Opacity == 0)
            {
                this.Hide();
                fadeOut.Stop();
                this.Close();
            }
            Opacity -= 2;
        }

        private void hoverExit(object sender, EventArgs e)
        {
            exitButton.BackgroundImage = Properties.Resources.exit_hover;
        }

        private void unhoverExit(object sender, EventArgs e)
        {
            exitButton.BackgroundImage = Properties.Resources.exit_nonhover;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            DimScreen dimscreen = new DimScreen();
            Information information = new Information();
            dimscreen.Show();
            information.Show();

        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            pictureBox2.BackgroundImage = Properties.Resources.Question_Hover;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.BackgroundImage = Properties.Resources.Question_Unhover;
        }
    }
}
