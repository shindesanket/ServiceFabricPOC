﻿using System;
using System.Collections.Generic;

namespace EmployeeMicroservice.Models
{
    public partial class Employee
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public int? EmpAge { get; set; }
        public string EmpSalary { get; set; }
        public string EmpEmail { get; set; }
    }
}
