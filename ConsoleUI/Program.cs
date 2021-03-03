using Business.Concrete;
using Business.Constants;
using Core.Entities.Concrete;
using DataAccess.Abstract;
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
            //RentDetailsTest();
            UserAddition();

            Console.ReadLine();
        }

        private static void UserAddition()
        {
            UserManager userManager = new UserManager(new EfUserDal());
            Console.WriteLine("First Name: ");
            string userNameForAdd = Console.ReadLine();
            Console.WriteLine("Last Name: ");
            string userSurnameForAdd = Console.ReadLine();
            Console.WriteLine("Email Name: ");
            string userEmailForAdd = Console.ReadLine();
            Console.WriteLine("Password Name: ");
            string userPasswordForAdd = Console.ReadLine();


            
           
        }
        private static void RentDetailsTest()
        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            var xxx = rentalManager.GetRentalDetails();
            if (xxx.Success == true)
            {
                foreach (var rent in xxx.Data)
                {
                    Console.WriteLine("CustomerName:{0} - CarName:{1} - CompanyName:{2} - RentDate:{3} - ReturnDate:{4}",
                        rent.CustomerName, rent.CarName, rent.CompanyName, rent.RentDate, rent.ReturnDate);
                }
                Console.WriteLine(Messages.Listed);
            }
            else
            {
                Console.WriteLine(Messages.ErrorMessage);
            }
        }

        private static void ColorDeleteTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            colorManager.Delete(new Color { ColorId = 3002});
        }

        private static void ColorAddTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            Console.Write("Enter Color name: "); 
            string addedColor = Console.ReadLine();
            colorManager.Add(new Color {ColorName = addedColor });
            
           
        }

        private static void BrandUpdateTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            brandManager.Update(new Brand { BrandId = 2, BrandName = "Bmw" });
        }

        private static void CarDetailsTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            var result = carManager.GetCarDetails();

            if (result.Success==true)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine(car.CarId + "/" + car.BrandName + "/" + car.ColorName + "/" + car.Descriptions);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
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
            foreach (var brand in brandManager.GetAll().Data)
            {
                Console.WriteLine(brand.BrandName);
            }
        }

        private static void CarColorNameTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            foreach (var color in colorManager.GetAll().Data)
            {
                Console.WriteLine(color.ColorName);
            }
        }

        private static void CarDescriptionsTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetAll().Data)
            {
                Console.WriteLine(car.Descriptions);
            }
        }
    }
}




