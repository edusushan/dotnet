using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace Lab_17.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home 
        public ActionResult Index()
        {
            ViewData["Message"] = "I am Nature lover";
            ViewData["CurrentTime"] = DateTime.Now.ToLongTimeString();
            return View();
        }
    }
}
