using demo1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web.Mvc;
using demo1.Auth;
namespace demo1.Areas.Admin.Controllers
{
    public class AdminHomeController : Controller
    {
        // GET: Admin/Home
        private QL_TOURDL_N5Entities2 db = new QL_TOURDL_N5Entities2();
        //[Authentication]
        public ActionResult Index()
        {

            if (Session["user"] == null)
            {
                return RedirectToAction("Login", "Access"); 
            }
            return View();

        }

        public ActionResult CheckQuyen()
        {

           
            return View();

        }


    }
}