// <copyright file="RegistrationModel.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace EcommerceDAL
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Implementation of a Class.
    /// </summary>
    public class RegistrationModel
    {
        /// <summary>
        /// Gets or sets implementation of property.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets implementation of property.
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets implementation of property.
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// Gets or sets implementation of property.
        /// </summary>
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Gets or sets implementation of property.
        /// </summary>
        public string EmailId { get; set; }

        /// <summary>
        /// Gets or sets implementation of property.
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// Gets implementation of property.
        /// </summary>
        public string FullName
        {
            get
            {
                string fullName = this.LastName;
                if (!string.IsNullOrWhiteSpace(this.FirstName))
                {
                    if (!string.IsNullOrWhiteSpace(this.LastName))
                    {
                        fullName += ", ";
                    }

                    fullName += this.FirstName;
                }

                return fullName;
            }
        }

        /// <summary>
        /// implementation of method.
        /// </summary>
        /// <returns> value.</returns>
        public bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(this.LastName))
            {
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(this.EmailId))
            {
                isValid = false;
            }

            return isValid;
        }
    }
}
