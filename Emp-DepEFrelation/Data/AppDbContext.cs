using Emp_DepEFrelation.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Emp_DepEFrelation.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext>options):base(options)    //Constructor
        {

        }
       public DbSet<Department> Departments { get; set; } //Here Department is Model class & Departments is the table name that will be created in sql
       public DbSet<Employee> Employees { get; set; }


    }
}
