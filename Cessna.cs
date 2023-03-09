using System; 

namespace Garage
{
    public class Cessna : Vehicle
    {
        public double FuelCapacity { get; set; }
        public void RefuelTank()
        {
            Console.WriteLine("Zzzzrrraaawwwwmannnndude");
        }
         public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Cessna soars by..... Zzzzrrraaawwwwmannnndude.");
        }
    }
}