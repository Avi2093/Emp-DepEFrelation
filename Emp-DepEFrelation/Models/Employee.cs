using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Emp_DepEFrelation.Models
{
   
        public class Employee
        {
            public int Id { get; set; }
            public string EmployeeName { get; set; }

            //Navigation Properties
            public int DepartmentId { get; set; }
            public Department Department { get; set; }
        
    }
}
