using COMP003B.SP25.Assignment3.Models;
using Microsoft.AspNetCore.Mvc;

namespace COMP003B.SP25.Assignment3.Controllers
{
    public class EventController : Controller
    {
        [HttpGet("event/register/{eventCode}")]
        public IActionResult Register([FromRoute] string eventCode)
        {
            var model = new EventRegistration { EventCode = eventCode };
            return View(model);
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register([FromForm] EventRegistration model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            return RedirectToAction("Success", model);
        }

        [HttpGet]
        public IActionResult Success(EventRegistration model)
        {
            return View(model);
        }
    }
}
