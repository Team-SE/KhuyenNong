using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KhuyenNong.Models;

namespace KhuyenNong.Controllers
{
    public class searchController : Controller
    {
        //
        // GET: /search/
        
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult searchResult(string keys, string tblname)
        {
            using (Database1Entities db = new Database1Entities())
            {
                var tble = db.KNOWLEDGES.Where(a => System.IO.File.ReadAllText(a.Contains).Contains(keys));
                var tbleKnowLedge = (from a in db.KNOWLEDGES
                                     where true
                                     select new resultSearch { Author = a.Author, Title = a.Title, Contains = System.IO.File.ReadAllText(a.Contains), DateWritten = "", Id = a.Id.ToString()}).ToList();
                var listRes = tbleKnowLedge.Where(x => x.Contains.Contains(keys)).ToList();
                return View(listRes);
            }
        }

    }
}
