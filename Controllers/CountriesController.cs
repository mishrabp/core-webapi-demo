using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using corewebapidemo.CustomModelBinder;

namespace corewebapidemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [BindProperties]
    public class CountriesController : ControllerBase
    {

        //[BindProperty]
        //public string Name { get; set; }
        //[BindProperty]
        //public string Population { get; set; }
        //[BindProperty]
        //public string Area { get; set; }

        //[BindProperty(SupportsGet =true)]
        public Models.CountryModel Country { get; set; }

        [HttpPost("/test")]
        public IActionResult AddCountry()
        {
            return Ok($"Name: {this.Country.Name}, Population: {this.Country.Population}, Area: {this.Country.Area}");
        }


        [HttpGet("")]
        public IActionResult GetCountry()
        {
            return Ok($"Name: {this.Country.Name}, Population: {this.Country.Population}, Area: {this.Country.Area}");
        }


        //URL: http://localhost:5000/api/countries?Name=India&Population=200&Area=900
        [HttpPost("")]
        public IActionResult AddCountry([FromQuery] Models.CountryModel country)
        {
            return Ok($"Name: {country.Name}");
        }

        //URL: http://localhost:5000/api/test2/countries/India/200/900
        [HttpPost("test2/{Name}/{Population}/{Area}")]
        public IActionResult AddCountry2([FromRoute] Models.CountryModel country)
        {
            return Ok($"Name: {country.Name}");
        }


        //URL: http://localhost:5000/api/countries?Id=1
        [HttpPut("{Id}")]
        public IActionResult AddCountry([FromQuery] int Id, [FromBody] Models.CountryModel country)
        {
            return Ok($"Name: {country.Name}");
        }

        //URL: http://localhost:5000/api/countries/search?countries=India|China|USA|France
        [HttpGet("search")]
        public IActionResult SearchCountryies([ModelBinder(typeof(CustomBinder))] string[] countries)
        {
            return Ok($"Name: {countries.Length}");
        }

    }
}