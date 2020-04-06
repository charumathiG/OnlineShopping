// <copyright file="IYourOrderDetailsBL.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace EcommerceBL.YourOrderDetails
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using EcommerceDAL.YourOrderDetails;

    /// <summary>
    /// Implementation of Interface.
    /// </summary>
    public interface IYourOrderDetailsBL
    {
        /// <summary>
        /// Implementation of Method.
        /// </summary>
        /// <returns>value.</returns>
        List<YourOrderDetailModel> GetYourOrderList();
    }
}
