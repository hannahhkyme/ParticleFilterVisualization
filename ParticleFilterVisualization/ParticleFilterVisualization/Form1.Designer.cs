
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.errorMap = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.map = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorMap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.map)).BeginInit();
            this.SuspendLayout();
            // 
            // errorMap
            // 
            chartArea5.Name = "ChartArea1";
            this.errorMap.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.errorMap.Legends.Add(legend5);
            this.errorMap.Location = new System.Drawing.Point(370, 0);
            this.errorMap.Margin = new System.Windows.Forms.Padding(2);
            this.errorMap.Name = "errorMap";
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series7.Legend = "Legend1";
            series7.Name = "Series1";
            this.errorMap.Series.Add(series7);
            this.errorMap.Size = new System.Drawing.Size(378, 357);
            this.errorMap.TabIndex = 0;
            this.errorMap.Text = "errorMap";
            this.errorMap.Click += new System.EventHandler(this.chart1_Click);
            // 
            // map
            // 
            chartArea6.Name = "ChartArea1";
            this.map.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.map.Legends.Add(legend6);
            this.map.Location = new System.Drawing.Point(1, 0);
            this.map.Margin = new System.Windows.Forms.Padding(2);
            this.map.Name = "map";
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series8.Legend = "Legend1";
            series8.Name = "Series1";
            series9.ChartArea = "ChartArea1";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series9.Legend = "Legend1";
            series9.Name = "Series2";
            this.map.Series.Add(series8);
            this.map.Series.Add(series9);
            this.map.Size = new System.Drawing.Size(365, 332);
            this.map.TabIndex = 1;
            this.map.Text = "map";
            this.map.Click += new System.EventHandler(this.map_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(290, 296);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 463);
            this.Controls.Add(this.button1);
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
        private System.Windows.Forms.Button button1;
    }
}

