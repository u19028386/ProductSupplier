using System.Collections.Generic;
using System;

using System.Linq;
using System.Web;
namespace ProductSupplier.Models
    {

    // Complete this Model. Consider the data that it would receive and manage.
    // You would also need to use this model to manage the data associated with
    // the products (ProductID), the Product's Name, as well as associate it with 
    // the ProdSupplier list.

    public class Product  // Complete this model......
        {

          public int ProductID { get; set; }

          public string ProductName { get; set; }
        
        // to query a specific price for a specific product
         public List<ProdSupplier> Prices { get; set; }


        }
    }