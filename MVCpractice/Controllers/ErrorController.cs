﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCpractice.Controllers
{
    public class ErrorController : Controller
    {
        [Route("Error/Index/{id}")]
        public ActionResult Index(int id)
        {
            return View();
        }
    }
}