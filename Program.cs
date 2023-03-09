namespace Garage
{
    class Program
    {
        static void Main(string[] args) 
        {
            Zero fxs = new Zero()
            {
                MainColor = "Silver",
                MaximumOccupancy = 2,
                BatteryKWh = 1249.2
            };
            Tesla modelS = new Tesla()
            {
                MainColor = "White",
                MaximumOccupancy = 5, 
                BatteryKWh = 2097.5
            };
            Cessna mx410 = new Cessna()
            {
                MainColor = "Red and White",
                MaximumOccupancy = 4,
                FuelCapacity = 58.3
            };
            Ram dodge = new Ram()
            {
                MainColor = "Black",
                MaximumOccupancy = 5,
                FuelCapacity = 27.0
            };

            fxs.Drive();
            fxs.Turn("left");
            fxs.Stop();
            modelS.Drive();
            modelS.Turn("lafoout");
            modelS.Stop();
            mx410.Drive();
            dodge.Drive();
        }
    }
}
