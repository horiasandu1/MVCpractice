using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCpractice.Models;
namespace MVCpractice.Controllers
{
    public class HomeController : Controller
    {
        public Model myModel = new Model();
        public ActionResult Index()

        {

            var records = myModel.GetList();
            return View(records);
        }

  
    }
}