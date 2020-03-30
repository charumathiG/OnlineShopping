using System;
using System.Collections.Generic;
using System.Text;
using EcommerceDAL.RepositoryPattern;
using EcommerceDAL.AddToCart;
using System.Data;
using System.Data.SqlClient;


namespace EcommerceDAL.AddToCart
{
     public class AddCartDAL:IAddCartDAL
     {
        public IBaseDAL basedal;
        public AddCartDAL(IBaseDAL baseDAL)
        {
            basedal = baseDAL;
        }

        public bool DeleteCart(AddCartModel delete)
        {
            var parameter = new List<SqlParameter>();
            parameter.Add(basedal.CreateParameter("@Id", 5, delete.Id, DbType.Int16));
            basedal.Update("SP_DeleteCart", CommandType.StoredProcedure, parameter.ToArray(), out bool Id);
            return Id;
        }

        public List<AddCartModel> GetCart()
        {
            var parameter = new List<SqlParameter>();
            List<AddCartModel> list = new List<AddCartModel>();
            AddCartModel cart = null;
            var List = basedal.GetData("SP_GetCart", CommandType.StoredProcedure);
            foreach (DataRow data in List.Tables[0].Rows)
            {
                cart = new AddCartModel();
                cart.Id = Convert.ToInt32(data[0]);
                cart.CustomerId =Convert.ToInt32( data[1]);
                cart.ProductId = data[2].ToString();
                cart.Price = Convert.ToInt32(data[3]);
                cart.Quantity = Convert.ToInt32(data[4]);
                cart.Date = Convert.ToDateTime(data[5]);

                list.Add(cart);
            }
            return list;
        }

        public int InsertCart(AddCartModel List)
        {
            var parameter = new List<SqlParameter>();
            parameter.Add(basedal.CreateParameter("@Id", 5, List.Id, DbType.Int16));
            parameter.Add(basedal.CreateParameter("@CustomerId", 5, List.CustomerId, DbType.Int16));
            parameter.Add(basedal.CreateParameter("@ProductId", 5, List.ProductId, DbType.String));
            parameter.Add(basedal.CreateParameter("@Price", 9, List.Price, DbType.VarNumeric));
            parameter.Add(basedal.CreateParameter("@Quantity",500, List.Quantity, DbType.Int16));
            parameter.Add(basedal.CreateParameter("@Date", 50, List.Date, DbType.Int16));

            basedal.Insert("SP_InsertCart", CommandType.StoredProcedure, parameter.ToArray(), out int lastId);

            return lastId;
        }

        public bool UpdateCart(AddCartModel update)
        {
            var parameter = new List<SqlParameter>();
            parameter.Add(basedal.CreateParameter("@ProductId", 5, update.ProductId, DbType.Int16));
            basedal.Update("SP_UpdateCart", CommandType.StoredProcedure, parameter.ToArray(), out bool status);
            return status;
        }
     }
}
