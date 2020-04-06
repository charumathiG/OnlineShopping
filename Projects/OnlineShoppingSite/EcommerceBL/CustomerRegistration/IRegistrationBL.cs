// <copyright file="IRegistrationBL.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace EcommerceBL.CustomerRegistrationBL
{
using System;
using System.Collections.Generic;
using System.Text;
using EcommerceBL;
using EcommerceDAL;

    /// <summary>
    /// Implementation of Interface.
    /// </summary>
public interface IRegistrationBL
     {
        /// <summary>
        /// Implementation of Method. 
        /// </summary>
        /// <param name="user">user.</param>
        /// <returns>value.</returns>
        int Insertion(RegistrationModel user);
     }
}
