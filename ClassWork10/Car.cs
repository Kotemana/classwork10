using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork10
{
    public class Car:BaseEntity
    {
        public int Price { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public DateTime DateMade { get; set; }

    }
}
