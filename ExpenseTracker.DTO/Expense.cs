﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseTracker.DTO
{
    public class Expense : IDTOEntity
    {
        public int Id { get; set; }

        public DateTime ExpenseDate { get; set; }

        public string Description { get; set; }

        public int ExpenseGroupId { get; set; }

        public decimal Amount { get; set; }


    }
}
