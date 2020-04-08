// <copyright file="UsersController.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>
namespace WebApi.Controllers
{
    using System.Linq;
    using EcommerceModels;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using WebApi.Services;

    /// <summary>
    /// Implementation.
    /// </summary>
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class UsersController : ControllerBase
    {
        private IUserService userService;

        /// <summary>
        /// Initializes a new instance of the <see cref="UsersController"/> class.
        /// </summary>
        /// <param name="userService">value.</param>
        public UsersController(IUserService userService)
        {
            this.userService = userService;
        }

        /// <summary>
        /// Implementation.
        /// </summary>
        /// <param name="model">model.</param>
        /// <returns>value.</returns>
        [AllowAnonymous]
        [HttpPost("authenticate")]
        public IActionResult Authenticate([FromBody]AuthenticateModel model)
        {
            var user = this.userService.Authenticate(model.EmailId, model.Password);

            if (user == null)
            {
                return this.BadRequest(new { message = "Username or password is incorrect" });
            }

            return this.Ok(user);
        }

        /// <summary>
        /// Implementation.
        /// </summary>
        /// <returns>value.</returns>
        [HttpGet]
        public IActionResult GetAll()
        {
            var users = this.userService.GetAll();
            return this.Ok(users);
        }
    }
}