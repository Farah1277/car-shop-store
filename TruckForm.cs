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
    public partial class TruckForm : Form
    {
        public TruckForm()
        {
            InitializeComponent();
      
           label7.Text = trackBar1.Value + "";
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

        

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label7.Text = trackBar1.Value + "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
                decimal year = numericUpDown1.Value;
                String color = comboBox1.Text;
                String gear;
                if (radioButton1.Checked)
                    gear = "Automatic";
                else
                    gear = "Manual";
                decimal price = trackBar1.Value;
                 Hide();
                SearchForm f = new SearchForm();
                f.Show();
                f.search(false,(int)year , color, gear, price,"");
            
        }
    }
}
