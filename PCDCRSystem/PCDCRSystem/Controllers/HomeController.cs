﻿using PCDCRSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net;

using PCDCRSystem.Models;
namespace PCDCRSystem.Controllers
{
    public class HomeController : Controller
    {

    
        public ActionResult Index()
        {
           if (Session["ID"] == null)
                {
                return RedirectToAction("Login", "Account");
                }

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

      
    }
}
