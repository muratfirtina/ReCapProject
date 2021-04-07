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
        IDataResult<CarImage> Get(int id);
        IDataResult<List<CarImage>> GetAll();
    }
}
