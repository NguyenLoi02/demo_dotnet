using demo1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using demo1.Auth;
namespace demo1.Areas.Admin.Controllers
{
    [AdminAuthorizeAttribute(MaCN = "CN04")]
    //Phân quyền: quản lý =>  quản lý nhân viên (thêm, sửa, xóa)
    public class AdminPersonnelController : Controller
    {
        private QL_TOURDL_N5Entities2 db = new QL_TOURDL_N5Entities2();
        //[Authentication]
        // GET: Admin/AdminPersonnel
        
        public ActionResult Personnel()
        {
            List<NhanVien> NhanVienList = db.NhanViens.ToList();
            return View(NhanVienList);
        }
    }
}