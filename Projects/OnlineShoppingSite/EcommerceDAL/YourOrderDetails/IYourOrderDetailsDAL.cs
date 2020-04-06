// <copyright file="IYourOrderDetailsDAL.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace EcommerceDAL.YourOrderDetails
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using EcommerceDAL;

    /// <summary>
    /// Implementation of Interface.
    /// </summary>
    public interface IYourOrderDetailsDAL
    {
        /// <summary>
        /// Implementation of Method.
        /// </summary>
        /// <returns>value.</returns>
        List<YourOrderDetailModel> GetOrderDetail();
    }
}
