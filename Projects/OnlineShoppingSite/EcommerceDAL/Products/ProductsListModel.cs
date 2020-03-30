using System;
using System.Collections.Generic;
using System.Text;

namespace EcommerceDAL.ProductsDAL
{
    public class ProductsListModel
    {
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public string CategoryId { get; set; }
        public string Descriptions { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }
        public string Image { get; set; }
    }
}

        
   
