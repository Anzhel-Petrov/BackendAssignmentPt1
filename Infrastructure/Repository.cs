using BackendAssignmentPt1.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackendAssignmentPt1.Infrastructure
{
    // this Repository class act as a mockup data class for storing data. It is static 
    // because the data should be the same for the whole application.
    public static class Repository
    {
        public static List<Product> Products = new List<Product>();
        public static List<Invoice> Invoices = new List<Invoice>();
        // when called the constructor instantiates all the objects and the lists
        static Repository()
        {

            // create Movie objects and add them to the Products catalogue list
            Movie jungleBook = new Movie("Jungle Book", 175m, "junglebook.jpg", "Jon Favreau");
            Movie gladiator = new Movie("Gladiator", 150.20m, "gladiator.jpg", "Ridley Scott");
            Movie forrest_gump = new Movie("Forest Gump", 100.10m, "forrest-gump.jpg", "Robert Zemeckis");
            Products.Add(jungleBook);
            Products.Add(gladiator);
            Products.Add(forrest_gump);

            // create Book objects and add them to the Products catalogue list. Book has one constructor with 4 arguments. 
            Book hardDay = new Book("Steve Turner", "A Hard Day's Write: The Stories Behind Every Beatles Song", 190.75m, 2005);

            //There are 3 extra properties that we need to be set. We can use the book object and call the property setter to assign the values
            hardDay.ImageFileName = "hard_day.jpg";
            hardDay.ISBN = "978-0060844097";
            hardDay.Publisher = "It Books";

            //Or we can use Object initialization - set any number of fields on the object trough the properties to specified values after it's been constructed
            Book sgtPepper = new Book("George Martin", "With a Little Help from My Friends: The Making of Sgt. Pepper", 120.60m, 1995)
            {
                ImageFileName = "pepper.jpg",
                ISBN = "978-0316547833",
                Publisher = "Little Brown & Co"
            };

            // Add the books to the Products list
            Products.Add(hardDay);
            Products.Add(sgtPepper);

            // create Track objects
            Track abbeyRoadTrack1 = new Track("Come Together", new TimeSpan(0, 2, 40))
            {
                Composer = "Lenon, McCartney"
            };
            Track abbeyRoadTrack2 = new Track("Something", new TimeSpan(0, 3, 03))
            {
                Composer = "Harrison"
            };
            Track abbeyRoadTrack3 = new Track("Maxwell's Silver Hammer", new TimeSpan(0, 2, 27))
            {
                Composer = "Lenon, McCartney"
            };

            // create the "blank" Music CD
            MusicCD abbeyRoad = new MusicCD("Beatles", "Abbey Road (Remastered)", 128m, 2009)
            {
                ImageFileName = "abbey_road.jpg",
                Label = "Capitol"
            };
            MusicCD revolver = new MusicCD("Beatles", "Revolver", 183m, 2009)
            {
                ImageFileName = "revolver.jpg",
                Label = "Capitol"
            };

            // call the AddTrack method
            abbeyRoad.AddTrack(abbeyRoadTrack1);
            abbeyRoad.AddTrack(abbeyRoadTrack2);
            abbeyRoad.AddTrack(abbeyRoadTrack3);
            // same as above but this time we use collection-initializer syntax and add object without the need to instantate them first
            abbeyRoad.AddTrack(new Track("Oh! Darling", new TimeSpan(0, 3, 26)) { Composer = "Lenon, McCartney" });
            abbeyRoad.AddTrack(new Track("Octopus's Garden", new TimeSpan(0, 2, 51)) { Composer = "Starkey" });
            abbeyRoad.AddTrack(new Track("I Want You (She's So Heavy)", new TimeSpan(0, 7, 47)) { Composer = "Lenon, McCartney" });
            abbeyRoad.AddTrack(new Track("Here Comes The Sun", new TimeSpan(0, 3, 05)) { Composer = "Harrison" });
            abbeyRoad.AddTrack(new Track("Because", new TimeSpan(0, 2, 45)) { Composer = "Lenon, McCartney" });
            abbeyRoad.AddTrack(new Track("You Never Give me Your Money", new TimeSpan(0, 4, 02)) { Composer = "Lenon, McCartney" });
            abbeyRoad.AddTrack(new Track("Sun King", new TimeSpan(0, 2, 26)) { Composer = "Lenon, McCartney" });
            abbeyRoad.AddTrack(new Track("Mean Mr. Mustard", new TimeSpan(0, 1, 06)) { Composer = "Lenon, McCartney" });
            abbeyRoad.AddTrack(new Track("Polythene Pam", new TimeSpan(0, 1, 12)) { Composer = "Lenon, McCartney" });
            abbeyRoad.AddTrack(new Track("She Came In Trough The Bathroom Window", new TimeSpan(0, 1, 57)) { Composer = "Lenon, McCartney" });
            abbeyRoad.AddTrack(new Track("Golden Slumbers", new TimeSpan(0, 1, 31)) { Composer = "Lenon, McCartney" });
            abbeyRoad.AddTrack(new Track("Carry That Weight", new TimeSpan(0, 1, 36)) { Composer = "Lenon, McCartney" });
            abbeyRoad.AddTrack(new Track("The End", new TimeSpan(0, 2, 19)) { Composer = "Lenon, McCartney" });
            abbeyRoad.AddTrack(new Track("Her Majesty", new TimeSpan(0, 0, 23)) { Composer = "Lenon, McCartney" });
            revolver.AddTrack(new Track("Taxman", new TimeSpan(0, 2, 28)) { Composer = "Harrison" });
            revolver.AddTrack(new Track("Eleanor Rigby", new TimeSpan(0, 2, 06)) { Composer = "Lenon, McCartney" });
            revolver.AddTrack(new Track("I'm Only Sleeping", new TimeSpan(0, 3, 00)) { Composer = "Lenon, McCartney" });
            revolver.AddTrack(new Track("Love You To", new TimeSpan(0, 2, 59)) { Composer = "Harrison" });
            revolver.AddTrack(new Track("Here, There And Everywhere", new TimeSpan(0, 2, 23)) { Composer = "Harrison" });
            revolver.AddTrack(new Track("Yellow Submarine", new TimeSpan(0, 2, 38)) { Composer = "Lenon, McCartney" });
            revolver.AddTrack(new Track("She Said She Said", new TimeSpan(0, 2, 36)) { Composer = "Lenon, McCartney" });
            revolver.AddTrack(new Track("Good Day Sunshine", new TimeSpan(0, 2, 09)) { Composer = "Lenon, McCartney" });
            revolver.AddTrack(new Track("And You Bird Can Sing", new TimeSpan(0, 2, 00)) { Composer = "Lenon, McCartney" });
            revolver.AddTrack(new Track("For No One", new TimeSpan(0, 1, 59)) { Composer = "Lenon, McCartney" });
            revolver.AddTrack(new Track("Doctor Robert", new TimeSpan(0, 1, 14)) { Composer = "Lenon, McCartney" });
            revolver.AddTrack(new Track("I Want To Tell You", new TimeSpan(0, 2, 27)) { Composer = "Harrison" });
            revolver.AddTrack(new Track("Got To Get You Into My Life", new TimeSpan(0, 2, 29)) { Composer = "Harrison" });
            revolver.AddTrack(new Track("Tomorrow Never Knows", new TimeSpan(0, 3, 01)) { Composer = "Harrison" });

            // add the complete Music CD to the Products catalogue list
            Products.Add(abbeyRoad);
            Products.Add(revolver);

            // create Customers
            Customer customer1 = new Customer(1, "Anzhel", "Petrov", "Gudrunsvej 28", "8220", "Aarhus")
            {
                // Use the two dates below to check the age check in Customer model
                //BirthDate = new DateTime(1900, 06, 27)
                //BirthDate = new DateTime(2222, 06, 27)
                BirthDate = new DateTime(1984, 06, 27)
            };
            Customer customer2 = new Customer(2, "Kristian", "Kubis", "Banegårdsgade 72", "8000", "Aarhus")
            {
                BirthDate = new DateTime(1998, 03, 15)
            };

            Customer customer3 = new Customer(3, "Michael", "Commerou", "Kirkegade 13", "7100", "Vejle")
            {
                BirthDate = new DateTime(1996, 10, 22)
            };

            //create Invoices
            Invoice invoice1 = new Invoice(1, new DateTime(2020, 08, 27), customer1);
            Invoice invoice2 = new Invoice(2, new DateTime(2020, 08, 26), customer2);
            Invoice invoice3 = new Invoice(2, new DateTime(2020, 09, 13), customer3);

            //// create OrderItem (we don't need to do that separately as we use the AddOrderItem method below)
            //OrderItem orderItem1 = new OrderItem(hardDay, 2);
            //OrderItem orderItem2 = new OrderItem(gladiator, 1);
            //OrderItem orderItem3 = new OrderItem(sgtPepper, 3);
            //OrderItem orderItem4 = new OrderItem(forrest_gump, 1);

            // add OrderItem to Invoice by using the OrderItem contructor as parameter to the method
            invoice1.AddOrderItem(hardDay, 2);
            invoice1.AddOrderItem(gladiator, 1);
            invoice2.AddOrderItem(sgtPepper, 3);
            invoice2.AddOrderItem(forrest_gump, 2);
            invoice3.AddOrderItem(jungleBook, 1);
            invoice3.AddOrderItem(abbeyRoad, 2);

            // add Invoice to Invoices list
            Invoices.Add(invoice1);
            Invoices.Add(invoice2);
            Invoices.Add(invoice3);

            // add invoice using the customer object. It is not used but it acts as a filter to get all invoices by specifying a customer
            //customer1.AddInvoice(invoice1);
        }
    }
}
