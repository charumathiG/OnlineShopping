// <copyright file="YourOrderController.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace EcommerceAPI.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using EcommerceBL;
    using EcommerceBL.YourOrder;
    using EcommerceDAL;
    using EcommerceDAL.YourOrder;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;

    /// <summary>
    /// Controller class of YourOrderController.
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class YourOrderController : ControllerBase
    {
        private IYourOrderBL bl;

        /// <summary>
        /// Initializes a new instance of the <see cref="YourOrderController"/> class.
        /// </summary>
        /// <param name="bL">bl.</param>
        public YourOrderController(IYourOrderBL bL)
        {
            this.bl = bL;
        }

        /// <summary>
        /// Method for GetOrderList.
        /// </summary>
        /// <returns>value.</returns>
        [HttpGet]
        public List<YourOrderModel> GetOrderList()
        {
            return this.bl.GetOrderList();
        }

        /// <summary>
        /// Method for InsertOrderList.
        /// </summary>
        /// <param name="view">view.</param>
        /// <returns>Dal.</returns>
        [HttpPost]
        public int InsertOrderList(YourOrderModel view)
        {
            return this.bl.InsertOrderList(view);
        }

        /// <summary>
        /// Method for UpdateOrderList.
        /// </summary>
        /// <param name="updateList"> updatelist.</param>
        /// <returns>DAL.</returns>
        [HttpPut]
        public bool UpdateOrderList(YourOrderModel updateList)
        {
            return this.bl.UpdateOrderList(updateList);
        }

        /// <summary>
        /// Method for DeleteOrderList.
        /// </summary>
        /// <param name="deleteList"> deleteList.</param>
        /// <returns>DAL.</returns>
        [HttpDelete]
        public bool DeleteOrderList(YourOrderModel deleteList)
        {
            return this.bl.DeleteOrderList(deleteList);
        }
    }
}
