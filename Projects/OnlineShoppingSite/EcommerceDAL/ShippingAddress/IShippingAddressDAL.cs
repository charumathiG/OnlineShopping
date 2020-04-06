// <copyright file="IShippingAddressDAL.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace EcommerceDAL.ShippingAddress
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using EcommerceDAL.ShippingAddress;

    /// <summary>
    /// Implementation of a Class.
    /// </summary>
    public interface IShippingAddressDAL
     {
        /// <summary>
        /// Impelementation of method.
        /// </summary>
        /// <returns>value.</returns>
        List<ShippingAddressModel> GetAddress();

        /// <summary>
        /// Impelementation of method.
        /// </summary>
        /// <param name="list">list.</param>
        /// <returns>value.</returns>
        int InsertAddress(ShippingAddressModel list);

        /// <summary>
        /// Impelementation of method.
        /// </summary>
        /// <param name="update">list.</param>
        /// <returns>value.</returns>
        bool UpdateAddress(ShippingAddressModel update);
     }
}
