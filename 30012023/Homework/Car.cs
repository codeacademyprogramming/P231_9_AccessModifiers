using System;
using System.Collections.Generic;
using System.Text;

namespace Homework
{
    internal class Car:Vehicle
    {
        public Car(int fuelCapacity)
        {
            FuelCapacity = fuelCapacity;
        }
        public int FuelCapacity;
        public int CurrentFuel = 10;

        public bool AddFuel(int fuel)
        {
            if (CurrentFuel + fuel <= FuelCapacity)
            {
                CurrentFuel += fuel;
                return true;
            }

            return false;
        }
    }
}
