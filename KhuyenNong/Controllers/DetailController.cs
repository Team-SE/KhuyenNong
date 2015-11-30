using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KhuyenNong.Controllers
{
    public class DetailController : Controller
    {
        //
        // GET: /Detail/

        public ActionResult Detail()
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
