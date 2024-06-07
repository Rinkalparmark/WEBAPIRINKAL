using Microsoft.AspNetCore.Mvc;
using System.Net;
using WebAPI.Services;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class HomeController : Controller
    {
        private readonly IHomeServices _homeServices;

        public HomeController(IHomeServices homeServices)
        {
            _homeServices = homeServices;
        }

        [HttpGet]
        public IActionResult GetUsersList(int userId)
        {
            var result = _homeServices.GetUsersList(userId);
            if (result != null && result.Count > 0)
            {

                return Ok(new
                {
                    statusCode = HttpStatusCode.OK,
                    message = "Data Found",
                    data = result

                });
            }

            return NoContent();

        }

    }
}
