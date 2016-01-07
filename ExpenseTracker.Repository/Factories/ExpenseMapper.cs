using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExpenseTracker.Repository.Entities;
using ExpenseTracker.DTO;
using System.Data.Entity.Core.Metadata.Edm;

namespace ExpenseTracker.Repository.Factories
{
    public class ExpenseMapper : IExpenseTrackerMapper
    {

        public ExpenseMapper()
        {

        }

        public DTO.IDTOEntity CreateDTOFromEntity(Entities.IEntity entity)
        {

            Entities.Expense expense = (Entities.Expense)entity;

            return new DTO.Expense()
            {
                Amount = expense.Amount,
                ExpenseDate = expense.ExpenseDate,
                Description = expense.Description,
                ExpenseGroupId = expense.ExpenseGroupId
            };
        }

        public Entities.IEntity CreateEntityFromDTO(DTO.IDTOEntity entity)
        {

            DTO.Expense expense = (DTO.Expense)entity;

            return new Entities.Expense()
            {
                Amount = expense.Amount,
                ExpenseDate = expense.ExpenseDate,
                Description = expense.Description,
                ExpenseGroupId = expense.ExpenseGroupId
            };
        }



    }

}
