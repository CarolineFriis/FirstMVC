using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using MVC.Models;

//Model class som kun kan holde de properties der er required for et specifiks view
//property hvor hvert input eller output viewet laver

namespace MVC.ViewModels.Garage
{
    //Konverter data så det  displayable.
    //Laver liste med bil i CarsList
    //FastestCar variabel
    // --> Controller - GarageController
    public class CarsListViewModel
    {
        public CarsListViewModel(IEnumerable<Car> cars)
        {
            CarsList = cars.Select(c => new SelectListItem() { Text = c.Model });
            FastestCar = cars.OrderByDescending(c => c.MaxSpeed).FirstOrDefault();
        }
        public IEnumerable<SelectListItem> CarsList { get; private set; }
        public Car FastestCar { get; set; }
    }
}