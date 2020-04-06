// <copyright file="PaymentDAL.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>
namespace EcommerceDAL.PaymentDAL
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Data.SqlClient;
    using System.Text;
    using EcommerceDAL.PaymentDAL;
    using EcommerceDAL.RepositoryPattern;

    /// <summary>
    /// Implemenattion of a Class.
    /// </summary>
    public class PaymentDAL : IPaymentDAL
    {
        private IBaseDAL basedal;

        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentDAL"/> class.
        /// </summary>
        /// <param name="baseDAL">value.</param>
        public PaymentDAL(IBaseDAL baseDAL)
        {
            this.basedal = baseDAL;
        }

        /// <summary>
        /// Implementation of Method.
        /// </summary>
        /// <returns>value.</returns>
        public List<PaymentModel> GetPayment()
        {
            var parameter = new List<SqlParameter>();
            List<PaymentModel> list = new List<PaymentModel>();
            PaymentModel pay = null;
            var paylist = this.basedal.GetData("SP_GetPaymentDetail", CommandType.StoredProcedure);
            foreach (DataRow data in paylist.Tables[0].Rows)
            {
                pay = new PaymentModel();
                pay.PaymentId = Convert.ToInt32(data[0]);
                pay.ProductId = Convert.ToInt32(data[1]);
                pay.PaymentModeId = Convert.ToInt32(data[2]);
                pay.CustomerId = Convert.ToInt32(data[3]);
                pay.Quantity = Convert.ToInt32(data[4]);
                pay.TotalPrice = Convert.ToInt32(data[5]);
                pay.Date = Convert.ToInt32(data[5]);

                list.Add(pay);
            }

            return list;
        }

        /// <summary>
        /// Implementation of Method.
        /// </summary>
        /// <param name="list">list.</param>
        /// <returns>value.</returns>
        public int InsertPayment(PaymentModel list)
        {
            var parameter = new List<SqlParameter>();
            parameter.Add(this.basedal.CreateParameter("@PaymentId", 5, list.PaymentId, DbType.Int16));
            parameter.Add(this.basedal.CreateParameter("@ProductId", 5, list.ProductId, DbType.Int16));
            parameter.Add(this.basedal.CreateParameter("@PaymentModeId", 5, list.PaymentModeId, DbType.String));
            parameter.Add(this.basedal.CreateParameter("@CustomerId", 9, list.CustomerId, DbType.VarNumeric));
            parameter.Add(this.basedal.CreateParameter("@Quantity", 50, list.Quantity, DbType.Int16));
            parameter.Add(this.basedal.CreateParameter("@TotalPrice", 500, list.TotalPrice, DbType.Int16));
            parameter.Add(this.basedal.CreateParameter("@Date", 50, list.Date, DbType.DateTime));

            this.basedal.Insert("SP_InsertCart", CommandType.StoredProcedure, parameter.ToArray(), out int lastId);

            return lastId;
        }

        /// <summary>
        /// Implementation of Method.
        /// </summary>
        /// <param name="update">list.</param>
        /// <returns>value.</returns>
        public bool UpdatePayment(PaymentModel update)
        {
            var parameter = new List<SqlParameter>();
            parameter.Add(this.basedal.CreateParameter("@Quantity", 50, update.Quantity, DbType.Int16));
            this.basedal.Update("SP_UpdateCart", CommandType.StoredProcedure, parameter.ToArray(), out bool status);
            return status;
        }
    }
}
