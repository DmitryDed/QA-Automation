using System;
using System.Collections.Generic;
using System.Text;

namespace Task_3
{
    class Car : Vehicle
    {
        public int Doors { get; set; }

        public Car(double engine_disp, string transmission, int max_speed, int doors) : base    
        {
            Doors = doors;
        }

        public override string GetFullInfo()
        {
            return (base.GetFullInfo() + $"Number of doors: {Doors}");
        }
    }
}
