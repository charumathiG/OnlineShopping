// <copyright file="IUserLoginBL.cs" company="PlaceholderCompany">
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
    /// Implementation of Interface.
    /// </summary>
    public interface IUserLoginBL
    {
        /// <summary>
        /// Implementation of a method.
        /// </summary>
        /// <param name="view">view.</param>
        /// <returns>value.</returns>
        List<User> GetAll();

        /// <summary>
        /// Implementation of a method.
        /// </summary>
        /// <returns>value.</returns>
        User Get(string emailId);

        /// <summary>
        /// Implementation of a method.
        /// </summary>
        /// <param name="user">user.</param>
        /// <returns>value.</returns>
        bool UpdateLoggedInTime(User user);
    }
}
