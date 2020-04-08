// <copyright file="ExtensionMethods.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>
namespace WebApi.Helpers
{
    using EcommerceModels;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Implementation of a Class.
    /// </summary>
    public static class ExtensionMethods
    {
        /// <summary>
        /// Implementation.
        /// </summary>
        /// <param name="users">user.</param>
        /// <returns>value.</returns>
        public static IEnumerable<User> WithoutPasswords(this IEnumerable<User> users)
        {
            return users.Select(x => x.WithoutPassword());
        }

        /// <summary>
        /// Implementation.
        /// </summary>
        /// <param name="user">user.</param>
        /// <returns>value.</returns>
        public static User WithoutPassword(this User user)
        {
            user.Password = "*";
            return user;
        }
    }
}