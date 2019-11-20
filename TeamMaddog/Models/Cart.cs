using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TeamMaddog.Models
{
    public class Cart
    {
        //various cart getters and setters
        //initialize the cart number
        [Required]
        public int CartNum { get; set; }

        //initialize the name
        [Required]
        [Display( Name = "Customer Name:")]
        public Customer TheCustomer { get; set; }

        //initialize the product name
        [Required]
        [Display( Name = "Item")]
        public List<Product> TheProducts { get; set; }

        //initialize the shipping method
        [Required]
        [Display(Name = "Shipping Method")]
        public string ShippingMethod { get; set; }

        public double SubTotal { get; set; }

    }
}