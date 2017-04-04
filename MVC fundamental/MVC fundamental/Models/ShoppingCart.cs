using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_fundamental.Models
{
    public class ShoppingCart
    {
        public List<Product> Products { get; set; }
    }

    public static class MyExtensionMethods
    {
        public static decimal TotalPrices(this ShoppingCart cartParam)
        {
            decimal total = 0;
            foreach (Product prod in cartParam.Products)
            {
                total += prod.price;
            }
            return total;
        }
    } 


}