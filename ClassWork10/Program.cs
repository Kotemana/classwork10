using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork10
{
    class Program
    {
        static void Main(string[] args)
        {

            var exit = false;
            while (!exit)
            {
                Console.WriteLine("Select Option");
                Console.WriteLine("1 - Show cars");
                Console.WriteLine("2 - Add Car");
                Console.WriteLine("3 - Exit");

                var answer = Console.ReadLine();
                switch (answer)
                {
                    case "1":
                        ShowCars();
                        break;
                    case "2":
                        AddCar();
                        break;
                    case "3":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("wrong input");
                        break;

                }
            }


            Console.ReadLine();
        }

        static void ShowCars()
        {
            using (var context = new CarsContext())
            {
                var cars = context.Cars;
                foreach (var car in cars)
                {
                    Console.WriteLine($"{car.Model} \t {car.Price}");
                }
            }
        }

        static void AddCar()
        {
            var car = new Car();
            Console.WriteLine("Enter Price");
            car.Price = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Model");
            car.Model = Console.ReadLine();
            Console.WriteLine("Enter Color");
            car.Color = Console.ReadLine();
            car.DateMade = DateTime.Now;
            
            using (var context = new CarsContext())
            {
                Console.WriteLine("Select Dealer");
                Console.WriteLine("0 - no dealer");
                foreach (var dealer in context.Dealers)
                {
                    Console.WriteLine($"{dealer.Id} - {dealer.Name}");
                }
                var dealerId = Int32.Parse(Console.ReadLine());
                if (dealerId != 0)
                {
                    var dealer = context.Dealers.Find(dealerId);
                    if(dealer!=null)
                    {
                        dealer.Cars.Add(car);
                    }
                    context.SaveChanges();
                }
                else
                {
                    context.Cars.Add(car);
                    context.SaveChanges();
                }

            }
        }

    }
}





















//var cars = new List<Car>
//{
//    new Car{Price=10000,Model="Acura Mdx", Color="Black"},
//    new Car{Price=1000,Model="Renault Duster", Color="Swamp"},
//    new Car{Price=100,Model="Bycicle", Color="Red"},
//};


//var adress = new Address()
//{
//    City = "Minsk",
//    Country = "Belarus",
//    Street = "Kalinovskogo",
//    TelNumber = "+55555555"

//};

//var dealer = new Dealer()
//{
//    Address = adress,
//    Cars = cars,
//    Name = "Bariga"
//};

//context.Dealers.Add(dealer);
//context.SaveChanges();