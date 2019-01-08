using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace ClassWork10
{
    public class DbInit : DropCreateDatabaseIfModelChanges<CarsContext>
    {
        protected override void Seed(CarsContext context)
        {
            var cars = new List<Car>
            {
            new Car{Price=10000,Model="Acura Mdx", Color="Black"},
            new Car{Price=1000,Model="Renault Duster", Color="Swamp"},
            new Car{Price=100,Model="Bycicle", Color="Red"},
            };

            //cars.ForEach(c => context.Cars.Add(c));
            //context.SaveChanges();
            var adress = new Address()
            {
            City="Minsk",
            Country="Belarus",
            Street="Kalinovskogo",
            TelNumber = "+55555555"
            
            };

            var dealer = new Dealer()
            {
                Address=adress,
                Cars=cars,
                Name="Bariga"
            };

            context.Dealers.Add(dealer);
            context.SaveChanges();
        }
    }
}