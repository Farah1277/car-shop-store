using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class Car : Vehicles
    {

        public Car (int Year,  string Color, string Model, string Gear , int price) :base(Year,Color,Model,Gear , price)
        {

        }
        public Car()
        {

        }

    }
}

