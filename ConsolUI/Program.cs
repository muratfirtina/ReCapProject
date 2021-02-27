using System;
using System.Collections.Generic;
using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

namespace ConsolUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());
            Console.WriteLine("Verilen bilgilerle yeni arabamızı eklemeye çalışıyoruz.\n");
            carManager.Add(new Car
            {
                CarId = 11,
                BrandId = 2,
                ColorId = 2,
                ModelYear = "2018",
                DailyPrice = 500,
                Description = "Seçilen araç kiralanır, muadili yoktur."
            });
            carManager.Update(new Car
            {
                CarId = 5,
                BrandId = 2,
                ColorId = 2,
                ModelYear = "2017",
                DailyPrice = 212,
                Description = "Seçilen araç kiralanır, muadili yoktur."
            });
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.ModelYear + " " + car.Description);
            }
        }
    }
}
