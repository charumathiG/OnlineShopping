// <copyright file="ProductsListController.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>
namespace EcommerceAPI.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using EcommerceBL.Products;
    using EcommerceDAL.ProductsDAL;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;

    /// <summary>
    /// Implementation of a class.
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsListController : ControllerBase
    {
        private IProductListBL bl;

        /// <summary>
        /// Initializes a new instance of the <see cref="ProductsListController"/> class.
        /// </summary>
        /// <param name="bL">value.</param>
        public ProductsListController(IProductListBL bL)
        {
            this.bl = bL;
        }

        /// <summary>
        /// Implementation of a Method.
        /// </summary>
        /// <param name="categoryId">categoryId.</param>
        /// <returns>value.</returns>
        [HttpGet]
        public List<ProductsListModel> GetProductById(int categoryId)
        {
            return this.bl.GetProductById(categoryId);
        }
    }
}