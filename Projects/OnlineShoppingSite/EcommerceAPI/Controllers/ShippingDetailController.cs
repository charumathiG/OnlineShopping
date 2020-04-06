// <copyright file="ShippingDetailController.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace EcommerceAPI.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using EcommerceBL.ShippingAddress;
    using EcommerceDAL.ShippingAddress;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;

    /// <summary>
    /// Controller Class of ShippingDetailController.
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class ShippingDetailController : ControllerBase
    {
        private IShippingAddressBL bl;

        /// <summary>
        /// Initializes a new instance of the <see cref="ShippingDetailController"/> class.
        /// </summary>
        /// <param name="bL">BL.</param>
        public ShippingDetailController(IShippingAddressBL bL)
        {
            this.bl = bL;
        }

        /// <summary>
        /// Method for GetDetailList.
        /// </summary>
        /// <returns>DAL.</returns>
        [HttpGet]
        public List<ShippingAddressModel> GetDetailList()
        {
            return this.bl.GetDetailList();
        }

        /// <summary>
        /// Method for InsertDetailList.
        /// </summary>
        /// <param name="view">BL.</param>
        /// <returns>DAL.</returns>
        [HttpPost]
        public int InsertDetailList(ShippingAddressModel view)
        {
            return this.bl.InsertDetailList(view);
        }

        /// <summary>
        /// Method for UpdateDetailList.
        /// </summary>
        /// <param name="updateList">BL.</param>
        /// <returns>DAL.</returns>
        [HttpPut]
        public bool UpdateDetailList(ShippingAddressModel updateList)
        {
            return this.bl.UpdateDetailList(updateList);
        }
    }
}
