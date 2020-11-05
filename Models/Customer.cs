using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackendAssignmentPt1.Models
{
    public class Customer
    {
        private DateTime birthdate;
        public int CustomerId { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Address { get; set; }
        public string Zip { get; set; }
        public string City { get; set; }
        public List<string> PhoneNumbers { get; } = new List<string>();
        public List<Invoice> Invoices { get; set; } = new List<Invoice>();

        public int Age
        {
            get
            {
                DateTime now = DateTime.Now;
                int age;
                age = now.Year - birthdate.Year;
                if (now.Month < birthdate.Month ||
                (now.Month == birthdate.Month && now.Day < birthdate.Day))
                {
                    age--;
                }
                return age;
            }
        }

        public DateTime BirthDate
        {
            set
            {
                int age = DateTime.Now.Year - value.Year;
                if (age <= 0 || age >= 120)
                {
                    throw new Exception("Age not accepted");
                }
                else
                {
                    birthdate = value;
                }
            }
            get { return birthdate; }
        }

        public Customer(int customerId, string firstnavn, string lastnavn, string address, string zip, string city)
        {
            CustomerId = customerId;
            Firstname = firstnavn;
            Lastname = lastnavn;
            Address = address;
            Zip = zip;
            City = city;
        }


        public void AddPhone(string phone)
        {
            PhoneNumbers.Add(phone);
        }

        public void AddInvoice(Invoice invoice)
        {
            Invoices.Add(invoice);
        }
    }
}
