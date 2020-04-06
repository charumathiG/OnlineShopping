// <copyright file="YourOrderModel.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace EcommerceDAL.YourOrder
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Implementation of a Class.
    /// </summary>
    public class YourOrderModel
     {
        /// <summary>
        /// Gets or sets implementation of property.
        /// </summary>
        public int OrderId { get; set; }

        /// <summary>
        ///  Gets or sets implementation of property.
        /// </summary>
        public string ProductId { get; set; }

        /// <summary>
        ///  Gets or sets implementation of property.
        /// </summary>
        public int CustomerId { get; set; }

        /// <summary>
        ///  Gets or sets implementation of property.
        /// </summary>
        public DateTime OrderDate { get; set; }

        /// <summary>
        ///  Gets or sets implementation of property.
        /// </summary>
        public DateTime OrderDeliveryDate { get; set; }

        /// <summary>
        ///  Gets or sets implementation of property.
        /// </summary>
        public string Status { get; set; }
    }
}
