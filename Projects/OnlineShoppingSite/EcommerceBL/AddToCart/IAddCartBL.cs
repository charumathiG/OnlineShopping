// <copyright file="IAddCartBL.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace EcommerceBL.AddToCart
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using EcommerceDAL;
    using EcommerceDAL.AddToCart;

    /// <summary>
    /// Implementation of Interface.
    /// </summary>
    public interface IAddCartBL
    {
        /// <summary>
        /// Implementation of Method.
        /// </summary>
        /// <param name="view">value.</param>
        /// <returns> DAL.</returns>
        int InsertCartList(AddCartModel view);

        /// <summary>
        ///  Implementation of Method.
        /// </summary>
        /// <returns>value.</returns>
        List<AddCartModel> GetCartList();

        /// <summary>
        ///  Implementation of Method.
        /// </summary>
        /// <param name="updateList">list.</param>
        /// <returns>DAL.</returns>
        bool UpdateCartList(AddCartModel updateList);

        /// <summary>
        ///  Implementation of Method.
        /// </summary>
        /// <param name="deleteList">list.</param>
        /// <returns>DAL.</returns>
        bool DeleteCartList(AddCartModel deleteList);
     }
}
