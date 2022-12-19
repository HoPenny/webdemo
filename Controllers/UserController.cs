using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace webdemo.Controllers
{
    public class UserController : Controller
    {
        
        [HttpGet]
        public ActionResult Login()
        {
            vmLogin model = new vmLogin();
            return View(model);
        }
        [HttpPost]
        public ActionResult Login(vmLogin model)
        {
            //驗證不合格返回View
            if (!ModelState.IsValid) return View(model);
            //記錄登入者資訊
            Session["UserNo"] = model.UserNo;
            Session["UserName"] = "Penny";
            Session["IsLogin"] = true;
            //回到首頁
            return RedirectToAction("Index","Home");
        }
    }
}