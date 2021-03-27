using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;
using System.Collections.Generic;
using System.Net;
using System.Drawing;

namespace NonoSquare
{
    public partial class LoveCheck : Form
    {
        public Color Black { get; private set; }

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

        public LoveCheck()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        string filePath = "C:\\Users\\Herve\\Desktop\\git\\NonoSquare\\NonoSquare\\Resources\\Files\\Motivation.txt";

        private void loadLoveCheck(object sender, EventArgs e)
        {
            this.BringToFront();
            WebClient client = new WebClient();
            client.Credentials = new NetworkCredential("Twinnies", "uhm@123456nalang");
            client.DownloadFile("ftp://66.220.9.50/My Documents/Motivation.txt", filePath);
        }

        private void clickBack(object sender, EventArgs e)
        {
            this.Close();
            DimScreen obj = (DimScreen)Application.OpenForms["DimScreen"];
            obj.Close();
        }

        private void hoverBack(object sender, EventArgs e)
        {
            pictureBox3.BackgroundImage = Properties.Resources.back_unhover;
        }

        private void unhoverBack(object sender, EventArgs e)
        {
            pictureBox3.BackgroundImage = Properties.Resources.back;
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            textBox1.ForeColor = Black;
            StreamReader sr = new StreamReader(filePath);
            List<string> messages = new List<string>();
            while (sr.Peek() != -1)
            {
                messages.Add(sr.ReadLine());
            }

            Random r = new Random();
            int which = r.Next(0, (messages.Count - 1));
            textBox1.Text = messages[which];
            generateButton.Visible = false;
            thanksButton.Visible = true;
        }

        private void thanksButton_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Generated message will be displayed here.";
            generateButton.Visible = true;
            thanksButton.Visible = false;
        }

        private void userInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                StreamWriter sw = new StreamWriter(filePath, true);
                sw.WriteLine(userInput.Text);
                sw.Close();
                userInput.Text = "Submission Received.";
                userInput.Enabled = false;
                ResetSpread.Start();

                WebClient client = new WebClient();
                client.Credentials = new NetworkCredential("Twinnies", "uhm@123456nalang");
                client.UploadFile("ftp://66.220.9.50/My Documents/Motivation.txt", filePath);
            }
        }

        private void ResetSpread_Tick(object sender, EventArgs e)
        {
            ResetSpread.Stop();
        }

        private void userInput_TextChanged(object sender, EventArgs e)
        {
            userInput.ForeColor = Black;
        }

        private void generateButton_MouseHover(object sender, EventArgs e)
        {
            generateButton.BackgroundImage = Properties.Resources.receive_hover;
        }

        private void generateButton_MouseLeave(object sender, EventArgs e)
        {
            generateButton.BackgroundImage = Properties.Resources.receive_unhover;
        }

        private void thanksButton_MouseHover(object sender, EventArgs e)
        {
            thanksButton.BackgroundImage = Properties.Resources.thanks_hover;
        }

        private void thanksButton_MouseLeave(object sender, EventArgs e)
        {
            thanksButton.BackgroundImage = Properties.Resources.thanks_unhover;
        }
    }
}
