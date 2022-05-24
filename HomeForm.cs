using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class HomeForm : Form
    {
        internal static List<Vehicles> vec = new List<Vehicles>();

        public HomeForm()
        {
            InitializeComponent();
            readCarsSUVFromFile();
            readCarsSedanFromFile();
            readTrucksFromFile();
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            Hide();

            HomeForm c = new HomeForm();
            c.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Hide();
            AboutForm f = new AboutForm();
            f.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Hide();
            TruckForm c = new TruckForm();
            c.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Hide();
            CarForm c = new CarForm();
            c.Show();
        }
        private void readCarsSUVFromFile()
        {
            String[] Lines = File.ReadAllLines("SUV.txt");

            foreach (String x in Lines)
            {
                String[] y = x.Split(new char[] { ',' });

                SUV c = new SUV();

                c.Year = int.Parse(y[0]);
                c.Color = y[1];
                c.Model = y[2];
                c.Gear = y[3];
                c.price = int.Parse(y[4]);
                vec.Add(c);
            }
        }
        private void readCarsSedanFromFile()
        {
            String[] Lines = File.ReadAllLines("Sedan.txt");

            foreach (String x in Lines)
            {
                String[] y = x.Split(new char[] { ',' });

                SEDAN c = new SEDAN();

                c.Year = int.Parse(y[0]);
                c.Color = y[1];
                c.Model = y[2];
                c.Gear = y[3];
                c.price = int.Parse(y[4]);
                vec.Add(c);
            }
        }
        private void readTrucksFromFile()
            {
                String[] Lines = File.ReadAllLines("Truck.txt");

                foreach (String x in Lines)
                {
                    String[] y = x.Split(new char[] { ',' });

                    Trucks t = new Trucks();

                    t.Year = int.Parse(y[0]);
                    t.Color = y[1];
                    t.Model = y[2];
                    t.Gear = y[3];
                    t.kg = int.Parse(y[4]);
                    t.price = int.Parse(y[5]);

                vec.Add(t);
                }
            }


    }
}