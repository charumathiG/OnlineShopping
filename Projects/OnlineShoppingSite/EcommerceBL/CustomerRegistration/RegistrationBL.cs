// <copyright file="RegistrationBL.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace EcommerceBL
{
    using System;
    using System.Data;
    using System.Data.SqlClient;
    using EcommerceBL;
    using EcommerceBL.CustomerRegistrationBL;
    using EcommerceDAL;
    using EcommerceDAL.CustomerRegistrationDAL;
    using EcommerceDAL.RepositoryPattern;

    /// <summary>
    /// Implementation of Class.
    /// </summary>
    public class RegistrationBL : IRegistrationBL
    {
        private IRegistrationDAL dal;

        /// <summary>
        /// Initializes a new instance of the <see cref="RegistrationBL"/> class.
        /// </summary>
        /// <param name="daL">dal.</param>
        public RegistrationBL(IRegistrationDAL daL)
        {
            this.dal = daL;
        }

        /// <summary>
        /// Implementation ofMethod.
        /// </summary>
        /// <param name="user">user.</param>
        /// <returns>value.</returns>
        public int Insertion(RegistrationModel user)
        {
            return this.dal.InsertUser(user);
        }
    }
}
