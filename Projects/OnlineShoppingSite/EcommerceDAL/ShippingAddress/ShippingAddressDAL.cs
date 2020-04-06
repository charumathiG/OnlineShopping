// <copyright file="ShippingAddressDAL.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace EcommerceDAL.ShippingAddress
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Data.SqlClient;
    using System.Text;
    using EcommerceDAL.RepositoryPattern;
    using EcommerceDAL.ShippingAddress;

    /// <summary>
    /// Implementation of a Class.
    /// </summary>
    public class ShippingAddressDAL : IShippingAddressDAL
    {
        private IBaseDAL basedal;

        /// <summary>
        /// Initializes a new instance of the <see cref="ShippingAddressDAL"/> class.
        /// </summary>
        /// <param name="baseDAL">value.</param>
        public ShippingAddressDAL(IBaseDAL baseDAL)
        {
            this.basedal = baseDAL;
        }

        /// <summary>
        /// Implementation of Method.
        /// </summary>
        /// <returns>value.</returns>
        public List<ShippingAddressModel> GetAddress()
        {
            var parameter = new List<SqlParameter>();
            List<ShippingAddressModel> list = new List<ShippingAddressModel>();
            ShippingAddressModel shipping = null;
            var addressList = this.basedal.GetData("SP_GetDetail", CommandType.StoredProcedure);
            foreach (DataRow data in addressList.Tables[0].Rows)
            {
                shipping = new ShippingAddressModel();
                shipping.ShippingId = Convert.ToInt32(data[0]);
                shipping.OrderId = Convert.ToInt32(data[1]);
                shipping.ShippingAddress = data[2].ToString();
                shipping.ContactNumber = data[3].ToString();
                list.Add(shipping);
            }

            return list;
        }

        /// <summary>
        /// Implementation of Method.
        /// </summary>
        /// <param name="list">list.</param>
        /// <returns>value.</returns>
        public int InsertAddress(ShippingAddressModel list)
        {
            var parameter = new List<SqlParameter>();
            parameter.Add(this.basedal.CreateParameter("@ShippingId", 5, list.ShippingId, DbType.Int16));
            parameter.Add(this.basedal.CreateParameter("@OrderId", 5, list.OrderId, DbType.Int16));
            parameter.Add(this.basedal.CreateParameter("@ShippingAddress", 50, list.ShippingAddress, DbType.String));
            parameter.Add(this.basedal.CreateParameter("@ContactNumber", 12, list.ContactNumber, DbType.String));

            this.basedal.Insert("SP_InsertAddress", CommandType.StoredProcedure, parameter.ToArray(), out int lastId);

            return lastId;
        }

        /// <summary>
        /// Implementation of Method.
        /// </summary>
        /// <param name="update">list.</param>
        /// <returns>value.</returns>
        public bool UpdateAddress(ShippingAddressModel update)
        {
            var parameter = new List<SqlParameter>();
            parameter.Add(this.basedal.CreateParameter("@ShippingId", 5, update.ShippingId, DbType.Int16));
            this.basedal.Update("SP_UpdateDetail", CommandType.StoredProcedure, parameter.ToArray(), out bool status);
            return status;
        }
    }
}
