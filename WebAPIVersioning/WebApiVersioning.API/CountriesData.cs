using WebApiVersioning.API.Models.Domain;

namespace WebApiVersioning.API
{
    public class CountriesData
    {

        public static List<Country> Get()
        {

            var countries = new[]
            {
                new { Id = 1, Name = "United States"},
                new { Id = 2, Name = "Germany" },
                new { Id = 3, Name = "Brazil" },
                new { Id = 4, Name = "China" },
                new { Id = 5, Name = "Italy" },
            };

            return countries.Select(c => new Country { Id = c.Id, Name = c.Name }).ToList();
            
        }
    }
}
