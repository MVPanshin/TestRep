using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using UnitLearning.Infrastructure;
using UnitLearning.Models.Account;
using UnitLearningDB;
using UnitLearningDB.Infrastructure;

namespace UnitLearning.Controllers
{
    public class AccountController : BaseController
    {
        /*
        private IRepository _db;
        public AccountController(): this(new DataBaseUL(null)) {
        }
        public AccountController(IRepository rep)
        {
            _db = rep;
        }*/
        protected DataBaseUL _db = new DataBaseUL(null);

        // GET
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginModel model)
        {
            if(ModelState.IsValid)
            {
                var user = _db.FindUser(model.Login, model.Password);

                if (user != null)
                {
                    Session["CurUser"] = user;
                    FormsAuthentication.SetAuthCookie(model.Login, false);
                    return RedirectToAction("Dashboard", "Index");
                }
                else
                {
                    ModelState.AddModelError("", "Пользователя с таким логином и паролем нет");
                }
            }

            return View(model);
        }

        [HttpGet]
        public ActionResult Logoff()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login");
        }
    }
}