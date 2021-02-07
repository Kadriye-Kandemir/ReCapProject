using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, CarDBContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (CarDBContext context = new CarDBContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands
                             on c.BrandId equals b.BrandId
                             join clr in context.Colors
                             on c.ColorId equals clr.ColorId

                             //select new CarDetailDto
                             //{

                             //    BrandName = b.BrandName,
                             //    ColorName = clr.ColorName,
                             //    DailyPrice = c.DailyPrice,
                             //    //CarName = c.CarName,                                 
                             //};
                             select new CarDetailDto 
                             {
                                 CarId= c.Id,
                                 BrandId=c.BrandId,
                                 BrandName=b.BrandName,
                                 ColorId=c.ColorId,
                                 ColorName=clr.ColorName,
                                 DailyPrice = c.DailyPrice,
                                 Descriptions =c.Descriptions
                             };

                return result.ToList();
            }
        }
    }
}
