using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;

namespace UserAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<User> Get()
        {
            dbcontext context = HttpContext.RequestServices.GetService(typeof(dbcontext)) as dbcontext;

            var user = context.GetUser();
            
            //var response =  "{\"name\": \"John\",  \"age\": \"23\",\"email\": \"john.doe@google.com\"}";
            //var result = JsonConvert.DeserializeObject<object>(response);
            return user;
        }
    }
}