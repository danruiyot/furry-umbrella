using System.Collections.Generic;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using MyQuiz.Helpers;
using MyQuiz.Models;

namespace MyQuiz.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Index()
        {
            HttpContext.Session.SetInt32("age", 20);

            HttpContext.Session.SetString("username", "abc");

            var product = new Product
            {
                Id = "p01",
                Name = "Name 1",
                Price = 5
            };

            SessionHelper.SetObjectAsJson(HttpContext.Session, "product", product);

            List<Product> products = new List<Product>() {
                new Product {
                    Id = "p01",
                    Name = "Name 1",
                    Price = 5
                },
                new Product {
                    Id = "p02",
                    Name = "Name 2",
                    Price = 9
                },
                new Product {
                    Id = "p03",
                    Name = "Name 3",
                    Price = 2
                }
            };
            SessionHelper.SetObjectAsJson(HttpContext.Session, "products", products);

            return View();
        }
    }
}
