using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

namespace Business.Concrete
{
    public class CarManager :Brand,ICarService
    {
        ICarDal _carDal;
        Brand brand = new Brand();

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }
        public void Add(Car car)
        {
            if (car.DailyPrice>0 && brand.BrandName.Length>2)
            {
                _carDal.Add(car);
                Console.WriteLine("Araç Başarıyla Eklendi");
            }
            else
            {
                Console.WriteLine("Kirayı 0 giremezsiniz ve Marka yı iki karakterden fazla giriniz");
            }
            
        }

        public void Delete(Car car)
        {
            _carDal.Delete(car);
            Console.WriteLine("Araç Başarıyla Silindi");
        }

        public void Update(Car car)
        {
            _carDal.Update(car);
            Console.WriteLine("Araç Güncellendi");
        }

        public List<Car> GetAll()
        {
            
            return _carDal.GetAll();
        }

        public List<Car> GetAllByBrandId(int id)
        {
            return _carDal.GetAll(c => c.BrandId == id);
        }

        public List<Car> GetByDailyPrice(decimal min, decimal max)
        {
            return _carDal.GetAll(c => c.DailyPrice >= min && c.DailyPrice <= max);
        }

        public List<Car> GetAllByColorId(int id)
        {
            return _carDal.GetAll(c => c.ColorId == id);
        }
    }
}
