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
            //CarManager carManager = new CarManager(new EfCarDal());
            //BrandManager brandManager = new BrandManager(new EfBrandDal());
            //ColorManager colorManager = new ColorManager(new EfColorDal());

            Console.WriteLine(" <<< **************************** <<< CarDB List >>> **************************** >>> \n");

            //CarDescriptionsTest();
            //CarColorNameTest();
            //CarBrandNameTest();
            //CarAddTest();      //(çalıştırma!!)
            //CarDetailsTest();
            //BrandUpdateTest();  //Bmw güncelleme çalıştırıldı daha önce
            //ColorAddTest();  //Yeni renk eklendi
            //ColorDeleteTest();  //Eklenen kırmızı renk silindi


            Console.ReadLine();
        }

        private static void ColorDeleteTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            colorManager.Delete(new Color { ColorId = 1002, ColorName = "Kırmızı" });
        }

        private static void ColorAddTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            colorManager.Add(new Color {ColorName = "Kırmızı" });
        }

        private static void BrandUpdateTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            brandManager.Update(new Brand { BrandId = 2, BrandName = "Bmw" });
        }

        private static void CarDetailsTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetCarDetails())
            {
                Console.WriteLine(car.CarId + "/" + car.BrandName + "/" + car.ColorName+ "/" + car.Descriptions);
            }
        }

        private static void CarAddTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            carManager.Add(new Car { ColorId = 2, BrandId = 2, Descriptions = "Benzinli", DailyPrice = 500 });
            Console.WriteLine("--------------");
        }

        private static void CarBrandNameTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            foreach (var brand in brandManager.GetAll())
            {
                Console.WriteLine(brand.BrandName);
            }
        }

        private static void CarColorNameTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            foreach (var color in colorManager.GetAll())
            {
                Console.WriteLine(color.ColorName);
            }
        }

        private static void CarDescriptionsTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Descriptions);
            }
        }
    }
}




