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
        public static Cart theCart = new Cart();

        //show cart items function displays cart items
        public ActionResult ShowCartItems()
        {
            return View(theCart);
        }

        //get info from addcartitems view
        [HttpGet]
        public ActionResult AddCartItems()
        {
            return View();
        }

        //post info to showcartitems view
        [HttpPost]
        public ActionResult AddCartItems(Product myCartItems)
        {
            if (ModelState.IsValid)
            {
                theCart.TheProducts.Add(myCartItems);
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return View(myCartItems);
            }
        }
    }
}