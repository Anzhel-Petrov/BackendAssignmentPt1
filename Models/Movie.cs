using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackendAssignmentPt1.Models
{
    public class Movie : Product
    {
        public string Director { get; set; }
        public short Released { get; set; }

        public Movie(string title, decimal price)
        {
            Title = title;
            Price = price;
        }

        public Movie(string title, decimal price, string imageUrl, string director)
        {
            Title = title;
            Price = price;
            ImageFileName = imageUrl;
            Director = director;
        }
    }
}
