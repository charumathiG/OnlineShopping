// <copyright file="IRegistrationDAL.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace EcommerceDAL
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using EcommerceDAL;

    /// <summary>
    /// Implementation of Interface.
    /// </summary>
    public interface IRegistrationDAL
    {
        /// <summary>
        /// Implementation of Method.
        /// </summary>
        /// <param name="user">user.</param>
        /// <returns>value.</returns>
        int InsertUser(RegistrationModel user);
    }
}
