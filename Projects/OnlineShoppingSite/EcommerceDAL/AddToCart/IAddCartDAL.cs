// <copyright file="IAddCartDAL.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>
namespace EcommerceDAL.AddToCart
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using EcommerceDAL;

    /// <summary>
    /// Implementation of Interface.
    /// </summary>
    public interface IAddCartDAL
    {
        /// <summary>
        /// Implementation of Method.
        /// </summary>
        /// <returns>value.</returns>
        List<AddCartModel> GetCart();

        /// <summary>
        /// Implementation of Method.
        /// </summary>
        /// <param name="list">list.</param>
        /// <returns>value.</returns>
        int InsertCart(AddCartModel list);

        /// <summary>
        /// Implementation of Method.
        /// </summary>
        /// <param name="update">update.</param>
        /// <returns>value.</returns>
        bool UpdateCart(AddCartModel update);

        /// <summary>
        /// Implementation of Method.
        /// </summary>
        /// <param name="delete">delete.</param>
        /// <returns>value.</returns>
        bool DeleteCart(AddCartModel delete);
    }
}
