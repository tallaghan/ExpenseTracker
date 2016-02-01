using ExpenseTracker.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseTracker.Common
{
    public interface IRepository<T> where T : IDTOEntity
    {
        IQueryable<T> GetAll();

        void Add(T newItem);

        void Remove(T item);

    }
}
