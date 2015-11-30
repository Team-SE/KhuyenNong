using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KhuyenNong.Models.HomePage;

namespace KhuyenNong.Controllers
{
    public class DetailController : Controller
    {
        //
        // GET: /Detail/

        public ActionResult Index()
        {
            using (Database1Entities1 db = new Database1Entities1())
            {
                var data = (from a in db.ShowHomes
                                orderby a.dateWritten descending
                                where (a.Type == 1)
                                select new thumbHome{
                                    linkTitle = a.Title,
                                    summary = a.Summary,
                                    linkIma = a.linkImage,
                                    dateUpdate = a.dateWritten.ToString(),
                                    linkPage = a.linkPage,
                                    type = a.Type
                                 }).Take(10).ToList();
                         
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
                Response.Redirect("Page Not Found Hahaha hahahha");
            }
        }

    }
}
