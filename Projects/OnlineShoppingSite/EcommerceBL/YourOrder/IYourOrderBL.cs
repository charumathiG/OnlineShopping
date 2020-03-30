using System;
using System.Collections.Generic;
using System.Text;
using EcommerceDAL.YourOrder;


namespace EcommerceBL.YourOrder
{
     public interface IYourOrderBL
     {
        int InsertOrderList(YourOrderModel view);

        List<YourOrderModel> GetOrderList();

        bool UpdateOrderList(YourOrderModel UpdateList);

        bool DeleteOrderList(YourOrderModel deleteList);
     }
}
