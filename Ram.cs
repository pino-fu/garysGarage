using System;

namespace Garage
{
    public class Ram : Vehicle
    {
        public double FuelCapacity { get; set; }

        public void RefuelTank()
        {
          Console.WriteLine("glugglugglugchugglug");
        }
    }
}