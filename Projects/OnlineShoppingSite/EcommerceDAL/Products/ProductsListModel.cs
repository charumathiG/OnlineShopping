using System;
using System.Collections.Generic;
using System.Text;

namespace EcommerceDAL.ProductsDAL
{
     public class ProductsListModel
     {
        public string Product_Id { get; set; }
        public string Product_Name { get; set; }
        public string Category { get; set; }
        public string Product_Type { get; set; }
        public string Description1 { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }
        public string Images { get; set; }
     }
}
