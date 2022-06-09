using Kolokwium_2.Services;
using Microsoft.AspNetCore.Mvc;

namespace Kolokwium_2.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HomeController : ControllerBase
    {
        private readonly Interface _service;
        public HomeController(Interface service)
        {
            _service = service;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
