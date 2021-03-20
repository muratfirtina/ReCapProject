using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using System.Linq.Expressions;
using Entities.DTOs;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, ReCapContext>, IRentalDal
    {
        public List<RentalDetailDto> GetRentDetails()
        {
            using (ReCapContext context = new ReCapContext())
            {
                var result = from r in context.Rentals
                    join c in context.Cars on r.CarId equals c.CarId
                    join cu in context.Customers on r.CustomerId equals cu.UserId
                    join b in context.Brands on c.BrandId equals b.BrandId
                    join co in context.Colors on c.ColorId equals co.ColorId 



                    select new RentalDetailDto
                    {
                        CarId = c.CarId,
                        CarName = c.CarName,
                        CustomerName = cu.CompanyName,
                        Description = c.Description,
                        DailyPrice = c.DailyPrice,
                        RentDate = r.RentDate,
                        ReturnDate = r.ReturnDate,
                        Id = r.Id,
                        UserId = r.CustomerId,
                        ColorName = co.ColorName,
                        BrandName = b.BrandName

                    };

                return result.ToList();
            }
        }
    }
}
