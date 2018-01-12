using MVCDay5Validations.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDay5Validations.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Employee e1)
        {
            if(ModelState.IsValid)
            {
                return RedirectToAction("ThankYou");
            }
            return View(e1);
        }

        public ActionResult ThankYou()
        {
            return View();
        }

        public ActionResult Contactus()
        {
            return View();
        }
    }
}