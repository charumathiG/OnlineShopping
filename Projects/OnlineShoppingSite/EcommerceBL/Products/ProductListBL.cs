// <copyright file="ProductListBL.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>
namespace EcommerceBL.Products
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Data.SqlClient;
    using System.Text;
    using EcommerceDAL;
    using EcommerceDAL.ProductsDAL;
    using EcommerceDAL.RepositoryPattern;

    /// <summary>
    /// Implementation of Class.
    /// </summary>
    public class ProductListBL : IProductListBL
    {
        private IProductsListDAL dal;

        /// <summary>
        /// Initializes a new instance of the <see cref="ProductListBL"/> class.
        /// </summary>
        /// <param name="daL">dal.</param>
        public ProductListBL(IProductsListDAL daL)
        {
            this.dal = daL;
        }

        /// <summary>
        /// Implemetntationof Method.
        /// </summary>
        /// <param name="deleteList">list.</param>
        /// <returns>value.</returns>
        public bool DeleteProducts(ProductsListModel deleteList)
        {
            return this.dal.DeleteProduct(deleteList);
        }

        /// <summary>
        /// Implementation of a method.
        /// </summary>
        /// <param name="categoryId">categoryId.</param>
        /// <returns>values.</returns>
        public List<ProductsListModel> GetProductById(int categoryId)
        {
            return this.dal.GetProductById(categoryId);
        }

        /// <summary>
        /// Implementation of Method.
        /// </summary>
        /// <returns>value.</returns>
        public List<ProductsListModel> GetProductsList()
        {
            return this.dal.GetProducts();
        }

        /// <summary>
        /// Implementation of Method.
        /// </summary>
        /// <param name="view">view.</param>
        /// <returns>value.</returns>
        public int InsertProducts(ProductsListModel view)
        {
            return this.dal.InsertProducts(view);
        }

        /// <summary>
        /// Implementation of method.
        /// </summary>
        /// <param name="keyword">key.</param>
        /// <returns>value.</returns>
        public List<ProductsListModel> Searching(string keyword)
        {
            return this.dal.SearchProduct(keyword);
        }

        /// <summary>
        /// Implementation of Method.
        /// </summary>
        /// <param name="updateList">list.</param>
        /// <returns>value.</returns>
        public bool UpdateProductList(ProductsListModel updateList)
        {
            return this.dal.UpdateProduct(updateList);
        }
    }
}
