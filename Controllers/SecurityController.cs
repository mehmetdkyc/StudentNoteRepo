using PersonelMVCUI.Models.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace PersonelMVCUI.Controllers
{
    [AllowAnonymous]
    public class SecurityController : Controller
    {
        PersonelDbEntities1 db = new PersonelDbEntities1();
        // GET: Security
        
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(Kullanici kullanici)
        {
            var kullaniciDb = db.Kullanici.FirstOrDefault(x=>x.Name==kullanici.Name);
            var kullaniciDbSifre = db.Kullanici.FirstOrDefault(x => x.Password == kullanici.Password);
            if (kullaniciDb != null && kullaniciDbSifre!=null)
            {
                FormsAuthentication.SetAuthCookie(kullaniciDb.Name, false);
                return RedirectToAction("Index", "Student");
            }
           
            else
            {
                ViewBag.Mesaj = "Geçersiz kullanıcı adı veya şifre";
                return View();
                
            } 
        }
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login");
        }
    }
}