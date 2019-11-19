using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TeamMaddog.Models
{
    public class Product
    {   
        [Key]
        public int ProductID { get; set; }

        [Required]
        [Display(Name = "Item")]
        public string ProdName { get; set; }

        [Required]
        [Display(Name = "Price")]
        public double ProdPrice { get; set; }

        [Display(Name = "Size")]
        public Size ProdSize { get; set; }

    }

    public enum Size
    {
        Small,
        Medium,
        Large
    }
}