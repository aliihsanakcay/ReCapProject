using Business.Concrete;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());

            Console.WriteLine("ALL ------------");
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Description);
            }

            Console.WriteLine("\nBRAND ------------");
            foreach (var car in carManager.GetByBrandId(3))
            {
                Console.WriteLine(car.Description);
            }

            Console.WriteLine("\nCOLOR ------------");
            foreach (var car in carManager.GetByColorId(3))
            {
                Console.WriteLine(car.Description);
            }

            Console.WriteLine("\nADDING CAR ------------");
            carManager.Add(new Car { CarId = 9, BrandId = 5, ColorId = 1, ModelYear = 1999, DailyPrice = 750, Description = "Volvo" });

            Console.WriteLine("\nALL ------------");
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Description);
            }

            Console.WriteLine("\nDELETING CAR ------------");
            carManager.Delete(new Car { CarId = 5, BrandId = 3, ColorId = 5, ModelYear = 1987, DailyPrice = 500, Description = "Opel" });

            Console.WriteLine("\nALL ------------");
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Description);
            }


            Console.WriteLine("\nUPDATING CAR ------------");
            carManager.Update(new Car { CarId = 3, BrandId = 3, ColorId = 2, ModelYear = 2005, DailyPrice = 900, Description = "Audi" });

            Console.WriteLine("\nALL ------------");
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine("{0} --- {1} --- {2}", car.Description, car.ModelYear, car.DailyPrice);
            }

        }
    }
}
