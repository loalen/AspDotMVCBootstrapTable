using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspDotNetMVCBootstrapTable.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult GetData()
        {
            var products = new[] {
                new Product { ID = "1", Name = "Item 1", Price = "$1" },
                new Product { ID = "2", Name = "Item 2", Price = "$1" },
                new Product { ID = "3", Name = "Item 3", Price = "$1" },
                new Product { ID = "4", Name = "Item 4", Price = "$4" },
                new Product { ID = "5", Name = "Item 5", Price = "$5" },
                new Product { ID = "6", Name = "Item 6", Price = "$6" },
                new Product { ID = "7", Name = "Item 7", Price = "$7" },
                new Product { ID = "8", Name = "Item 8", Price = "$8" },
                new Product { ID = "9", Name = "Item 9", Price = "$9" },
                new Product { ID = "10", Name = "Item 10", Price = "$10" },
                new Product { ID = "11", Name = "Item 11", Price = "$11" },
                new Product { ID = "12", Name = "Item 12", Price = "$12" },
                new Product { ID = "13", Name = "Item 13", Price = "$13" },
                new Product { ID = "14", Name = "Item 14", Price = "$14" },
                new Product { ID = "15", Name = "Item 15", Price = "$15" },
                new Product { ID = "16", Name = "Item 16", Price = "$16" },
                new Product { ID = "17", Name = "Item 17", Price = "$17" },
                new Product { ID = "18", Name = "Item 18", Price = "$18" },
                new Product { ID = "19", Name = "Item 19", Price = "$19" },
                new Product { ID = "20", Name = "Item 20", Price = "$20" },
                new Product { ID = "21", Name = "Item 21", Price = "$21" },
                new Product { ID = "22", Name = "Item 22", Price = "$22" },
                new Product { ID = "23", Name = "Item 23", Price = "$23" },
                new Product { ID = "24", Name = "Item 24", Price = "$24" },
                new Product { ID = "25", Name = "Item 25", Price = "$25" },
                new Product { ID = "26", Name = "Item 26", Price = "$26" },
                new Product { ID = "27", Name = "Item 27", Price = "$27" },
                new Product { ID = "28", Name = "Item 28", Price = "$28" },
                new Product { ID = "29", Name = "Item 29", Price = "$29" },
                new Product { ID = "30", Name = "Item 30", Price = "$30" },
            };

            return Json(products.ToList(), JsonRequestBehavior.AllowGet);

        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        private class Product
        {
            public string ID { get; set; }
            public string Name { get; set; }
            public string Price { get; set; }
        }
    }
}