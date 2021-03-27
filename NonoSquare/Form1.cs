using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using System.IO;
using System.Net;

namespace NonoSquare
{
    public partial class Form1 : MetroForm
    {
        List<string> dataSet; 
        List<int> newCases, newDeaths; //if .csv file has new cases and new deaths given
        SortedSet<string> countries;
        Dictionary<string, Dictionary<DateTime, int>> casesConfirmed, casesDeath; //supposedly, there is casesRecovered if .csv file has recovered cases given
        DateTime start, end; //see SettingDates() if you want to changeDateTime
        int countriesIndex = 1, dateIndex = 2, casesIndex = 3, deathsIndex = 5, newCasesIndex = 4, newDeathsIndex = 6, numberOfCases = 5; // may change according to .csv file; easy access; supposedly, there's a recoveriesIndex = 0,
        public Form1()
        {
            InitializeComponent(); 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DownloadFromFTP();
            SettingDates();
            LoadCountriesToBox();
            LoadAndStoreData();
            TopCountries();
            Extras();
        }

        private void DownloadFromFTP()
        {
            Console.WriteLine("Download file from DriveHQ");
            WebClient client = new WebClient();
            client.Credentials = new NetworkCredential("Twinnies", "uhm@123456nalang");
            client.DownloadFile("ftp://66.220.9.50/My Documents/covid19_by_country.csv", "C:\\Users\\Herve\\Downloads\\covid19_by_country.csv");
            Console.WriteLine("Done");
        }

        private void SettingDates() // sets date limitations and initialization the users may see; may change according to wants/needs
        {
            start = DateTime.Parse("2020-01-01"); // limiting dates
            end = DateTime.Today;

            startDate.Value = DateTime.Parse("2020-01-01"); // initializing dates; can be seen in the DateTime
            endDate.Value = DateTime.Today;
        }  

        private void endDate_ValueChanged(object sender, EventArgs e)
        {
            if (endDate.Value > end)
            {
                endDate.Value = end;
            }
        }

        private void startDate_ValueChanged(object sender, EventArgs e)
        {
            if (startDate.Value < start)
            {
                startDate.Value = start;
            }
        }

