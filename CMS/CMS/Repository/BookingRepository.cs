using System.Linq;
using CMS.Models;

namespace CMS.Repository
{
    public class BookingRepository : IBookingRepository
    {
        private readonly CMSDbContext dbContext = new CMSDbContext();

        public Booking GetBookingById(int id)
        {
            return dbContext.Bookings.Where(b => b.Id == id).FirstOrDefault();
        }
    }
}