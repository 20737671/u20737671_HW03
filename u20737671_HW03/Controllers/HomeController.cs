﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;



namespace u20737671_HW03.Controllers
{
    public class HomeController : Controller
    {
       

        public ActionResult Home()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        
        public ActionResult Index()
        {
            return View();
        }
    }
}