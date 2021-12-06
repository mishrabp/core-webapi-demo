using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

/****IT IS A TEST CONTROLLER CLASS FOR LEARNING************/

namespace corewebapidemo.Controllers
{
    [ApiController]
    [Route("test/[action]")]
    public class TestController : ControllerBase 
    {
        public string Get()
        {
            return "Hello from TestController class - Get";
        }

        public string Get1()
        {
            return "Hello from TestController class - Get1";
        }
    }
}
