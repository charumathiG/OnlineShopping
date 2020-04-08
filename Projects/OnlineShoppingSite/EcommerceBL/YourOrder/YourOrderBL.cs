// <copyright file="YourOrderBL.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace EcommerceBL.YourOrder
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using EcommerceDAL.RepositoryPattern;
    using EcommerceDAL.YourOrder;

    /// <summary>
    /// Implementation of Interface.
    /// </summary>
    public class YourOrderBL : IYourOrderBL
    {
        private IYourOrderDAL dal;

        /// <summary>
        /// Initializes a new instance of the <see cref="YourOrderBL"/> class.
        /// </summary>
        /// <param name="daL">dal.</param>
        public YourOrderBL(IYourOrderDAL daL)
        {
            this.dal = daL;
        }

        /// <summary>
        /// Implementation of Method.
        /// </summary>
        /// <param name="deleteList">list.</param>
        /// <returns>value.</returns>
        public bool DeleteOrderList(YourOrderModel deleteList)
        {
            return this.dal.DeleteOrder(deleteList);
        }

        /// <summary>
        /// Implementation of Method.
        /// </summary>
        /// <returns>value.</returns>
        public List<YourOrderModel> GetOrderList()
        {
            return this.dal.GetOrder();
        }

        /// <summary>
        /// Implementation of Method.
        /// </summary>
        /// <param name="view">view.</param>
        /// <returns>value.</returns>
        public int InsertOrderList(YourOrderModel view)
        {
            return this.dal.InsertOrder(view);
        }

        /// <summary>
        /// Implementation of Method.
        /// </summary>
        /// <param name="updateList">list.</param>
        /// <returns>value.</returns>
        public bool UpdateOrderList(YourOrderModel updateList)
        {
            return this.dal.UpdateOrder(updateList);
        }
    }
}
