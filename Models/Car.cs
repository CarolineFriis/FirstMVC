using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

//Håndterer data
//responderer til requests fra views
//responderer til instruktioner fra controller

namespace MVC.Models
{
    //lav cars class
    //Hvordan tabellen skal se ud
    // --> Models - Garagefactory
    public class Car
    {
        public int ID { get; set; }
        public string Model { get; set; }
        public double MaxSpeed { get; set; }

    }
    //Auto --> tilføj controller - MVC Controller with views using entity F
}