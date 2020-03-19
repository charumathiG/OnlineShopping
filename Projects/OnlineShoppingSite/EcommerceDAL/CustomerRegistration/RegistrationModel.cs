using System;
using System.Collections.Generic;
using System.Text;

namespace EcommerceDAL
{
     public class RegistrationModel
     {
        public int CustomerID { get; set; }
        public string CustomerName { get; set; }
        public string CustomerPassword { get; set; }
        public string CustomerPhone { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerAddress { get; set; }
     }
}
