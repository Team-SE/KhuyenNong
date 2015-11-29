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

    }
}
