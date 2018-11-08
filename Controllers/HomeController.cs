using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CoffeeShopApp.Models;

namespace CoffeeShopApp.Controllers
{
    public class HomeController : Controller
    {
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

        public ActionResult RegistrationPage()
        {
            return View();
        }

        public ActionResult WelcomeUser(AddMember newUser)
        {
            if (ModelState.IsValid)
            {
                ViewBag.ConfirmMessage = "Welcome! " + newUser.FirstName;
                return View("Confirm");  //GO HERE DANG IT!!!
            }
            else
            {
                return View("Error"); //So it goes to the Error page fine but it won't go to the confirm page.
            }
        }
    }
}