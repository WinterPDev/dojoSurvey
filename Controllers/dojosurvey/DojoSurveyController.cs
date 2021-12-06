using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace dojoSurvey.Controllers
{
    public class DojoSurveyController : Controller
    {
        public static string uName;
        public static string uLocation;
        public static string uLanguage;
        public static string uComment;

        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            return View("Index");
        }
    
        [HttpGet("Result")]
        public IActionResult Result()
        {
            ViewBag.name = uName;
            ViewBag.location = uLocation;
            ViewBag.language = uLanguage;
            ViewBag.comment = uComment;
            return View("Result");
        }

        [HttpPost]
        [Route("submitsurvey")]
        public IActionResult submitsurvey(string Name, string Location, string Language, string Comment)
        {
            uName = Name;
            uLocation = Location;
            uLanguage = Language;
            uComment = Comment;
            return RedirectToAction("Result");
        }
    }
}
