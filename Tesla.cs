using System;

namespace Garage
{
    public class Tesla : Vehicle
    {
        public double BatteryKWh { get; set; }
        public void ChargeBattery()
        {
            Console.WriteLine("Zaaawaaaoooom");
        }
           public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Tesla whispers away.... Zaaawaaaoooom?");
        }
          public override void Turn(string direction)
        {
            Console.WriteLine($"The {MainColor} vehicle turns {direction}.");
        }
    }
}