// <copyright file="PaymentController.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace EcommerceAPI.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using EcommerceBL.Payment;
    using EcommerceDAL.PaymentDAL;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;

    /// <summary>
    /// A class for PaymentController.
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentController : ControllerBase
    {
        private IPaymentBL bl;

        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentController"/> class.
        /// </summary>
        /// <param name="bL">value.</param>
        public PaymentController(IPaymentBL bL)
        {
            this.bl = bL;
        }

        /// <summary>
        /// Method for GetPaymentList.
        /// </summary>
        /// <returns> value.</returns>
        [HttpGet]
        [Route("api/GetPaymentDetail")]
        public List<PaymentModel> GetPaymentList()
        {
            return this.bl.GetPaymentList();
        }
    }
}