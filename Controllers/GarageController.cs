using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using MVC.Models;
using MVC.ViewModels;
using MVC.ViewModels.Garage;

namespace MVC.Controllers
{
    //giver data til view --> returnere viewmodel vi lige har lavet
    // --> View - Garage - Carslist
    public class GarageController : Controller
    {
        // GET: Garage
        public ActionResult CarsList()
        {
            var factory = new GarageFactory();
            var viewModel = new CarsListViewModel(factory.Cars);

            return View(viewModel);
        }
    }
}