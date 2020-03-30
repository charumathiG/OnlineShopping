using System;
using System.Collections.Generic;
using System.Text;

namespace EcommerceDAL.YourOrder
{
     public class YourOrderModel
     {
        public int OrderId { get; set; }
        public string ProductId { get; set; }
        public int CustomerId { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime OrderDeliveryDate { get; set; }
        public string Status { get; set; }
     }
}
