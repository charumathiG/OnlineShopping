using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using EcommerceDAL.YourOrder;
using EcommerceBL.YourOrder;
using EcommerceDAL;
using EcommerceBL;

namespace EcommerceAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class YourOrderController : ControllerBase
    {
        IYourOrderBL bl;
        public YourOrderController(IYourOrderBL BL)
        {
            bl = BL;
        }

        // GET: api/YourOrder
        [HttpGet]
        [Route("api/GetOrderList")]

        public List<YourOrderModel> GetOrderList()
        {
            return bl.GetOrderList();
        }
    }
}

//        // GET: api/YourOrder/5
//        [HttpGet("{id}", Name = "Get")]
//        public string Get(int id)
//        {
//            return "value";
//        }

//        // POST: api/YourOrder
//        [HttpPost]
//        public int InsertOrderList(YourOrderModel view)
//        {
//            return bl.InsertOrderList(view);
//        }

//        // PUT: api/YourOrder/5
//        [HttpPut("{id}")]
//        public bool UpdateOrderList(YourOrderModel UpdateList)
//        {
//            return bl.UpdateOrderList(UpdateList);
//        }

//        // DELETE: api/ApiWithActions/5
//        [HttpDelete("{id}")]
//        public bool DeleteOrderList(YourOrderModel deleteList)
//        {
//            return bl.DeleteOrderList(deleteList);
//        }
//    }
//}
