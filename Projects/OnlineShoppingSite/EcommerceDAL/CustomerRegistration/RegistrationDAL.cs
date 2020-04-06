// <copyright file="RegistrationDAL.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace EcommerceDAL.CustomerRegistrationDAL
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Data.SqlClient;
    using EcommerceDAL;
    using EcommerceDAL.RepositoryPattern;

    /// <summary>
    /// Implementation of a Class.
    /// </summary>
    public class RegistrationDAL : IRegistrationDAL
    {
        private IBaseDAL basedal;

        /// <summary>
        /// Initializes a new instance of the <see cref="RegistrationDAL"/> class.
        /// </summary>
        /// <param name="baseDAL">value.</param>
        public RegistrationDAL(IBaseDAL baseDAL)
        {
            this.basedal = baseDAL;
        }

        /// <summary>
        /// Implementation of Method.
        /// </summary>
        /// <param name="user">user.</param>
        /// <returns>value.</returns>
        public int InsertUser(RegistrationModel user)
        {
            var parameters = new List<SqlParameter>();
            parameters.Add(this.basedal.CreateParameter("@FirstName", 50, user.FirstName, DbType.String));
            parameters.Add(this.basedal.CreateParameter("@LastName", 50, user.LastName, DbType.String));
            parameters.Add(this.basedal.CreateParameter("@FullName", 100, user.FullName, DbType.String));
            parameters.Add(this.basedal.CreateParameter("@PhoneNumber", 11, user.PhoneNumber, DbType.String));
            parameters.Add(this.basedal.CreateParameter("@Password", 100, user.Password, DbType.String));
            parameters.Add(this.basedal.CreateParameter("@EmailId", 100, user.EmailId, DbType.String));
            parameters.Add(this.basedal.CreateParameter("@Address", 100, user.Address, DbType.String));

            int last = this.basedal.Insert("SP_CustomerRegistration", CommandType.StoredProcedure, parameters.ToArray(), out int lastId);
            return lastId;
        }
    }
}
