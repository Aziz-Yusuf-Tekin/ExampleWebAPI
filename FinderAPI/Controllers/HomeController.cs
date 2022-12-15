using Business.Abstract;
using Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FinderAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private IHomeService _homeService;

        public HomeController(IHomeService homeService)
        {
            _homeService = homeService;
        }

        /// <summary>
        /// Get All Homes
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public List<Home> Get()
        {
            return _homeService.GetListAll();
        }


        /// <summary>
        /// Get Home By Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("(id)")]
        public Home Get(int id)
        {
            return _homeService.GetById(id);
        }

        /// <summary>
        /// Create an Home
        /// </summary>
        /// <param name="home"></param>
        [HttpPost]
        public void Post([FromBody]Home home)
        {
            _homeService.Insert(home);
        }

        /// <summary>
        /// Update an Home
        /// </summary>
        /// <param name="home"></param>
        [HttpPut]
        public void Put([FromBody]Home home)
        {
            _homeService.Update(home);
        }

        /// <summary>
        /// Delete an Home
        /// </summary>
        /// <param name="id"></param>
        [HttpDelete("(id)")]
        public void Delete(int id)
        {
            _homeService.Delete(id);
        }
    }
}
