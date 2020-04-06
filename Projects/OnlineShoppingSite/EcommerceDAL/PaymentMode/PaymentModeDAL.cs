// <copyright file="PaymentModeDAL.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace EcommerceDAL.FeedbackDAL.PaymentModeDAL
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Data.SqlClient;
    using System.Text;
    using EcommerceDAL.PaymentMode;
    using EcommerceDAL.RepositoryPattern;

    /// <summary>
    /// Implementation of a Class.
    /// </summary>
    public class PaymentModeDAL : IPaymentModeDAL
    {
        private IBaseDAL basedal;

        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentModeDAL"/> class.
        /// </summary>
        /// <param name="baseDAL">value.</param>
        public PaymentModeDAL(IBaseDAL baseDAL)
        {
            this.basedal = baseDAL;
        }

        /// <summary>
        /// Implementation of Method.
        /// </summary>
        /// <returns>value.</returns>
        public List<PaymentModeModel> GetPaymentMode()
        {
            var parameter = new List<SqlParameter>();
            List<PaymentModeModel> list = new List<PaymentModeModel>();
            PaymentModeModel mode = null;
            var payList = this.basedal.GetData("SP_GetPayment", CommandType.StoredProcedure);
            foreach (DataRow data in payList.Tables[0].Rows)
            {
                mode = new PaymentModeModel();
                mode.PaymentModeId = Convert.ToInt32(data[0]);
                mode.ModeOfPayment = data[1].ToString();

                list.Add(mode);
            }

            return list;
        }

        /// <summary>
        /// Implementation of Method.
        /// </summary>
        /// <param name="list">list.</param>
        /// <returns>value.</returns>
        public int InsertPayment(PaymentModeModel list)
        {
            var parameter = new List<SqlParameter>();
            parameter.Add(this.basedal.CreateParameter("@PaymentModeId", 5, list.PaymentModeId, DbType.Int16));
            parameter.Add(this.basedal.CreateParameter("@ModeOfPayment", 5, list.ModeOfPayment, DbType.Int16));

            this.basedal.Insert("SP_InsertPayment", CommandType.StoredProcedure, parameter.ToArray(), out int lastId);

            return lastId;
        }

        /// <summary>
        /// Implementation of Method.
        /// </summary>
        /// <param name="update">list.</param>
        /// <returns>value.</returns>
        public bool UpdatePayment(PaymentModeModel update)
        {
            var parameter = new List<SqlParameter>();
            parameter.Add(this.basedal.CreateParameter("@PaymentModeId", 5, update.PaymentModeId, DbType.Int16));
            this.basedal.Update("SP_UpdatePayment", CommandType.StoredProcedure, parameter.ToArray(), out bool status);
            return status;
        }
    }
}
