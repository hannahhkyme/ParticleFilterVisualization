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
        ParticleFilter particle_filter = new ParticleFilter();
        Boolean stopHere = true;
        List<double> errorList = new List<double>();
        List<double> PredictedSharkXList = new List<double>();
        List<double> PredictedSharkYList = new List<double>();
        public Form1()
        {
            InitializeComponent();
            
        }
        public void create_simulation()
        {
            particle_filter.create();
            particle_filter.s1.create_shark_list();
            particle_filter.r1.create_robot_list();
        }

        private void update_pf()
        {
            particle_filter.update();
            particle_filter.update_weights();
        }
        private void update_weight_lists()
        {
            w1xList = particle_filter.w1_list_x;
            w1yList = particle_filter.w1_list_y;
            w2xList = particle_filter.w2_list_x;
            w2yList = particle_filter.w2_list_y;
            w3yList = particle_filter.w3_list_y;
            w3xList = particle_filter.w3_list_x;
        }
        private void shark_motion()
        {
            particle_filter.correct();

            // update Shark Location
            particle_filter.s1.update_shark();
            particle_filter.s1.create_shark_list();
        }
        private void create_range_error()
        {
            List<double> predictedList = particle_filter.predicting_shark_location();
            double currentError = Math.Abs(calculateRangeError(predictedList));
            calculate_predicted_shark(predictedList);
            errorList.Add(currentError);
        }
        private void update_robot_location()
        {
            particle_filter.r1.update_robot_position();
            particle_filter.r1.create_robot_list();
        }
        private void getParticleCoordinates()
        {
            create_simulation();
            double count = 0;
            while (stopHere)
            {
                count += 10;
                update_pf();
                bool get_new_measurement = particle_filter.s1.get_shark_measurement();
                if (count % 80== 0)
                {
                    shark_motion();
                }

                particle_filter.weight_list_x();
                particle_filter.weight_list_y();

                // make coordinate list 
                update_weight_lists();

                update_robot_location();

                // range_error creator
                create_range_error();

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
            double realRange = particle_filter.calc_range_error();
            // calc particle range
            Particle meanParticle = new Particle();
            meanParticle.X = meanList[0];
            meanParticle.Y = meanList[1];
            double particleRange = meanParticle.calc_particle_range(particle_filter.r1.X, particle_filter.r1.Y);
            double rangeError = realRange - particleRange;
            return rangeError;
        }

        private void calculate_predicted_shark(List<double> meanList)
        {
            PredictedSharkXList = new List<double>();
            PredictedSharkYList = new List<double>();
            PredictedSharkXList.Add(meanList[0]);
            PredictedSharkYList.Add(meanList[1]);
        }
        private void UpdateMap()
        {
            map.Series["Predicted Shark"].Points.Clear();
            map.Series["Weight1"].Points.Clear();
            map.Series["Weight2"].Points.Clear();
            map.Series["Weight3"].Points.Clear();
            map.Series["Shark"].Points.Clear();
            map.Series["Robot"].Points.Clear();
           
            
            for (int i = 0; i < w1xList.Count; ++i)
            {
                map.Series["Weight1"].Points.AddXY(w1xList[i], w1yList[i]);
            }
            for (int i = 0; i < w2xList.Count; ++i)
            {
                map.Series["Weight2"].Points.AddXY(w2xList[i], w2yList[i]);
            }
            for (int i = 0; i < w3xList.Count; ++i)
            {
                map.Series["Weight3"].Points.AddXY(w3xList[i], w3yList[i]);
            }
            map.Series["Predicted Shark"].Points.AddXY(PredictedSharkXList[0], PredictedSharkYList[0]);
            map.Series["Shark"].Points.AddXY(particle_filter.s1.shark_list_x[0], particle_filter.s1.shark_list_y[0]);
            double hey = particle_filter.r1.robot_list_x.Count;
            //double yes = particle_filter.r1.robot_list_y[0];
            map.Series["Robot"].Points.AddXY(particle_filter.r1.robot_list_x[0], particle_filter.r1.robot_list_y[0]);
            
        }

        private void UpdateChart1()
        {
            errorMap.Series["Range Error"].Points.Clear();
            for (int i = 0; i < errorList.Count; ++i)
            {
                errorMap.Series["Range Error"].Points.AddY(errorList[i]);
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
