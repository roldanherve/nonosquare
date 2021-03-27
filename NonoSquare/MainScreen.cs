using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;
using System.Net;


namespace NonoSquare
{

    public partial class MainScreen : Form
    {
        List<String> dataCollected = new List<String>();
        List<string> dataSet;
        List<int> newCases, newDeaths; //if .csv file has new cases and new deaths given
        SortedSet<string> countries;
        Dictionary<string, Dictionary<DateTime, int>> casesConfirmed, casesDeath; 
        DateTime start, end; //see SettingDates() if you want to changeDateTime
        int countriesIndex = 1, dateIndex = 2, casesIndex = 3, deathsIndex = 5, newCasesIndex = 4, newDeathsIndex = 6, numberOfCases = 5; // may change according to .csv file; easy access; supposedly, there's a recoveriesIndex = 0,

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

        public MainScreen()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void loadMainScreen(object sender, EventArgs e)
        {
            DownloadFromFTP();
            StreamReader sr = new StreamReader(filePath);
            sr.ReadLine();
            while (sr.Peek() != -1)
            {
                dataCollected.Add(sr.ReadLine());
            }
            sr.Close();

            SettingDates();
            LoadCountriesToBox();
            LoadAndStoreData();
            TopCountries(0);
            Extras();

            Bot bot = new Bot();
            DimScreen dimscreen = new DimScreen();
            dimscreen.Show();
            bot.Show();
        }

        private void fadeinForm(object sender, EventArgs e)
        {
            if (Opacity == 1)
            {
                fadeIn.Stop();
            }
            Opacity += .2;
        }

        private void fadeoutForm(object sender, EventArgs e) 
        {
            if (Opacity == 0)
            {
                this.Hide();
                fadeOut.Stop();
                StartUpScreen startupscreen = new StartUpScreen();
                startupscreen.ShowDialog();
                this.Close();
            }
            Opacity -= .2;
        }

        private void gotoMenuScreen(object sender, EventArgs e)
        {
            fadeOut.Start();
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            pictureBox1.BackgroundImage = Properties.Resources.back_unhover;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.BackgroundImage = Properties.Resources.back;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            LoveCheck lovecheck = new LoveCheck();
            DimScreen dimscreen = new DimScreen();
            dimscreen.Show();
            lovecheck.Show();
        }

        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            pictureBox3.BackgroundImage = Properties.Resources.lovecheck_hover;
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.BackgroundImage = Properties.Resources.lovecheck_unhover;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
        
        int highorlow = 0;
        private void switchTopCountries(object sender, EventArgs e)
        {
            highlowCasesChart.Series.Clear();
            if(highorlow == 0)
            {
                pictureBox6.BackgroundImage = Properties.Resources.highest_hover;
                TopCountries(0);
                highorlow = 1;
            }
            else if(highorlow == 1)
            {
                pictureBox6.BackgroundImage = Properties.Resources.lowest_hover;
                TopCountries(1);
                highorlow = 0;
            }
        }

        int whichLoadData = 1;

        public int organizeValue(int r)
        {
            int value;
            if(r <= 0)
            {
                value = 3;
            }
            else if(r >= 4)
            {
                value = 1;
            }
            else
            {
                value = r;
            }
            return value;
        }

        public void showcaseData(int n)
        {
            if(n == 1)
            {
                overviewChart.Visible = true;
                deathsChart.Visible = false;
                casesChart.Visible = false;
            } 
            else if(n == 2)
            {
                casesChart.Visible = true;
                deathsChart.Visible = false;
                overviewChart.Visible = false;
            }
            else if (n == 3)
            {
                deathsChart.Visible = true;
                casesChart.Visible = false;
                overviewChart.Visible = false;
            }
        }

        private void minusLoadData(object sender, EventArgs e)
        {
            whichLoadData -= 1;
            var x = organizeValue(whichLoadData);
            showcaseData(x);
        }

        private void plusLoadData(object sender, EventArgs e)
        {
            whichLoadData += 1;
            var x = organizeValue(whichLoadData);
            showcaseData(x);
        }

        private void pictureBox6_MouseHover(object sender, EventArgs e)
        {
            if(pictureBox6.BackgroundImage == Properties.Resources.Highest_Unhover)
            {
                pictureBox6.BackgroundImage = Properties.Resources.highest_hover;
            }
            if (pictureBox6.BackgroundImage == Properties.Resources.lowest_unhover)
            {
                pictureBox6.BackgroundImage = Properties.Resources.lowest_hover;
            }
        }

