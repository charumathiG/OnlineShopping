// <copyright file="YourOrderDAL.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace EcommerceDAL.YourOrder
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Data.SqlClient;
    using System.Text;
    using EcommerceDAL.RepositoryPattern;
    using EcommerceDAL.YourOrder;

    /// <summary>
    /// Implementation of a Class.
    /// </summary>
    public class YourOrderDAL : IYourOrderDAL
    {
        private IBaseDAL basedal;

        /// <summary>
        /// Initializes a new instance of the <see cref="YourOrderDAL"/> class.
        /// </summary>
        /// <param name="baseDAL">value.</param>
        public YourOrderDAL(IBaseDAL baseDAL)
        {
            this.basedal = baseDAL;
        }

        /// <summary>
        /// Implementation of Method.
        /// </summary>
        /// <param name="delete">list.</param>
        /// <returns>value.</returns>
        public bool DeleteOrder(YourOrderModel delete)
        {
            var parameter = new List<SqlParameter>();
            parameter.Add(this.basedal.CreateParameter("@OrderId", 5, delete.OrderId, DbType.Int16));
            this.basedal.Update("SP_DeleteOrder", CommandType.StoredProcedure, parameter.ToArray(), out bool id);
            return id;
        }

        /// <summary>
        /// Implementation of Method.
        /// </summary>
        /// <returns>value.</returns>
        public List<YourOrderModel> GetOrder()
        {
            var parameter = new List<SqlParameter>();
            List<YourOrderModel> list = new List<YourOrderModel>();
            YourOrderModel order = null;
            var orderList = this.basedal.GetData("SP_GetOrder", CommandType.StoredProcedure);
            foreach (DataRow data in orderList.Tables[0].Rows)
            {
                order = new YourOrderModel();
                order.OrderId = Convert.ToInt32(data[0]);
                order.ProductId = data[1].ToString();
                order.CustomerId = Convert.ToInt32(data[2].ToString());
                order.OrderDate = Convert.ToDateTime(data[3]);
                order.OrderDeliveryDate = Convert.ToDateTime(data[4]);
                order.Status = data[5].ToString();

                list.Add(order);
            }

            return list;
        }

        /// <summary>
        /// Implementation of method.
        /// </summary>
        /// <param name="list">list.</param>
        /// <returns>value.</returns>
        public int InsertOrder(YourOrderModel list)
        {
            var parameter = new List<SqlParameter>();
            parameter.Add(this.basedal.CreateParameter("@OrderId", 5, list.OrderId, DbType.Int16));
            parameter.Add(this.basedal.CreateParameter("@CustomerId", 5, list.CustomerId, DbType.Int16));
            parameter.Add(this.basedal.CreateParameter("@ProductId", 5, list.ProductId, DbType.String));
            parameter.Add(this.basedal.CreateParameter("@OrderDate", 9, list.OrderDate, DbType.DateTime));
            parameter.Add(this.basedal.CreateParameter("@OrderDeliveryDate", 500, list.OrderDeliveryDate, DbType.DateTime));
            parameter.Add(this.basedal.CreateParameter("@Status", 50, list.Status, DbType.String));

            this.basedal.Insert("SP_InsertOrder", CommandType.StoredProcedure, parameter.ToArray(), out int lastId);

            return lastId;
        }

        /// <summary>
        /// Implementation of method.
        /// </summary>
        /// <param name="update">list.</param>
        /// <returns>value.</returns>
        public bool UpdateOrder(YourOrderModel update)
        {
            var parameter = new List<SqlParameter>();
            parameter.Add(this.basedal.CreateParameter("@CustomerId", 5, update.CustomerId, DbType.Int16));
            this.basedal.Update("SP_UpdateOrderById", CommandType.StoredProcedure, parameter.ToArray(), out bool status);
            return status;
        }
    }
}
