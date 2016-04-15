using NUnit.Framework;
using Moq;
using CMS.API;
using CMS.Repository;
using CMS.Models;
using System.Web.Http;
using System.Web.Http.Results;

namespace CMS.Tests.Controllers
{
    /// <summary>
    /// Summary description for BookingController
    /// </summary>
    [TestFixture]
    public class BookingControllerTest
    {
        private Mock<IBookingRepository> mockBookingRepository;
        [SetUp]
        public void SetUpTest()
        {
           mockBookingRepository = new Mock<IBookingRepository>();
        }

        [Test]
        public void Booking_Should_Be_Return_By_Id()
        {
            const int Id = 1;
            const string Name = "2";
            const int NumberOfAdults = 3;
            const int NumberOfBabies = 4;
            mockBookingRepository.Setup(m => m.GetBookingById(Id)).Returns(new Booking { Id = Id, Name = Name, NumberOfAdults = NumberOfAdults, NumberOfBabies = NumberOfBabies });
            var bookingController = new BookingsController(mockBookingRepository.Object);
            IHttpActionResult actionResult = bookingController.GetBookingById(Id);
            var contentResult = actionResult as OkNegotiatedContentResult<Booking>;
            Assert.IsNotNull(contentResult);
            Assert.IsNotNull(contentResult.Content);
            Assert.AreEqual(Id, contentResult.Content.Id);
        }
       
    }
}
