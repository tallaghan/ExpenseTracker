using ExpenseTracker.Repository.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using ExpenseTracker.Repository.Entities;

namespace ExpenseTracker.Repository
{
    public class ExpenseTrackerEFRepository<T> : IExpenseTrackerRepository<T>
    {
        private ExpenseTrackerEntities db = new ExpenseTrackerEntities();

        public ExpenseTrackerEFRepository()
        {


        }

        public void Add(T newEntity)
        {
            throw new NotImplementedException();
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
