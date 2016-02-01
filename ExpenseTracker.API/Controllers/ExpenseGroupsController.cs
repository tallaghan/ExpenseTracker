using ExpenseTracker.Common;
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

        IRepository<DTO.ExpenseGroup> _repository;
        ExpenseGroupMapper _expenseGroupFactory = new ExpenseGroupMapper();

        public ExpenseGroupsController(IRepository<DTO.ExpenseGroup> repository)
        {
            _repository = repository;
        }

        public IHttpActionResult Get()
        {
            try
            {
                var expenseGroups = _repository.GetAll();

                return Ok(expenseGroups.ToList());
            } catch (Exception)
            {
                return InternalServerError();
            }
        }
    }
}
