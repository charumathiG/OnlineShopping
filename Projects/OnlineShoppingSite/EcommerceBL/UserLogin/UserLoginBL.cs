// <copyright file="UserLoginBL.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>
namespace EcommerceBL.UserLogin
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using EcommerceDAL.UserLogin;
    using EcommerceModels;

    /// <summary>
    /// Implementation of a Class.
    /// </summary>
    public class UserLoginBL : IUserLoginBL
    {
        private IUserLoginDAL dal;

        /// <summary>
        /// Initializes a new instance of the <see cref="UserLoginBL"/> class.
        /// </summary>
        /// <param name="daL">dal.</param>
        public UserLoginBL(IUserLoginDAL daL)
        {
            this.dal = daL;
        }

        /// <summary>
        /// Implementation of a method.
        /// </summary>
        /// <returns>value.</returns>
        public List<User> GetAll()
        {
            return this.dal.GetAll();
        }

        /// <summary>
        /// Implementation of a method.
        /// </summary>
        /// <param name="emailId">emailid.</param>
        /// <returns>value.</returns>
        public User Get(string emailId)
        {
            return this.dal.Get(emailId);
        }

        /// <summary>
        /// Implementation of a method.
        /// </summary>
        /// <param name="user">user.</param>
        /// <returns>value.</returns>
        public bool UpdateLoggedInTime(User user)
        {
            return this.dal.UpdateLoggedInTime(user);
        }
    }
}
