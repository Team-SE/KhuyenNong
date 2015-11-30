using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KhuyenNong.Controllers
{
    public class LoginController : Controller
    {
        //
        // GET: /Login/

        public ActionResult Log_in()
        {
            return View();
        }

        public ActionResult Register()
        {
            return View();
        }

        public ActionResult CheckLogin(FormCollection frm)
        {
            string Username = frm["Email"];
            string Password = frm["Password"];
            if ((Username=="admin")&&(Password=="123")) {
                ViewBag.Thongbao = "Dang nhap thanh cong.";
            }
            else {
                ViewBag.Thongbao = "Dang nhap that bai.";
            }
            return View("Detail");
        }
        
    }
}
