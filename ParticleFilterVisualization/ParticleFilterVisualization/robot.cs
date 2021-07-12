﻿using System;
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
            this.THETA = -Math.PI/3;
            this.V = 3.0;
            this.robot_list_x = new List<double>();
            this.robot_list_y = new List<double>();

        }

        public void create_robot_list()
        {
            this.robot_list_x = new List<double>();
            this.robot_list_y = new List<double>();

            this.robot_list_x.Add(this.X);
            this.robot_list_y.Add(this.Y);
        }

        public void update_robot_position( )
        {
            // should update the sharks position after 
            double RANDOM_VELOCITY = 2;
            double RANDOM_THETA = Math.PI / 2;

            // updates velocity of particles
            this.V += MyGlobals.random_num.NextDouble() * RANDOM_VELOCITY;
            this.V = MyGlobals.velocity_wrap(this.V);

            //change theta & pass through angle_wrap
            this.THETA += MyGlobals.random_num.NextDouble() * (2 * RANDOM_THETA) - RANDOM_THETA;
            this.THETA = MyGlobals.angle_wrap(this.THETA);

            // change x & y coordinates to match
            this.X += this.V * Math.Cos(this.THETA);
            this.Y += this.V * Math.Sin(this.THETA);
        }

       

    }
}
