using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework;
using System;

namespace UI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EFCarDal());
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Description);
            }
             

            CarManager carManager3 = new CarManager(new EFCarDal());

            carManager3.Add(new Entities.Concrete.Car { Id = 2, BrandId = 1, ColorId = 1, DailyPrice = 200, Description = "BMW", ModelYear = 2022 });


        }
    }
}
