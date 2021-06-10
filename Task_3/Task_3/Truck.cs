using System;
using System.Collections.Generic;
using System.Text;

namespace Task_3
{
    class Truck : Vehicle
    {
        public double Max_load { get; set; }

        public Truck(double engine_disp, string transmission, int max_speed, double max_load) : base(engineСapacity, transmissionType, maximumSpeed)
        {
            Max_load = max_load;
        }

        public override string GetFullInfo()
        {
            return (base.GetFullInfo() + $"Maximum load: {Max_load}");
        }
    }
}
