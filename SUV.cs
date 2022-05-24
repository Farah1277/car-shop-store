using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class SUV :Car
    {
        public int noofPassengers;
        public SUV(int noofPassengers, int Year, string Color, string Model, string Gear, int price) : base(Year,Color,Model,Gear,price)

        {
            this.noofPassengers = noofPassengers;

        }
        public SUV()
        {

        }

    }
}
