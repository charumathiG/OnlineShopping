// <copyright file="IPaymentDAL.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace EcommerceDAL.PaymentDAL
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using EcommerceDAL;

    /// <summary>
    /// Implementation of Interface.
    /// </summary>
    public interface IPaymentDAL
    {
        /// <summary>
        /// Implementation of Method.
        /// </summary>
        /// <returns>value.</returns>
        List<PaymentModel> GetPayment();

        /// <summary>
        /// Implementation of Method.
        /// </summary>
        /// <param name="list">list.</param>
        /// <returns>value.</returns>
        int InsertPayment(PaymentModel list);

        /// <summary>
        /// Implementation of Method.
        /// </summary>
        /// <param name="update">list.</param>
        /// <returns>value.</returns>
        bool UpdatePayment(PaymentModel update);
    }
}
