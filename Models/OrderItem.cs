﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackendAssignmentPt1.Models
{
    public class OrderItem
    {
        public int OrderItemId { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public decimal TotalPrice
        {
            get
            {
                return Product.Price * Quantity;
            }
        }

        public OrderItem(Product product, int quantity)
        {
            Product = product;
            Quantity = quantity;
        }
    }
}
