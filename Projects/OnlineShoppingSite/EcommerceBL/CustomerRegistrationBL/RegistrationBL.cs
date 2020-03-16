using System;
using System.Data;
using System.Data.SqlClient;
using EcommerceDAL.RepositoryPattern;
using EcommerceBL.CustomerRegistrationBL;
using EcommerceBL;
using EcommerceDAL.CustomerRegistrationDAL;
using EcommerceDAL;

namespace EcommerceBL
{
    public class RegistrationBL: IRegistrationBL
    {
        IRegistrationDAL dal;
        public RegistrationBL(IRegistrationDAL Dal)
        {
            dal = Dal;
        }
        public int Insertion(RegistrationModel user)
        {
            return dal.InsertUser(user);
        }
    }
}
