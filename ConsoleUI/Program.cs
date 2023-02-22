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
            //CarTest();
            //BrandTest();
            //ColorTest();
        }

        private static void ColorTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            colorManager.Add(new Color { Name = "Kırmızı" });
            colorManager.Delete(new Color { Id = 3, Name = "Oltu " });
            colorManager.Update(new Color { Id = 4, Name = "Kar Beyazı" });
            foreach (var color in colorManager.GetAll())
            {
                Console.WriteLine(color.Name);
            }
            foreach (var color in colorManager.GetById(4))
            {
                Console.WriteLine(color.Name);
            }
        }

        private static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            brandManager.Add(new Brand { Name = "Alfa Romeo" });
            brandManager.Update(new Brand { Id = 5, Name = "Audi" });
            foreach (var brand in brandManager.GetAll())
            {
                Console.WriteLine(brand.Name);
            }
            foreach (var brand in brandManager.GetById(5))
            {
                Console.WriteLine(brand.Name);
            }
        }

        private static void CarTest()
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
