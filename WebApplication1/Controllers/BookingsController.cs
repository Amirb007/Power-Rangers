using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Context;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingsController : ControllerBase
    {
        private readonly CRUDContext _context;

        public BookingsController(CRUDContext context)
        {
            _context = context;
        }

        // GET: api/Bookings
        [HttpGet]
        public IEnumerable<Booking> GetBooking()
        {
            return _context.Booking;
        }

        // GET: api/Bookings/5
        [HttpGet("{id}")]
        public Booking Get(int id)
        {
            return _context.Booking.SingleOrDefault(x => x.bookingID == id);

        }

        // POST api/Bookings
        [HttpPost]
        public void Post([FromBody] Booking booking_info)
        {
            this._context.Booking.Add(booking_info);
            this._context.SaveChanges();
        }

        // PUT api/<BookingsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Booking booking_info)
        {
            _context.Booking.Update(booking_info);
            _context.SaveChanges();
        }

        // DELETE api/<BookingsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var item = _context.Booking.FirstOrDefault(x => x.bookingID == id);
            if (item != null)
            {
                _context.Booking.Remove(item);
                _context.SaveChanges();
            }
        }
    }
}
