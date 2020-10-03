using System;
using System.Collections.Generic;
using ClassesService.Domain.Utils;

namespace ClassesService.Domain.Aggregates.SchoolClass
{
    public class Book : ValueObject
    {
        public string Author { get; private set; }
        public string Publisher { get; private set; }
        public int Pages { get; private set; }
        public DateTime Year { get; private set; }

        public Book(string author, string publisher, int pages, DateTime year)
        {
            Author = author;
            Publisher = publisher;
            Pages = pages;
            Year = year;
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            // Using a yield return statement to return each element one at a time
            yield return Author;
            yield return Publisher;
            yield return Pages;
            yield return Year;
        }
    }

}