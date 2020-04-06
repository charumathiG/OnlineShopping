// <copyright file="YourOrderDetailModel.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace EcommerceDAL.YourOrderDetails
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Implementation of a Class.
    /// </summary>
    public class YourOrderDetailModel
    {
        /// <summary>
        /// Gets or sets implementation of a Property.
        /// </summary>
        public int OrderId { get; set; }

        /// <summary>
        /// Gets or sets implementation of a Property.
        /// </summary>
        public int PaymentId { get; set; }

        /// <summary>
        /// Gets or sets implementation of a Property.
        /// </summary>
        public int CustomerId { get; set; }

        /// <summary>
        /// Gets or sets implementation of a Property.
        /// </summary>
        public int TotalPrice { get; set; }

        /// <summary>
        /// Gets or sets implementation of a Property.
        /// </summary>
        public int Quantity { get; set; }
    }
}
