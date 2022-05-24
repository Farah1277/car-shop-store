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
    public partial class CheckoutForm : Form
    {
        
        public CheckoutForm()
        {
            InitializeComponent();
        }

        internal void checkout(string model,String year, string color , string gear , string type , string price)
        {
            label8.Text = model;
            label7.Text = year;
            label6.Text = color;
            label14.Text = gear;
            label13.Text = type;
            label12.Text = price;

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

       

        private void button2_Click(object sender, EventArgs e)
        {
            Payment x;
            int price = int.Parse(label12.Text);
            
            int duration=0;
            Hide();
             if (radioButton1.Checked)
                {
                    x = new Cash(price);
                    PaymentForm p = new PaymentForm(x);
                    p.Show();
                }
               else if  (radioButton2.Checked && radioButton6.Checked)
              {
                duration = 6;
                x = new Installment(duration, price);
                PaymentForm p = new PaymentForm(x);
                p.Show();
            }
            else if(radioButton2.Checked && radioButton5.Checked)
            {
                duration = 12;
                x = new Installment(duration, price);
                PaymentForm p = new PaymentForm(x);
                p.Show();
            }
            else if(radioButton2.Checked && radioButton4.Checked)
            {
                duration = 18;
                x = new Installment(duration, price);
                PaymentForm p = new PaymentForm(x);
                p.Show();
            }
            else
            {
                MessageBox.Show("you didnt choose the duration,please try again");
            }

           
           
            

        }
        

         private void radioButton2_CheckedChanged(object sender, EventArgs e)
         {
          if (radioButton1.Checked)
          {
              label15.Visible = false;
              radioButton6.Visible = false;
              radioButton5.Visible = false;
              radioButton4.Visible = false;
          }
          else
          {
            
                  label15.Visible = true;
                  radioButton6.Visible = true;
                  radioButton5.Visible = true;
                  radioButton4.Visible = true;

          }
      }
    }
}
