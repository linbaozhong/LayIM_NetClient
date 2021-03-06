﻿using LayIM.Logger;
using System;
using System.Web.Mvc;

namespace LayIM_RongCloud_Chat.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            try
            {
               
            }
            catch (Exception ex) {
                LogHelper.WriteLog(ex);
            }
            return View();
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