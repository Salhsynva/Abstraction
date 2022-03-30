using System;
using ClassLibrary;

namespace Abstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            #region main
            //Console.WriteLine("Nece masin daxil etmek isteyirsiniz?");
            //int carCount = Convert.ToInt32(Console.ReadLine());
            //Car[] cars = new Car[carCount];

            //string color, brand;
            //double millage, fuelCapacity, currentFuel, fuelFor1km;

            //for (int i = 0; i < cars.Length; i++)
            //{
            //    Console.WriteLine($"{i + 1}. masinin rengini daxil edin: ");
            //    color = Console.ReadLine();
            //    Console.WriteLine($"{i + 1}. masinin brand adini daxil edin: ");
            //    brand = Console.ReadLine();
            //    Console.WriteLine($"{i + 1}. masin bu vaxta qeder nece km yol gedib? ");
            //    millage = IsPositive();
            //    Console.WriteLine($"{i + 1}. masinin umumi benzin tutumunu daxil edin: ");
            //    fuelCapacity = IsPositive();
            //    Console.WriteLine($"{i + 1}. masinda nece lt benzin var?");
            //    currentFuel = IsFuelValue(fuelCapacity);
            //    Console.WriteLine($"{i + 1}. masin 1 km ucun ne qeder benzin serf edir?");
            //    fuelFor1km = IsFuelValue(fuelCapacity);

            //    Car car = new Car()
            //    {
            //        Color = color,
            //        Millage = millage,
            //        Brand = brand,
            //        FuelCapacity = fuelCapacity,
            //        CurrentFuel = currentFuel,
            //        FuelFor1km = fuelFor1km
            //    };
            //    cars[i] = car;
            //}

            //Console.WriteLine("\n 1. Masinlari millage-e göre filtirle \n 2.Butun masinlari goster \n 3.Prosesi bitir \n Seciminizi edin: ");
            //int answer = Convert.ToInt32(Console.ReadLine());
            //switch (answer)
            //{
            //    case 1:
            //        {
            //            Console.WriteLine("millage ucun min ve max deyerleri daxil edin: ");
            //            double minMillage = Convert.ToDouble(Console.ReadLine());
            //            double maxMillage = Convert.ToDouble(Console.ReadLine());
            //            foreach (var item in cars)
            //            {
            //                if (item.Millage > minMillage && item.Millage < maxMillage)
            //                {
            //                    item.ShowInfo();
            //                }
            //            }
            //            break;
            //        }
            //    case 2:
            //        {
            //            foreach (var item in cars)
            //            {
            //                item.ShowInfo();
            //            }
            //            break;
            //        }
            //    case 3:
            //        Console.WriteLine("proqram bitdi");
            //        break;
            //    default:
            //        Console.WriteLine("bele secin yoxdur!");
            //        break;
            //}
            #endregion

            #region testDriveMethod
            Car car1 = new Car();
            car1.FuelCapacity = 100;
            car1.CurrentFuel = 50;
            car1.FuelFor1km = 5;
            car1.Millage = 20;
            car1.Drive(4);
            Console.WriteLine(car1.CurrentFuel);
            #endregion
        }

        static double IsPositive()
        {
            double value = Convert.ToDouble(Console.ReadLine());
            while (value < 0)
            {
                Console.WriteLine("bu deyer deyer 0-dan kicik ola bilmez! Yeniden daxil edin");
                value = Convert.ToDouble(Console.ReadLine());
            }
            return value;
        }
        static double IsFuelValue(double fuelCapacity)
        {
            double value = IsPositive();
            if (value > fuelCapacity)
            {
                Console.WriteLine("deyer umumi tutumdan kicik olmalidir!");
                value = IsPositive();
            }
            return value;
        }
    }
}
