// <copyright file="IShippingAddressBL.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>
namespace EcommerceBL.ShippingAddress
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using EcommerceDAL;
    using EcommerceDAL.ShippingAddress;

    /// <summary>
    /// Implementation of Interface.
    /// </summary>
    public interface IShippingAddressBL
    {
        /// <summary>
        /// Implementation of Method.
        /// </summary>
        /// <param name="view">view.</param>
        /// <returns>value.</returns>
        int InsertDetailList(ShippingAddressModel view);

        /// <summary>
        /// Implementation of Method.
        /// </summary>
        /// <returns>value.</returns>
        List<ShippingAddressModel> GetDetailList();

        /// <summary>
        /// Implementation of Method.
        /// </summary>
        /// <param name="updateList">list.</param>
        /// <returns>value.</returns>
        bool UpdateDetailList(ShippingAddressModel updateList);
    }
}
