using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class Trucks:Vehicles
    {
        public int kg;
        public Trucks()
        {

        }
        public Trucks(int Year, string Color, string Model, string Gear, int kg , int price) : base(Year, Color, Model, Gear , price)
        {
            this.kg = kg;
        }
    }
}
