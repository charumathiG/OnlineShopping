// <copyright file="ProductController.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>
namespace EcommerceAPI.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using EcommerceBL;
    using EcommerceBL.Products;
    using EcommerceDAL;
    using EcommerceDAL.ProductsDAL;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;

    /// <summary>
    /// Controller class for ProductController.
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private IProductListBL bl;

        /// <summary>
        /// Initializes a new instance of the <see cref="ProductController"/> class.
        /// </summary>
        /// <param name="bL"> BL.</param>
        public ProductController(IProductListBL bL)
        {
            this.bl = bL;
        }

        /// <summary>
        /// Implementation of method.
        /// </summary>
        /// <param name="keyword">keyword.</param>
        /// <returns>value.</returns>
        [HttpGet]
        public List<ProductsListModel> Searching(string keyword)
        {
            return this.bl.Searching(keyword);
        }

        ///// <summary>
        ///// Method for GetProductsList.
        ///// </summary>
        ///// <returns> DAL.</returns>
        // [HttpGet]
        // public List<ProductsListModel> GetProductsList()
        // {
        //    return this.bl.GetProductsList();
        // }

        /// <summary>
        /// Method for InsertProducts.
        /// </summary>
        /// <param name="view">BL.</param>
        /// <returns>DAL.</returns>
        [HttpPost]
        public int InsertProducts(ProductsListModel view)
        {
            return this.bl.InsertProducts(view);
        }

        /// <summary>
        /// Method for DeleteProducts.
        /// </summary>
        /// <param name="deleteList">BL.</param>
        /// <returns>DAL.</returns>
        [HttpDelete]
        public bool DeleteProducts(ProductsListModel deleteList)
        {
            return this.bl.DeleteProducts(deleteList);
        }

        /// <summary>
        /// Method for UpdateProductList.
        /// </summary>
        /// <param name="updateList">BL.</param>
        /// <returns>DAL.</returns>
        [HttpPut]
        public bool UpdateProductList(ProductsListModel updateList)
        {
            return this.bl.UpdateProductList(updateList);
        }
    }
}
