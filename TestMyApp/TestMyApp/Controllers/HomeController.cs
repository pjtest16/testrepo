﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TestMyApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
            ///fasdfdasfsa
            ///fsdfsdafdasfasd
            /////psakajjjdasdsadsa
            //test branch
            ///master
            ///master ---4PM
            //master ---9:27PM
            //master ---10:44PM
            //master ---11:15PM
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}