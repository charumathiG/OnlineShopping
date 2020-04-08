// <copyright file="PaymentBL.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace EcommerceBL.Payment
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using EcommerceDAL.PaymentDAL;

    /// <summary>
    /// Implementation of a Class.
    /// </summary>
    public class PaymentBL : IPaymentBL
    {
        private IPaymentDAL dal;

        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentBL"/> class.
        /// </summary>
        /// <param name="dal">dal.</param>
        public PaymentBL(IPaymentDAL dal)
        {
            this.dal = dal;
        }

        /// <summary>
        /// Implementation of Method.
        /// </summary>
        /// <returns>value.</returns>
        public List<PaymentModel> GetPaymentList()
        {
            return this.dal.GetPayment();
        }
    }
}
