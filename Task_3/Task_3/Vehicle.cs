using System;

namespace Task_3
{
    public abstract class Vehicle
    {
        public double Engine_disp { get; set; }
        public string Transmission { get; set; }
        public int Max_speed { get; set; }

        public Vehicle(double engine_disp, string transmission, int max_speed)
        {
            Engine_disp = engine_disp;
            Transmission = transmission;
            Max_speed = max_speed;
        }

        public virtual string GetFullInfo()
        {
            return "Engine capacity: " + $"{Engine_disp} " + "Transmission type: " + $"{Transmission} " + "Maximum speed: " + $"{Max_speed} ";
        }
    }
}