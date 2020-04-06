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
        private IAddCartBL dal;

        /// <summary>
        /// Initializes a new instance of the <see cref="AddCartBL"/> class.
        /// </summary>
        /// <param name="daL">dal.</param>
        public AddCartBL(IAddCartBL daL)
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
            return this.dal.DeleteCartList(deleteList);
        }

        /// <summary>
        /// Implementation of Method.
        /// </summary>
        /// <returns>DAL.</returns>
        public List<AddCartModel> GetCartList()
        {
            return this.dal.GetCartList();
        }

        /// <summary>
        /// Implementation of Method.
        /// </summary>
        /// <param name="view">View.</param>
        /// <returns>DAL.</returns>
        public int InsertCartList(AddCartModel view)
        {
            return this.dal.InsertCartList(view);
        }

        /// <summary>
        /// Implementation of Method.
        /// </summary>
        /// <param name="updateList">list.</param>
        /// <returns>DAL.</returns>
        public bool UpdateCartList(AddCartModel updateList)
        {
            return this.dal.UpdateCartList(updateList);
        }
    }
}
