using System;
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
        public Shark()
        {
            this.X = 30;
            this.Y = 60;
            this.Z = 3.0;
            this.THETA  = Math.PI/2;
            this.V = 3.0;
            
        }

        void create_shark()
        {
            // creates sharks
        }
        void update_shark()
        {
            // should update the sharks position after 
        }
       
    }
}