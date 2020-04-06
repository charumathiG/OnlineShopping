// <copyright file="CategoryDAL.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace EcommerceDAL.Category
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Data.SqlClient;
    using System.Text;
    using EcommerceDAL.Category;
    using EcommerceDAL.RepositoryPattern;

    /// <summary>
    /// Implementation of a Class.
    /// </summary>
    public class CategoryDAL : ICategoryDAL
    {
        private IBaseDAL basedal;

        /// <summary>
        /// Initializes a new instance of the <see cref="CategoryDAL"/> class.
        /// </summary>
        /// <param name="baseDAL">value.</param>
        public CategoryDAL(IBaseDAL baseDAL)
        {
            this.basedal = baseDAL;
        }

        /// <summary>
        /// Implementation of Method.
        /// </summary>
        /// <returns>value.</returns>
        public List<CategoryModel> GetCategory()
        {
            var parameter = new List<SqlParameter>();
            List<CategoryModel> list = new List<CategoryModel>();
            CategoryModel categoryList = null;
            var category = this.basedal.GetData("SP_GetCategory", CommandType.StoredProcedure);
            foreach (DataRow data in category.Tables[0].Rows)
            {
                categoryList = new CategoryModel();
                categoryList.CategoryId = Convert.ToInt32(data[0]);
                categoryList.CategoryName = data[1].ToString();
                categoryList.Description = data[2].ToString();

                list.Add(categoryList);
            }

            return list;
        }
    }
}
