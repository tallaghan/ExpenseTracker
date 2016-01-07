using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExpenseTracker.DTO;
using ExpenseTracker.Repository.Entities;

namespace ExpenseTracker.Repository.Factories
{
    public class ExpenseGroupMapper : IExpenseTrackerMapper
    {

        public ExpenseGroupMapper()
        {

        }

        public IDTOEntity CreateDTOFromEntity(IEntity entity)
        {

            Entities.ExpenseGroup expenseGroup = (Entities.ExpenseGroup)entity;

            return new DTO.ExpenseGroup()
            {
                Description = expenseGroup.Description,
                IsActive = true,
                Title = expenseGroup.Title
            };
        }

        public IEntity CreateEntityFromDTO(IDTOEntity entity)
        {

            DTO.ExpenseGroup expenseGroup = (DTO.ExpenseGroup)entity;

            return new Entities.ExpenseGroup()
            {
                Description = expenseGroup.Description,
                IsActive = true,
                Title = expenseGroup.Title
            };
        }

    }

}
