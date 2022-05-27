using Business.Concrete;
using DataAccess.Concrete;
using System;

namespace UI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Description);
            }
         
        }
    }
}
