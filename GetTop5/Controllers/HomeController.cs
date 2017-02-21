using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GetTop5.Models;
using GetTop5.Factories;

namespace GetTop5.Controllers
{
    public class HomeController : Controller
    {
        ProductFactory productFac = new ProductFactory();

        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            List<Product> tmp = productFac.GetAll().OrderBy(x => x.DateAdded).ToList();
            tmp.Reverse();

            List<Product> top5Products = tmp.Take(5).ToList();

            ViewBag.Top5Products = top5Products;

            base.OnActionExecuting(filterContext);
        }

        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
    }
}