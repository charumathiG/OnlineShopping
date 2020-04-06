// <copyright file="IYourOrderDAL.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace EcommerceDAL.YourOrder
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using EcommerceDAL;

    /// <summary>
    /// Implementation of Interface.
    /// </summary>
    public interface IYourOrderDAL
     {
        /// <summary>
        /// Implementation of Method.
        /// </summary>
        /// <returns>value.</returns>
        List<YourOrderModel> GetOrder();

        /// <summary>
        /// Implementation of Method.
        /// </summary>
        /// <param name="list">list.</param>
        /// <returns>value.</returns>
        int InsertOrder(YourOrderModel list);

        /// <summary>
        /// Implementation of Method.
        /// </summary>
        /// <param name="update">list.</param>
        /// <returns>value.</returns>
        bool UpdateOrder(YourOrderModel update);

        /// <summary>
        /// Implementation of Method.
        /// </summary>
        /// <param name="delete">list.</param>
        /// <returns>value.</returns>
        bool DeleteOrder(YourOrderModel delete);
     }
}
