// <copyright file="IPaymentModeBL.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace EcommerceBL.PaymentMode
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using EcommerceDAL.PaymentMode;

    /// <summary>
    /// Implementation of Interface.
    /// </summary>
    public interface IPaymentModeBL
    {
        /// <summary>
        /// Implementation of Method.
        /// </summary>
        /// <param name="view">veiw.</param>
        /// <returns>value.</returns>
        int InsertPayModeList(PaymentModeModel view);

        /// <summary>
        /// Implementation of Method.
        /// </summary>
        /// <returns>value.</returns>
        List<PaymentModeModel> GetPaymentList();

        /// <summary>
        /// Implementation of Method.
        /// </summary>
        /// <param name="updateList">list.</param>
        /// <returns>value.</returns>
        bool UpdatePaymentList(PaymentModeModel updateList);
    }
}
