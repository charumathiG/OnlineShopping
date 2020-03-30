using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using EcommerceDAL.ProductsDAL;
using EcommerceBL.Products;
using EcommerceDAL;
using EcommerceBL;


namespace EcommerceAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        IProductListBL bl;
        public ProductController(IProductListBL BL)
        {
            bl = BL;
        }

        [HttpGet]
        [Route("api/GetProductsList")]
       public List<ProductsListModel> GetProductsList()
       {
            return bl.GetProductsList();
       }

        [HttpPost]
        public int InsertProducts(ProductsListModel view)
        {
            return bl.InsertProducts(view);
        }
        [HttpDelete]
        public bool DeleteProducts(ProductsListModel deleteList)
        {
            return bl.DeleteProducts(deleteList);
        }

        [HttpPut]
        public bool UpdateProductList(ProductsListModel UpdateList)
        {
            return bl.UpdateProductList(UpdateList);
        }
    }
}
  

    
