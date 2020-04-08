// <copyright file="ShippingAddressBL.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace EcommerceBL.ShippingAddress
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using EcommerceDAL;
    using EcommerceDAL.RepositoryPattern;
    using EcommerceDAL.ShippingAddress;

    /// <summary>
    /// Implementation of a Class.
    /// </summary>
    public class ShippingAddressBL : IShippingAddressBL
    {
        private IShippingAddressDAL dal;

        /// <summary>
        /// Initializes a new instance of the <see cref="ShippingAddressBL"/> class.
        /// </summary>
        /// <param name="daL">dal.</param>
        public ShippingAddressBL(IShippingAddressDAL daL)
        {
            this.dal = daL;
        }

        /// <summary>
        /// Implementation of Method.
        /// </summary>
        /// <returns>value.</returns>
        public List<ShippingAddressModel> GetDetailList()
        {
            return this.dal.GetAddress();
        }

        /// <summary>
        /// Implementation of Method.
        /// </summary>
        /// <param name="view">view.</param>
        /// <returns>value.</returns>
        public int InsertDetailList(ShippingAddressModel view)
        {
            return this.dal.InsertAddress(view);
        }

        /// <summary>
        /// Implementation of Method.
        /// </summary>
        /// <param name="updateList">list.</param>
        /// <returns>value.</returns>
        public bool UpdateDetailList(ShippingAddressModel updateList)
        {
            return this.dal.UpdateAddress(updateList);
        }
    }
}
