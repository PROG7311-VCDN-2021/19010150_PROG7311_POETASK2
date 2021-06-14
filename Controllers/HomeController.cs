using ACMEINCStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ACMEINCStore.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(string search)
        {
            return View();
        }

        public ActionResult AddToCart(int productId)
        {
            var cart = new List<Item>();
            
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}