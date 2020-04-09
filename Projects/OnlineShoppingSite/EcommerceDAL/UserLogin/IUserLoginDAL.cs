// <copyright file="IUserLoginDAL.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>
namespace EcommerceDAL.UserLogin
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using EcommerceModels;

    /// <summary>
    /// Implementation o Interface.
    /// </summary>
    public interface IUserLoginDAL
     {
        /// <summary>
        /// Implementation of Method.
        /// </summary>
        /// <returns>value.</returns>
        List<User> GetAll();

       /// <summary>
       /// Implementation of a Method.
       /// </summary>
       /// <param name="emailId">email.</param>
       /// <returns>value.</returns>
        User Get(string emailId);

        /// <summary>
        /// Implementation of a Method.
        /// </summary>
        /// <param name="user">user.</param>
        /// <returns>value.</returns>
        bool UpdateLoggedInTime(User user);
    }
}
