using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebApplication1.Requests;
using WebApplication1.Structures;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("test")]
    public class WeatherForecastController : Controller
    {
        [HttpPost]
        [HttpGet]
        [Produces("application/json")]
        [Route("index")]

        public async Task<IActionResult> Index()
        {
            return this.Json(new { result = "Hello World" });
        }

        [HttpPost]
        [HttpGet]
        [Produces("application/json")]
        [Route("get_square")]

        public async Task<IActionResult> GetSquare()
        {
            WebApplicationRequest request = new WebApplicationRequest(this.Request);

            double square = request.S * request.H;

            MyClassResponce res = new MyClassResponce();
            res.Success = "Success";
            res.Result = square;
            res.Version = "1.0";
            return this.Json(res);
        }

    }
}
