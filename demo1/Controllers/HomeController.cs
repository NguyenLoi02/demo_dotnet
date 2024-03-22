using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace demo1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var url = Url.Action("Login", "Access");
            return View();
        }

      
    }
}