using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExpenseTracker.Repository.Entities;

namespace ExpenseTracker.Repository.Factories
{
    public class ExpenseGroupFactory
    {

        public ExpenseGroupFactory()
        {

        }

        public DTO.ExpenseGroup CreateExpenseGroup(ExpenseGroup expenseGroup)
        {

            return new DTO.ExpenseGroup()
            {
                 Description = expenseGroup.Description,
                 IsActive = true,
                 Title = expenseGroup.Title
            };
        }


        public ExpenseGroup CreateExpenseGroup(DTO.ExpenseGroup expenseGroup)
        {

            return new ExpenseGroup()
            {
                Description = expenseGroup.Description,
                IsActive = true,
                Title = expenseGroup.Title
            };
        }


    }

}
