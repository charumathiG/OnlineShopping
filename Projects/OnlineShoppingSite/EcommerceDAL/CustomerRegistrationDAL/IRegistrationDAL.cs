using System;
using System.Collections.Generic;
using System.Text;
using EcommerceDAL;

namespace EcommerceDAL
{
    public interface IRegistrationDAL
    {
        int InsertUser(RegistrationModel user);

    }
}
