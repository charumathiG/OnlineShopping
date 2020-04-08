// <copyright file="YourOrderDetailsBL.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace EcommerceBL.YourOrderDetails
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using EcommerceDAL.RepositoryPattern;
    using EcommerceDAL.YourOrderDetails;

    /// <summary>
    /// Implementation of a Class.
    /// </summary>
    public class YourOrderDetailsBL : IYourOrderDetailsBL
    {
        private IYourOrderDetailsDAL dal;

        /// <summary>
        /// Initializes a new instance of the <see cref="YourOrderDetailsBL"/> class.
        /// </summary>
        /// <param name="daL">dal.</param>
        public YourOrderDetailsBL(IYourOrderDetailsDAL daL)
        {
            this.dal = daL;
        }

        /// <summary>
        /// Implementation of Method.
        /// </summary>
        /// <returns>value.</returns>
        public List<YourOrderDetailModel> GetYourOrderList()
        {
            return this.dal.GetOrderDetail();
        }
    }
}
