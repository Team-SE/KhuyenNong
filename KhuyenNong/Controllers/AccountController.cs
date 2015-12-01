using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KhuyenNong.Models;
//using Microsoft.AspNet.Web.Optimization;
namespace KhuyenNong.Controllers
{
    public class AccountController : Controller
    {
        //
        // GET: /Account/

        public ActionResult Login_in0()
        {
            return View();
        }

        public ActionResult Login8(string u, string p)
        {

            return View();
        }
        public ActionResult Login_in(User_Table u)
        {
            if (u == null) return RedirectToAction("LoginFail", "Account");
            using (var db = new DatabaeEntities())
            {
                var data = (from a in db.User_Table
                            where u.password.Equals(a.password) && u.Email.Equals(a.Email)
                            select a).ToList();
               if (data == null){
                   ViewBag.Error = "Sai mật khẩu hoặc email";
                   return RedirectToAction("LoginFail", "Account");
               }
               else
               {
                   return RedirectToAction("Index", "HomePage");
               }
                   
            }
        }


        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Login(User_Table u)
        //{
        //    // this action is for handle post (login)
        //    if (ModelState.IsValid) // this is check validity
        //    {
        //        using (DatabaeEntities dc = new DatabaeEntities())
        //        {
        //            var v = dc.User_Table.Where(a => a.Email.Equals(u.Email) && a.password.Equals(u.password)).FirstOrDefault();
        //            if (v != null)
        //            {
        //                Session["LogedUserID"] = v.Email.ToString();
        //                Session["LogedUserFullname"] = v.username.ToString();
        //                return RedirectToAction("AfterLogin");
        //            }
        //        }
        //    }
        //    return View(u);
        //}

        //public ActionResult loginFail(){
        //    return View();
        //}
        //public ActionResult AfterLogin()
        //{
        //    if (Session["LogedUserID"] != null)
        //    {
        //        return View();
        //    }
        //    else
        //    {
        //        return RedirectToAction("Login");
        //    }
        //}
    }
}
