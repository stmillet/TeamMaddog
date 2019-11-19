using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TeamMaddog.Controllers
{
    public class CustomerController : Controller
    {
        //initialize customer list
        public static List<Customer> lstCustomerInfo = new List<Customer>();

        //show customer function displays customer information
        public ActionResult ShowCustomerInfo()
        {
            return View(lstCustomer);
        }

        //get info from addcustomer view
        [HttpGet]
        public ActionResult AddCustomerInfo()
        {
            return View();
        }

        //post info to showcustomerinfo view
        [HttpPost]
        public ActionResult AddCustomerInfo(Customer myCustomerInfo)
        {
            if (ModelState.IsValid)
            {
                myCustomerInfo.Customer_Code = lstCustomerInfo.Count() + 1;
                lstCustomerInfo.Add(myCustomerInfo);
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return View(myCustomerInfo);
            }
        }

        //get info from editcustomerinfo view
        [HttpGet]
        public ActionResult EditCustomerInfo(int iCode)
        {
            Customer oCustomerInfo = lstCustomerInfo.Find(x => x.Customer_Code == iCode);
            return View(oCustomerInfo);
        }

        //post edited info to showcustomerinfo view
        [HttpPost]
        public ActionResult EditCustomerInfo(Customer myModel)
        {
            var obj = lstCustomerInfo.FirstOrDefault(x => x.Customer_Code == myModel.Customer_Code);

            if (obj != null)
            {
                obj.Customer_FName = myModel.Customer_FName;
                obj.Customer_LName = myModel.Customer_LName;
                obj.Customer_Email = myModel.Customer_Email;
                obj.Cust_Street_Address = myModel.Cust_Street_Address;
                obj.Cust_City = myModel.Cust_City;
                obj.Cust_State = myModel.Cust_State;
                obj.Cust_Zip = myModel.Cust_Zip;
            }

            return View("ShowCustomers", lstCustomerInfo);
        }
    }
}