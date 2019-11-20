using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TeamMaddog.Models
{
    public class Customer
    {
        //initialize customer code
        [Display(Name = "Customer Code")]
        public int Customer_Code { get; set; }

        //initialize customer first name
        [Required]
        [Display(Name = "First Name")]
        public string Customer_FName { get; set; }

        //initialize customer last name
        [Required]
        [Display(Name = "Last Name")]
        public string Customer_LName { get; set; }

        //initialize customer email
        [DataType(DataType.EmailAddress, ErrorMessage = "Email is not valid")]
        [StringLength(50)]
        [Display(Name = "Email")]
        public string Customer_Email { get; set; }

        //initialize customer street address
        [Required]
        [Display(Name = "Street Address")]
        public string Cust_Street_Address { get; set; }

        //initialize customer  city
        [Required]
        [Display(Name = "City")]
        public string Cust_City { get; set; }

        //initialize customer state
        [Required]
        [Display(Name = "State")]
        public string Cust_State { get; set; }

        //initialize customer zip
        [Required]
        [Display(Name = "Zip")]
        public int Cust_Zip { get; set; }
    }
}