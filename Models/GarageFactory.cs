using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using MVC.Models;

namespace MVC.Models
{
    // context class med metoder, for aå vi kan få adgang til databasen
    // inherit fra DbContext for at bruge entity framework
    // --> ViewModels - Garage - CarsListViewModel
    public class GarageFactory : DbContext
    {   
        public DbSet<Car> Cars { get; set; } // <-- add property for each table
        //you can add other tables here

        //Lav contructor  for at lave db
        public GarageFactory()
        {
            Database.SetInitializer(new GarageInitializer());
        }
    }

    //initializer
    //CropCreate... --> create db if it doesn't exist (or model schema changes), clear is necessary, 
    public class GarageInitializer : DropCreateDatabaseIfModelChanges<GarageFactory>
    {
        protected override void Seed(GarageFactory context)
        {
            context.Cars.Add(new Car() { Model = "Rabbit", MaxSpeed = 300 });
            context.Cars.Add(new Car() { Model = "Turtle", MaxSpeed = 150 });
        }
    }
}