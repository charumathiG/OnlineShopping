// <copyright file="IYourOrderBL.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace EcommerceBL.YourOrder
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using EcommerceDAL.YourOrder;

    /// <summary>
    /// Implementation of Interface.
    /// </summary>
    public interface IYourOrderBL
     {
        /// <summary>
        /// Implementation of Method.
        /// </summary>
        /// <param name="view">view.</param>
        /// <returns>value.</returns>
        int InsertOrderList(YourOrderModel view);

        /// <summary>
        /// Implementation of Method.
        /// </summary>
        /// <returns>value.</returns>
        List<YourOrderModel> GetOrderList();

        /// <summary>
        /// Implementation of Method.
        /// </summary>
        /// <param name="updateList">list.</param>
        /// <returns>value.</returns>
        bool UpdateOrderList(YourOrderModel updateList);

        /// <summary>
        /// Implementation of Method.
        /// </summary>
        /// <param name="deleteList">list.</param>
        /// <returns>value.</returns>
        bool DeleteOrderList(YourOrderModel deleteList);
     }
}
