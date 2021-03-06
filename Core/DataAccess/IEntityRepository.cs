﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess
{
    //new() :newlenebilir olmalı demek
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        //T GetById(int id);
        List<T> GetAll(Expression<Func<T, bool>> filter = null); //filtre vermemize yarıyor
        T Get(Expression<Func<T, bool>> filter);
    }
}
