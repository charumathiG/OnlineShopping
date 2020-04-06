// <copyright file="IPaymentBL.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace EcommerceBL.Payment
{
using System;
using System.Collections.Generic;
using System.Text;
using EcommerceDAL.PaymentDAL;

    /// <summary>
    /// Implementation of Interface.
    /// </summary>
public interface IPaymentBL
    {
        /// <summary>
        /// Implementation of Method.
        /// </summary>
        /// <returns>dal.</returns>
        List<PaymentModel> GetPaymentList();
    }
}
