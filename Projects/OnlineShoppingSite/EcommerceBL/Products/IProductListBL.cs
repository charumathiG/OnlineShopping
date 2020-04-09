// <copyright file="IProductListBL.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>
namespace EcommerceBL.Products
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using EcommerceDAL;
    using EcommerceDAL.ProductsDAL;

    /// <summary>
    /// Implementation of Interface.
    /// </summary>
    public interface IProductListBL
     {
        /// <summary>
        /// Implementation of Method.
        /// </summary>
        /// <param name="keyword">keyword.</param>
        /// <returns>value.</returns>
        List<ProductsListModel> Searching(string keyword);

        /// <summary>
        /// Implementation of Method.
        /// </summary>
        /// <param name="view">view.</param>
        /// <returns>value.</returns>
        int InsertProducts(ProductsListModel view);

        /// <summary>
        /// Implementation of Method.
        /// </summary>
        /// <returns>value.</returns>
        List<ProductsListModel> GetProductsList();

        /// <summary>
        /// Implementation of a method.
        /// </summary>
        /// <param name="categoryId">categoryId.</param>
        /// <returns>value.</returns>
        List<ProductsListModel> GetProductById(int categoryId);

        /// <summary>
        /// Implementation of Method.
        /// </summary>
        /// <param name="updateList">list.</param>
        /// <returns>value.</returns>
        bool UpdateProductList(ProductsListModel updateList);

        /// <summary>
        /// Implementation of Method.
        /// </summary>
        /// <param name="deleteList">list.</param>
        /// <returns>value.</returns>
        bool DeleteProducts(ProductsListModel deleteList);
    }
}
