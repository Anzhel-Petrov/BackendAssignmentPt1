using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackendAssignmentPt1.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public string ImageFileName { set; get; }

        // parameterless constructor that allows the automatic base call to it. If it's missing we well get an error creating objects with constructors that are inhereting the Product
        // parameters and not explicitly calling with the "base" keyword
        public Product()
        {

        }

        public Product(string title, decimal price)
        {
            Title = title;
            Price = price;
        }
    }
}
