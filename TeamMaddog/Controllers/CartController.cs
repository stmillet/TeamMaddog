using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TeamMaddog.Models;

namespace TeamMaddog.Controllers
{
    public class CartController : Controller
    {
        //initialize customer list
        public static List<Cart> lstCartItems = new List<Cart>();

        //show cart items function displays cart items
        public ActionResult ShowCartItems()
        {
            return View(lstCartItems);
        }

        //get info from addcartitems view
        [HttpGet]
        public ActionResult AddCartItems()
        {
            return View();
        }

        //post info to showcartitems view
        [HttpPost]
        public ActionResult AddCartItems(Cart myCartItems)
        {
            if (ModelState.IsValid)
            {
                lstCartItems.Add(myCartItems);
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return View(myCartItems);
            }
        }
    }
}