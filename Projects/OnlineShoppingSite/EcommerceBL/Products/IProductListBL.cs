using System;
using System.Collections.Generic;
using System.Text;
using EcommerceDAL.ProductsDAL;
using EcommerceDAL;

namespace EcommerceBL.Products
{
     public interface IProductListBL
     {
        int InsertProducts(ProductsListModel view);

        List<ProductsListModel> GetProductsList();

        bool UpdateProductList(ProductsListModel UpdateList);

        bool DeleteProducts(ProductsListModel deleteList);
    }
}
