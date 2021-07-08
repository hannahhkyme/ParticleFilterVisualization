using System;
using System.Collections.Generic;
namespace ParticleFilterVisualization
{
    internal class Robot
    {
        Random random_num = new Random();
        // SETS TYPE OF MEMBER VARIABLE
        public double X;
        public double Y;
        public double Z;
        public double THETA;
        public double V;
        public List<double> robot_list_x;
        public List<double> robot_list_y;
        public Robot()
        {
            this.X = 0;
            this.Y = 0;
            this.Z = 3.0;
            this.THETA = Math.PI;
            this.V = 3.0;
            this.robot_list_x = new List<double>();
            this.robot_list_y = new List<double>();

        }

        public void create_robot_list()
        {
            this.robot_list_x.Add(this.X);
            this.robot_list_y.Add(this.Y);
        }

        void update_robot_position(double velocity, double ang_velocity )
        {

        }

        void calc_new_robot_position()
        {

        }

    }
}
