using demo1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using demo1.Auth;
namespace demo1.Areas.Admin.Controllers
{
    //[Authentication]
    [AdminAuthorizeAttribute(MaCN = "CN01")]
    //Phân quyền: nhân viên đăng bài => quản lý tin tức ( thêm, sửa, xóa)
    public class AdminNewsController : Controller
    {
        private QL_TOURDL_N5Entities2 db = new QL_TOURDL_N5Entities2();
        // GET: Admin/AdminNews
        
        public ActionResult NewsManage()
        {
            List<TinTuc> TinTucList = db.TinTucs.ToList();

            return View(TinTucList);
        }
        public ActionResult CreateNews()
        {
            return View();
        }
       
    }
}