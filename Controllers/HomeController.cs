using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Globalization;
using System.Data.Entity;
using System.Web.Helpers;
using MVC.Models;
using MVC.ViewModels.Home;

//Business logic
//Håndterer indkommende requests og giver et respons
//Koordinator ml. view og model





namespace MVC.Controllers
{
    public class HomeController : Controller
    {
        //Action er en public method som returnerer et actionresult
        //actionresult kan være alt - ofte et view
        public ActionResult Index(string searchCriteria)
        {
            var factory = new ShopFactory();
            IQueryable<Product> prods = factory.Products.OrderBy(p => p.Name);
            if (searchCriteria != null)
            {
                prods = prods.Where(p => p.Name.Contains(searchCriteria));
            }
            var products = prods.Take(10).ToList();
            return View(products);
        }

        public ActionResult Details(int id)
        {
            var factory = new ShopFactory();
            var found = factory.Products.Where(p => p.ID == id).FirstOrDefault();
            return View(found);
        }

        public ActionResult Picture(int id)
        {
            var factory = new ShopFactory();
            var product = factory.Products.Where(p => p.ID == id).FirstOrDefault();
            if(product == null)
            {
                return HttpNotFound();
            }
            var img = new WebImage(string.Format("~Content/Images/{0}.jpg", product.ImageName));
            img.Resize(50, 50);
            return File(img.GetBytes(), "image/jpeg");
        }

        public ActionResult About()
        {
            //giver data videre til view. Viewbag er dybamisk objekt. Kan også bruge viewdata(dictionary)
            ViewBag.Message = "Your application description page."; 

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult ShowLanguages()
        {
            var viewModel = new ViewModels.Home.ShowLanguagesViewModel(CultureInfo.GetCultures(CultureTypes.SpecificCultures));
            return View(viewModel);
        }
    }
}