using ExpenseTracker.Repository;
using ExpenseTracker.Repository.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ExpenseTracker.API.Controllers
{
    public class ExpenseGroupsController : ApiController
    {

        IExpenseTrackerRepository<DTO.ExpenseGroup> _repository;
        ExpenseGroupMapper _expenseGroupFactory = new ExpenseGroupMapper();

        public ExpenseGroupsController()
        {
            _repository = new ExpenseTrackerEFRepository<DTO.ExpenseGroup>();

        }

    }
}
