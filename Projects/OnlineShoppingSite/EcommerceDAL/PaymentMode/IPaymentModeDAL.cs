// <copyright file="IPaymentModeDAL.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>
namespace EcommerceDAL.FeedbackDAL
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using EcommerceDAL;
    using EcommerceDAL.PaymentMode;

    /// <summary>
    /// Implementation of a Class.
    /// </summary>
    public interface IPaymentModeDAL
    {
        /// <summary>
        /// Implementation of Method.
        /// </summary>
        /// <returns>value.</returns>
        List<PaymentModeModel> GetPaymentMode();

        /// <summary>
        /// Implementation of a Method.
        /// </summary>
        /// <param name="list">list.</param>
        /// <returns>value.</returns>
        int InsertPayment(PaymentModeModel list);

        /// <summary>
        /// Implementation of method.
        /// </summary>
        /// <param name="update">list.</param>
        /// <returns>value.</returns>
        bool UpdatePayment(PaymentModeModel update);
    }
}
