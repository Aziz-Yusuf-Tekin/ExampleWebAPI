using Business.Abstract;
using Business.Concrete;
using Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FinderAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HotelController : ControllerBase
    {
        private IHotelService _hotelService;

        public HotelController(IHotelService hotelService)
        {
            _hotelService = hotelService;
        }


        /// <summary>
        /// Get All Hotels
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public List<Hotel> Get()
        {
            return _hotelService.GetListAll();
        }

        /// <summary>
        /// Get Hotel By Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("(id)")]
        public Hotel Get(int id)
        {
            return _hotelService.GetById(id);
        }

        /// <summary>
        /// Create an Hotel
        /// </summary>
        /// <param name="hotel"></param>
        [HttpPost]
        public void Post([FromBody] Hotel hotel)
        {
            _hotelService.Insert(hotel);
        }

        /// <summary>
        /// Update an Hotel
        /// </summary>
        /// <param name="hotel"></param>
        [HttpPut]
        public void put([FromBody] Hotel hotel)
        {
            _hotelService.Updated(hotel);
        }

        /// <summary>
        /// Delete an Hotel
        /// </summary>
        /// <param name="id"></param>
        [HttpDelete("(id)")]
        public void Delete(int id)
        {
            _hotelService.Delete(id);
        }
    }
}
