using ExpenseTracker.Repository.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using ExpenseTracker.Repository.Entities;
using ExpenseTracker.DTO;
using System.Data.Entity.Core.Metadata.Edm;
using ExpenseTracker.Common;

namespace ExpenseTracker.Repository
{
    public class ExpenseGroupsEFRepository : IRepository<DTO.ExpenseGroup>
    {
        private ExpenseTrackerEntities db = new ExpenseTrackerEntities();

        private IExpenseTrackerMapper _mapper;

        public ExpenseGroupsEFRepository()
        {
            ExpenseMapperFactory<DTO.ExpenseGroup> mapperFactory = new ExpenseMapperFactory<DTO.ExpenseGroup>();

            _mapper = mapperFactory.CreateInstance();

    }

        public IQueryable<DTO.ExpenseGroup> GetAll() 
        {

            IQueryable<DTO.ExpenseGroup> items = (from c in db.ExpenseGroups
                                                  select _mapper.CreateDTOFromEntity(c) as DTO.ExpenseGroup);

            return items;

        }

        public void Add(DTO.ExpenseGroup newItem)
        {
            Entities.ExpenseGroup newEntity = _mapper.CreateEntityFromDTO(newItem) as Entities.ExpenseGroup;

            db.ExpenseGroups.Add(newEntity);

            db.SaveChanges();

        }

        public IQueryable<DTO.ExpenseGroup> Find(Expression<Func<DTO.ExpenseGroup, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public void Remove(DTO.ExpenseGroup entity)
        {
            throw new NotImplementedException();
        }
    }
}
