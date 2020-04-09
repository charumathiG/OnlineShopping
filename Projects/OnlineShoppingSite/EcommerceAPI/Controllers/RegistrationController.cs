// <copyright file="RegistrationController.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace EcommerceAPI.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using EcommerceBL;
    using EcommerceBL.CustomerRegistrationBL;
    using EcommerceDAL;
    using EcommerceDAL.CustomerRegistrationDAL;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;

    /// <summary>
    /// Controller Class for RegistrationController.
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class RegistrationController : ControllerBase
    {
        private IRegistrationBL bl;

        /// <summary>
        /// Initializes a new instance of the <see cref="RegistrationController"/> class.
        /// </summary>
        /// <param name="bL">BL.</param>
        public RegistrationController(IRegistrationBL bL)
        {
            this.bl = bL;
        }

        /// <summary>
        /// Method for Insertion.
        /// </summary>
        /// <param name="user">BL.</param>
        /// <returns>DAL.</returns>
        [HttpPost]
        public int Insertion(RegistrationModel user)
        {
            return this.bl.Insertion(user);
        }
    }
}