using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace VisaTracking.Controllers
{
    public class AdminController : Controller
    {
        public ActionResult GetEmpVisaDetails()
        {
            return View();
        }
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }
    }
}