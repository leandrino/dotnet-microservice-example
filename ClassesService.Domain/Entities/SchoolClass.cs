using System;
using ClassesService.Domain.Interfaces;

namespace ClassesService.Domain.Entities
{
    public class SchoolClass: IAggregateRoot
    {
        public SchoolClass(Guid id, string name, int number, string grade)
        {
            Id = id;
            Name = name;
            Number = number;
            Grade = grade;
        }

        public Guid Id { get; set; }

        public string Grade { get; set; }

        public int Number { get; set; }

        public string Name { get; set; }

    }
}