using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class PaymentForm : Form
    {
        Payment pay;
        public PaymentForm(Payment p)
        {
            InitializeComponent();

            this.pay = p;
            if (pay is Cash)
            {
                label1.Text = pay.Amount + "";
            }
            if (pay is Installment)
            {
                if (((Installment)pay).month == 6)
                {
                    label2.Text = ((Installment)pay).SIXmonth();
                }
              else   if (((Installment)pay).month == 12)
                {
                    label2.Text = ((Installment)pay).TWELVEmonth();
                }
              else   if (((Installment)pay).month == 18)
                {
                    label2.Text = ((Installment)pay).EIGHTEENmonth();
                }
              
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            HomeForm f = new HomeForm();
            f.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Hide();
            AboutForm f = new AboutForm();
            f.Show();
        }

       
    }
}
