
namespace ParticleFilterVisualization
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.errorMap = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.map = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.start = new System.Windows.Forms.Button();
            this.stop = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorMap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.map)).BeginInit();
            this.SuspendLayout();
            // 
            // errorMap
            // 
            chartArea1.Name = "ChartArea1";
            this.errorMap.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.errorMap.Legends.Add(legend1);
            this.errorMap.Location = new System.Drawing.Point(431, 0);
            this.errorMap.Margin = new System.Windows.Forms.Padding(2);
            this.errorMap.Name = "errorMap";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Range Error";
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            this.errorMap.Series.Add(series1);
            this.errorMap.Size = new System.Drawing.Size(378, 357);
            this.errorMap.TabIndex = 0;
            this.errorMap.Text = "errorMap";
            title1.Name = "Range Error";
            this.errorMap.Titles.Add(title1);
            this.errorMap.Click += new System.EventHandler(this.chart1_Click);
            // 
            // map
            // 
            chartArea2.AxisX.Maximum = 150D;
            chartArea2.AxisX.Minimum = -150D;
            chartArea2.AxisY.Maximum = 150D;
            chartArea2.AxisY.Minimum = -150D;
            chartArea2.Name = "ChartArea1";
            this.map.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.map.Legends.Add(legend2);
            this.map.Location = new System.Drawing.Point(1, 0);
            this.map.Margin = new System.Windows.Forms.Padding(2);
            this.map.Name = "map";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series2.Legend = "Legend1";
            series2.MarkerColor = System.Drawing.Color.Black;
            series2.MarkerSize = 15;
            series2.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Triangle;
            series2.Name = "Shark";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series3.Legend = "Legend1";
            series3.MarkerBorderColor = System.Drawing.Color.Yellow;
            series3.MarkerSize = 8;
            series3.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Cross;
            series3.Name = "Robot";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series4.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            series4.Legend = "Legend1";
            series4.Name = "Weight1";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series5.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            series5.Legend = "Legend1";
            series5.Name = "Weight2";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series6.Color = System.Drawing.Color.Red;
            series6.Legend = "Legend1";
            series6.Name = "Weight3";
            this.map.Series.Add(series2);
            this.map.Series.Add(series3);
            this.map.Series.Add(series4);
            this.map.Series.Add(series5);
            this.map.Series.Add(series6);
            this.map.Size = new System.Drawing.Size(426, 452);
            this.map.TabIndex = 1;
            this.map.Text = "map";
            this.map.Click += new System.EventHandler(this.map_Click);
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(329, 294);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(75, 23);
            this.start.TabIndex = 2;
            this.start.Text = "start";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.button1_Click);
            // 
            // stop
            // 
            this.stop.Location = new System.Drawing.Point(329, 355);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(75, 23);
            this.stop.TabIndex = 3;
            this.stop.Text = "stop";
            this.stop.UseVisualStyleBackColor = true;
            this.stop.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 463);
            this.Controls.Add(this.stop);
            this.Controls.Add(this.start);
            this.Controls.Add(this.map);
            this.Controls.Add(this.errorMap);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorMap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.map)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart errorMap;
        private System.Windows.Forms.DataVisualization.Charting.Chart map;
        private System.Windows.Forms.Button stop;
        private System.Windows.Forms.Button start;
    }
}

