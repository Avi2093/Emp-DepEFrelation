using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Emp_DepEFrelation.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Employee> Employees { get; set; }   // the Department entity includes a collection navigation property of type ICollection<Employee>

    }
}









//At the time of seeding(inserting data) make sure to feed both the table properties at once or else due to auto increment the id value to set as{1,2,3,4,5,6,) and then {7,8,9,10,11,12,13) whwn we keep the departmentId value as 1,2,3,4,5,6 and it was 7,8,9,10