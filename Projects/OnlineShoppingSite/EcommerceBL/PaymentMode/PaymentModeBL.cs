// <copyright file="PaymentModeBL.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace EcommerceBL.PaymentMode
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using EcommerceDAL.FeedbackDAL;
    using EcommerceDAL.PaymentMode;

    /// <summary>
    /// Implementation of a Class.
    /// </summary>
    public class PaymentModeBL : IPaymentModeBL
    {
        private IPaymentModeDAL dal;

        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentModeBL"/> class.
        /// </summary>
        /// <param name="daL">value.</param>
        public PaymentModeBL(IPaymentModeDAL daL)
        {
            this.dal = daL;
        }

        /// <summary>
        /// implementation of Method.
        /// </summary>
        /// <returns>value.</returns>
        public List<PaymentModeModel> GetPaymentList()
        {
            return this.dal.GetPaymentMode();
        }

        /// <summary>
        /// Implementation of Method.
        /// </summary>
        /// <param name="view">view.</param>
        /// <returns>value.</returns>
        public int InsertPayModeList(PaymentModeModel view)
        {
            return this.dal.InsertPayment(view);
        }

        /// <summary>
        /// Implementation of Method.
        /// </summary>
        /// <param name="updateList">list.</param>
        /// <returns>value.</returns>
        public bool UpdatePaymentList(PaymentModeModel updateList)
        {
            return this.dal.UpdatePayment(updateList);
        }
    }
}
