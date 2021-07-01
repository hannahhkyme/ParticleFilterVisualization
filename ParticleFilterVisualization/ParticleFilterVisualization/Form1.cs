using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Threading;

namespace ParticleFilterVisualization
{
    public partial class Form1 : Form
    {
        private Thread cpuThread;
        List<double>  w1xList = new List<double> ();
        List<double> w1yList = new List<double>();
        List<double> w2xList = new List<double>();
        List<double> w2yList = new List<double>();
        List<double> w3xList = new List<double>();
        List<double> w3yList = new List<double>();
        ParticleFilter p1 = new ParticleFilter();

        public Form1()
        {
            InitializeComponent();
            
        }

        private void getParticleCoordinates()
        {
            Random random_num = new Random();
            p1.create();
            while (true)
            {
                p1.update();
                p1.update_weights();
                p1.correct();
                // make coordinate list 
                double w1 = 0.333;
                w1xList = p1.weight_list_x(w1);
                w1yList = p1.weight_list_x(w1);
                double w2 = 0.666;
                w1xList = p1.weight_list_x(w2);
                w1yList = p1.weight_list_x(w2);

                if (map.IsHandleCreated)
                {
                    this.Invoke((MethodInvoker)delegate { UpdateMap(); });
                }
                else
                {
                    //......
                }

                if (errorMap.IsHandleCreated)
                {
                    this.Invoke((MethodInvoker)delegate { UpdateChart1(); });
                }
                else
                {
                    //......
                }

                Thread.Sleep(100);
            }
        }

        private void UpdateMap()
        {
            map.Series["Series1"].Points.Clear();
            map.Series["Series2"].Points.Clear();
            for (int i = 0; i < w1xList.Count; ++i)
            {
                map.Series["Series1"].Points.AddXY(w1xList[i], w1yList[i]);
                map.Series["Series2"].Points.AddXY(w2xList[i], w2yList[i]);
            }
        }

        private void UpdateChart1()
        {
            errorMap.Series["Series1"].Points.Clear();
            for (int i = 0; i < w1xList.Count; ++i)
            {
                errorMap.Series["Series1"].Points.AddXY(w1xList[i], w1yList[i]);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void map_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ParticleFilter p1 = new ParticleFilter();
            p1.create();
            System.WriteLine(p1.particleList[0].X);
            //cpuThread = new Thread(new ThreadStart(this.getParticleCoordinates));
            //cpuThread.IsBackground = true;
            //cpuThread.Start();

        }
    }
}
