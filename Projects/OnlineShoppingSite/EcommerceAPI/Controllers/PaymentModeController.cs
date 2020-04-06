// <copyright file="PaymentModeController.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>
namespace EcommerceAPI.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using EcommerceBL.PaymentMode;
    using EcommerceDAL.PaymentMode;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;

    /// <summary>
    /// Controller class for PaymentModeController.
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentModeController : ControllerBase
    {
        private IPaymentModeBL bl;

        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentModeController"/> class.
        /// </summary>
        /// <param name="bL">value.</param>
        public PaymentModeController(IPaymentModeBL bL)
        {
            this.bl = bL;
        }

        /// <summary>
        /// Method for GetPaymentList.
        /// </summary>
        /// <returns>value.</returns>
        [HttpGet]
        public List<PaymentModeModel> GetPaymentList()
        {
            return this.bl.GetPaymentList();
        }

        /// <summary>
        /// Method for InsertPayModeList.
        /// </summary>
        /// <param name="view">BL.</param>
        /// <returns>DAL.</returns>
        [HttpPost]
        public int InsertPayModeList(PaymentModeModel view)
        {
            return this.bl.InsertPayModeList(view);
        }

        /// <summary>
        /// Method for UpdatePaymentList.
        /// </summary>
        /// <param name="updateList">BL.</param>
        /// <returns> DAL.</returns>
        [HttpPut]
        public bool UpdatePaymentList(PaymentModeModel updateList)
        {
            return this.bl.UpdatePaymentList(updateList);
        }
    }
}