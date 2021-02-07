using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService :IBaseService<Car>
    {
       
        List<Car> GetCarsByColorId(int id);
        List<Car> GetCarsByBrandId(int id);
        List<Car> GetByDailyPrice(decimal min, decimal max);
        List<Car> GetByModelYear(string year);

        List<CarDetailDto> GetCarDetails();
    }
}
