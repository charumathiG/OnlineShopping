// <copyright file="ShippingAddressModel.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace EcommerceDAL.ShippingAddress
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Implementation of a Class.
    /// </summary>
    public class ShippingAddressModel
    {
        /// <summary>
        /// Gets or sets implementation of property.
        /// </summary>
        public int ShippingId { get; set; }

        /// <summary>
        ///  Gets or sets implementation of property.
        /// </summary>
        public int OrderId { get; set; }

        /// <summary>
        ///  Gets or sets implementation of property.
        /// </summary>
        public string ShippingAddress { get; set; }

        /// <summary>
        ///  Gets or sets implementation of property.
        /// </summary>
        public string ContactNumber { get; set; }
    }
}
