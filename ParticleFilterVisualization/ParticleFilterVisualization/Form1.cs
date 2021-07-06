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
        Boolean stopHere = true;
        List<double> errorList = new List<double>();
        public Form1()
        {
            InitializeComponent();
            
        }

        private void getParticleCoordinates()
        {
            Random random_num = new Random();
            p1.create();
            while (stopHere)
            {
                p1.update();
                p1.update_weights();
                p1.correct();
                p1.weight_list_x();
                p1.weight_list_y();
                // make coordinate list 
                w1xList = p1.w1_list_x;
                w1yList = p1.w1_list_y;
                w2xList = p1.w2_list_x;
                w2yList = p1.w2_list_y;
                w3yList = p1.w3_list_y;
                w3xList = p1.w3_list_x;

                // range_error creator
                List<double> meanList = p1.calculating_mean_particle();
                double currentError = calculateRangeError(meanList);
                errorList.Add(currentError);

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
        private double calculateRangeError(List<double> meanList)
        {
            double realRange = p1.calc_range_error();
            // calc particle range
            Particle meanParticle = new Particle();
            meanParticle.X = meanList[0];
            meanParticle.Y = meanList[1];
            double particleRange = meanParticle.calc_particle_range(p1.r1.X, p1.r1.Y);
            double rangeError = realRange - particleRange;
            return rangeError;
        }
        private void UpdateMap()
        {
            map.Series["Series1"].Points.Clear();
            map.Series["Series2"].Points.Clear();
            map.Series["Series3"].Points.Clear();
            for (int i = 0; i < w1xList.Count; ++i)
            {
                map.Series["Series1"].Points.AddXY(w1xList[i], w1yList[i]);
            }
            for (int i = 0; i < w2xList.Count; ++i)
            {
                map.Series["Series2"].Points.AddXY(w2xList[i], w2yList[i]);
            }
            for (int i = 0; i < w3xList.Count; ++i)
            {
                map.Series["Series3"].Points.AddXY(w3xList[i], w3yList[i]);
            }
        }

        private void UpdateChart1()
        {
            errorMap.Series["Series1"].Points.Clear();
            for (int i = 0; i < errorList.Count; ++i)
            {
                errorMap.Series["Series1"].Points.AddY(errorList[i]);
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
            
            cpuThread = new Thread(new ThreadStart(this.getParticleCoordinates));
            cpuThread.IsBackground = true;
            cpuThread.Start();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            cpuThread.Abort();
            stopHere = false;
        }
    }
}
