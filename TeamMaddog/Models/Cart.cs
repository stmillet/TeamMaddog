using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TeamMaddog.Models
{
    public class Cart
    {   
        //Various fields that are all required in the Cart page. 
        [Required]
        public int CartNum { get; set; }

        [Required]
        [Display( Name = "Customer Name:")]
        public Customer TheCustomer { get; set; }

        [Required]
        [Display( Name = "Item")]
        public List<Product> TheProducts { get; set; }

        [Required]
        [Display(Name = "Shipping Method")]
        public string ShippingMethod { get; set; }

        public double SubTotal { get; set; }

    }
}