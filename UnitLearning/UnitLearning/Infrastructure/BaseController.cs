using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UnitLearningDB;

namespace UnitLearning.Infrastructure
{
    public class BaseController : Controller
    {
        protected UserBase CurUser;

        protected override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            //this.CurUser = 
            GetCurUser();
            base.OnActionExecuted(filterContext);   
        }

        public UserBase GetCurUser()
        {
            if (Session["CurUser"] != null)
            {
                UserBase user = (UserBase)Session["CurUser"];
                user.User = base.User;
                return (UserBase)Session["CurUser"];
            }
            else
            {
               // RedirectToAction("Account", "Login");
               // return null;
            }
            return null;
            /*var user = new Manager();
            Session["CurUser"] = user;
            return user;*/
        }
    }
}