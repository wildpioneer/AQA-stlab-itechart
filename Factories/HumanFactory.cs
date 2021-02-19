using System.Collections.Generic;
using System.Linq;
using Bogus;
using Bogus.DataSets;
using Lesson3.Models;

namespace Lesson3.Factories
{
    public class HumanFactory
    {
        public Faker<Employee> GenerateEmployee()
        {
            return new Faker<Employee>()
                .Rules((f, u) =>
                {
                    u.FirstName = f.Name.FirstName();
                    u.LastName = f.Name.LastName();
                    u.JobTittle = f.Name.JobTitle();
                    u.JobDescription = f.Name.JobDescriptor();
                    u.JobSalary = f.Random.Int(500, 3000);
                    u.CompanyName = f.Company.CompanyName();
                    u.CompanyCountry = f.Address.Country();
                    u.CompanyCity = f.Address.City();
                    u.CompanyStreet = f.Address.StreetAddress();
                });
        }

        public List<Employee> GenerateEmployees(int count = 1)
        {
            return GenerateEmployee().Generate(count).ToList();
        }
        
        public Faker<Candidate> GenerateCandidate()
        {
            return new Faker<Candidate>()
                .Rules((f, u) =>
                {
                    u.FirstName = f.Name.FirstName();
                    u.LastName = f.Name.LastName();
                    u.JobTittle = f.Name.JobTitle();
                    u.JobDescription = f.Name.JobDescriptor();
                    u.JobSalary = f.Random.Int(50, 500);
                }); 
        }

        public List<Candidate> GenerateCandidates(int count = 1)
        {
            return GenerateCandidate().Generate(count).ToList();
        }
    }
}