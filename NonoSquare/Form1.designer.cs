namespace NonoSquare
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend8 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea9 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend9 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea10 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend10 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.startDate = new MetroFramework.Controls.MetroDateTime();
            this.endDate = new MetroFramework.Controls.MetroDateTime();
            this.country_Box = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroTabControl = new MetroFramework.Controls.MetroTabControl();
            this.overview = new MetroFramework.Controls.MetroTabPage();
            this.overviewChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cases = new MetroFramework.Controls.MetroTabPage();
            this.casesChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.deaths = new MetroFramework.Controls.MetroTabPage();
            this.deathsChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.metroTile3 = new MetroFramework.Controls.MetroTile();
            this.metroTile4 = new MetroFramework.Controls.MetroTile();
            this.highestCasesChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lowestCasesChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.bothCities = new MetroFramework.Controls.MetroTabPage();
            this.lowest = new MetroFramework.Controls.MetroTabPage();
            this.metroTile5 = new MetroFramework.Controls.MetroTile();
            this.metroTile6 = new MetroFramework.Controls.MetroTile();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.metroTabControl.SuspendLayout();
            this.overview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.overviewChart)).BeginInit();
            this.cases.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.casesChart)).BeginInit();
            this.deaths.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deathsChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.highestCasesChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lowestCasesChart)).BeginInit();
            this.metroTabControl1.SuspendLayout();
            this.bothCities.SuspendLayout();
            this.lowest.SuspendLayout();
            this.SuspendLayout();
            // 
            // startDate
            // 
            this.startDate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.startDate.Location = new System.Drawing.Point(610, 435);
            this.startDate.MinimumSize = new System.Drawing.Size(0, 30);
            this.startDate.Name = "startDate";
            this.startDate.Size = new System.Drawing.Size(250, 30);
            this.startDate.TabIndex = 0;
            this.startDate.ValueChanged += new System.EventHandler(this.startDate_ValueChanged);
            // 
            // endDate
            // 
            this.endDate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.endDate.Location = new System.Drawing.Point(610, 484);
            this.endDate.MinimumSize = new System.Drawing.Size(0, 30);
            this.endDate.Name = "endDate";
            this.endDate.Size = new System.Drawing.Size(250, 30);
            this.endDate.TabIndex = 0;
            this.endDate.ValueChanged += new System.EventHandler(this.endDate_ValueChanged);
            // 
            // country_Box
            // 
            this.country_Box.Cursor = System.Windows.Forms.Cursors.Hand;
            this.country_Box.FormattingEnabled = true;
            this.country_Box.ItemHeight = 24;
            this.country_Box.Location = new System.Drawing.Point(610, 386);
            this.country_Box.Name = "country_Box";
            this.country_Box.Size = new System.Drawing.Size(250, 30);
            this.country_Box.TabIndex = 1;
            this.country_Box.UseSelectable = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(530, 390);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(62, 20);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "Country:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(552, 439);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(40, 20);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Start:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(556, 488);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(36, 20);
            this.metroLabel3.TabIndex = 3;
            this.metroLabel3.Text = "End:";
            // 
            // metroButton1
            // 
            this.metroButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroButton1.Location = new System.Drawing.Point(653, 538);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(165, 33);
            this.metroButton1.Style = MetroFramework.MetroColorStyle.Purple;
            this.metroButton1.TabIndex = 4;
            this.metroButton1.Text = "Load Chart";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.ProcessCasesChart);
            // 
            // metroTabControl
            // 
            this.metroTabControl.Controls.Add(this.overview);
            this.metroTabControl.Controls.Add(this.cases);
            this.metroTabControl.Controls.Add(this.deaths);
            this.metroTabControl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroTabControl.ItemSize = new System.Drawing.Size(100, 30);
            this.metroTabControl.Location = new System.Drawing.Point(43, 273);
            this.metroTabControl.Name = "metroTabControl";
            this.metroTabControl.SelectedIndex = 0;
            this.metroTabControl.Size = new System.Drawing.Size(459, 341);
            this.metroTabControl.TabIndex = 5;
            this.metroTabControl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTabControl.UseSelectable = true;
            // 
            // overview
            // 
            this.overview.Controls.Add(this.overviewChart);
            this.overview.HorizontalScrollbarBarColor = true;
            this.overview.HorizontalScrollbarHighlightOnWheel = false;
            this.overview.HorizontalScrollbarSize = 10;
            this.overview.Location = new System.Drawing.Point(4, 34);
            this.overview.Name = "overview";
            this.overview.Size = new System.Drawing.Size(451, 303);
            this.overview.TabIndex = 3;
            this.overview.Text = "Overview";
            this.overview.VerticalScrollbarBarColor = true;
            this.overview.VerticalScrollbarHighlightOnWheel = false;
            this.overview.VerticalScrollbarSize = 10;
            // 
            // overviewChart
            // 
            chartArea6.Name = "ChartArea1";
            this.overviewChart.ChartAreas.Add(chartArea6);
            this.overviewChart.Cursor = System.Windows.Forms.Cursors.Arrow;
            legend6.Name = "Legend1";
            this.overviewChart.Legends.Add(legend6);
            this.overviewChart.Location = new System.Drawing.Point(0, 29);
            this.overviewChart.Name = "overviewChart";
            this.overviewChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.Legend = "Legend1";
            series5.Name = "Cases";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.Legend = "Legend1";
            series6.Name = "Deaths";
            this.overviewChart.Series.Add(series5);
            this.overviewChart.Series.Add(series6);
            this.overviewChart.Size = new System.Drawing.Size(455, 271);
            this.overviewChart.TabIndex = 3;
            this.overviewChart.Text = "chart1";
            // 
            // cases
            // 
            this.cases.Controls.Add(this.casesChart);
            this.cases.HorizontalScrollbarBarColor = true;
            this.cases.HorizontalScrollbarHighlightOnWheel = false;
            this.cases.HorizontalScrollbarSize = 10;
            this.cases.Location = new System.Drawing.Point(4, 34);
            this.cases.Name = "cases";
            this.cases.Size = new System.Drawing.Size(451, 303);
            this.cases.TabIndex = 0;
            this.cases.Text = "Cases";
            this.cases.VerticalScrollbarBarColor = true;
            this.cases.VerticalScrollbarHighlightOnWheel = false;
            this.cases.VerticalScrollbarSize = 10;
            // 
            // casesChart
            // 
            chartArea7.Name = "ChartArea1";
            this.casesChart.ChartAreas.Add(chartArea7);
            legend7.Name = "Legend1";
            this.casesChart.Legends.Add(legend7);
            this.casesChart.Location = new System.Drawing.Point(0, 29);
            this.casesChart.Name = "casesChart";
            this.casesChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series7.Legend = "Legend1";
            series7.Name = "Cases";
            this.casesChart.Series.Add(series7);
            this.casesChart.Size = new System.Drawing.Size(455, 271);
            this.casesChart.TabIndex = 2;
            this.casesChart.Text = "chart1";
            // 
            // deaths
            // 
            this.deaths.Controls.Add(this.deathsChart);
            this.deaths.HorizontalScrollbarBarColor = true;
            this.deaths.HorizontalScrollbarHighlightOnWheel = false;
            this.deaths.HorizontalScrollbarSize = 10;
            this.deaths.Location = new System.Drawing.Point(4, 34);
            this.deaths.Name = "deaths";
            this.deaths.Size = new System.Drawing.Size(451, 303);
            this.deaths.TabIndex = 1;
            this.deaths.Text = "Deaths";
            this.deaths.VerticalScrollbarBarColor = true;
            this.deaths.VerticalScrollbarHighlightOnWheel = false;
            this.deaths.VerticalScrollbarSize = 10;
            // 
            // deathsChart
            // 
            chartArea8.Name = "ChartArea1";
            this.deathsChart.ChartAreas.Add(chartArea8);
            legend8.Name = "Legend1";
            this.deathsChart.Legends.Add(legend8);
            this.deathsChart.Location = new System.Drawing.Point(0, 29);
            this.deathsChart.Name = "deathsChart";
            this.deathsChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series8.Legend = "Legend1";
            series8.Name = "Deaths";
            this.deathsChart.Series.Add(series8);
            this.deathsChart.Size = new System.Drawing.Size(455, 271);
            this.deathsChart.TabIndex = 3;
            this.deathsChart.Text = "chart1";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(43, 452);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(0, 0);
            this.metroLabel4.TabIndex = 3;
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Location = new System.Drawing.Point(690, 79);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(170, 150);
            this.metroTile1.Style = MetroFramework.MetroColorStyle.Purple;
            this.metroTile1.TabIndex = 6;
            this.metroTile1.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile1.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.metroTile1.UseSelectable = true;
            // 
            // metroTile2
            // 
            this.metroTile2.ActiveControl = null;
            this.metroTile2.Location = new System.Drawing.Point(511, 79);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(170, 150);
            this.metroTile2.TabIndex = 6;
            this.metroTile2.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile2.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.metroTile2.UseSelectable = true;
            // 
            // metroTile3
            // 
            this.metroTile3.ActiveControl = null;
            this.metroTile3.Location = new System.Drawing.Point(332, 79);
            this.metroTile3.Name = "metroTile3";
            this.metroTile3.Size = new System.Drawing.Size(170, 150);
            this.metroTile3.Style = MetroFramework.MetroColorStyle.Purple;
            this.metroTile3.TabIndex = 6;
            this.metroTile3.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile3.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.metroTile3.UseSelectable = true;
            // 
            // metroTile4
            // 
            this.metroTile4.ActiveControl = null;
            this.metroTile4.Location = new System.Drawing.Point(153, 79);
            this.metroTile4.Name = "metroTile4";
            this.metroTile4.Size = new System.Drawing.Size(170, 150);
            this.metroTile4.TabIndex = 6;
            this.metroTile4.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile4.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.metroTile4.UseSelectable = true;
            // 
            // highestCasesChart
            // 
            chartArea9.Name = "ChartArea1";
            this.highestCasesChart.ChartAreas.Add(chartArea9);
            legend9.Name = "Legend1";
            this.highestCasesChart.Legends.Add(legend9);
            this.highestCasesChart.Location = new System.Drawing.Point(3, 3);
            this.highestCasesChart.Name = "highestCasesChart";
            this.highestCasesChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            this.highestCasesChart.Size = new System.Drawing.Size(553, 285);
            this.highestCasesChart.TabIndex = 7;
            this.highestCasesChart.Text = "chart2";
            // 
            // lowestCasesChart
            // 
            chartArea10.Name = "ChartArea1";
            this.lowestCasesChart.ChartAreas.Add(chartArea10);
            legend10.Name = "Legend1";
            this.lowestCasesChart.Legends.Add(legend10);
            this.lowestCasesChart.Location = new System.Drawing.Point(3, 3);
            this.lowestCasesChart.Name = "lowestCasesChart";
            this.lowestCasesChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            this.lowestCasesChart.Size = new System.Drawing.Size(553, 285);
            this.lowestCasesChart.TabIndex = 8;
            this.lowestCasesChart.Text = "chart3";
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.bothCities);
            this.metroTabControl1.Controls.Add(this.lowest);
            this.metroTabControl1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroTabControl1.HotTrack = true;
            this.metroTabControl1.Location = new System.Drawing.Point(293, 659);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 1;
            this.metroTabControl1.Size = new System.Drawing.Size(567, 333);
            this.metroTabControl1.TabIndex = 9;
            this.metroTabControl1.UseSelectable = true;
            // 
            // bothCities
            // 
            this.bothCities.Controls.Add(this.lowestCasesChart);
            this.bothCities.Cursor = System.Windows.Forms.Cursors.Default;
            this.bothCities.HorizontalScrollbarBarColor = true;
            this.bothCities.HorizontalScrollbarHighlightOnWheel = false;
            this.bothCities.HorizontalScrollbarSize = 10;
            this.bothCities.Location = new System.Drawing.Point(4, 38);
            this.bothCities.Name = "bothCities";
            this.bothCities.Size = new System.Drawing.Size(559, 291);
            this.bothCities.TabIndex = 1;
            this.bothCities.Text = "Lowest";
            this.bothCities.VerticalScrollbarBarColor = true;
            this.bothCities.VerticalScrollbarHighlightOnWheel = false;
            this.bothCities.VerticalScrollbarSize = 10;
            // 
            // lowest
            // 
            this.lowest.Controls.Add(this.highestCasesChart);
            this.lowest.Cursor = System.Windows.Forms.Cursors.Default;
            this.lowest.HorizontalScrollbarBarColor = true;
            this.lowest.HorizontalScrollbarHighlightOnWheel = false;
            this.lowest.HorizontalScrollbarSize = 10;
            this.lowest.Location = new System.Drawing.Point(4, 38);
            this.lowest.Name = "lowest";
            this.lowest.Size = new System.Drawing.Size(559, 291);
            this.lowest.TabIndex = 2;
            this.lowest.Text = "Highest";
            this.lowest.VerticalScrollbarBarColor = true;
            this.lowest.VerticalScrollbarHighlightOnWheel = false;
            this.lowest.VerticalScrollbarSize = 10;
            // 
            // metroTile5
            // 
            this.metroTile5.ActiveControl = null;
            this.metroTile5.Location = new System.Drawing.Point(37, 734);
            this.metroTile5.Name = "metroTile5";
            this.metroTile5.Size = new System.Drawing.Size(206, 109);
            this.metroTile5.TabIndex = 10;
            this.metroTile5.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.metroTile5.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.metroTile5.UseSelectable = true;
            // 
            // metroTile6
            // 
            this.metroTile6.ActiveControl = null;
            this.metroTile6.Location = new System.Drawing.Point(37, 876);
            this.metroTile6.Name = "metroTile6";
            this.metroTile6.Size = new System.Drawing.Size(206, 109);
            this.metroTile6.Style = MetroFramework.MetroColorStyle.Purple;
            this.metroTile6.TabIndex = 10;
            this.metroTile6.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.metroTile6.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.metroTile6.UseSelectable = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1942, 1080);
            this.Controls.Add(this.metroTile6);
            this.Controls.Add(this.metroTile5);
            this.Controls.Add(this.metroTabControl1);
            this.Controls.Add(this.metroTile4);
            this.Controls.Add(this.metroTile3);
            this.Controls.Add(this.metroTile2);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.metroTabControl);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.country_Box);
            this.Controls.Add(this.endDate);
            this.Controls.Add(this.startDate);
            this.Name = "Form1";
            this.Style = MetroFramework.MetroColorStyle.Default;
            this.Text = "NonoSquare";
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.metroTabControl.ResumeLayout(false);
            this.overview.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.overviewChart)).EndInit();
            this.cases.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.casesChart)).EndInit();
            this.deaths.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.deathsChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.highestCasesChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lowestCasesChart)).EndInit();
            this.metroTabControl1.ResumeLayout(false);
            this.bothCities.ResumeLayout(false);
            this.lowest.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroDateTime startDate;
        private MetroFramework.Controls.MetroDateTime endDate;
        private MetroFramework.Controls.MetroComboBox country_Box;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroTabControl metroTabControl;
        private MetroFramework.Controls.MetroTabPage cases;
        private MetroFramework.Controls.MetroTabPage deaths;
        private System.Windows.Forms.DataVisualization.Charting.Chart casesChart;
        private MetroFramework.Controls.MetroTabPage overview;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroTile metroTile2;
        private MetroFramework.Controls.MetroTile metroTile3;
        private MetroFramework.Controls.MetroTile metroTile4;
        private System.Windows.Forms.DataVisualization.Charting.Chart overviewChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart deathsChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart highestCasesChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart lowestCasesChart;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage bothCities;
        private MetroFramework.Controls.MetroTabPage lowest;
        private MetroFramework.Controls.MetroTile metroTile5;
        private MetroFramework.Controls.MetroTile metroTile6;
        private System.Windows.Forms.Timer timer1;
    }
}

