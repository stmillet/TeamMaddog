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
        //initialize the shopping Cart
        public static Cart theCart = new Cart();

        public static List<Product> lstProducts = new List<Product>()
        {
            new Product { ProductID = 1, ProdName = "Backpack", ProdPrice = 49.99, ProdSize = "" },
            new Product { ProductID = 2, ProdName = "Hat", ProdPrice = 14.99, ProdSize = "" },
            new Product { ProductID = 3, ProdName = "Sweater", ProdPrice = 34.99, ProdSize = "" },
            new Product { ProductID = 4, ProdName = "Tshirt", ProdPrice = 19.99, ProdSize = "" },
        };

        public ActionResult Details(string name)
        {
            Product theProduct = lstProducts.Find(x => x.ProdName == name);
            return View(theProduct);
        }

        //show cart items function displays cart items
        public ActionResult ShowCartItems()
        {
            if(theCart.TheProducts == null)
            {
                theCart.TheProducts = new List<Product>();
            }
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
        public ActionResult AddCartItems(string nameIn)
        {
            if (ModelState.IsValid)
            {
                Product myCartItems = lstProducts.FirstOrDefault(x => x.ProdName == nameIn);
                theCart.TheProducts.Add(myCartItems);
                return RedirectToAction("ShowCartItems", "Cart");
            }
            else
            {
                return View("ShowCartItems", theCart);
            }
        }
    }
}