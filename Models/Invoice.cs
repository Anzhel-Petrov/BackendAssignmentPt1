using BackendAssignmentPt1.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackendAssignmentPt1.Models
{
    public class Invoice
    {
        private decimal totalPrice;
        public int InvoiceId { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal TotalPrice
        {
            get
            {
                //totalPrice = OrderItems.Sum(r => r.TotalPrice);

                // The foreach loop below works but on page refresh it keeps adding the totalprice. The lambda sum above does not have that - why?
                totalPrice = 0;
                foreach (OrderItem o in OrderItems)
                {
                    totalPrice += o.TotalPrice;
                }
                return totalPrice;
            }

        }
        public Customer Customer { get; set; }
        public List<OrderItem> OrderItems { get; } = new List<OrderItem>();
        public Invoice(int invoiceId, DateTime orderDate, Customer customer)
        {
            InvoiceId = invoiceId;
            OrderDate = orderDate;
            Customer = customer;
        }

        public void AddOrderItem(Product product, int quantity)
        {
            OrderItems.Add(new OrderItem(product, quantity));
        }
    }
}
