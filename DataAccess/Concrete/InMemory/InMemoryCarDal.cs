﻿using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car> {
             new Car{BrandId=1, CarId=1, ColorId=1, ModelYear=2011, DailyPrice=400, Description="Renault-Latıtude => Sedan , 1.5cc "},
             new Car{BrandId=1, CarId=2, ColorId=3, ModelYear=2019, DailyPrice=300, Description="Renault-Clıo => Hatchback , 1.3cc"},
             new Car{BrandId=2, CarId=3, ColorId=4, ModelYear=2012, DailyPrice=900, Description="BMW-X7 => Jip , 2.0cc"},
             new Car{BrandId=3, CarId=4, ColorId=1, ModelYear=2008, DailyPrice=600, Description="Peugeot-3008 => SUV , 1.6cc"},
             new Car{BrandId=4, CarId=6, ColorId=2, ModelYear=2015, DailyPrice=1000, Description="AUDI-A7 => Coupe , 2.5cc "},
             new Car{BrandId=5, CarId=7, ColorId=4, ModelYear=2000, DailyPrice=200, Description="Skoda-Octavia => Sedan , 1.4cc"},
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            _cars.Remove(carToDelete);
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpdate.Description = car.Description;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.CarId = car.CarId;
            carToUpdate.BrandId = car.BrandId;
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAllByBrand(int brandId)
        {
            return _cars.Where(c => c.BrandId == brandId).ToList();
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }
    }
}
