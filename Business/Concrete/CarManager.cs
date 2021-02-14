﻿using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public IResult Add(Car car)
        {
            if (car.DailyPrice < 0)
            {
                //magic strings
                return new ErrorResult(Messages.AddErrorMessage);
            }
            _carDal.Add(car);
            return new SuccessResult(Messages.AddSuccessMessage);
        }

        public IResult Delete(Car car)
        {
            _carDal.Delete(car);
            return new SuccessResult();            
        }

        public IDataResult<List<Car>> GetAll()
        {
            if (DateTime.Now.Hour ==17)
            {
                return new ErrorDataResult<List<Car>>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(),Messages.Listed);
        }

        public IDataResult<List<Car>> GetCarsByBrandId(int id)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.BrandId == id),Messages.Listed);
        }

        public IDataResult<List<Car>> GetCarsByColorId(int id)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.ColorId == id),Messages.Listed);
        }

        public IDataResult<List<Car>> GetByDailyPrice(decimal min, decimal max)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.DailyPrice >= min && c.DailyPrice <= max),Messages.Listed);
        }

       
        public IDataResult<List<Car>> GetByModelYear(string year)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.ModelYear.Contains(year) == true),Messages.Listed);
        }

        public IResult Update(Car car)
        {
              _carDal.Update(car);
              return new SuccessResult(Messages.UpdateSuccessMessage);            
        }

        public IDataResult<Car> Get(int id)
        {
            if (id > 0)
            {
                return new SuccessDataResult<Car>(_carDal.Get(p => p.Id == id), Messages.CarExist);
            }
            else
            {
                return new ErrorDataResult<Car>(_carDal.Get(p => p.Id != id), Messages.CarNoExist);
            }
        }

        public IDataResult<List<CarDetailDto>> GetCarDetails()
        {
            if (DateTime.Now.Hour == 18)
            {
                return new ErrorDataResult<List<CarDetailDto>>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetails());
        }

    }
}
