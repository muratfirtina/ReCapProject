using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Results;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;

namespace Business.Abstract
{
    public interface ICarImageService
    {
        IResult Add(CarImage carImage, IFormFile iFormFile);
        IResult Update(CarImage carImage, IFormFile iFormFile);
        IResult Delete(CarImage carImage);
        IDataResult<CarImage> GetCarImageById(int id);
        IDataResult<List<CarImage>> GetImagesByCarId(int carId);
        IDataResult<List<CarImage>> GetAll();
    }
}
