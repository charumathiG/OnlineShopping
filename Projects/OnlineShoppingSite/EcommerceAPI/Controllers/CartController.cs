// <copyright file="CartController.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>
namespace EcommerceAPI.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using EcommerceBL;
    using EcommerceBL.AddToCart;
    using EcommerceDAL.AddToCart;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;

    /// <summary>
    /// Controller Class for CartController.
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class CartController : ControllerBase
    {
        private IAddCartBL bl;

        /// <summary>
        /// Initializes a new instance of the <see cref="CartController"/> class.
        /// </summary>
        /// <param name="bL">bL.</param>
        public CartController(IAddCartBL bL)
        {
            this.bl = bL;
        }

        /// <summary>
        /// Method for GetCartList.
        /// </summary>
        /// <returns>List.</returns>
        // GET: api/Cart
        [HttpGet]
        public List<AddCartModel> GetCartList()
        {
            return this.bl.GetCartList();
        }

        /// <summary>
        /// Method for InsertCardList.
        /// </summary>
        /// <param name="view"> view.</param>
        /// <returns> DAL. </returns>
        // POST: api/Cart
        [HttpPost]
        public int InsertCartList(AddCartModel view)
        {
            return this.bl.InsertCartList(view);
        }

        /// <summary>
        /// Method for UpdateCartList.
        /// </summary>
        /// <param name="updateList"> BL.</param>
        /// <returns> DAL.</returns>
        // PUT: api/Cart/5
        [HttpPut("{id}")]
        public bool UpdateCartList(AddCartModel updateList)
        {
            return this.bl.UpdateCartList(updateList);
        }

        /// <summary>
        /// Method for DeleteCartList.
        /// </summary>
        /// <param name="deleteList"> BL.</param>
        /// <returns> DAL.</returns>
        [HttpDelete]
        public bool DeleteCartList(AddCartModel deleteList)
        {
            return this.bl.DeleteCartList(deleteList);
        }
    }
}
