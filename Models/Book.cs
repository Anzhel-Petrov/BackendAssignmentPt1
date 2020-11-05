using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackendAssignmentPt1.Models
{
    public class Book : Product
    {
        public string Author { get; set; }
        public string Publisher { get; set; }
        public short Published { get; set; }
        public string ISBN { get; set; }

        // a constructor for the Book class. Notice: the Book inherits the Product class (a Book is a Product). 
        // The Book constructor does not uses the base keyword to pass the price and title property to the base class Product constructor because Product
        // class has a parameterless constructor - there is an automatic call.
        public Book(string author, string title, decimal price, short published)
        {
            Author = author;
            Title = title;
            Price = price;
            Published = published;
        }

    }
}
