using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EcommerceModels
{

    /// <summary>
    /// Implementation.
    /// </summary>
    public class AuthenticateModel
    {
        /// <summary>
        /// Gets or sets implementation of a property.
        /// </summary>
        [Required]
        public string EmailId { get; set; }

        /// <summary>
        /// Gets or sets implementation of a property.
        /// </summary>
        [Required]
        public string Password { get; set; }
    }
}

