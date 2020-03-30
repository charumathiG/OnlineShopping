using System;
using EcommerceDAL;
using EcommerceDAL.RepositoryPattern;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;

namespace EcommerceDAL.CustomerRegistrationDAL
{
    public class RegistrationDAL:IRegistrationDAL
    {
        public IBaseDAL basedal;
        public RegistrationDAL(IBaseDAL baseDAL)
        {
            basedal = baseDAL;
        }
        public int InsertUser(RegistrationModel user)
        {
            var parameters = new List<SqlParameter>();
            parameters.Add(basedal.CreateParameter("@FirstName", 50, user.FirstName, DbType.String));
            parameters.Add(basedal.CreateParameter("@LastName", 50, user.LastName, DbType.String));
            parameters.Add(basedal.CreateParameter("@CustomerPhone", 11, user.CustomerPhone, DbType.String));
            parameters.Add(basedal.CreateParameter("@CustomerPassword", 100, user.CustomerPassword, DbType.String));
            parameters.Add(basedal.CreateParameter("@CustomerEmail", 100, user.CustomerEmail, DbType.String));
            parameters.Add(basedal.CreateParameter("@CustomerAddress", 100, user.CustomerAddress, DbType.String));

            int last = basedal.Insert("CustomerRegistration", CommandType.StoredProcedure, parameters.ToArray(), out int lastId);
            return lastId;

        }

    }
}
