using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiVersioning.API.Models.DTOs;

namespace WebApiVersioning.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountriesController : ControllerBase
    {

        [HttpGet]
        public IActionResult Get()
        {
            var countriesDomainModel = CountriesData.Get();

            //Map Domain Model to DTO
            var response = new List<CountryDto>();
            foreach (var countryDomain in countriesDomainModel)
            {
                response.Add(new CountryDto
                {
                    Id = countryDomain.Id,
                    Name = countryDomain.Name
                });
            }

            return Ok(response);

        }

    }
}
