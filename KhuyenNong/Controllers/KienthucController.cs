using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KhuyenNong.Models;

namespace KhuyenNong.Controllers
{
    public class KienthucController : Controller
    {
        //
        // GET: /Kienthuc/

        public ActionResult Index()
        {
            using (var db = new DatabaeEntities())
            {
                var data = (from a in db.ShowHomes
                            orderby a.dateWritten descending
                            where (a.Type == 2)
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

    }
}
