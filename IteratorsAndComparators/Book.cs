using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace IteratorsAndComparators
{
    public class Book : IComparable<Book>
    {
        public Book(string title, int year, params string[] authors)
        {

            Year = year;
            Title = title;
            Authors = authors;
        }
        public string Title { get; set; }
        public int Year { get; set; }
        public IReadOnlyList<string> Authors { get; set; } = new List<string>();
        public int CompareTo(Book other)
        {
            if (Year > other.Year)
            {
                return 1;
            }
            else if (Year < other.Year)
            {
                return -1;
            }
            else
            {
                return Title.CompareTo(other.Title);
            }

        }

        public override string ToString()
        {
            return $"{this.Title} - {this.Year}";
        }

    }
}
