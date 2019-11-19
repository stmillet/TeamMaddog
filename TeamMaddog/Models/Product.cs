using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TeamMaddog.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        public string ProdName { get; set; }
        public decimal ProdPrice { get; set; }
        public string ProdSize { get; set; }

    }
}