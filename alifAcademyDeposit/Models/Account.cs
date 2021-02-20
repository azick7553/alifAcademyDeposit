using System;
using System.Collections.Generic;
using System.Text;

namespace alifAcademyDeposit.Models
{
    public class Account
    {
        public int Id { get; set; }
        public string AccountNumber { get; set; }
        public int CustomerId { get; set; }
        public DateTime OpenDate { get; set; }
        public DateTime? CloseDate { get; set; }
    }
}
