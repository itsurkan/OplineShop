﻿using System.Collections.Generic;
using System.Web.Mvc;
using OnlineShop.Models.Db;

namespace OnlineShop.Controllers
{

    public class HomeController : Controller
    {
		public static AppContext context = new AppContext();
        public ActionResult Index()
        {

	        context.Products.Add(new Product() {Pr_Name = "Product", Pr_Description = new Description(){Desc_Path = "dfd"}, Pr_Images = new List<Image>(), Pr_Price = 500});
	        context.SaveChanges();

            return View();
        }

        [Authorize]
        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
