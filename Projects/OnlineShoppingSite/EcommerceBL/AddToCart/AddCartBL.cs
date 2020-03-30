using System;
using System.Collections.Generic;
using System.Text;
using EcommerceDAL.AddToCart;
using EcommerceDAL.RepositoryPattern;


namespace EcommerceBL.AddToCart
{
    public class AddCartBL : IAddCartBL
    {
        Random random = new Random();
        IAddCartBL dal;
        public AddCartBL(IAddCartBL Dal)
        {
            dal = Dal;
        }
        public bool DeleteCartList(AddCartModel deleteList)
        {
            return dal.DeleteCartList(deleteList);
        }

        public List<AddCartModel> GetCartList()
        {
            return dal.GetCartList();
        }

        public int InsertCartList(AddCartModel view)
        {
            return dal.InsertCartList(view);
        }

        public bool UpdateCartList(AddCartModel UpdateList)
        {
            return dal.UpdateCartList(UpdateList);
        }
    }
}
