// <copyright file="ProductsListDAL.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace EcommerceDAL.ProductsDAL
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Data.SqlClient;
    using System.Text;
    using EcommerceDAL;
    using EcommerceDAL.RepositoryPattern;

    /// <summary>
    /// Implementation of a class.
    /// </summary>
    public class ProductsListDAL : IProductsListDAL
    {
        private IBaseDAL basedal;

        /// <summary>
        /// Initializes a new instance of the <see cref="ProductsListDAL"/> class.
        /// </summary>
        /// <param name="baseDAL">list.</param>
        public ProductsListDAL(IBaseDAL baseDAL)
        {
            this.basedal = baseDAL;
        }

        /// <summary>
        /// Implementation of method.
        /// </summary>
        /// <param name="delete">list.</param>
        /// <returns>value.</returns>
        public bool DeleteProduct(ProductsListModel delete)
        {
            var parameter = new List<SqlParameter>();
            parameter.Add(this.basedal.CreateParameter("@ProductId", 5, delete.ProductId, DbType.Int16));
            this.basedal.Update("SP_DeleteProduct", CommandType.StoredProcedure, parameter.ToArray(), out bool status);
            return status;
        }

        public List<ProductsListModel> GetProductById(int CategoryId)
        {
            var parameter = new List<SqlParameter>();
            List<ProductsListModel> list = new List<ProductsListModel>();
            ProductsListModel product = null;
            parameter.Add(this.basedal.CreateParameter("@CategoryId", 50, CategoryId, DbType.Int32));
            var productList = (DataSet)this.basedal.GetData("SP_GetProductById", CommandType.StoredProcedure, parameter);
            if (productList != null && productList.Tables.Count > 0)
            {
                foreach (DataRow data in productList.Tables[0].Rows)
                {
                    product = new ProductsListModel();
                    product.ProductId = data[1].ToString();
                    product.ProductName = data[2].ToString();
                    product.Price = Convert.ToInt16(data[0]);
                    product.Image = data[7].ToString();

                    list.Add(product);
                }
            }

            return list;
        }

        /// <summary>
        /// Implementation of method.
        /// </summary>
        /// <returns>value.</returns>
        public List<ProductsListModel> GetProducts()
        {
            var parameter = new List<SqlParameter>();
            List<ProductsListModel> list = new List<ProductsListModel>();
            ProductsListModel product = null;
            var productList = this.basedal.GetData("SP_GetProducts", CommandType.StoredProcedure);
            foreach (DataRow data in productList.Tables[0].Rows)
            {
                product = new ProductsListModel();
                product.ProductId = data[0].ToString();
                product.ProductName = data[0].ToString();
                product.CategoryId = Convert.ToInt32(data[0]);
                product.Description = data[0].ToString();
                product.Price = Convert.ToInt16(data[0]);
                product.Quantity = Convert.ToInt16(data[0]);
                product.Image = data[0].ToString();

                list.Add(product);
            }

            return list;
        }

        /// <summary>
        /// Implementation of Method.
        /// </summary>
        /// <param name="productList">list.</param>
        /// <returns>value.</returns>
        public int InsertProducts(ProductsListModel productList)
        {
            var parameter = new List<SqlParameter>();
            parameter.Add(this.basedal.CreateParameter("@ProductName", 50, productList.ProductName, DbType.String));
            parameter.Add(this.basedal.CreateParameter("@CategoryId", 50, productList.CategoryId, DbType.Int16));
            parameter.Add(this.basedal.CreateParameter("@Description", 50, productList.Description, DbType.String));
            parameter.Add(this.basedal.CreateParameter("@Price", 50, productList.Price, DbType.Int32));
            parameter.Add(this.basedal.CreateParameter("@Quantity", 50, productList.Quantity, DbType.Int16));
            parameter.Add(this.basedal.CreateParameter("@Image", 50, productList.Image, DbType.String));

            this.basedal.Insert("SP_InsertProduct", CommandType.StoredProcedure, parameter.ToArray(), out int lastId);

            return lastId;
        }

        /// <summary>
        /// Implementation of method.
        /// </summary>
        /// <param name="keyword">list.</param>
        /// <returns>value.</returns>
        public List<ProductsListModel> SearchProduct(string keyword)
        {
            var parameter = new List<SqlParameter>();
            List<ProductsListModel> list = new List<ProductsListModel>();
            ProductsListModel product = null;
            parameter.Add(this.basedal.CreateParameter("@keyword", 50, keyword, DbType.String));
            var productList = this.basedal.GetData("SP_SearchProductByKeyword", CommandType.StoredProcedure);
            foreach (DataRow data in productList.Tables[0].Rows)
            {
                product = new ProductsListModel();
                product.ProductId = data[0].ToString();
                product.CategoryId = Convert.ToInt32(data[1]);

                list.Add(product);
            }

            return list;
        }

        /// <summary>
        /// Implementation of Method.
        /// </summary>
        /// <param name="update">list.</param>
        /// <returns>value.</returns>
        public bool UpdateProduct(ProductsListModel update)
        {
            var parameter = new List<SqlParameter>();
            parameter.Add(this.basedal.CreateParameter("@ProductId", 5, update.ProductId, DbType.Int16));
            this.basedal.Update("SP_UpdateProductById", CommandType.StoredProcedure, parameter.ToArray(), out bool status);
            return status;
        }
    }
}

