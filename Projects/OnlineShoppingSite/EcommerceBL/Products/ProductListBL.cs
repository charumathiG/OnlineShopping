using System;
using System.Collections.Generic;
using System.Text;
using EcommerceDAL.ProductsDAL;
using EcommerceDAL;
using System.Data;
using System.Data.SqlClient;
using EcommerceDAL.RepositoryPattern;

namespace EcommerceBL.Products
{
    public class ProductListBL : IProductListBL
    {
        Random random = new Random();
        IProductsListDAL dal;
        public ProductListBL(IProductsListDAL Dal)
        {
            dal = Dal;
        }

        public bool DeleteProducts(ProductsListModel deleteList)
        {
            return dal.DeleteProduct(deleteList);
        }

        public List<ProductsListModel> GetProductsList()
        {
            return dal.GetProducts();
        }

        public int InsertProducts(ProductsListModel view)
        {
            return dal.InsertProducts(view);
        }

        public bool UpdateProductList(ProductsListModel UpdateList)
        {
            return dal.UpdateProduct(UpdateList);
        }
    }
}
