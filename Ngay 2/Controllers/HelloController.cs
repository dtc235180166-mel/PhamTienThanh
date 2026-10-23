using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace Ngay_2.Controllers
{
    public class HelloController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [Route("lmao")]
        public IActionResult Welcome(String name="Goodboicamau", int numTimes = 1)
        {
            ViewData["name"] = name;
            ViewBag.numTimes = numTimes;
            return View();
            
        }
    }
}
