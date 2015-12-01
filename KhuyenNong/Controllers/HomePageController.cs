using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KhuyenNong.Models;

namespace KhuyenNong.Controllers
{
    public class HomePageController : Controller
    {
        //
        // GET: /HomePage/

        public ActionResult Index() //hihi
        {
            using (var db = new DatabaeEntities())
            {
                var data = (from a in db.ShowHomes
                            orderby a.dateWritten descending
                            select new thumbHome
                            {
                                linkTitle = a.Title,
                                summary = a.Summary,
                                linkIma = a.linkImage,
                                dateUpdate = a.dateWritten.ToString(),
                                linkPage = a.linkPage,
                                type = a.Type
                            }).Take(10).ToList();
                var t = data.First().linkIma;
                return View(data);
            }
            
        }

        protected override void HandleUnknownAction(string actionName)
        {
            try
            {
                this.View(actionName).ExecuteResult(this.ControllerContext);
            }
            catch
            {
                Response.Redirect("/HomePage");
            }
        }

    }
}
