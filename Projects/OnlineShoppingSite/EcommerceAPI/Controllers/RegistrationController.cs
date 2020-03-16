using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using EcommerceBL.CustomerRegistrationBL;
using EcommerceDAL.CustomerRegistrationDAL;
using EcommerceDAL;
using EcommerceBL;

namespace EcommerceAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegistrationController : ControllerBase
    {
        IRegistrationBL bl;
        public RegistrationController(IRegistrationBL BL)
        {
            bl = BL;
        }
        [HttpGet]
        public int Index()
        {
            return 1;
        }

        [HttpPost]
        [Route("api/Registration")]
        public int Insertion(RegistrationModel user)
        {
            return bl.Insertion(user);
        }
    }
}