        private void pictureBox6_MouseLeave(object sender, EventArgs e)
        {
            if (pictureBox6.BackgroundImage == Properties.Resources.highest_hover)
            {
                pictureBox6.BackgroundImage = Properties.Resources.Highest_Unhover;
            }
            if (pictureBox6.BackgroundImage == Properties.Resources.lowest_hover)
            {
                pictureBox6.BackgroundImage = Properties.Resources.lowest_unhover;
            }
        }

        private void pictureBox8_MouseHover(object sender, EventArgs e)
        {
            pictureBox8.BackgroundImage = Properties.Resources.go_hover;
        }

        private void pictureBox8_MouseLeave(object sender, EventArgs e)
        {
            pictureBox8.BackgroundImage = Properties.Resources.go_unhover;
        }

        private void pictureBox7_MouseHover(object sender, EventArgs e)
        {
            pictureBox7.BackgroundImage = Properties.Resources.back_hover;
        }

        private void pictureBox7_MouseLeave(object sender, EventArgs e)
        {
            pictureBox7.BackgroundImage = Properties.Resources.back_unhover1;
        }




        //////////////////////////////////////////////////////////////////////////

        string filePath = "C:\\Users\\Herve\\Desktop\\git\\NonoSquare\\NonoSquare\\Resources\\Files\\owid-covid-data.csv";

        private void DownloadFromFTP()
        {
            WebClient client = new WebClient();
            client.Credentials = new NetworkCredential("Twinnies", "uhm@123456nalang");
            client.DownloadFile("ftp://66.220.9.50/My Documents/owid-covid-data.csv", filePath);
        }

        private void SettingDates() // sets date limitations and initialization the users may see; may change according to wants/needs
        {
            start = DateTime.Parse("2020-01-01"); // limiting dates
            end = DateTime.Today;

            startDate.Value = DateTime.Parse("2020-01-01"); // initializing dates; can be seen in the DateTime
            endDate.Value = DateTime.Today;
        }

        private void startDate_ValueChanged(object sender, EventArgs e)
        {
            if (startDate.Value < start) startDate.Value = start;
        }

        private void endDate_ValueChanged(object sender, EventArgs e)
        {
            if (endDate.Value > end) endDate.Value = end;
        }

        private void LoadCountriesToBox() // reads file, identifies and loads countries into comboBox
        {
            StreamReader sr = new StreamReader(filePath);
            sr.ReadLine(); // dumps header of the .csv file
            countries = new SortedSet<string>();

            while (sr.Peek() != -1)
            {
                countries.Add(sr.ReadLine().Split(',').ElementAt(countriesIndex));
            }

            sr.Close();

            foreach (var c in countries) // serves as identification/key purposes and for adding items to country_Box
            {
                country_Box.Items.Add(c);
            }
        }

        private void LoadAndStoreData() // reads file, identifies needed variables, stores and parses string, converts tokens' datatype, stored into lists and dictionaries
        {
            StreamReader sr = new StreamReader(filePath);
            sr.ReadLine(); // dumps header
            dataSet = new List<string>();

            while (sr.Peek() != -1)
            {
                dataSet.Add(sr.ReadLine()); // reads strings in file, splits into tokes and stores to list dataset
            }

            sr.Close();

            // instantiation of lists and dictionaries
            casesConfirmed = new Dictionary<string, Dictionary<DateTime, int>>();  // stores total confirmed cases
            casesDeath = new Dictionary<string, Dictionary<DateTime, int>>(); // stores total death cases
            newCases = new List<int>(); // stores new cases //if there's newCases and newDeaths
            newDeaths = new List<int>(); //stores new deaths 

            // adding elements to dictionaries
            foreach (var c in countries)
            {
                Dictionary<DateTime, int> d = new Dictionary<DateTime, int>(); // stores inner dictionary of casesConfirmed
                Dictionary<DateTime, int> e = new Dictionary<DateTime, int>(); // stores inner dictionary of casesDeath
                
                foreach (var data in dataSet)
                {
                    string[] parsed = data.Split(','); // splits string into tokens

                    if (parsed[countriesIndex] == c)
                    {
                        d.Add(DateTime.Parse(parsed[dateIndex]), int.Parse(parsed[casesIndex])); // adds date (as Key) and # of cases (as Value)
                        e.Add(DateTime.Parse(parsed[dateIndex]), int.Parse(parsed[deathsIndex])); // adds date (as Key) and # of deaths (as Value)

                        if (c == "World") // if there's newCases and newDeaths
                        {
                            newCases.Add(int.Parse(parsed[newCasesIndex])); // stores # of new cases alone
                            newDeaths.Add(int.Parse(parsed[newDeathsIndex])); // stores # of new deaths alone
                        }
                    }
                }
                casesConfirmed.Add(c, d); // adds country (as Key) and dictionary (as Value)
                casesDeath.Add(c, e);
            }
        }

