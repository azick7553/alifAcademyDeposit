﻿using System;
using System.Collections.Generic;
using System.Text;

namespace alifAcademyDeposit.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string DocumentNumber { get; set; }
    }
}
