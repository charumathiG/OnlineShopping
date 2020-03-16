using System;
using System.Collections.Generic;
using System.Text;
using EcommerceDAL;
using EcommerceDAL.RepositoryPattern;


namespace EcommerceDAL.ProductsDAL
{
     public class ProductsListDAL:IProductsListDAL
    {
        public IBaseDAL basedal;
        public ProductsListDAL(IBaseDAL baseDAL)
        {
            basedal = baseDAL;
        }

        public int GetProducts(ProductsListModel productList)
        {
            
        }
    }
}
