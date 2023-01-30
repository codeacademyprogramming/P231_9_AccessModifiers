using System;
using System.Collections.Generic;
using System.Text;

namespace Tasks
{
    internal class Car:Vehicle
    {
        public Car(double fuelCapacity)
        {
            _fuelCapacity = fuelCapacity;
        }
        double _fuelCapacity;
        public double FuelCapacity
        {
            set
            {
                if (_currentFuel <= value)
                    _fuelCapacity = value;
            }
            get => _fuelCapacity;
        }
        

        private double _currentFuel;

        public double CurrentFuel => _currentFuel;
        
        public double FuelFor1Km;
       
        public void AddFuel(int fuel)
        {
            if (_currentFuel + fuel <= FuelCapacity)
                _currentFuel += fuel;
        }

        public override void Drive(double km)
        {
            double neededFuel = km * FuelFor1Km;

            if (_currentFuel >= neededFuel)
            {
                _currentFuel -= neededFuel;
                _mileage += km;
            }
        }
    }
}
