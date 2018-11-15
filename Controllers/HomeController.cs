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
        private CoffeeShopDBEntities Caffine = new CoffeeShopDBEntities();
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
        public ActionResult ShoppingList(Item itemName)
        {
            ViewBag.list = Caffine.Items.ToList<Item>();
            return View();
        }
        //public ActionResult ShoppingList()
        //{
        //    return View();
        //}
        public ActionResult AddUser(User userInfo)
        {
            CoffeeShopDBEntities dataBase = new CoffeeShopDBEntities();
            dataBase.Users.Add(userInfo); //Not sure why it's Users instead of the class name User
            ViewBag.UserAdded = "Welcome to the Coffee Jungle";
            dataBase.SaveChanges(); //This does not work. Don't know why and it's making me rage. A LOT.
            return View("WelcomeUser");

        }

        public ActionResult AdminPage(Item itemName)
        {
            ViewBag.list = Caffine.Items.ToList<Item>();

            return View();
        }
        public ActionResult AddingItems(Item item)
        {
            Caffine.Items.Add(item);
            Caffine.SaveChanges();
            ViewBag.AddedItem = "Thank You for Adding an Item";

            return View("AddItem");
        }
        public ActionResult Edit(string id)
        {
            Item item = Caffine.Items.Find(id);
            Caffine.SaveChanges();
            return View("ShoppingList");
        }
        [HttpPost]
        public ActionResult Edit(Item item)
        {
            Caffine.Entry(Caffine.Items.Find(item.Name)).CurrentValues.SetValues(item);
            Caffine.SaveChanges();
            return RedirectToAction("ShoppingList");
        }
        public ActionResult Delete(string id)
        {
            Item item = Caffine.Items.Find(id);
            Caffine.Items.Remove(item);
            Caffine.SaveChanges();
            return RedirectToAction("ShoppingList");
        }
    }
}