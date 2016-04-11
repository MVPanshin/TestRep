using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UnitLearning.Infrastructure;

namespace UnitLearning.Controllers
{
    public class DashboardController : BaseController
    {
        // GET: Dashboard
        public ActionResult Index()
        {
            
            return View();
        }
    }
}