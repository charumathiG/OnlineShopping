using System;
using System.Collections.Generic;
using System.Text;
using EcommerceDAL.RepositoryPattern;
using EcommerceDAL.YourOrder;


namespace EcommerceBL.YourOrder
{
    public class YourOrderBL:IYourOrderBL
    {
        Random random = new Random();
        IYourOrderBL dal;
        public YourOrderBL(IYourOrderBL Dal)
        {
            dal = Dal;
        }

        public bool DeleteOrderList(YourOrderModel deleteList)
        {
            return dal.DeleteOrderList(deleteList);
        }

        public List<YourOrderModel> GetOrderList()
        {
            return dal.GetOrderList();
        }

        public int InsertOrderList(YourOrderModel view)
        {
            return dal.InsertOrderList(view);
        }

        public bool UpdateOrderList(YourOrderModel UpdateList)
        {
            return dal.UpdateOrderList(UpdateList);
        }
    }
}
