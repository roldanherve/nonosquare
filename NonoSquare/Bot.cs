using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;
using LiveCharts;
using LiveCharts.Wpf;
using System.Net;

namespace NonoSquare
{
    public partial class Bot : Form
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

        public Bot()
        {
            InitializeComponent();
        }

        string filePath = "C:\\Users\\Herve\\Desktop\\git\\NonoSquare\\NonoSquare\\Resources\\Files\\YesorNo.txt";

        private void Bot_Load(object sender, EventArgs e)
        {
            WebClient client = new WebClient();
            client.Credentials = new NetworkCredential("Twinnies", "uhm@123456nalang");
            client.DownloadFile("ftp://66.220.9.50/My Documents/YesorNo.txt", filePath);

            whichDialog(0);
        }

        private void fadeIn_Tick(object sender, EventArgs e)
        {
            if(Opacity == 1)
            {
                fadeIn.Stop();
            } 
            Opacity += .2; 
        }

        public string whichDialog(int x)
        {
            string dialogMessage = string.Empty;
            if(x == 0)
            {
                dialogMessage = "Oh, Hello There! Within contains data analystics in regards the World's Covid-19 Cases.";
            }
            else if(x == 1)
            {
                dialogMessage = "This is to provide access to information beyond the boundaries from the safety of our home.";
            }
            else if (x == 2)
            {
                dialogMessage = "Feel free to interact with NonoSquare's Interface, they say First-Hand is the best experience.";
            }
            else if (x == 3)
            {
                dialogMessage = "But first, I want to know if you are safe from the Covid-19. Are you?";
            }
            return dialogMessage;
        }

        int count = 0;
        int delayy = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            string botMessage = whichDialog(delayy);

            count++;
            botDialog.Text = botMessage.Remove(count);
            if(count == (botMessage.Length - 1))
            {
                count = 0;
                dialog1.Stop();
                delay.Start();
            }
        }

        private void delay_Tick(object sender, EventArgs e)
        {
            delayy++;
            if(delayy == 4)
            {
                yesButton.Visible = true;
                noButton.Visible = true;
                delay.Stop();
            }
            else
            {
                delay.Stop();
                dialog1.Start();
            }
        }

        private void clickYes(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter(filePath, true);

            sw.WriteLine();
            sw.Write("Yes");
            sw.Close();

            yesButton.Visible = false;
            noButton.Visible = false;
            showData();

        }

        private void hoverYes(object sender, EventArgs e)
        {
            yesButton.BackgroundImage = Properties.Resources.Yes_hover1;
        }

        private void unhoverYes(object sender, EventArgs e)
        {
            yesButton.BackgroundImage = Properties.Resources.Yes_unhover1;
        }

        private void ClickNo(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter(filePath, true);

            sw.WriteLine();
            sw.Write("No");
            sw.Close();

            yesButton.Visible = false;
            noButton.Visible = false;
            showData();
        }

        private void hoverNo(object sender, EventArgs e)
        {
            noButton.BackgroundImage = Properties.Resources.no_hover1;
        }

        private void unhoverNo(object sender, EventArgs e)
        {
            noButton.BackgroundImage = Properties.Resources.no_unhover1;
        }


        public void showData()
        {
            
            StreamReader sr = new StreamReader(filePath);

            int countYes = 0;
            int countNo = 0;

            while(sr.Peek() != -1)
            {
                var current = sr.ReadLine();

                if (current == "Yes")
                {
                    countYes++;
                }
                else if (current == "No")
                {
                    countNo++;
                }
            }

            sr.Close();

            chart1.Series["Series1"].Points.AddXY("Yes", countYes);
            chart1.Series["Series1"].Points.AddXY("No", countNo);
            chart1.Visible = true;

            timer1.Start();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            timer1.Stop();
            this.Close();
            DimScreen obj = (DimScreen)Application.OpenForms["DimScreen"];
            obj.Close();
        }
    }
}
