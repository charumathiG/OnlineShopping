using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using EcommerceDAL.AddToCart;
using EcommerceBL.AddToCart;
using EcommerceDAL;
using EcommerceBL;

namespace EcommerceAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartController : ControllerBase
    {
        IAddCartBL bl;
        public CartController(IAddCartBL BL)
        {
            bl = BL;
        }
        // GET: api/Cart
        [HttpGet]
        public List<AddCartModel> GetCartList()
        {
            return bl.GetCartList();
        }

        // GET: api/Cart/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Cart
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Cart/5
        [HttpPut("{id}")]
        public int InsertCartList(AddCartModel view)
        {
            return bl.InsertCartList(view);
        }

        [Route("api/DeleteCart/{id}")]
        [HttpDelete]
        public bool DeleteCartList(AddCartModel deleteList)
        {
            return bl.DeleteCartList(deleteList);
        }

    }
}

