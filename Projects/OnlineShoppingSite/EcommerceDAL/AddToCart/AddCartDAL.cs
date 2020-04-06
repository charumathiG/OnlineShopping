// <copyright file="AddCartDAL.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace EcommerceDAL.AddToCart
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Data.SqlClient;
    using System.Text;
    using EcommerceDAL.AddToCart;
    using EcommerceDAL.RepositoryPattern;

    /// <summary>
    /// Implementation of a Class.
    /// </summary>
    public class AddCartDAL : IAddCartDAL
     {
        private IBaseDAL basedal;

        /// <summary>
        /// Initializes a new instance of the <see cref="AddCartDAL"/> class.
        /// </summary>
        /// <param name="baseDAL">value.</param>
        public AddCartDAL(IBaseDAL baseDAL)
        {
            this.basedal = baseDAL;
        }

        /// <summary>
        /// Implementation of Method.
        /// </summary>
        /// <param name="delete">delete.</param>
        /// <returns>value.</returns>
        public bool DeleteCart(AddCartModel delete)
        {
            var parameter = new List<SqlParameter>();
            parameter.Add(this.basedal.CreateParameter("@CartId", 5, delete.CartId, DbType.Int16));
            this.basedal.Update("SP_DeleteCart", CommandType.StoredProcedure, parameter.ToArray(), out bool id);
            return id;
        }

        /// <summary>
        /// Implementation of Method.
        /// </summary>
        /// <returns>value.</returns>
        public List<AddCartModel> GetCart()
        {
            var parameter = new List<SqlParameter>();
            List<AddCartModel> list = new List<AddCartModel>();
            AddCartModel cart = null;
            var cartlist = this.basedal.GetData("SP_GetCart", CommandType.StoredProcedure);
            foreach (DataRow data in cartlist.Tables[0].Rows)
            {
                cart = new AddCartModel();
                cart.CartId = Convert.ToInt32(data[0]);
                cart.CustomerId = Convert.ToInt32(data[1]);
                cart.ProductId = data[2].ToString();
                cart.Price = Convert.ToInt32(data[3]);
                cart.Quantity = Convert.ToInt32(data[4]);
                cart.Date = Convert.ToDateTime(data[5]);

                list.Add(cart);
            }

            return list;
        }

        /// <summary>
        /// Implementation of Method.
        /// </summary>
        /// <param name="list">list.</param>
        /// <returns>value.</returns>
        public int InsertCart(AddCartModel list)
        {
            var parameter = new List<SqlParameter>();
            parameter.Add(this.basedal.CreateParameter("@CartId", 5, list.CartId, DbType.Int16));
            parameter.Add(this.basedal.CreateParameter("@CustomerId", 5, list.CustomerId, DbType.Int16));
            parameter.Add(this.basedal.CreateParameter("@ProductId", 5, list.ProductId, DbType.String));
            parameter.Add(this.basedal.CreateParameter("@Price", 9, list.Price, DbType.VarNumeric));
            parameter.Add(this.basedal.CreateParameter("@Quantity", 500, list.Quantity, DbType.Int16));
            parameter.Add(this.basedal.CreateParameter("@Date", 50, list.Date, DbType.Int16));

            this.basedal.Insert("SP_InsertCart", CommandType.StoredProcedure, parameter.ToArray(), out int lastId);

            return lastId;
        }

        /// <summary>
        /// Implementation of Method.
        /// </summary>
        /// <param name="update">update.</param>
        /// <returns>value.</returns>
        public bool UpdateCart(AddCartModel update)
        {
            var parameter = new List<SqlParameter>();
            parameter.Add(this.basedal.CreateParameter("@ProductId", 5, update.ProductId, DbType.Int16));
            this.basedal.Update("SP_UpdateCart", CommandType.StoredProcedure, parameter.ToArray(), out bool status);
            return status;
        }
     }
}
