using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using corewebapidemo.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace corewebapidemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnimalController : ControllerBase
    {
        private List<AnimalModel> animals = null;
        public AnimalController()
        {
            animals = new List<AnimalModel>()
            {
                new AnimalModel(){Id=1, Name="Dog"},
                new AnimalModel(){Id=2, Name="Cat"}
            };
        }

        [Route("")]
        public IActionResult GetAnimals()
        {
            return Ok(animals); 
        }

        [Route("test")]
        public IActionResult GetAnimalsTest()
        {
            return AcceptedAtAction("GetAnimalsTest", animals);
        }


        [Route("{name}")]
        public IActionResult GetAnimalsByName(string name)
        {
            if(!name.Contains("ABC"))
            {
                return BadRequest();
            }
            return Ok(animals);
        }

    }
}