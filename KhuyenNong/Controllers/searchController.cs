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
       
        public ActionResult searchPage(string keys)
        {
            if (keys == null || keys.Trim() == "") return RedirectToAction("Index", "HomePage");
            using (DatabaeEntities db = new DatabaeEntities())
            {
                keys = keys.Trim().ToLower();
                var data = (from a in db.ShowHomes
                            select new thumbHome
                            {
                                linkTitle = a.Title,
                                type = a.Type,
                                linkPage = a.linkPage,
                                summary = a.Summary
                            }).ToList();
                List<thumbHome> result = new List<thumbHome>(data.Count);
                foreach (var i in data)
                {
                    var line = System.IO.File.ReadAllLines(Server.MapPath("~\\Views" + i.linkPage + ".cshtml"));
                    int length = line.Length;
                    for (int j = 0; j < length; j++ )
                    {
                        if (line[j].ToLower().Contains(keys))
                        {
                            result.Add(i);
                            break;
                        }
                    }
                    //if (line)
                }
                return View(new resSearch(result, keys));
            }
           
        }

    }
}
