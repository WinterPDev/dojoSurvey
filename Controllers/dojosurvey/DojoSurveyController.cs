using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using dojoSurvey.Models;

using System;

namespace dojoSurvey.Controllers
{
    public class DojoSurveyController : Controller
    {
        static User newUser;

        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            return View("Index");
        }

        [HttpGet("Result")]
        public IActionResult Result()
        {
            return View(newUser);
        }


        [HttpPost("submitsurvey")]
        public IActionResult submitsurvey(User surveyUser)
        {
            if(ModelState.IsValid)
            {
            newUser = surveyUser;
            return RedirectToAction("Result");
            }
            else
            {
            return View("Index");
            }
        }
    }
}
