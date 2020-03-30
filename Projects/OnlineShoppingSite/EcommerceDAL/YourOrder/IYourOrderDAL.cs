using System;
using System.Collections.Generic;
using System.Text;
using EcommerceDAL;

namespace EcommerceDAL.YourOrder
{
     public interface IYourOrderDAL
     {
        List<YourOrderModel> GetOrder();

        int InsertOrder(YourOrderModel List);

        bool UpdateOrder(YourOrderModel update);

        bool DeleteOrder(YourOrderModel delete);
     }
}
