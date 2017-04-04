using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_fundamental.Models;

namespace MVC_fundamental.Controllers
{
    public class ProductController : Controller
    {
       
        public ActionResult Index()
        {
            return View();
        }

        public ViewResult CreateProduct()
        {
            Product p1 = new Product { ProductId = 100, Name = "Patanjali", Description = "Atta", price = 85, Category = "Food" };
            return View("Result",p1);
        }

        public Decimal GetProductPrice()
        {
            Product p1 = new Product { ProductId = 100, Name = "Patanjali", Description = "Atta", price = 85, Category = "Food" };
            Product p2 = new Product { ProductId = 101, Name = "Britania", Description = "Cake", price = 35, Category = "Food" };
            Product p3 = new Product { ProductId = 102, Name = "Priyagold", Description = "Cookies", price = 45, Category = "Food" };

            List<Product> lst = new List<Product>();
            lst.Add(p1);
            lst.Add(p2);
            lst.Add(p3);
            ShoppingCart sc = new ShoppingCart { Products = lst };
            return sc.TotalPrices();
        }

    }
}
