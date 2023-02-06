﻿using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>()
            {
                new Car{Id=1,BrandId=1,ColorId=2,ModelYear="2020",DailyPrice=2500,Description="Hyundai Kona"},
                new Car{Id=2,BrandId=1,ColorId=2,ModelYear="2018",DailyPrice=2000,Description="Hyundai Accent"},
                new Car{Id=3,BrandId=1,ColorId=1,ModelYear="2020",DailyPrice=2300,Description="Hyundai i20"},
                new Car{Id=4,BrandId=2,ColorId=3,ModelYear="2022",DailyPrice=3000,Description="Cupra Formentor"},
                new Car{Id=5,BrandId=3,ColorId=1,ModelYear="2017",DailyPrice=1700,Description="Skoda Karoq"},
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => car.Id == c.Id);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int carId)
        {
            return _cars.Where(c => c.Id == carId).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => car.Id == c.Id);
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;
        }
    }
}
