using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal
    {
        //List<Car> _cars;
        //public InMemoryCarDal()
        //{
        //    _cars = new List<Car> {
        //        new Car{Id=1, ColorId=10001, BrandId=10, ModelYear=1998, DailyPrice=35000, Descriptions="Dizel"},
        //        new Car{Id=2, ColorId=10002, BrandId=11, ModelYear=1999, DailyPrice=45000, Descriptions="Benzin"},
        //        new Car{Id=3, ColorId=10003, BrandId=12, ModelYear=2000, DailyPrice=55000, Descriptions="Dizel"},
        //        new Car{Id=4, ColorId=10004, BrandId=13, ModelYear=2010, DailyPrice=105000, Descriptions="Benzin"},
        //        new Car{Id=5, ColorId=10005, BrandId=14, ModelYear=2021, DailyPrice=175000, Descriptions="Dizel"}

        //    };
        //}
        //public void Add(Car car)
        //{
        //    _cars.Add(car);
        //}

        //public void Delete(Car car)
        //{
        //    Car carToDelete = _cars.SingleOrDefault(c=> c.Id ==car.Id);

        //    _cars.Remove(carToDelete);
        //}

        //public Car Get(Expression<Func<Car, bool>> filter = null)
        //{
        //    throw new NotImplementedException();
        //}

        //public List<Car> GetAll()
        //{
        //    return _cars;
        //}

        //public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        //{
        //    throw new NotImplementedException();
        //}

        //public Car GetById(int id)
        //{
        //    return _cars.SingleOrDefault(c => c.Id == id);
        //}

        //public void Update(Car car)
        //{
        //    Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
        //    carToUpdate.ColorId = car.ColorId;
        //    carToUpdate.DailyPrice = car.DailyPrice;
        //    carToUpdate.Descriptions = car.Descriptions;
        //    carToUpdate.ModelYear = car.ModelYear;
        //    carToUpdate.BrandId = car.BrandId;
        //}
    }
}
