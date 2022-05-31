using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework;
using System;

namespace UI
{

    //SOLID
    //Open Closed Principle
    class Program
    {
        static void Main(string[] args)
        {
            //CarManager carManager = new CarManager(new EFCarDal());
            //foreach (var car in carManager.GetAll())
            //{
            //    Console.WriteLine(car.Description);
            //}


            //CarManager carManager3 = new CarManager(new EFCarDal());

            //carManager3.Add(new Entities.Concrete.Car { Id = 2, BrandId = 1, ColorId = 1, DailyPrice = 200, Description = "BMW", ModelYear = 2022 });

            CarManager carManager = new CarManager(new EFCarDal());
            foreach (var car in carManager.GetCarDetails())
            {
                Console.WriteLine(car.BrandName + "--" + car.ColorName); 
            }

            BrandManagerTest();
            CarManagerTest();

        }

        private static void BrandManagerTest()
        {
            BrandManager brandManager = new BrandManager(new EFBrandDal());
            foreach (var brand in brandManager.GetAll())
            {
                Console.WriteLine(brand.BrandName);
            }
        }

        private static void CarManagerTest()
        {
            CarManager carManager = new CarManager(new EFCarDal());
            foreach (var car in carManager.GetAllByCategoryId(2))
            {
                Console.WriteLine(car.Description);
            }
        }
    }
}
