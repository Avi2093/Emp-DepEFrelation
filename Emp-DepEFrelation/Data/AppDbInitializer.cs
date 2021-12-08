using Emp_DepEFrelation.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Emp_DepEFrelation.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)           //Here for IApplicationBuilder It will throw an error so add namespace Microsoft.AspNetCore.Builder;
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())   //Here for CreateScopeIApplicationBuilder It will throw an error so add namespace using Microsoft.Extensions.DependencyInjection;
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();


                if (!context.Departments.Any())
                {
                    context.Departments.AddRange(
                        new Department()
                        {

                            Name = "Science"


                        },
                        new Department()
                        {

                            Name = "physics11"

                        },
                         new Department()
                         {


                             Name = "physics12"

                         },
                          new Department()
                          {

                              Name = "physics122"

                          },
                           new Department()
                           {

                               Name = "physics123"

                           },
                            new Department()
                            {

                                Name = "physics162"

                            },
                             new Department()
                             {

                                 Name = "physics162",
                             });
                    context.SaveChanges();
                }



                if (!context.Employees.Any())
                {
                    context.Employees.AddRange(
                        new Employee()
                        {
                            EmployeeName = "Sanjay",
                            DepartmentId = 21



                        },
                    new Employee()
                    {
                        EmployeeName = "Sanjay11",
                        DepartmentId = 22


                    },
                     new Employee()
                     {
                         EmployeeName = "Ravi",
                         DepartmentId = 16

                     },
                      new Employee()
                      {
                          EmployeeName = "Shakil",
                          DepartmentId = 17

                      },
                       new Employee()
                       {
                           EmployeeName = "Sanjay11",

                           DepartmentId = 18
                       },
                        new Employee()
                        {
                            EmployeeName = "Sanjay12",
                            DepartmentId = 20

                        },
                         new Employee()
                         {
                             EmployeeName = "Sanjay1245",
                             DepartmentId = 19
                         });
                }

                context.SaveChanges();
            }
        }
    }
}





       
