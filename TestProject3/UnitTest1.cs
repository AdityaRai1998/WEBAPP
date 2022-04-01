using Microsoft.AspNetCore.Mvc;
using Xunit;
using System;

namespace TestProject3
{
    public class HomeController : Controller
    {

        [Fact]
        public ActionResult About()
        {
            ViewData["Message"] = "Your application description page.";
            return View("About");
        }
    }
}