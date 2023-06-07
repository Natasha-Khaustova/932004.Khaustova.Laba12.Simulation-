
namespace KhaustovaLab12Simulation
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.Label1 = new System.Windows.Forms.Label();
            this.StartButton = new System.Windows.Forms.Button();
            this.DaysNumeric = new System.Windows.Forms.NumericUpDown();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.ClearDays = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.CloudyDays = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this.OvercastDays = new System.Windows.Forms.Label();
            this.Label10 = new System.Windows.Forms.Label();
            this.Label11 = new System.Windows.Forms.Label();
            this.OvercastDistr = new System.Windows.Forms.Label();
            this.CloudyDistr = new System.Windows.Forms.Label();
            this.ClearDistr = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.WeatherChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.DaysNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WeatherChart)).BeginInit();
            this.SuspendLayout();
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(342, 20);
            this.Label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(258, 38);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Weather forecast";
            // 
            // StartButton
            // 
            this.StartButton.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartButton.Location = new System.Drawing.Point(524, 76);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(191, 51);
            this.StartButton.TabIndex = 1;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // DaysNumeric
            // 
            this.DaysNumeric.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DaysNumeric.Location = new System.Drawing.Point(204, 88);
            this.DaysNumeric.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.DaysNumeric.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.DaysNumeric.Name = "DaysNumeric";
            this.DaysNumeric.Size = new System.Drawing.Size(171, 30);
            this.DaysNumeric.TabIndex = 2;
            this.DaysNumeric.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label2.Location = new System.Drawing.Point(184, 131);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(214, 23);
            this.Label2.TabIndex = 3;
            this.Label2.Text = "Enter the number of days";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label3.Location = new System.Drawing.Point(511, 131);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(228, 23);
            this.Label3.TabIndex = 4;
            this.Label3.Text = "Press to know the forecast!";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label4.Location = new System.Drawing.Point(60, 223);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(145, 23);
            this.Label4.TabIndex = 5;
            this.Label4.Text = "Number of days:";
            // 
            // ClearDays
            // 
            this.ClearDays.AutoSize = true;
            this.ClearDays.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClearDays.Location = new System.Drawing.Point(113, 288);
            this.ClearDays.Name = "ClearDays";
            this.ClearDays.Size = new System.Drawing.Size(20, 23);
            this.ClearDays.TabIndex = 6;
            this.ClearDays.Text = "0";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label6.Location = new System.Drawing.Point(12, 288);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(51, 23);
            this.Label6.TabIndex = 7;
            this.Label6.Text = "Clear";
            // 
            // CloudyDays
            // 
            this.CloudyDays.AutoSize = true;
            this.CloudyDays.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloudyDays.Location = new System.Drawing.Point(113, 352);
            this.CloudyDays.Name = "CloudyDays";
            this.CloudyDays.Size = new System.Drawing.Size(20, 23);
            this.CloudyDays.TabIndex = 8;
            this.CloudyDays.Text = "0";
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label8.Location = new System.Drawing.Point(12, 352);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(67, 23);
            this.Label8.TabIndex = 9;
            this.Label8.Text = "Cloudy";
            // 
            // OvercastDays
            // 
            this.OvercastDays.AutoSize = true;
            this.OvercastDays.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OvercastDays.Location = new System.Drawing.Point(113, 418);
            this.OvercastDays.Name = "OvercastDays";
            this.OvercastDays.Size = new System.Drawing.Size(20, 23);
            this.OvercastDays.TabIndex = 10;
            this.OvercastDays.Text = "0";
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label10.Location = new System.Drawing.Point(12, 418);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(81, 23);
            this.Label10.TabIndex = 11;
            this.Label10.Text = "Overcast";
            // 
            // Label11
            // 
            this.Label11.AutoSize = true;
            this.Label11.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label11.Location = new System.Drawing.Point(211, 223);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(194, 23);
            this.Label11.TabIndex = 12;
            this.Label11.Text = "Stationary distribution:";
            // 
            // OvercastDistr
            // 
            this.OvercastDistr.AutoSize = true;
            this.OvercastDistr.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OvercastDistr.Location = new System.Drawing.Point(286, 418);
            this.OvercastDistr.Name = "OvercastDistr";
            this.OvercastDistr.Size = new System.Drawing.Size(20, 23);
            this.OvercastDistr.TabIndex = 15;
            this.OvercastDistr.Text = "0";
            // 
            // CloudyDistr
            // 
            this.CloudyDistr.AutoSize = true;
            this.CloudyDistr.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloudyDistr.Location = new System.Drawing.Point(286, 352);
            this.CloudyDistr.Name = "CloudyDistr";
            this.CloudyDistr.Size = new System.Drawing.Size(20, 23);
            this.CloudyDistr.TabIndex = 14;
            this.CloudyDistr.Text = "0";
            // 
            // ClearDistr
            // 
            this.ClearDistr.AutoSize = true;
            this.ClearDistr.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClearDistr.Location = new System.Drawing.Point(286, 288);
            this.ClearDistr.Name = "ClearDistr";
            this.ClearDistr.Size = new System.Drawing.Size(20, 23);
            this.ClearDistr.TabIndex = 13;
            this.ClearDistr.Text = "0";
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // WeatherChart
            // 
            chartArea1.Name = "ChartArea1";
            this.WeatherChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Clear days";
            legend1.TitleBackColor = System.Drawing.Color.Transparent;
            this.WeatherChart.Legends.Add(legend1);
            this.WeatherChart.Location = new System.Drawing.Point(402, 157);
            this.WeatherChart.Name = "WeatherChart";
            this.WeatherChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Clear days";
            series1.Name = "Clear days";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Clear days";
            series2.Name = "Cloudy days";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Clear days";
            series3.Name = "Overcast days";
            this.WeatherChart.Series.Add(series1);
            this.WeatherChart.Series.Add(series2);
            this.WeatherChart.Series.Add(series3);
            this.WeatherChart.Size = new System.Drawing.Size(567, 385);
            this.WeatherChart.TabIndex = 16;
            this.WeatherChart.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 43F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.WeatherChart);
            this.Controls.Add(this.OvercastDistr);
            this.Controls.Add(this.CloudyDistr);
            this.Controls.Add(this.ClearDistr);
            this.Controls.Add(this.Label11);
            this.Controls.Add(this.Label10);
            this.Controls.Add(this.OvercastDays);
            this.Controls.Add(this.Label8);
            this.Controls.Add(this.CloudyDays);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.ClearDays);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.DaysNumeric);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.Label1);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(8);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.DaysNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WeatherChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.NumericUpDown DaysNumeric;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.Label Label3;
        private System.Windows.Forms.Label Label4;
        private System.Windows.Forms.Label ClearDays;
        private System.Windows.Forms.Label Label6;
        private System.Windows.Forms.Label CloudyDays;
        private System.Windows.Forms.Label Label8;
        private System.Windows.Forms.Label OvercastDays;
        private System.Windows.Forms.Label Label10;
        private System.Windows.Forms.Label Label11;
        private System.Windows.Forms.Label OvercastDistr;
        private System.Windows.Forms.Label CloudyDistr;
        private System.Windows.Forms.Label ClearDistr;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataVisualization.Charting.Chart WeatherChart;
    }
}

