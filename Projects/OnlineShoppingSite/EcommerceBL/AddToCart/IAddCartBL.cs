using System;
using System.Collections.Generic;
using System.Text;
using EcommerceDAL.AddToCart;
using EcommerceDAL;

namespace EcommerceBL.AddToCart
{
     public interface IAddCartBL
    {
        int InsertCartList(AddCartModel view);

        List<AddCartModel> GetCartList();

        bool UpdateCartList(AddCartModel UpdateList);

        bool DeleteCartList(AddCartModel deleteList);
     }
}
