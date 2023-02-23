using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
namespace MVC.Models
{
    public class ShopFactory : DbContext
    {
        //constructor så vi opsætter DB
        public ShopFactory()
        {
            Database.SetInitializer(new ShopInitializer());
        }
        public DbSet<Product> Products { get; set; }
    }

    //nedarveer fra DropCrea... class --> 
    public class ShopInitializer : DropCreateDatabaseIfModelChanges<ShopFactory>
    {
        protected override void Seed(ShopFactory context)
        {
            context.Products.Add(new Product() { Name = "Yoghurt", Description = "this creamy one will melt you", Price = 5.4M, ImageName="Yoghurt.jpg" });
            context.Products.Add(new Product() { Name = "Cleaning logtion", Description = "nothimg gets in its way", Price = 64M, ImageName="spray.jpg" });
            context.Products.Add(new Product() { Name = "Banana", Description = "hungry? that's going to get you satisfied", Price = 3M, ImageName="banan.jpg" });
        }
    }
}