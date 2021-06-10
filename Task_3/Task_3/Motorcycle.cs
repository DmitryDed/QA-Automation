using System;
using System.Collections.Generic;
using System.Text;

namespace Task_3
{
    class Motorcycle : Vehicle
    {
        public double Weight { get; set; }

        public Motorcycle(double engine_disp, string transmission, int max_speed, double weight) : base(engineСapacity, transmissionType, maximumSpeed)
        {
            Weight = weight;
        }

        public override string GetFullInfo()
        {
            return (base.GetFullInfo() + $"Weight of motorcycle : {Weight}");
        }
    }
}