using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using EcommerceDAL;
using EcommerceDAL.RepositoryPattern;


namespace EcommerceDAL.ProductsDAL
{
    public class ProductsListDAL : IProductsListDAL
    {
        public IBaseDAL basedal;

        public ProductsListDAL()
        {
        }

        public ProductsListDAL(IBaseDAL baseDAL)
        {
            basedal = baseDAL;
        }

        public bool DeleteProduct(ProductsListModel delete)
        {
            var parameter = new List<SqlParameter>();
            parameter.Add(basedal.CreateParameter("@ProductId", 5, delete.ProductId, DbType.Int16));
            basedal.Update("SP_DeleteProduct", CommandType.StoredProcedure, parameter.ToArray(), out bool status);
            return status;
        }

        public List<ProductsListModel> GetProducts()
        {
            var parameter = new List<SqlParameter>();
            List<ProductsListModel> list = new List<ProductsListModel>();
            ProductsListModel product = null;
            var List = basedal.GetData("SP_GetProducts", CommandType.StoredProcedure);
            foreach (DataRow data in List.Tables[0].Rows)
            {
                product = new ProductsListModel();
                product.ProductId = data[0].ToString();
                product.CategoryId = data[1].ToString();
                list.Add(product);
            }
            return list;
        }

        public int InsertProducts(ProductsListModel productList)
        {
            var parameter = new List<SqlParameter>();
            parameter.Add(basedal.CreateParameter("@ProductName", 50, productList.ProductName, DbType.String));
            parameter.Add(basedal.CreateParameter("@CategoryId", 50, productList.CategoryId, DbType.Int16));
            parameter.Add(basedal.CreateParameter("@Descriptions", 50, productList.Descriptions, DbType.String));
            parameter.Add(basedal.CreateParameter("@Price", 50, productList.Price, DbType.VarNumeric));
            parameter.Add(basedal.CreateParameter("@Quantity", 50, productList.Quantity, DbType.Int16));
            parameter.Add(basedal.CreateParameter("@Image", 50, productList.Image, DbType.String));

            basedal.Insert("SP_InsertProduct", CommandType.StoredProcedure, parameter.ToArray(), out int lastId);

            return lastId;

        }

        public bool UpdateProduct(ProductsListModel update)
        {
            var parameter = new List<SqlParameter>();
            parameter.Add(basedal.CreateParameter("@ProductId", 5, update.ProductId, DbType.Int16));
            basedal.Update("SP_UpdateProductById", CommandType.StoredProcedure, parameter.ToArray(), out bool status);
            return status;
        }
    }
}
