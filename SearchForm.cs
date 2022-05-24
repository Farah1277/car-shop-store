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
    public partial class SearchForm : Form
    {
        bool isCar ;
        public SearchForm()
        {
            InitializeComponent();
        }

        public void search(bool isCar,int y, string color, string gear, decimal maxPrice,String type)
        {
           this.isCar = isCar;

            foreach (Vehicles v in HomeForm.vec) 
            {
                if (v is Trucks && isCar == false)
                {
                    if (v.Year == y && v.Color.Equals(color, StringComparison.OrdinalIgnoreCase) && v.Gear.Equals(gear, StringComparison.OrdinalIgnoreCase) && v.price <= maxPrice)
                    {

                        dataGridView1.Rows.Add(new object[] { v.Model, v.Year + "", v.Color, v.Gear, "10000", v.price + "" });

                    }
                }
                else if (v is Car && isCar == true)
                {

                    if (type.Equals("SUV"))
                    {
                        if ( v is SUV && v.Year == y && v.Color.Equals(color, StringComparison.OrdinalIgnoreCase) && v.Gear.Equals(gear, StringComparison.OrdinalIgnoreCase) && v.price <= maxPrice)
                        {

                            dataGridView1.Rows.Add(new object[] { v.Model, v.Year + "", v.Color, v.Gear, "SUV", v.price + "" });

                        }
                    }
                    else if (type.Equals("SEDAN"))

                    {
                        if(v is SEDAN && v.Year == y && v.Color.Equals(color, StringComparison.OrdinalIgnoreCase) && v.Gear.Equals(gear, StringComparison.OrdinalIgnoreCase) && v.price <= maxPrice)
                        {

                            dataGridView1.Rows.Add(new object[] { v.Model, v.Year + "", v.Color, v.Gear, "SEDAN", v.price + "" });

                        }
                    }




                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String Model, Year, Color, Gear, Type, Price;
            try
            {
                DataGridViewRow r = dataGridView1.SelectedRows[0];
               
                    Model = r.Cells[0].Value.ToString();
                    Year = r.Cells[1].Value.ToString();
                    Color = r.Cells[2].Value.ToString();
                    Gear = r.Cells[3].Value.ToString();
                    Type = r.Cells[4].Value.ToString();
                    Price = r.Cells[5].Value.ToString();
                
          
            }
            catch(Exception ex )
            {

                 
                MessageBox.Show("Error : No Cars Selected");
                return;
            }
            Hide();
            CheckoutForm c = new CheckoutForm();
            c.Show();
            c.checkout(Model, Year, Color, Gear, Type, Price);

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

       

        private void button5_Click(object sender, EventArgs e)
        {
            Hide();
            if (isCar)
            {
                CarForm c = new CarForm();
                c.Show();
            }
            else
            {
                TruckForm C = new TruckForm();
                C.Show();
            }
        }
    }
}
