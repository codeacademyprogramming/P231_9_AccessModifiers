using System;

namespace Tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehicle vehicle1 = new Vehicle();
            vehicle1.Drive(10);
            vehicle1.Drive(15);
            vehicle1.Drive(20);

            Console.WriteLine(vehicle1.Mileage);

            Car car1 = new Car(50);
            //car1.FuelCapacity = 50;
            car1.FuelFor1Km = 0.5;

            car1.AddFuel(10);
            car1.AddFuel(15);
            car1.AddFuel(100);



            car1.FuelCapacity = 30;

            car1.Drive(5);
            car1.Drive(7);
            car1.Drive(15);
            car1.Drive(100);


            Console.WriteLine("Capacity:"+car1.FuelCapacity);
            Console.WriteLine("Current:"+car1.CurrentFuel);
            Console.WriteLine("Mileage:" + car1.Mileage);




        }
    }
}
