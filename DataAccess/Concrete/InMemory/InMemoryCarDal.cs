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
        List<Cars> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Cars> {
             new Cars{BrandId=1, CarId=1, ColorId=1, ModelYear=2011, DailyPrice=400, Description="Renault-Latıtude => Sedan , 1.5cc "},
             new Cars{BrandId=1, CarId=2, ColorId=3, ModelYear=2019, DailyPrice=300, Description="Renault-Clıo => Hatchback , 1.3cc"},
             new Cars{BrandId=2, CarId=3, ColorId=4, ModelYear=2012, DailyPrice=900, Description="BMW-X7 => Jip , 2.0cc"},
             new Cars{BrandId=3, CarId=4, ColorId=1, ModelYear=2008, DailyPrice=600, Description="Peugeot-3008 => SUV , 1.6cc"},
             new Cars{BrandId=4, CarId=6, ColorId=2, ModelYear=2015, DailyPrice=1000, Description="AUDI-A7 => Coupe , 2.5cc "},
             new Cars{BrandId=5, CarId=7, ColorId=4, ModelYear=2000, DailyPrice=200, Description="Skoda-Octavia => Sedan , 1.4cc"},
            };
        }

        public void Add(Cars car)
        {
            _cars.Add(car);
        }

        public void Delete(Cars car)
        {
            Cars carToDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            _cars.Remove(carToDelete);
        }

        public void Update(Cars car)
        {
            Cars carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpdate.Description = car.Description;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.CarId = car.CarId;
            carToUpdate.BrandId = car.BrandId;
        }

        public List<Cars> GetAll()
        {
            return _cars;
        }

        public List<Cars> GetAllByBrand(int brandId)
        {
            return _cars.Where(c => c.BrandId == brandId).ToList();
        }

    }
}
