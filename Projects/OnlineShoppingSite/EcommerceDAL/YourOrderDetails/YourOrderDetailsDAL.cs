// <copyright file="YourOrderDetailsDAL.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace EcommerceDAL.YourOrderDetails
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Data.SqlClient;
    using System.Text;
    using EcommerceDAL.RepositoryPattern;
    using EcommerceDAL.YourOrderDetails;

    /// <summary>
    /// Implementation of a Class.
    /// </summary>
    public class YourOrderDetailsDAL : IYourOrderDetailsDAL
    {
        private IBaseDAL basedal;

        /// <summary>
        /// Initializes a new instance of the <see cref="YourOrderDetailsDAL"/> class.
        /// </summary>
        /// <param name="baseDAL">list.</param>
        public YourOrderDetailsDAL(IBaseDAL baseDAL)
        {
            this.basedal = baseDAL;
        }

        /// <summary>
        /// Implementation of Method.
        /// </summary>
        /// <returns>value.</returns>
        public List<YourOrderDetailModel> GetOrderDetail()
        {
            var parameter = new List<SqlParameter>();
            List<YourOrderDetailModel> list = new List<YourOrderDetailModel>();
            YourOrderDetailModel orderDetail = null;
            var order = this.basedal.GetData("SP_GetYourOrderDetails", CommandType.StoredProcedure);
            foreach (DataRow data in order.Tables[0].Rows)
            {
                orderDetail = new YourOrderDetailModel();
                orderDetail.OrderId = Convert.ToInt32(data[0]);
                orderDetail.PaymentId = Convert.ToInt32(data[1]);
                orderDetail.CustomerId = Convert.ToInt16(data[2]);
                orderDetail.TotalPrice = Convert.ToInt32(data[3]);
                orderDetail.Quantity = Convert.ToInt32(data[4]);

                list.Add(orderDetail);
            }

            return list;
        }
    }
}
