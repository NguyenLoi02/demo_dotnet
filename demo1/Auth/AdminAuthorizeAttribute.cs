using demo1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.UI.WebControls;

namespace demo1.Auth
{
    public class AdminAuthorizeAttribute:AuthorizeAttribute
    {
        public string MaCN { get; set; }
        public override void OnAuthorization(AuthorizationContext filterContext)
        {
            //1 check sesstion : đã đăng nhập => cho thực hiện filter
            //ngược lại trở lại trang đăng nhập
            TaiKhoan tkSesstion = (TaiKhoan)HttpContext.Current.Session["user"];
            if (tkSesstion != null )
            {
                //2 check quyền : có quyền => cho thực hiện filter
                //ngược lại trở lại trang đăng nhập
                
                QL_TOURDL_N5Entities2 db = new QL_TOURDL_N5Entities2();
                var count = db.PhanQuyens.Count(m => m.UserName == tkSesstion.UserName & m.MaCN == MaCN);
                if (count != 0)
                {
                    return;
                }
                else
                {
                    var returnURL = filterContext.RequestContext.HttpContext.Request.RawUrl;
                    filterContext.Result = new RedirectToRouteResult(new
                        RouteValueDictionary(
                            new
                            {
                                Controller = "AdminHome",
                                Action = "CheckQuyen",
                                Areas = "Admin",
                                returnURL = returnURL.ToString()
                            }
                        )
                    );
                }
                return;
            }
            else
            {
                var returnURL = filterContext.RequestContext.HttpContext.Request.RawUrl;
                filterContext.Result = new RedirectToRouteResult(new
                    RouteValueDictionary(
                        new
                        {
                            Controller = "Access",
                            Action = "Login",
                            Areas = "Admin",
                            returnURL = returnURL.ToString()
                        }
                    )
                );
            }
            
        }
    }
}