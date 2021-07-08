using System;
using System.Collections.Generic;
namespace ParticleFilterVisualization
{
    internal class Shark
    {
        Random random_num = new Random();
        // SETS TYPE OF MEMBER VARIABLE
        public double X;
        public double Y;
        public double Z;
        public double THETA;
        public double V;
        public List<double> shark_list_x;
        public List<double> shark_list_y;

        public Shark()
        {
            this.X = 120;
            this.Y = 60;
            this.Z = 3.0;
            this.THETA  = Math.PI/2;
            this.V = 3.0;
            this.shark_list_x = new List<double>();
            this.shark_list_y = new List<double>();

        }

        public void create_shark_list()
        {
            this.shark_list_x.Add(this.X);
            this.shark_list_y.Add(this.Y);
        }
        void update_shark()
        {
            // should update the sharks position after 
        }
       
    }
}