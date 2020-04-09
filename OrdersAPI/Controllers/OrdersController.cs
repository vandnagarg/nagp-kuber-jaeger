using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace OrdersAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<object> Get()
        {
            var response =  "[{\"orderId\": 1,\"orderAmount\": 250,\"orderDate\": \"14-Apr-2020\"},{\"orderId\": 2,\"orderAmount\": 450,\"orderDate\": \"15-Apr-2020\"}]";
            var result = JsonConvert.DeserializeObject<object>(response);
            return result;
        }
    }
}