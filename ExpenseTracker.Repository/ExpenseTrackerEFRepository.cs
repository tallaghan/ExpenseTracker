﻿using ExpenseTracker.Repository.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using ExpenseTracker.Repository.Entities;
using ExpenseTracker.DTO;
using System.Data.Entity.Core.Metadata.Edm;
using System.Reflection;
using System.Data.Entity.Infrastructure;

namespace ExpenseTracker.Repository
{
    public abstract class ExpenseTrackerEFRepository<T> : IExpenseTrackerRepository<T> where T : IDTOEntity
    {
        private ExpenseTrackerEntities db = new ExpenseTrackerEntities();

        private IExpenseTrackerMapper _mapper;

        public ExpenseTrackerEFRepository()
        {
            ExpenseMapperFactory<T> mapperFactory = new ExpenseMapperFactory<T>();

            _mapper = mapperFactory.CreateInstance();
        }

        public abstract IQueryable<T> GetAll();

        public void Add(T newItem) 
        {
            Entities.IEntity newEntity = _mapper.CreateEntityFromDTO(newItem);

            Type entityType = newEntity.GetType();

            db.Set(entityType).Add(newEntity);

            db.SaveChanges();

        }

        public IQueryable<T> Find(Expression<Func<T, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public void Remove(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
