using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
   abstract class Vehicles
    {

        public int Year { set; get; }
        public string Color { set; get; }

        public string Model;

        public string Gear { set; get; }
         public int price { set; get; }

        public Vehicles()
        {

        }
        public Vehicles (int Year,  string Color, string Model, string Gear , int price)
        {
            this.Year = Year;
            this.Color = Color;
            this.Model = Model;
            this.Gear = Gear;
            this.price = price;
        }
    }
}
