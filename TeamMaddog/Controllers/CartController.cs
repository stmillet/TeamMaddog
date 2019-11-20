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

        //List of sizes for the drop down size menu
        public static List<Size> sizes = new List<Size>() 
            {
                new Size { SizeCode = "XS", SizeDesc = "Extra Small" },
                new Size { SizeCode = "S", SizeDesc = "Small"},
                new Size { SizeCode = "M", SizeDesc = "Medium"},
                new Size { SizeCode = "L", SizeDesc = "Large"},
                new Size { SizeCode = "XL", SizeDesc = "Extra Large"}
            };

        //Get method for the size detail
        [HttpGet]
        public ActionResult Details(string name)
        {
            Product theProduct = lstProducts.Find(x => x.ProdName == name);
            
            ViewBag.Cart = sizes;
            return View(theProduct);
        }

        //show cart items function displays cart items
        public ActionResult ShowCartItems()
        {
            if (theCart.TheProducts == null)
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
        public ActionResult Detail(Product theProduct)
        {
            if(theCart.TheProducts == null)
            {
                theCart.TheProducts = new List<Product>();
            }

            if (ModelState.IsValid)
            {
                Product myCartItems = lstProducts.Find(x => x.ProdName == theProduct.ProdName);
                myCartItems.ProdSize = theProduct.ProdSize;
                theCart.TheProducts.Add(myCartItems);
                return RedirectToAction("ShowCartItems", "Cart");
            }
            else
            {
                return View("ShowCartItems", theCart);
            }
        }

        //Check out post method after the customer is done choosing their items
        [HttpPost]
        public ActionResult CheckOut()
        {
            return View(theCart);
        }
    }
}