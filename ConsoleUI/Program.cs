using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using System;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore.Migrations.Operations;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //RentalDetailTest();
            //RentalAddTest();
            //RentalTest();
            //CustomerAddTest();
            //UserAddedTest();
            //CarDetailTest2();
            //CarAdd();
            //DailyPriceTest();
            //BrandNameTest();
            //CarDetailsTest();
        }

        private static void RentalDetailTest()
        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            foreach (var rent in rentalManager.GetRentalDetails().Data)
            {
                Console.WriteLine(rent.BrandName + "/" + rent.CarName
                                  + "/" + rent.ColorName + "/" + rent.Description
                                  + "/" + rent.DailyPrice + "/" + rent.ReturnDate
                                  + "/" + rent.CustomerName);
            }
        }

        private static void CustomerAddTest()
        {
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            var result = customerManager.Add(new Customer
            {
                UserId = 1,
                CompanyName = "Storms"
            });
            Console.WriteLine(result.Success);
        }

        private static void RentalAddTest()
        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            var result = rentalManager.Add(new Rental
            {
                CarId = 13,
                CustomerId = 1,
                RentDate = new DateTime(2021,02,01,10,30,0),
                ReturnDate = new DateTime(2021,02,07,10,30,0)
            });
            Console.WriteLine(result.Success);
        }

        private static void RentalTest()
        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            var result = rentalManager.GetAll();
            if (result.Success)
            {
                foreach (var rental in result.Data)
                {
                    Console.WriteLine(rental.CarId + " " + rental.CustomerId + " " + rental.RentDate + " " + rental.ReturnDate);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void UserAddedTest()
        {
            UserManager userManager = new UserManager(new EfUserDal());
            var result = userManager.Add(new User
            {
                FirstName = "VERA",
                LastName = "FIRTINA",
                Email = "verafirtina@hotmail.com",
                Password = "123456"
            });
            Console.WriteLine(result.Success);
        }

        private static void CarDetailTest2()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            var result = carManager.GetCarDetails();

            if (result.Success)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine(car.BrandName + "/" + car.CarName + "/" + car.ColorName + "/" + car.DailyPrice);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void CarAdd()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            var result = 
            carManager.Add(new Car
            {
                BrandId = 7,
                ColorId = 2,
                CarName = "Megane",
                ModelYear = "2018",
                Description = "Düz Vites",
                DailyPrice = 250
            });
            
            Console.WriteLine(result.Message);
        }

        private static void CarDetailsTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetCarDetails().Data)
            {
                Console.WriteLine(car.BrandName + "/" + car.CarName + "/" + car.ColorName + "/" + car.DailyPrice);
            }
        }

        private static void BrandNameTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            foreach (var brand in brandManager.GetAll().Data)
            {
                Console.WriteLine(brand.BrandName);
            }
        }

        private static void DailyPriceTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            foreach (var car in carManager.GetAll().Data)
            {
                Console.WriteLine(car.DailyPrice);
            }
        }
    }
}
