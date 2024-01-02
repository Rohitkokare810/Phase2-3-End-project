using System;
using System.Collections.Generic;

namespace WebApplEMS2.Models
{
    public partial class Employee
    {
        public int Eid { get; set; }
        public string? Fname { get; set; }
        public string? Lname { get; set; }
        public DateTime? Doj { get; set; }
        public double? Salary { get; set; }
    }
}
