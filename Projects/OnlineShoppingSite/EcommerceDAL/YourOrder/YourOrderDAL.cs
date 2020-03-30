using System;
using System.Collections.Generic;
using System.Text;
using EcommerceDAL.YourOrder;
using EcommerceDAL.RepositoryPattern;
using System.Data.SqlClient;
using System.Data;

namespace EcommerceDAL.YourOrder
{
    public class YourOrderDAL:IYourOrderDAL
    {
        public IBaseDAL basedal;
        public YourOrderDAL(IBaseDAL baseDAL)
        {
            basedal = baseDAL;
        }

        public bool DeleteOrder(YourOrderModel delete)
        {
            var parameter = new List<SqlParameter>();
            parameter.Add(basedal.CreateParameter("@OrderId", 5, delete.OrderId, DbType.Int16));
            basedal.Update("SP_DeleteOrder", CommandType.StoredProcedure, parameter.ToArray(), out bool Id);
            return Id;
        }

        public List<YourOrderModel> GetOrder()
        {
            var parameter = new List<SqlParameter>();
            List<YourOrderModel> list = new List<YourOrderModel>();
            YourOrderModel order = null;
            var List = basedal.GetData("SP_GetCart", CommandType.StoredProcedure);
            foreach (DataRow data in List.Tables[0].Rows)
            {
                order = new YourOrderModel();
                order.OrderId = Convert.ToInt32(data[0]);
                order.ProductId = (data[1]).ToString();
                order.CustomerId = Convert.ToInt32(data[2].ToString());
                order.OrderDate = Convert.ToDateTime(data[3]);
                order.OrderDeliveryDate = Convert.ToDateTime(data[4]);
                order.Status = (data[5]).ToString();

                list.Add(order);
            }
            return list;
        }

        public int InsertOrder(YourOrderModel List)
        {
            var parameter = new List<SqlParameter>();
            parameter.Add(basedal.CreateParameter("@OrderId", 5, List.OrderId, DbType.Int16));
            parameter.Add(basedal.CreateParameter("@CustomerId", 5, List.CustomerId, DbType.Int16));
            parameter.Add(basedal.CreateParameter("@ProductId", 5, List.ProductId, DbType.String));
            parameter.Add(basedal.CreateParameter("@OrderDate", 9, List.OrderDate, DbType.DateTime));
            parameter.Add(basedal.CreateParameter("@OrderDeliveryDate", 500, List.OrderDeliveryDate, DbType.DateTime));
            parameter.Add(basedal.CreateParameter("@Status", 50, List.Status, DbType.String));

            basedal.Insert("SP_InsertOrder", CommandType.StoredProcedure, parameter.ToArray(), out int lastId);

            return lastId;
        }

        public bool UpdateOrder(YourOrderModel update)
        {
            var parameter = new List<SqlParameter>();
            parameter.Add(basedal.CreateParameter("@CustomerId", 5, update.CustomerId, DbType.Int16));
            basedal.Update("SP_UpdateOrderById", CommandType.StoredProcedure, parameter.ToArray(), out bool status);
            return status;
        }
    }
}
