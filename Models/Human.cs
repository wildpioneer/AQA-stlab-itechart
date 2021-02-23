using System;

namespace Lesson3.Models
{
    public abstract class Human
    {
        public Guid Id => Guid.NewGuid();
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string JobTittle { get; set; }
        public string JobDescription { get; set; }
        public int JobSalary { get; set; }
        public string FullName => FirstName + " " + LastName; //ToDo: Переделать в интерполированную строку
    }
}
