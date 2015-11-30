using KhuyenNong.Areas.Admin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KhuyenNong.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Admin/Home/

        public ActionResult Index()
        {
            var model = List_BaiViet.Baiviet_List;
            return View("Index", model);          
        }

        [HttpPost]
        public ViewResult Create(BaiViet a)
        {
            List_BaiViet.Add(a);
            var model = List_BaiViet.Baiviet_List;
            return View("Index", model);
        }
    }   
}
