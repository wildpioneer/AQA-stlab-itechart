using System;
using Lesson3.Interfaces;

namespace Lesson3.Models
{
    public class Employee : Human, IHumanInfo
    {
        public string CompanyName { get; set; }
        public string CompanyCountry { get; set; }
        public string CompanyCity { get; set; }
        public string CompanyStreet { get; set; }

        public void ShowHumanInfo()
        {
            Console.WriteLine($"\nHello, I am {FullName}, {JobTittle} in {CompanyName}" +
                              $" ({CompanyCountry}, {CompanyCity}, {CompanyStreet}) and my salary {JobSalary}");
        }
    }
}