using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

namespace Business.Concrete
{
    public class CarManager:ICarService
    {
        private ICarDal _carDal;


        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }
        public void Add(Car car)
        {
            _carDal.Add(car);
            Console.WriteLine("Araç Başarıyla Eklendi");
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

    }
}
