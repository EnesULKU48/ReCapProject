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
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public void Add(Car car)
        {
            if (car.DailyPrice>0 && car.Description.Length>=2)
            {
                _carDal.Add(car);
                Console.WriteLine("Araba başarıyla eklendi");
            }
            else
            {
                Console.WriteLine("Günlük fiyatı 0'dan büyük ve en az 2 karakter olamlı");
            }
        }

        public void Delete(Car car)
        {
            _carDal.Delete(car);
        }

        public void Update(Car car)
        {
            if (car.DailyPrice > 0 && car.Description.Length >= 2)
            {
                _carDal.Update(car);
                Console.WriteLine("Araba başarıyla güncellendi");
            }
            else
            {
                Console.WriteLine("Günlük fiyatı 0'dan büyük ve en az 2 karakter olamlı");
            }
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public List<Car> GetCarsByBrandId(int id)
        {
            return _carDal.GetAll(b=> b.BrandId==id);
        }

        public List<Car> GetCarsByColorId(int id)
        {
            return _carDal.GetAll(c=> c.ColorId==id);
        }

    }
}
