using demo1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
namespace demo1.Areas.Admin.Controllers.AccessController
{
    public class AccessController : Controller
    {
        // GET: Admin/Login
        private QL_TOURDL_N5Entities2 db = new QL_TOURDL_N5Entities2();
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(string user, string pass)
        {
            var Account = db.TaiKhoans.SingleOrDefault(m => m.UserName.ToLower() == user.ToLower() && m.Password == pass);
            if (Account != null)
            {
                Session["user"] = Account;
                return RedirectToAction("Index","AdminHome");
            }
            else
            {
                return View();

            }
        }

        public ActionResult Logout()
        {
            Session.Clear();
            Session.Abandon();
            return RedirectToAction("Login", "Access");
        }
    }
}