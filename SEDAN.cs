using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class SEDAN : Car
    {
        public int doors;
        public SEDAN(int doors, int Year, string Color, string Model, string Gear, int price) : base(Year, Color, Model, Gear, price)
        {
            this.doors = doors;
        }
        public SEDAN()
        {

        }
    }
}
