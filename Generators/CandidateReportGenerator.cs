using System;
using System.Collections.Generic;
using System.Linq;
using Lesson3.Interfaces;
using Lesson3.Models;

namespace Lesson3.Generators
{
    public class CandidateReportGenerator : IReportGenerator<Candidate>
        {
            public void GenerateReport(List<Candidate> candidates) 
            { 
                Console.WriteLine("\n{0,-36}  |  {1,-30}  |  {2,-40}  |  {3,-25}", 
                    "HumanId", "FullName", "JobTittle", "Salary"); 
                Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------"); 
            
                 candidates
                     .ToList()
                     .ForEach(u=> Console.WriteLine("{0,20}  |  {1,-30}  |  {2,-40}  |  {3,-25}", 
                    u.Id, u.FullName, u.JobTittle, u.JobSalary));
            }
    }
}