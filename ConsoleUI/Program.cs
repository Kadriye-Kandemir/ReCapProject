using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            //BrandManager brandManager = new BrandManager(new EfBrandDal());
            //ColorManager colorManager = new ColorManager(new EfColorDal());

            //foreach (var brand in brandManager.GetAll())
            //{
            //    Console.WriteLine(brand.BrandName);
            //}

            //foreach (var color in colorManager.GetAll())
            //{
            //    Console.WriteLine(color.ColorName);
            //}

            //foreach (var car in carManager.GetAll())
            //{
            //    Console.WriteLine(car.Descriptions);
            //}
            //foreach (var car in carManager.GetAll())
            //{
            //    Console.WriteLine(car.BrandId);
            //    Console.WriteLine(car.ColorId);
            //    Console.WriteLine(car.ModelYear);
            //}


            //carManager.Add(new Car {ColorId=2, BrandId=2, Descriptions = "Benzinli", DailyPrice = 500 });
            //Console.WriteLine("--------------");

            //foreach (var car in carManager.GetAll())
            //{

            //    Console.WriteLine("Günlük ücreti: " + car.DailyPrice);
            //    Console.WriteLine("Açıklaması: " + car.Descriptions);
            //    Console.WriteLine("********");
            //}
            //List<Car> cars = new List<Car>();
            //cars = carManager.GetById(id: 1005);

            //foreach (var car in cars)
            //{
            //    Console.WriteLine(car.Id);
            //}

            //carManager.Delete(new Car { Id=1005});

            Console.ReadLine();
        }

    }
}




