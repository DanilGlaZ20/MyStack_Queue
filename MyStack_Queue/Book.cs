using System;
using System.Net.Cache;

namespace MyStack_Queue
{
    public class Book
    {
        public string Name { get; set; }
        public int Year { get; set; }

        public Book(string name, int year)
        {
            this.Name = name;
            this.Year = year;

        }

        public String Print()
        {
            return Name + " " + Year;
        }
    }
}