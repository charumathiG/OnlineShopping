// <copyright file="CategoryBL.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace EcommerceBL.Category
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using EcommerceDAL.Category;
    using EcommerceDAL.RepositoryPattern;

    /// <summary>
    /// Implementation of Class.
    /// </summary>
    public class CategoryBL : ICategoryBL
    {
        private ICategoryDAL dal;

        /// <summary>
        /// Initializes a new instance of the <see cref="CategoryBL"/> class.
        /// </summary>
        /// <param name="daL"> dal.</param>
        public CategoryBL(ICategoryDAL daL)
        {
            this.dal = daL;
        }

        /// <summary>
        /// Implementation of Method.
        /// </summary>
        /// <returns>value.</returns>
        public List<CategoryModel> GetCategoryList()
        {
           return this.dal.GetCategory();
        }
    }
}
