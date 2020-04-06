// <copyright file="YourOrderDetailsController.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace EcommerceAPI.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using EcommerceBL.YourOrderDetails;
    using EcommerceDAL.YourOrderDetails;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;

    /// <summary>
    /// Controller Class of YourOrderDetailsController.
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class YourOrderDetailsController : ControllerBase
    {
        private IYourOrderDetailsBL bl;

        /// <summary>
        /// Initializes a new instance of the <see cref="YourOrderDetailsController"/> class.
        /// </summary>
        /// <param name="bL">bl.</param>
        public YourOrderDetailsController(IYourOrderDetailsBL bL)
        {
            this.bl = bL;
        }

        /// <summary>
        /// Method for GetYourOrderList.
        /// </summary>
        /// <returns>DAl.</returns>
        [HttpGet]
        public List<YourOrderDetailModel> GetYourOrderList()
        {
            return this.bl.GetYourOrderList();
        }
    }
}