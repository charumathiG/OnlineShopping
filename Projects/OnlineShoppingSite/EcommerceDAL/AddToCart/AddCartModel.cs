using System;
using System.Collections.Generic;
using System.Text;

namespace EcommerceDAL.AddToCart
{
    public class AddCartModel
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public string ProductId { get; set; }
        public float Price { get; set; }
        public int Quantity { get; set; }
        public DateTime Date { get; set; }
    }
}

    