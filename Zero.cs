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
        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Zero zaps by.... Vruuuuuhm?");
        }
        public override void Stop()
        {
            Console.WriteLine($"DAAAANG! That Zero stopped so fast that the rider flew over the handlbars.");
        }

    }
}