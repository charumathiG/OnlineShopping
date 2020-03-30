using System;
using System.Collections.Generic;
using System.Text;
using EcommerceDAL;

namespace EcommerceDAL.ProductsDAL
{
     public interface IProductsListDAL
     {
        List<ProductsListModel> GetProducts();

        int InsertProducts(ProductsListModel productList);

        bool UpdateProduct(ProductsListModel update);

        bool DeleteProduct(ProductsListModel delete);
     }
}
