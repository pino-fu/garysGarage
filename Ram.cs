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
         public override void Drive()
        {
          Console.WriteLine($"The Ram carries plywood for a home project..... glugglugglugchugglug. (It's {MainColor}).");
        }
    }
}