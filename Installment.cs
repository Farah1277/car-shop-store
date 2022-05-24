using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class Installment : Payment
    {
       public double tax;
        public int month;
        public Installment(int month,int Amount) : base(Amount)
        {
            this.month = month;

        }

        public string SIXmonth ()
        {
            int o = Amount;
            tax = 0.1;
            Amount = (int)(Amount * tax) + Amount;
            return "The original price is:" + o + "\n" +  "The total price is :" + Amount + "\n" + "The total amount per month:" + Amount / 6 ;
     
        }
        public String TWELVEmonth()
        {
            int o = Amount;
            tax = 0.15;
            Amount = (int)(Amount * tax) + Amount; 
            return "The original price is:" + o + "\n" + "The total price is :" + Amount + "\n"  + "The total amount per month:" + Amount / 12;
        }
        public string EIGHTEENmonth()
        {
            int o = Amount;
            tax = 0.2;
            Amount = (int)(Amount * tax) + Amount;
            return "The original price is:" + o + "\n"+"The total price is :" + Amount +"\n"+"The total amount per month:" + Amount / 18;

        }
    }
}
