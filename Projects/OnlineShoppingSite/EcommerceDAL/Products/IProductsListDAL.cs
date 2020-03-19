using System;
using System.Collections.Generic;
using System.Text;
using EcommerceDAL;

namespace EcommerceDAL.ProductsDAL
{
     public interface IProductsListDAL
     {
        int GetProducts(ProductsListModel productList);
     }
}
