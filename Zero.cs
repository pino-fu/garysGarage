using System;

namespace Garage
{
    public class Zero : Vehicle
    {
        public double BatteryKWh { get; set; }
        public void ChargeBattery()
        {
            Console.WriteLine("Vruuuuuhm");
        }

    }
}