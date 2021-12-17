using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace Markit.Controllers
{
    public class Markit : Controller
    {
        public int Id { get; internal set; }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;

            return View();
        }
    }
}
