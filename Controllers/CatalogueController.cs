using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BackendAssignmentPt1.Infrastructure;
using BackendAssignmentPt1.Models;
using Microsoft.AspNetCore.Mvc;

namespace BackendAssignmentPt1.Controllers
{
    public class CatalogueController : Controller
    {
        public IActionResult Movies()
        {
            //We create an IEnumerable list of movie objects. Then we query only the information from the movie objects from the Repository products list and assign it to the new movie list
            // We assign that list to a ViewBag property so we can pass it to the View

            IEnumerable<Movie> movies;
            movies = Repository.Products.OfType<Movie>().ToList();
            ViewBag.Movies = movies;

            // Alternatively we can store the entire Products list in a viewbag. The negative side of that is that we need to explicitly cast a product object to a movie object
            //ViewBag.Products = Repository.Products;

            return View();
        }

        public IActionResult Books()
        {
            //We create an IEnumerable list of book objects. Then we query only the information from the book objects from the Repository products list and assign it to the new book list
            // We assign that list to a ViewBag property so we can pass it to the View

            IEnumerable<Book> books;
            books = Repository.Products.OfType<Book>().ToList();
            ViewBag.Books = books;

            // Alternatively we can store the entire Products list in a viewbag. The negative side of that is that we need to explicitly cast a product object to a book object
            //ViewBag.Products = Repository.Products;

            return View();
        }
        public IActionResult MusicCDs()
        {
            //We create an IEnumerable list of cd objects. Then we query only the information from the cd objects from the Repository products list and assign it to the new cd list
            // We assign that list to a ViewBag property so we can pass it to the View

            IEnumerable<MusicCD> cds;
            cds = Repository.Products.OfType<MusicCD>().ToList();
            ViewBag.CDs = cds;

            // Alternatively we can store the entire Products list in a viewbag. The negative side of that is that we need to explicitly cast a product object to a CD object
            //ViewBag.Products = Repository.Products;

            return View();
        }
    }
}
