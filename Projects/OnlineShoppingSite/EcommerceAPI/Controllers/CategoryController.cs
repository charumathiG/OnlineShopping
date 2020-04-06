// <copyright file="CategoryController.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace EcommerceAPI.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using EcommerceBL.Category;
    using EcommerceDAL.Category;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;

    /// <summary>
    /// A class for CategoryController.
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private ICategoryBL bl;

        /// <summary>
        /// Initializes a new instance of the <see cref="CategoryController"/> class.
        /// </summary>
        /// <param name="bL"> bL.</param>
        public CategoryController(ICategoryBL bL)
        {
            this.bl = bL;
        }

        /// <summary>
        /// Method for GetCategoryList.
        /// </summary>
        /// <returns> Value.</returns>
        [HttpGet]
        public List<CategoryModel> GetCategoryList()
        {
            return this.bl.GetCategoryList();
        }
    }
}