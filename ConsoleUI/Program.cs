using Business.Concrete;
using DataAccess.Concrete.EntityFramework;

using Entities.Concrete;
using System;


namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            
            Console.WriteLine("*********First List*********");
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Description);
            }
            
            Car carToDelete = new Car { Id = 3, BrandId = 1, ColorId = 2, ModelYear = "2021", DailyPrice = 1000, Description = "Hyundai i20" };
            carManager.Delete(carToDelete);
            Console.WriteLine("*********After Delete*********");
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Description);
            }
            
            Console.WriteLine("********Order ID********");
            foreach (var item in carManager.GetById(4))
            {
                Console.WriteLine(item.Description);
            }
            
            Car newCar = new Car() { Id = 7, BrandId = 3, DailyPrice = 2000, ModelYear = "2023", ColorId = 3, Description = "Bmw 530" };
            carManager.Add(newCar);
            Console.WriteLine("********After Add********");
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Description);
            }
        }
    }
}
