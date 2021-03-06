using System;
using System.Collections.Generic;
namespace ParticleFilterVisualization
{
    internal class ParticleFilter
    {
        public int NUMBER_OF_PARTICLES;
        public double Current_Time;
        public List<Particle> particleList = new List<Particle>();
        public Robot r1;
        public List<double> w1_list_x;
        public List<double> w1_list_y;

        public List<double> w2_list_x;
        public List<double> w2_list_y;

        public List<double> w3_list_x;
        public List<double> w3_list_y;

        public List<double> errorList;

        public ParticleFilter()
        {
            this.Current_Time = 0;
            this.NUMBER_OF_PARTICLES = 1000;
            this.r1 = new Robot();
            this.w1_list_x = new List<double>();
            this.w2_list_x = new List<double>();
            this.w3_list_x = new List<double>();
            this.w1_list_y = new List<double>();
            this.w2_list_y = new List<double>();
            this.w3_list_y = new List<double>();
            this.errorList = new List<double>();
        }

   
    public double calc_range_error()
    {
        // calculates the average particles position to the true sharks' position
        double auvRange = Math.Sqrt(Math.Pow((MyGlobals.s1.Y-r1.Y), 2) + Math.Pow((MyGlobals.s1.X - r1.X), 2));
        return auvRange;
    }
    double calc_alpha_error()
    {
        // calculates the average particles position to the true sharks' position
        double auvAlpha = MyGlobals.angle_wrap(Math.Atan2((MyGlobals.s1.Y - r1.Y), (MyGlobals.s1.X - r1.X)) - r1.THETA);
        return auvAlpha;
    }

    public void create()
    {
            
            for (int i = 0; i < NUMBER_OF_PARTICLES; ++i)
            {
                particleList.Add(new Particle());
            }
            /*
            Particle particle1 = new Particle();
            particle1.X = 27;
            particle1.Y = 130;
            particleList.Add(particle1);

            Particle particle2 = new Particle();
            particle2.X = -27;
            particle2.Y = -130;

            particleList.Add(particle2);
            /*
            Particle particle3 = new Particle();
            particle3.Y = -60;
            particleList.Add(particle3);
            */

        }
    public void update()
    {
        // updates particles while simulated
        // returns new list of updated particles

        for (int i = 0; i < NUMBER_OF_PARTICLES; ++i)
        {
            particleList[i].updateParticles();
        }

    }
    public void update_weights()
    {
        // normalize new weights for each new shark measurement
        double auv_range = this.calc_range_error();
        //Console.WriteLine(auv_range);
        double auv_alpha = this.calc_alpha_error();
        List<double> particle_range_list = new List<double>();
        List<double> particle_alpha_list = new List<double>();
        for (int i = 0; i < NUMBER_OF_PARTICLES; ++i)
        {
            double particle_range = particleList[i].calc_particle_range(r1.X, r1.Y);
            particle_range_list.Add(particle_range);
            double particle_alpha = particleList[i].calc_particle_alpha(r1.X, r1.Y, r1.THETA);
            particle_alpha_list.Add(particle_alpha);
            particleList[i].weight(auv_alpha, particle_alpha, auv_range, particle_range);
        }



    }
    public void correct()
    {
            //corrects the particles, adding more copies of particles based on how high the weight is
            List<Particle> tempList = new List<Particle>();

        for (int i = 0; i < NUMBER_OF_PARTICLES; ++i)
        {
            if (particleList[i].W <= 0.333)
            {
                Particle particle1 = particleList[i].DeepCopy();
                tempList.Add(particle1);


            }
            else if (particleList[i].W <= 0.666)
            {
                Particle particle1 = particleList[i].DeepCopy();
                tempList.Add(particle1);
                Particle particle2 = particleList[i].DeepCopy();
                tempList.Add(particle2);

            }
            else
            {
                Particle particle1 = particleList[i].DeepCopy();
                tempList.Add(particle1);
                Particle particle2 = particleList[i].DeepCopy();
                tempList.Add(particle2);
                Particle particle3 = particleList[i].DeepCopy();
                tempList.Add(particle3);
                Particle particle4 = particleList[i].DeepCopy();
                tempList.Add(particle4);
            }

        }
            particleList = new List<Particle>();
            for (int i = 0; i < NUMBER_OF_PARTICLES; ++i)
            {
                int index = MyGlobals.random_num.Next(0,tempList.Count);
                Particle particleIndex = tempList[index].DeepCopy();
                particleList.Add(particleIndex);

            }
    }

    public void weight_list_x()
    {
       w1_list_x = new List<double>();
       w2_list_x = new List<double>();
       w3_list_x = new List<double>();
        for (int i = 0; i < NUMBER_OF_PARTICLES; ++i)
        {
            if (particleList[i].W <= 0.333)
            {
                w1_list_x.Add(particleList[i].X);
            }
            else if (particleList[i].W <= 0.666)
            {
                w2_list_x.Add(particleList[i].X);
            }
            else
            {
                w3_list_x.Add(particleList[i].X);
            }

        }

    }
        public void weight_list_y()
        {
            w1_list_y = new List<double>();
            w2_list_y = new List<double>();
            w3_list_y = new List<double>();
            for (int i = 0; i < NUMBER_OF_PARTICLES; ++i)
            {
                if (particleList[i].W <= 0.333)
                {
                    w1_list_y.Add(particleList[i].Y);
                }
                else if (particleList[i].W <= 0.666)
                {
                    w2_list_y.Add(particleList[i].Y);
                }
                else
                {
                    w3_list_y.Add(particleList[i].Y);
                }
            }
        }
    public List<double> predicting_shark_location()
            {
            double particle_total_x = 0;
            double particle_total_y = 0;
            for (int i = 0; i < NUMBER_OF_PARTICLES; ++i)
                {
                particle_total_x += particleList[i].X;
                particle_total_y += particleList[i].Y;
            }
            double particle_mean_x = particle_total_x / NUMBER_OF_PARTICLES;
            double particle_mean_y = particle_total_y / NUMBER_OF_PARTICLES;
            List<double> mean_particle = new List<double>();
            mean_particle.Add(particle_mean_x);
            mean_particle.Add(particle_mean_y);
            return mean_particle;
            }
    }
    

}

