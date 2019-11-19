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
        [Required]
        public int Customer_Code { get; set; }

        //initialize customer first name
        [Required]
        [StringLength(25, ErrorMessage = "Name must be less than 25 characters")]
        public string Customer_FName { get; set; }

        //initialize customer last name
        [Required]
        [StringLength(25, ErrorMessage = "Name must be less than 25 characters")]
        public string Customer_LName { get; set; }

        //initialize customer email
        [DataType(DataType.EmailAddress, ErrorMessage = "Email is not valid")]
        [StringLength(50)]
        public string Customer_Email { get; set; }

        //initialize customer street address
        [Required]
        [StringLength(50, ErrorMessage = "Street Address must be less than 50 characters")]
        public string Cust_Street_Address { get; set; }

        //initialize customer  city
        [Required]
        [StringLength(20, ErrorMessage = "City must be less than 20 characters")]
        public string Cust_City { get; set; }

        //initialize customer state
        [Required]
        [StringLength(2, MinimumLength = 2, ErrorMessage = "State Abbreviation must be 2 characters")]
        public string Cust_State { get; set; }

        //initialize customer zip
        [Required]
        [StringLength(5, MinimumLength = 5, ErrorMessage = "Zip must be 5 characters")]
        public int Cust_Zip { get; set; }
    }
}