// <copyright file="ICategoryBL.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>
namespace EcommerceBL.Category
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using EcommerceDAL.Category;

    /// <summary>
    /// Implementation of Interface.
    /// </summary>
    public interface ICategoryBL
    {
        /// <summary>
        /// Implementation of Method.
        /// </summary>
        /// <returns>DAL.</returns>
        List<CategoryModel> GetCategoryList();
    }
}
