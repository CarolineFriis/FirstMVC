using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Globalization;

namespace MVC.Controllers
{
    public class LanguageController : Controller
    {
        // GET: Language
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Action1()
        {
            CultureInfo[] languages = CultureInfo.GetCultures(CultureTypes.SpecificCultures);
            return View(languages);
        }
    }
}