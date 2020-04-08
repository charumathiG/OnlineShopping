// <copyright file="UserLoginDAL.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>
namespace EcommerceDAL.UserLogin
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Data.SqlClient;
    using System.Text;
    using EcommerceDAL.RepositoryPattern;
    using EcommerceDAL.UserLogin;
    using EcommerceModels;

    /// <summary>
    /// Implementation of a Class.
    /// </summary>
    public class UserLoginDAL : IUserLoginDAL
    {
        private IBaseDAL basedal;

        /// <summary>
        /// Initializes a new instance of the <see cref="UserLoginDAL"/> class.
        /// </summary>
        /// <param name="baseDAL">value.</param>
        public UserLoginDAL(IBaseDAL baseDAL)
        {
            this.basedal = baseDAL;
        }

        /// <summary>
        /// Implementation of Method.
        /// </summary>
        /// <returns>value.</returns>
        public List<User> GetAll()
        {
            var parameter = new List<SqlParameter>();
            List<User> list = new List<User>();
            User login = null;
            var userList = this.basedal.GetData("SP_GetUsers", CommandType.StoredProcedure);
            foreach (DataRow data in userList.Tables[0].Rows)
            {
                login = new User();
                login.EmailId = data["EmailId"].ToString();
                login.Password = data["Password"].ToString();
                list.Add(login);
            }

            return list;
        }

        /// <summary>
        /// Implementation of a method.
        /// </summary>
        /// <param name="emailId">emailid.</param>
        /// <returns>value.</returns>
        public User Get(string emailId)
        {
            var parameter = new List<SqlParameter>();
            User login = null;
            parameter.Add(new SqlParameter()
            {
                ParameterName = "@EmailId",
                Value = emailId,
                DbType = DbType.String,
            });
            var userList = (DataSet)this.basedal.GetData("SP_GetUser", CommandType.StoredProcedure, parameter);
            foreach (DataRow data in userList.Tables[0].Rows)
            {
                login = new User();
                login.EmailId = data["EmailId"].ToString();
                login.Password = data["Password"].ToString();
            }

            return login;
        }

        /// <summary>
        /// Implementation of Method.
        /// </summary>
        /// <param name="user">user.</param>
        /// <returns>value.</returns>
        public int UpdateLoggedInTime(User user)
        {
            var parameter = new List<SqlParameter>();
            parameter.Add(this.basedal.CreateParameter("@EmailId", 50, user.EmailId, DbType.String));
            parameter.Add(this.basedal.CreateParameter("@TokenNo", 225, user.Token, DbType.String));

            this.basedal.Insert("SP_UpdateUserLoggedInTime", CommandType.StoredProcedure, parameter.ToArray(), out int lastId);

            return lastId;
        }
    }
}
