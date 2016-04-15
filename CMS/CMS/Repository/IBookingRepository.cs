using CMS.Models;

namespace CMS.Repository
{
    public interface IBookingRepository
    {
        Booking GetBookingById(int id);
    }
}
