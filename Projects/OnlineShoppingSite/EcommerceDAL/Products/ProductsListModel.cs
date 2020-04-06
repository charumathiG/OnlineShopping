// <copyright file="ProductsListModel.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace EcommerceDAL.ProductsDAL
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Implementation of a Class.
    /// </summary>
    public class ProductsListModel
    {
        /// <summary>
        /// Gets or sets implementation of property.
        /// </summary>
        public string ProductId { get; set; }

        /// <summary>
        /// Gets or sets implementation of property.
        /// </summary>
        public string ProductName { get; set; }

        /// <summary>
        /// Gets or sets implementation of property.
        /// </summary>
        public string CategoryId { get; set; }

        /// <summary>
        /// Gets or sets implementation of property.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets implementation of property.
        /// </summary>
        public int Price { get; set; }

        /// <summary>
        /// Gets or sets implementation of property.
        /// </summary>
        public int Quantity { get; set; }

        /// <summary>
        /// Gets or sets implementation of property.
        /// </summary>
        public string Image { get; set; }
    }
}
