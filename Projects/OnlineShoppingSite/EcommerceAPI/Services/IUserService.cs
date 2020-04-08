// <copyright file="IUserService.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>
namespace WebApi.Services
{
    using EcommerceBL.UserLogin;
    using EcommerceModels;
    using Microsoft.Extensions.Options;
    using Microsoft.IdentityModel.Tokens;
    using System;
    using System.Collections.Generic;
    using System.IdentityModel.Tokens.Jwt;
    using System.Linq;
    using System.Security.Claims;
    using System.Text;
    using WebApi.Helpers;

    /// <summary>
    /// Implementation.
    /// </summary>
    public interface IUserService
    {
        /// <summary>
        /// Implementation.
        /// </summary>
        /// <param name="emailId">user.</param>
        /// <param name="password">pass.</param>
        /// <returns>value.</returns>
        User Authenticate(string emailId, string password);

        /// <summary>
        /// Implementation.
        /// </summary>
        /// <returns>value.</returns>
        IEnumerable<User> GetAll();
    }

    /// <summary>
    /// Implementation.
    /// </summary>
    public class UserService : IUserService
    {
        private AppSettings appSettings;
        private IUserLoginBL userLoginBL;
        List<User> users = new List<User>();


        /// <summary>
        /// Initializes a new instance of the <see cref="UserService"/> class.
        /// </summary>
        /// <param name="appSettings">value.</param>
        public UserService(IOptions<AppSettings> appSettings, IUserLoginBL _userLoginBL)
        {
            this.appSettings = appSettings.Value;
            this.userLoginBL = _userLoginBL;
        }

        /// <summary>
        /// Implementation.
        /// </summary>
        /// <param name="emailId">user.</param>
        /// <param name="password">pass.</param>
        /// <returns>value.</returns>
        public User Authenticate(string emailId, string password)
        {
            users = this.userLoginBL.GetAll();
            var usr = users.FirstOrDefault<User>(x => x.EmailId == emailId && x.Password == password);
            // var user = this.users.SingleOrDefault(x => x.EmailId == emailId && x.Password == password);

            // return null if user not found
            if (usr == null)
            {
                return null;
            }

            // authentication successful so generate jwt token
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(this.appSettings.Secret);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Name, usr.EmailId),
                }),
                Expires = DateTime.UtcNow.AddDays(7),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature),
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            usr.Token = tokenHandler.WriteToken(token);

            return usr.WithoutPassword();
        }



        /// <summary>
        /// Implementation.
        /// </summary>
        /// <returns>value.</returns>
        public IEnumerable<User> GetAll()
        {
            return this.users.WithoutPasswords();
        }
    }
}