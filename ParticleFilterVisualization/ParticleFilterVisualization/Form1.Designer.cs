
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            this.errorMap.Location = new System.Drawing.Point(370, 0);
            this.errorMap.Margin = new System.Windows.Forms.Padding(2);
            this.errorMap.Name = "errorMap";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.errorMap.Series.Add(series1);
            this.errorMap.Size = new System.Drawing.Size(378, 357);
            this.errorMap.TabIndex = 0;
            this.errorMap.Text = "errorMap";
            this.errorMap.Click += new System.EventHandler(this.chart1_Click);
            // 
            // map
            // 
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
            series2.Name = "Series1";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series3.Legend = "Legend1";
            series3.Name = "Series2";
            this.map.Series.Add(series2);
            this.map.Series.Add(series3);
            this.map.Size = new System.Drawing.Size(365, 332);
            this.map.TabIndex = 1;
            this.map.Text = "map";
            this.map.Click += new System.EventHandler(this.map_Click);
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(290, 296);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(75, 23);
            this.start.TabIndex = 2;
            this.start.Text = "start";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.button1_Click);
            // 
            // stop
            // 
            this.stop.Location = new System.Drawing.Point(290, 262);
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

