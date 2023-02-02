using MVC_Authorize.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace MVC_Authorize.Controllers
{
   
    public class SecurityController : Controller
    {
        // GET: Security
        devrimme_ramazanBeyDbEntities db=new devrimme_ramazanBeyDbEntities();
        [AllowAnonymous]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [AllowAnonymous]
        public ActionResult Login(Tbl_User user)
        {
            var _user = db.Tbl_User.FirstOrDefault(x=>x.Username==user.Username && x.Password==user.Password);
            if (_user!=null)
            {
                FormsAuthentication.SetAuthCookie(_user.Username,false);
                return RedirectToAction("Index","Departments");
            }else
            {
                ViewBag.Message = "Geçersiz Kullanıcı Adı veya Parola";
                return View();
            }

          
        }

        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login");
        }
    }
}