        private void ProcessCasesChart(object sender, EventArgs e) // once button is clicked, charts are processed
        {
            overviewChart.Series["Cases"].Points.Clear(); // clears previous data
            casesChart.Series["Cases"].Points.Clear();

            // processes charts for number of cases and overview
            Dictionary<DateTime, int> popCases;
            if (country_Box.Text != string.Empty)
            {
                popCases = casesConfirmed[country_Box.Text];
                foreach (var cases in popCases)
                {
                    DateTime dt = DateTime.Parse(cases.Key.ToString());
                    if (dt >= startDate.Value && dt <= endDate.Value)
                    {
                        casesChart.Series["Cases"].Points.AddXY(dt.ToString("MMMM dd"), cases.Value);
                        overviewChart.Series["Cases"].Points.AddXY(dt.ToString("MMMM dd"), cases.Value);
                    }
                }
            }
            else
                MessageBox.Show("Please input country", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // processes charts for number of deaths and overview
            overviewChart.Series["Deaths"].Points.Clear(); // clears previous data
            deathsChart.Series["Deaths"].Points.Clear();

            Dictionary<DateTime, int> popDeaths;
            if (country_Box.Text != string.Empty)
            {
                popDeaths = casesDeath[country_Box.Text];
                foreach (var cases in popDeaths)
                {
                    DateTime dt = DateTime.Parse(cases.Key.ToString());
                    if (dt >= startDate.Value && dt <= endDate.Value)
                    {
                        deathsChart.Series["Deaths"].Points.AddXY(dt.ToString("MMMM dd"), cases.Value);
                        overviewChart.Series["Deaths"].Points.AddY(cases.Value);
                    }
                }
            }
        }

        

        private void TopCountries(int n) // processes chart for countries with highest and lowest # of cases
        {
            Dictionary<string, int> temp = new Dictionary<string, int>();

            foreach (var key in casesConfirmed.Keys)
            {
                var value = casesConfirmed[key];
                temp.Add(key, value.Last().Value); // adds last element's/recorded data's country (as Key) and # of cases (as Value)
            }

            temp = temp.OrderBy(x => x.Value).ToDictionary(pair => pair.Key, pair => pair.Value); //orders pair by Value

            // shows country with highest and lowest case; part of Extras; can be deleted
            var hCase = temp.ElementAt(temp.Count - 2); // last element (excluding World records, hence - 2)
            var lCase = temp.First(); // first element
            label4.Text = $"{hCase.Key}\n{hCase.Value}";
            label5.Text = $"{lCase.Key}\n{lCase.Value}";

            // processes chart for countries with highest and lowest # of cases
            var highestCases = temp.Skip(temp.Count - numberOfCases - 1).Take(numberOfCases); // finds last number of cases
            var lowestCases = temp.Take(numberOfCases); // finds first number of cases

            if(n == 0)
            {
                foreach (var hCases in highestCases) // generates graph of highest cases
                {
                    highlowCasesChart.Series.Add(hCases.Key).Points.AddY(hCases.Value);
                }
            }
            else if(n == 1)
            {
                foreach (var lCases in lowestCases) // generates graph of lowest cases
                {
                    highlowCasesChart.Series.Add(lCases.Key).Points.AddY(lCases.Value);
                }
            }

        }
        private void Extras() // might have changes according to .csv file; can be deleted
        {
            int totalCases = casesConfirmed["World"].Last().Value;
            int deathCases = casesDeath["World"].Last().Value;
            double mortality = (double)deathCases / totalCases;
            int numOfNewCases = newCases.Last();
            int numOfNewDeaths = newDeaths.Last();

            label6.Text = $"{totalCases}";
            label8.Text = $"{numOfNewDeaths}"; //if there's newCases and newDeaths
            label9.Text = $"{numOfNewCases}";
        }
    }
}
