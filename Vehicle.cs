using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public abstract class Vehicle
    {
        public string Color;
        public string Brand;
        public double Millage;

        public virtual void ShowInfo()
        {
            Console.WriteLine($"brand: {Brand} || reng: {Color} || getdiyi mesafe: {Millage} ");
        }

        public abstract void Drive(double drivekm);
    }
}
