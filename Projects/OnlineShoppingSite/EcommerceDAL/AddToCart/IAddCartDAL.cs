using System;
using System.Collections.Generic;
using System.Text;
using EcommerceDAL;

namespace EcommerceDAL.AddToCart
{
    public interface IAddCartDAL
    {
        List<AddCartModel> GetCart();

        int InsertCart(AddCartModel List);

        bool UpdateCart(AddCartModel update);

        bool DeleteCart(AddCartModel delete);

    }
}
