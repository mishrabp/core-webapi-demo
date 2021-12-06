using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace corewebapidemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        //URL:https://localhost:5001/api/book/23 
        [Route("{id:int:min(10):max(30)}")]
        public string GetById(int id)
        {
            return "hello int " + id;
        }

        //url: https://localhost:5001/api/book/bROWN
        [Route("{id:minlength(5):maxlength(10):alpha}")]
        public string GetByIdString(string id)
        {
            return "hello string " + id;
        }

        //Ensure date is supplied as yyyy-mm-dd
        //URL: https://localhost:5001/api/book/2004-12-12
        [Route("{id:regex(^\\d{{4}}\\-(0?[[1-9]]|1[[012]])\\-(0?[[1-9]]|[[12]][[0-9]]|3[[01]])$)}")]
        public string GetDateRegex(string id)
        {
            return "hello date " + id;
        }


    }
}