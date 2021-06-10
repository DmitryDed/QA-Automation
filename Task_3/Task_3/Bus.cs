using System;
using System.Collections.Generic;
using System.Text;

namespace Task_3
{
    public class Bus : Vehicle
    {
        public int Seats { get; set; }

        public Bus(double engine_disp, string transmission, int max_speed, int seats) : base(engine_disp, transmission, max_speed)
        {
            Seats = seats;
        }

        public override string GetFullInfo()
        {
            return (base.GetFullInfo() + $"Number of seats: {Seats}");
        }
    }
}