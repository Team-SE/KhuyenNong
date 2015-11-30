using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KhuyenNong.Models;
using System.IO;

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
        public ActionResult searchResult(string keys)
        {
            
           // String l = "~/database/knowledge/1.txt";
            if (keys == null) return null;
            using (Database1Entities db = new Database1Entities())
            {
               // var tble = db.KNOWLEDGES.Where(a => System.IO.File.ReadAllText(a.Contains).Contains(keys));
                var tbleKnowLedge = (from a in db.KNOWLEDGES
                                     join b in db.User_Table on a.Author equals b.Email
                                     select new rowSearch { Author = b.username, Title = a.Title, Contains = a.Contains, DateWritten = "", Id = a.Id.ToString()}).ToList();
                var mapping = tbleKnowLedge.Select(a => new rowSearch { Author = a.Author, Title = a.Title, Contains = System.IO.File.ReadAllText(Server.MapPath(a.Contains)), DateWritten = "", Id = a.Id.ToString() }).ToList();
                var listRes = mapping.Where(x => x.Contains.Contains(keys)).ToList();

                //var s = System.IO.Directory.GetCurrentDirectory();
                return View(new searchResult(listRes, keys));
            }
        }

    }
}
