// <copyright file="AddCartModel.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace EcommerceDAL.AddToCart
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Implementation of a class.
    /// </summary>
    public class AddCartModel
    {
        /// <summary>
        /// Gets or sets implementation of Property.
        /// </summary>
        public int CartId { get; set; }

        /// <summary>
        /// Gets or sets implementation of Property.
        /// </summary>
        public int CustomerId { get; set; }

        /// <summary>
        /// Gets or sets implementation of Property.
        /// </summary>
        public string ProductId { get; set; }

        /// <summary>
        /// Gets or sets implementation of Property.
        /// </summary>
        public float Price { get; set; }

        /// <summary>
        /// Gets or sets implementation of Property.
        /// </summary>
        public int Quantity { get; set; }

        /// <summary>
        /// Gets or sets implementation of Property.
        /// </summary>
        public DateTime Date { get; set; }
    }
}
