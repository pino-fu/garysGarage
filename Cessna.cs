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
    }
}