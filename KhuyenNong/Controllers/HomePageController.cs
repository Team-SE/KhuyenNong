using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KhuyenNong.Controllers
{
    public class HomePageController : Controller
    {
        //
        // GET: /HomePage/

        public ActionResult Index() //hihi
        {
            return View();
        }

        protected override void HandleUnknownAction(string actionName)
        {
            try
            {
                this.View(actionName).ExecuteResult(this.ControllerContext);
            }
            catch
            {
                Response.Redirect("Page Not Found Hahaha hahahha");
            }
        }

    }
}
