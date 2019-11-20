using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TeamMaddog.Models
{
    public class Product
    {   
        //initialize productID as primary key
        [Key]
        public int ProductID { get; set; }

        //initialize product name
        [Required]
        [Display(Name = "Item")]
        public string ProdName { get; set; }

        //initialize product price
        [Required]
        [Display(Name = "Price")]
        public double ProdPrice { get; set; }

        //initialize product size
        [Display(Name = "Size")]
        public string ProdSize { get; set; }

    }
}