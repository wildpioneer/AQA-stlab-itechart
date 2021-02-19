using System;
using System.Collections.Generic;
using System.Linq;
using Lesson3.Interfaces;
using Lesson3.Models;

namespace Lesson3.Generators
{
    public class EmployeeReportGenerator : IReportGenerator<Employee>
        { 
            public void GenerateReport(List<Employee> employees) 
            { 
                Console.WriteLine("\n{0,-36}  |  {1,-30}  |  {2,-40}  |  {3,-10}", 
                    "HumanId", "Company Name", "FullName", "Salary"); 
                Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------"); 
            
                employees
                    .ToList()
                    .ForEach(u=> Console.WriteLine("{0,20}  |  {1,-30}  |  {2,-40}  |  {3,-10}", 
                        u.Id, u.CompanyName, u.FullName, u.JobSalary)); 
            
        }
    }
}