        private void LoadCountriesToBox() // reads file, identifies and loads countries into comboBox
        {
            StreamReader sr = new StreamReader("C:\\Users\\Herve\\Downloads\\owid-covid-data.csv");
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
            StreamReader sr = new StreamReader("C:\\Users\\Herve\\Downloads\\owid-covid-data.csv");
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
            //casesRecovered = new Dictionary<string, Dictionary<DateTime, int>>(); // stores total recovery cases; if there is casesRecovered
            newCases = new List<int>(); // stores new cases //if there's newCases and newDeaths
            newDeaths = new List<int>(); //stores new deaths 

            // adding elements to dictionaries
            foreach (var c in countries)
            {
                Dictionary<DateTime, int> d = new Dictionary<DateTime, int>(); // stores inner dictionary of casesConfirmed
                Dictionary<DateTime, int> e = new Dictionary<DateTime, int>(); // stores inner dictionary of casesDeath
                //Dictionary<DateTime, int> f = new Dictionary<DateTime, int>(); // stores inner dictionary of casesRecovered; if there is casesRecovered
                foreach (var data in dataSet)
                {
                    string[] parsed = data.Split(','); // splits string into tokens

                    if (parsed[countriesIndex] == c)
                    {
                        d.Add(DateTime.Parse(parsed[dateIndex]),int.Parse(parsed[casesIndex])); // adds date (as Key) and # of cases (as Value)
                        e.Add(DateTime.Parse(parsed[dateIndex]), int.Parse(parsed[deathsIndex])); // adds date (as Key) and # of deaths (as Value)
                        //f.Add(DateTime.Parse(parsed[dateIndex]), int.Parse(parsed[recoveriesIndex])); // adds date (as Key) and # of deaths (as Value); if there is casesRecovered

                        if (c == "World") // if there's newCases and newDeaths
                        {
                            newCases.Add(int.Parse(parsed[newCasesIndex])); // stores # of new cases alone
                            newDeaths.Add(int.Parse(parsed[newDeathsIndex])); // stores # of new deaths alone
                        }
                    }
                }
                casesConfirmed.Add(c, d); // adds country (as Key) and dictionary (as Value)
                casesDeath.Add(c, e);
                //casesRecovered.Add(c, f); // if there is casesRecovered
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

            // processes charts for number of recovered and overview; if there is casesRecovered
            //overviewChart.Series["Recovered"].Points.Clear(); // clears previous data
            //recoveredChart.Series["Recovered"].Points.Clear();
            //Dictionary<DateTime, int> popRecovered;
            //if (country_Box.Text != string.Empty)
            //{
            //    popRecovered = casesRecovered[country_Box.Text];
            //    foreach (var cases in popRecovered)
            //    {
            //        DateTime dt = DateTime.Parse(cases.Key.ToString());
            //        if (dt >= startDate.Value && dt <= endDate.Value)
            //        {
            //            recoveredChart.Series["Recovered"].Points.AddXY(dt.ToString("MMMM dd"), cases.Value);
            //            overviewChart.Series["Recovered"].Points.AddY(cases.Value);
            //        }
            //    }
            //}
        }

        private void TopCountries() // processes chart for countries with highest and lowest # of cases
        {
            Dictionary<string, int> temp = new Dictionary<string, int>();
            Dictionary<string, int> tempUlit = new Dictionary<string, int>();
            DateTime tempDate = new DateTime();
            DateTime counter = start;



            foreach (var key in casesConfirmed.Keys)
            {
                var value = casesConfirmed[key];
                //foreach (var key2 in value)
                //{
                //    if (key2.Key == counter)
                //    {
                //        tempUlit.Add(key, key2.Value);
                //    }
                //    counter = counter.AddMonths(1);
                //    foreach (var item in tempUlit)
                //    {
                //        Console.WriteLine($"{key2.Key} - {item.Key} : {item.Value}");
                //    }
                //}
                temp.Add(key, value.Last().Value); // adds last element's/recorded data's country (as Key) and # of cases (as Value)
            }

            temp = temp.OrderBy(x => x.Value).ToDictionary(pair => pair.Key, pair => pair.Value); //orders pair by Value

            // shows country with highest and lowest case; part of Extras; can be deleted
            var hCase = temp.ElementAt(temp.Count - 2); // last element (excluding World records, hence - 2)
            var lCase = temp.First(); // first element
            metroTile5.Text = $"Highest Cases:\n{hCase.Key}\n{hCase.Value}";
            metroTile6.Text = $"Lowest Cases:\n{lCase.Key}\n{lCase.Value}";

            // processes chart for countries with highest and lowest # of cases
            var highestCases = temp.Skip(temp.Count - numberOfCases - 1).Take(numberOfCases); // finds last number of cases
            var lowestCases = temp.Take(numberOfCases); // finds first number of cases

            foreach (var hCases in highestCases) // generates graph of highest cases
            {
                highestCasesChart.Series.Add(hCases.Key).Points.AddY(hCases.Value);
            }

            foreach (var lCases in lowestCases) // generates graph of lowest cases
            {
                lowestCasesChart.Series.Add(lCases.Key).Points.AddY(lCases.Value);
            }
        }

        private void Extras() // might have changes according to .csv file; can be deleted
        {
            int totalCases = casesConfirmed["World"].Last().Value;
            int deathCases = casesDeath["World"].Last().Value;
            double mortality = (double)deathCases / totalCases;
            int numOfNewCases = newCases.Last();
            int numOfNewDeaths = newDeaths.Last();

            metroTile1.Text = $"World\nCases:\n {totalCases}";
            metroTile2.Text = $"World\nMortality\nRate:\n {mortality.ToString("P")}";
            metroTile3.Text = $"Welcome to\nNonoSquare";
            metroTile4.Text = $"";
            metroTile3.Text = $"New Deaths:\n {numOfNewDeaths}"; //if there's newCases and newDeaths
            metroTile4.Text = $"New Cases:\n {numOfNewCases}";
        }
    }
}
