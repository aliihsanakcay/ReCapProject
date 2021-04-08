using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{ CarId=1, BrandId=1, ColorId=2, ModelYear=1987, DailyPrice=500, Description="Mercedes"},
                new Car{ CarId=2, BrandId=1, ColorId=3, ModelYear=1987, DailyPrice=500, Description="volkswagen"},
                new Car{ CarId=3, BrandId=3, ColorId=1, ModelYear=1987, DailyPrice=500, Description="Audi"},
                new Car{ CarId=4, BrandId=3, ColorId=5, ModelYear=1987, DailyPrice=500, Description="Renault"},
                new Car{ CarId=5, BrandId=3, ColorId=5, ModelYear=1987, DailyPrice=500, Description="Opel"},
                new Car{ CarId=6, BrandId=2, ColorId=4, ModelYear=1987, DailyPrice=500, Description="Toyota"},
                new Car{ CarId=7, BrandId=2, ColorId=1, ModelYear=1987, DailyPrice=500, Description="Honda"},
                new Car{ CarId=8, BrandId=4, ColorId=2, ModelYear=1987, DailyPrice=500, Description="Hundai"}
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c=>c.CarId == car.CarId);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetByColorId(int colorId)
        {
            return _cars.Where(c => c.ColorId == colorId).ToList();
        }

        public List<Car> GetByBrandId(int brandId)
        {
            return _cars.Where(c => c.BrandId == brandId).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.Description = car.Description;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.ModelYear = car.ModelYear;
        }
    }
}
