using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //Test();
            TestDto();

        }

        private static void TestDto()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetCarDetails())
            {
                Console.WriteLine("Car Name : {0}--> Brand Name : {1}--> Color Name : {2}--> Daily Price : {3}", car.CarName, car.BrandName, car.ColorName, car.DailyPrice);
            }
        }

        private static void Test()
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());

            foreach (var c in carManager.GetAll())
            {
                Console.WriteLine(c.Description);
            }
        }
    }
}
