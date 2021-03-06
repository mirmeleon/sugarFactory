﻿using System.Web.Mvc;

namespace SugarFactory.Web.Controllers
{
    [AllowAnonymous]
   
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
      
        public ActionResult About()
        {
          return View();
        }
      
        public ActionResult Contact()
        {
            ViewBag.Message = "More information you can receive by phone or email.";

            return View();
        }


        public ActionResult FancyChat()
        {
           return View();
        }
    }
}