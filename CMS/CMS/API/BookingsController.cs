using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using CMS.Models;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Web.Http.Description;
using CMS.Repository;

namespace CMS.API
{
    public class BookingsController : ApiController
    {
        private IBookingRepository bookingRepository;

        public BookingsController(IBookingRepository bookingRepository)
        {
            this.bookingRepository = bookingRepository;
        }

        [HttpGet]
        [Route("api/Bookings/{id}")]
        public IHttpActionResult GetBookingById(int id)
        {
            var booking = this.bookingRepository.GetBookingById(id);
            if (booking == null)
                return NotFound();
            return Ok(booking);
        }
    }
}
