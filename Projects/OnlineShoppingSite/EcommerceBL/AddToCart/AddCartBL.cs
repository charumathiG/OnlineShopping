// <copyright file="AddCartBL.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace EcommerceBL.AddToCart
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using EcommerceDAL.AddToCart;
    using EcommerceDAL.RepositoryPattern;

    /// <summary>
    /// Implementation of a Class.
    /// </summary>
    public class AddCartBL : IAddCartBL
    {
        private IAddCartDAL dal;

        /// <summary>
        /// Initializes a new instance of the <see cref="AddCartBL"/> class.
        /// </summary>
        /// <param name="daL">dal.</param>
        public AddCartBL(IAddCartDAL daL)
        {
            this.dal = daL;
        }

        /// <summary>
        /// Implementation of Method.
        /// </summary>
        /// <param name="deleteList">list.</param>
        /// <returns>DAL.</returns>
        public bool DeleteCartList(AddCartModel deleteList)
        {
            return this.dal.DeleteCart(deleteList);
        }

        /// <summary>
        /// Implementation of Method.
        /// </summary>
        /// <returns>DAL.</returns>
        public List<AddCartModel> GetCartList()
        {
            return this.dal.GetCart();
        }

        /// <summary>
        /// Implementation of Method.
        /// </summary>
        /// <param name="view">View.</param>
        /// <returns>DAL.</returns>
        public int InsertCartList(AddCartModel view)
        {
            return this.dal.InsertCart(view);
        }

        /// <summary>
        /// Implementation of Method.
        /// </summary>
        /// <param name="updateList">list.</param>
        /// <returns>DAL.</returns>
        public bool UpdateCartList(AddCartModel updateList)
        {
            return this.dal.UpdateCart(updateList);
        }
    }
}
