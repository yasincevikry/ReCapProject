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
            var colorResult1 = colorManager.Add(new Color { Name = "Kırmızı" });
            if (colorResult1.Success)
            {
                Console.WriteLine(colorResult1.Message);
            }
            else
            {
                Console.WriteLine(colorResult1.Message);
            }
            Console.WriteLine("****************************");

            var colorResult2 = colorManager.Delete(new Color { Id = 2002, Name = "Kırmızı" });
            if (colorResult2.Success)
            {
                Console.WriteLine(colorResult2.Message);
            }
            else
            {
                Console.WriteLine(colorResult2.Message);
            }
            Console.WriteLine("****************************");

            var colorResult3 = colorManager.Update(new Color { Id = 3002, Name="Pembe" });
            if (colorResult3.Success)
            {
                Console.WriteLine(colorResult3.Message);
            }
            else
            {
                Console.WriteLine(colorResult3.Message);
            }
            Console.WriteLine("****************************");
            var colorResult4 = colorManager.GetAll();
            if (colorResult4.Success)
            {
                foreach (var color in colorResult4.Data)
                {
                    Console.WriteLine(color.Name);
                }
                Console.WriteLine(colorResult4.Message);
            }
            else
            {
                Console.WriteLine(colorResult4.Message);
            }
            Console.WriteLine("****************************");
            var colorResult5 = colorManager.GetById(4);

            if (colorResult5.Success)
            {
                foreach (var color in colorResult5.Data)
                {
                    Console.WriteLine(color.Name);
                }
                Console.WriteLine(colorResult5.Message);
            }
            else
            {
                Console.WriteLine(colorResult5.Message);
            }
        }

        private static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            
            var brandResult1 = brandManager.Add(new Brand { Name = "Alfa Romeo" });
            if (brandResult1.Success)
            {
                Console.WriteLine(brandResult1.Message);
            }
            else
            {
                Console.WriteLine(brandResult1.Message);
            }
            
            Console.WriteLine("************************");
            var brandResult2 = brandManager.Delete(new Brand { Id = 1002, Name = "Alfa Romeo" });

            if (brandResult2.Success)
            {
                Console.WriteLine(brandResult2.Message);
            }
            else
            {
                Console.WriteLine(brandResult2.Message);
            } 

            var brandResult3 = brandManager.Update(new Brand { Id = 5, Name = "Audi" });
            if (brandResult3.Success)
            {
                Console.WriteLine(brandResult3.Message);
            }
            else
            {
                Console.WriteLine(brandResult3.Message);
            }
            
            Console.WriteLine("************************");
            
            var brandResult4 = brandManager.GetAll();
            if (brandResult4.Success)
            {
                foreach (var brand in brandResult4.Data)
                {
                    Console.WriteLine(brand.Name);
                }
                Console.WriteLine(brandResult4.Message);
            }
            else
            {
                Console.WriteLine(brandResult3.Message);
            }

            var brandResult5 = brandManager.GetById(1);
            if (brandResult5.Success)
            {
                foreach (var brand in brandResult5.Data)
                {
                    Console.WriteLine(brand.Name);
                }
                Console.WriteLine(brandResult5.Message);
            }
            else
            {
                Console.WriteLine(brandResult5.Message);
            }  
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            var carResult1 = carManager.Add(new Car { BrandId = 1, ColorId = 2, DailyPrice = 3000, ModelYear = "2022", Description = "Santa Fe" });
            if (carResult1.Success)
            {
                Console.WriteLine(carResult1.Message);
            }
            else
            {
                Console.WriteLine(carResult1.Message);
            }
            Console.WriteLine("************************");

            var carResult2 = carManager.Delete(new Car { Id = 7 });
            if (carResult2.Success)
            {
                Console.WriteLine(carResult2.Message); 
            }
            else
            {
                Console.WriteLine(carResult2.Message);
            }
            Console.WriteLine("************************");

            var carResult3 = carManager.Update(new Car { Id = 4, BrandId = 5, ColorId = 2, ModelYear = "2023", DailyPrice = 1850, Description = "Formentor" });
            if (carResult3.Success)
            {
                Console.WriteLine(carResult3.Message);
            }
            else
            {
                Console.WriteLine(carResult3.Message);
            }
            Console.WriteLine("************************");

            var carResult4 = carManager.GetCarsByColorId(3);
            if(carResult4.Success)
            {
                foreach (var car in carResult4.Data)
                {
                    Console.WriteLine(car.Description);
                }
                Console.WriteLine(carResult4.Message);
            }
            else
            {
                Console.WriteLine(carResult4.Message);
            }
            Console.WriteLine("************************");

            var carResult5 = carManager.GetAll();
            if (carResult5.Success)
            {
                foreach (var car in carResult5.Data)
                {
                    Console.WriteLine(car.Description);
                }
                Console.WriteLine(carResult5.Message);
            }
            else
            {
                Console.WriteLine(carResult5.Message);
            }
            var carResult6 = carManager.GetCarsByBrandId(1);
            if (carResult6.Success)
            {
                foreach (var car in carResult6.Data)
                {
                    Console.WriteLine(car.Description);
                }
                Console.WriteLine(carResult6.Message);
            }
            else
            {
                Console.WriteLine(carResult6.Message);
            }
        }
    }
}
