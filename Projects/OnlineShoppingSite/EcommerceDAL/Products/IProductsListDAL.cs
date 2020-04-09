// <copyright file="IProductsListDAL.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace EcommerceDAL.ProductsDAL
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using EcommerceDAL;

    /// <summary>
    /// Implementation of Interface.
    /// </summary>
    public interface IProductsListDAL
    {
        /// <summary>
        /// Implementation of Method.
        /// </summary>
        /// <param name="keyword">keyword.</param>
        /// <returns>value.</returns>
        List<ProductsListModel> SearchProduct(string keyword);

        /// <summary>
        /// Implementation of Method.
        /// </summary>
        /// <returns>value.</returns>
        List<ProductsListModel> GetProducts();

        /// <summary>
        /// Implementation of a Method.
        /// </summary>
        /// <param name="CategoryId">categoryId.</param>
        /// <returns>Value.</returns>
        List<ProductsListModel> GetProductById(int CategoryId);

        /// <summary>
        /// Implementation of Method.
        /// </summary>
        /// <param name="productList">list.</param>
        /// <returns>value.</returns>
        int InsertProducts(ProductsListModel productList);

        /// <summary>
        /// Implementation of Method.
        /// </summary>
        /// <param name="update">list.</param>
        /// <returns>value.</returns>
        bool UpdateProduct(ProductsListModel update);

        /// <summary>
        /// Implementation of Method.
        /// </summary>
        /// <param name="delete">list.</param>
        /// <returns>value.</returns>
        bool DeleteProduct(ProductsListModel delete);
    }
}
