using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KhuyenNong.Models;
namespace KhuyenNong.Controllers
{
    public class UserController : Controller
    {
        //
        // GET: /User/

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult submit(User_Table u)
        {
            using (DatabaeEntities db = new DatabaeEntities())
            {
                var data = (from a in db.User_Table
                            where u.password.Equals(a.password) && u.Email.Equals(a.Email)
                            select a).ToList();
               if (data.Count == 0){
                   return RedirectToAction("LoginF", "User");
               }
               else
               {
                   
                   Session["kk"] = data.First().username;
                   Session["level"] = data.First().level;
                   return RedirectToAction("Index", "HomePage");
               }
                   
            }
        }
        public ActionResult LoginF()
        {
            return View();
        }

        public ActionResult logOut()
        {
            Session["kk"] = null;
            Session["level"] = null;
            return RedirectToAction("Index", "HomePage");
        }

    }
}
