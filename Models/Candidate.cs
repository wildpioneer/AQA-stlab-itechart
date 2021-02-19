using System;
using Lesson3.Interfaces;

namespace Lesson3.Models
{
    public class Candidate : Human, IHumanInfo
    {
        public void ShowHumanInfo()
        {
            Console.WriteLine($"\nHello, I am {FullName} I want to be a {JobTittle} " +
                              $"({JobDescription}) with a salary from {JobSalary}");
        }
        
    }
}