using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class Car:Vehicle
    {
        private double _fuelCapacity;
        private double _currentFuel;
        private double _fuelFor1km;

        public double FuelCapacity { get => _fuelCapacity ; set { if (value > 0) _fuelCapacity = value; } }
        public double CurrentFuel { get => _currentFuel ; set { if (value > 0 && value < FuelCapacity) _currentFuel = value; } }
        public double FuelFor1km { get => _fuelFor1km ; set { if (value > 0 && value < FuelCapacity) _fuelFor1km = value; } }

        public override void Drive(double drivekm)
        {
            if (_currentFuel >= _fuelFor1km*drivekm)
            {
                Millage += drivekm;
                _currentFuel =_currentFuel - drivekm * _fuelFor1km;
            }
            else if (_currentFuel < _fuelFor1km*drivekm)
            {
                Console.WriteLine("yeteri qeder benzin yoxdur!");
            }
            
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"brand: {Brand} || reng: {Color} || getdiyi mesafe: {Millage} || umumi benzin tutumu: {FuelCapacity}|| hazirki benzin miqdari: {CurrentFuel} || 1 km ucun serf eediyini benzin:{FuelFor1km} ");
        }       
    }
}
