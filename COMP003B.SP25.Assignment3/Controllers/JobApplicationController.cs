using COMP003B.SP25.Assignment3.Models;
using Microsoft.AspNetCore.Mvc;

namespace COMP003B.SP25.Assignment3.Controllers
{
    public class JobApplicationController : Controller
    {
        //[HttpGet("apply/{position?}")]
        [HttpGet]
        public IActionResult Apply([FromQuery] string? position)

        {
            var model = new JobApplication
            {
                Position = position ?? string.Empty
            };
            return View(model);
        }

        [HttpPost]
        public IActionResult Apply(JobApplication model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            return RedirectToAction("Confirm", model);
        }

        [HttpGet]
        public IActionResult Confirm(JobApplication model)
        {
            return View(model);
        }
    }
}
