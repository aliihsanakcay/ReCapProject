using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _icarDal;
        public CarManager(ICarDal icarDal)
        {
            _icarDal = icarDal;
        }

        public void Add(Car car)
        {
            _icarDal.Add(car);
        }

        public void Delete(Car car)
        {
            _icarDal.Delete(car);
        }

        public List<Car> GetAll()
        {
            return _icarDal.GetAll();
        }

        public List<Car> GetByBrandId(int brandId)
        {
            return _icarDal.GetByBrandId(brandId);
        }

        public List<Car> GetByColorId(int colorId)
        {
            return _icarDal.GetByColorId(colorId);
        }

        public void Update(Car car)
        {
            _icarDal.Update(car);
        }
    }
}
