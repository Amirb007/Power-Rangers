using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;
using WebApplication1.Context;
using WebApplication1.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HotelController : ControllerBase
    {

        private readonly CRUDContext _CRUDContext;

        public HotelController(CRUDContext CRUDContext) {

            _CRUDContext = CRUDContext;

        }

        //GET: api/<HotelController>
        [HttpGet]
        public IEnumerable<Hotels> Get()
        {
                return _CRUDContext.Hotels;
        }

        //GET: api/<HotelController>
        [HttpGet("city")]
        // Query the Hotel by City
        public IEnumerable<Hotels> Get([FromQuery] string cityName)
        {
                return _CRUDContext.Hotels.Where(hotel => hotel.hotelCity.Equals(cityName)).ToList();
        }


        // GET api/<HotelController>/5
        [HttpGet("{id}")]
        public Hotels Get(int id)
        {
            return _CRUDContext.Hotels.SingleOrDefault(x=>x.hotelID==id) ;
        }

        // GET api/<HotelController>/{city}
        /*
        [HttpGet("/api/v1/hotel")]
        public List<Hotels> Get([FromQuery] string cityName)
        {
            return _CRUDContext.Hotels.Where(hotel => hotel.hotelCity.Equals(cityName)).ToList(); //.SelectMany<Hotels, String>(hotel => hotel.hotelCity.Equals(cityName));
        }*/


        // POST api/Hotels
        [HttpPost]
        public void Post([FromBody] Hotels hotel_info)
        {
            this._CRUDContext.Hotels.Add(hotel_info);
            this._CRUDContext.SaveChanges();
        }

        // PUT api/<HotelController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Hotels hotel_info)
        {
            _CRUDContext.Hotels.Update(hotel_info);
            _CRUDContext.SaveChanges();
        }

        // DELETE api/<HotelController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var item = _CRUDContext.Hotels.FirstOrDefault(x => x.hotelID == id);
            if (item != null) {
                _CRUDContext.Hotels.Remove(item);
                _CRUDContext.SaveChanges();
            }
        }
    }
}
