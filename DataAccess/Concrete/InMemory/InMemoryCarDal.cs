using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Concrete.InMemory
{

    public class InMemoryCarDal:ICarDal
    {
        List<Car> _cars;
        
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{CarId = 1, BrandId  = 1, ColorId = 1, CarName = "deneme1", ModelYear = "2020", DailyPrice = 175, Description = "Muadili olabilir"},
                new Car{CarId = 2, BrandId  = 1, ColorId = 2, CarName = "deneme2", ModelYear = "2021", DailyPrice = 200, Description = "Muadili olabilir"},
                new Car{CarId = 3, BrandId  = 2, ColorId = 2, CarName = "deneme3", ModelYear = "2019", DailyPrice = 550, Description = "Seçilen araç kiralanır, muadili yoktur."},
                new Car{CarId = 4, BrandId  = 2, ColorId = 4, CarName = "deneme4", ModelYear = "2020", DailyPrice = 600, Description = "Seçilen araç kiralanır, muadili yoktur."},
                new Car{CarId = 5, BrandId  = 3, ColorId = 4, CarName = "deneme5", ModelYear = "2018", DailyPrice = 500, Description = "Seçilen araç kiralanır, muadili yoktur. "},
                new Car{CarId = 6, BrandId  = 3, ColorId = 2, CarName = "deneme6", ModelYear = "2021", DailyPrice = 550, Description = "Seçilen araç kiralanır, muadili yoktur. "},
                new Car{CarId = 7, BrandId  = 4, ColorId = 1, CarName = "deneme7", ModelYear = "2021", DailyPrice = 250, Description = "Muadili olabilir"},
                new Car{CarId = 8, BrandId  = 4, ColorId = 3, CarName = "deneme8", ModelYear = "2017", DailyPrice = 200, Description = "Muadili olabilir"},
                new Car{CarId = 9, BrandId  = 5, ColorId = 1, CarName = "deneme9", ModelYear = "2021", DailyPrice = 220, Description = "Muadili olabilir"},
                new Car{CarId = 10, BrandId  = 5, ColorId = 4, CarName = "deneme10", ModelYear = "2020", DailyPrice = 200, Description = "Muadili olabilir"},
            };
            
        }
        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int Id)
        {
            return _cars.Where(c => c.CarId == Id).ToList();
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            _cars.Remove(carToDelete);
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.CarName = car.CarName;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.Description = car.Description;

        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }
    }
}
