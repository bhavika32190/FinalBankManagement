using BankManage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace BankManage.Controllers
{
    public class HomeController : Controller
    {

        DBContext _dbContext = new DBContext();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(Login Login)
        {
            if (ModelState.IsValid)
            {
                bool IsValidUser = _dbContext.Login
                    .Any(u => u.UserName.ToLower() == Login
                    .UserName.ToLower() &&
                    u.Password == Login.Password);

                if (IsValidUser)
                {
                    FormsAuthentication.SetAuthCookie(Login.UserName, false);
                    return RedirectToAction("Index", "UserDetails");
                }
            }
            ModelState.AddModelError("", "Invalid UserName & Password");
            return View();
        }

        private bool GetIsValidUser(Login Login)
        {
            return _dbContext.Login
                            .Any(u => u.UserName.ToLower() == Login
                            .UserName.ToLower() && 
                            u.Password == Login.Password);
        }

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Home");
        }
    }
}   