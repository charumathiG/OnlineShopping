// <copyright file="PaymentModel.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace EcommerceDAL.PaymentDAL
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Implementation of a Class.
    /// </summary>
    public class PaymentModel
     {
        /// <summary>
        /// Gets or sets implementation of Property.
        /// </summary>
        public int PaymentId { get; set; }

        /// <summary>
        /// Gets or sets implementation of Property.
        /// </summary>
        public int ProductId { get; set; }

        /// <summary>
        /// Gets or sets implementation of Property.
        /// </summary>
        public int PaymentModeId { get; set; }

        /// <summary>
        /// Gets or sets implementation of Property.
        /// </summary>
        public int CustomerId { get; set; }

        /// <summary>
        /// Gets or sets implementation of Property.
        /// </summary>
        public int Quantity { get; set; }

        /// <summary>
        /// Gets or sets implementation of Property.
        /// </summary>
        public int TotalPrice { get; set; }

        /// <summary>
        /// Gets or sets implementation of Property.
        /// </summary>
        public int Date { get; set; }
     }
}
