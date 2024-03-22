using demo1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using demo1.Auth;
namespace demo1.Areas.Admin.Controllers
{
    public class AdminPersonnelController : Controller
    {
        private QL_TOURDL_N5Entities2 db = new QL_TOURDL_N5Entities2();
        //[Authentication]
        // GET: Admin/AdminPersonnel
        [AdminAuthorizeAttribute(MaCN = "CN04")]
        public ActionResult Personnel()
        {
            List<NhanVien> NhanVienList = db.NhanViens.ToList();
            return View(NhanVienList);
        }
    }
}