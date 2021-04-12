using System;
using System.Collections.Generic;

#nullable disable

namespace CoreWebAppDBF.Models
{
    public partial class Employee
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public decimal? Salary { get; set; }
        public int DeptId { get; set; }

        public virtual Department Dept { get; set; }
    }
}
