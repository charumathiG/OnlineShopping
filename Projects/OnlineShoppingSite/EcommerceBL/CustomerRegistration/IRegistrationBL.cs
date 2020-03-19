using System;
using System.Collections.Generic;
using System.Text;
using EcommerceBL;
using EcommerceDAL;

namespace EcommerceBL.CustomerRegistrationBL
{
     public interface IRegistrationBL
     {
        int Insertion(RegistrationModel user);

     }
}
