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
                p1.weight_list_x();
                p1.weight_list_y();
                // make coordinate list 
                w1xList = p1.w1_list_x;
                w1yList = p1.w1_list_y;
                w2xList = p1.w2_list_x;
                w2yList = p1.w2_list_y;
                w3yList = p1.w3_list_y;
                w3xList = p1.w3_list_x;


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
            }
            for (int i = 0; i < w2xList.Count; ++i)
            {
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
            
            cpuThread = new Thread(new ThreadStart(this.getParticleCoordinates));
            cpuThread.IsBackground = true;
            cpuThread.Start();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            cpuThread.Abort();

        }
    }
}
