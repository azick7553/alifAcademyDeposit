using System;
using System.Collections.Generic;
using System.Text;

namespace alifAcademyDeposit.Models
{
    public class Transaction
    {
        public int Id { get; set; }
        public int AccountId { get; set; }
        public decimal Amount { get; set; }
        public DateTime TransactionDate { get; set; } = DateTime.Now;
    }
}
