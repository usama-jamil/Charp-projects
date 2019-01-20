﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Lib.Models
{
  public  class Expense
    {
        public int Id { get; set; }

        public string Title { get; set; }
        public int BillNo { get; set; }
        public string Description { get; set; }

        public decimal Amount { get; set; }

        public DateTime Date { get; set; } = DateTime.Today;

        public PaymentMethod PaymentMethod { get; set; }

    }
}
