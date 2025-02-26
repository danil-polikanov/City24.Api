using City24.Api.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.TagHelpers;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace City24.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApartmentController : ControllerBase
    {
        List<Apartment> apartments = new List<Apartment>
        {
        new Apartment
        {
            Id = 2715300,
            Title = "РЕНОВИРОВАННАЯ КВАРТИРА! КОМНАТЫ РАЗДЕЛЬНЫЕ!",
            Price = new RentPrice{FullPrice=575,CubicMetrePrice=8.85,AdditionPayment="все коммунальные услуги",
            SummerUtility=90,WinterUtility=180,Deposit=575,MaklerPrice=575,ApartmentId=2715300            },
            Area = 55.5,
            Rooms = 3,
            Description = "КВАРТИРА\r\nЗаходя в квартиру, попадаете в большую квадратную прихожую, которая соединяет все комнаты. Гостиная комната просторная и светлая. Кухня оснащенная всей необходимой техникой. Спальная комната имеет выход на застеклённый балкон.",
            Type = "реновировано",
            Floor = 7,
            TotalFloors = 9,
            TotalBathrooms=3,
            Balcony="Полностью застекленный балкон",
            Ownership="квартирная собственность",
            SecuritySystems= new List<SecuritySystem>{ new SecuritySystem {Name="стальная дверь",ApartmentId= 2715300 } },
            Address = new Address { Street = "Mahtra tn 14", City = "Tallinn", District = "Lasnamäe ", PostalCode = "10124" },
            Owner = new Owner { Name = "Иван Петров", Phone = "+372 5555 1234", Email = "ivan.petrov@example.com" },
            Photos = new List<Photo> { new Photo { Url = "D:\\Programming\\repos\\City24.Api\\Domain\\Images\\images.jpg" } },
            Communications=new Communications{EnergyType="Центральное отопление",HeatingSystem="Радиаторы",
            Plate="Электроплита",BathroomInfo=new List<BathroomInfo>{new BathroomInfo { Name="Ванная"} },

            } } };
    // GET: api/<ApartmentController>
    [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<ApartmentController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ApartmentController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ApartmentController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ApartmentController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
