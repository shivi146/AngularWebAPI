using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VisaTracking.Models;

namespace VisaTracking.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(EmpDetails empdetails)
        {
            empdetails.AppRole = "emp87";
            if(empdetails.AppRole == "emp")
            {
                return RedirectToAction("AddVisaDetails", "User");
            }
            else
            {
                return RedirectToAction("GetEmpVisaDetails", "Admin");
            }
        }
    }
}