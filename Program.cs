using System.Linq;
using Bogus;
using Lesson3.Factories;
using Lesson3.Generators;
using Lesson3.Models;

namespace Lesson3
{
    class Program
    {
        static void Main(string[] args)
        {
            var factory = new HumanFactory();
            var employees = factory.GenerateEmployees(new Faker().Random.Int(1, 5));
            var candidates = factory.GenerateCandidates(new Faker().Random.Int(1,5));
            
            employees.First().ShowHumanInfo();
            candidates.First().ShowHumanInfo();
            
            Candidate candidate = factory.GenerateCandidate();
            candidate.ShowHumanInfo();
            
            Employee employee = factory.GenerateEmployee();
            employee.ShowHumanInfo();

            var reportGenerator1 = new CandidateReportGenerator();
            reportGenerator1.GenerateReport(candidates);

            var reportGenerator2 = new EmployeeReportGenerator();
            reportGenerator2.GenerateReport(employees);
        }
    }
}