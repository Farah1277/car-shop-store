using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new HomeForm());
            

            //Vehicles[] car = { new Car(2019, "red", "soul", "automatic",404000 ),
            //new Car(2019, "black", "soul" , "automatic",404000 ),new Car(2019, "black", "soul", "manual" ,360000), 
            //new Car(2019, "blue" , "soul" , "automatic",404000 ),new Car(2019, "blue", "soul", "manual",360000),
            //new Car(2019, "black", "rio"     , "automatic" , 190000),new Car(2019, "red", "soul", "manual",360000),
            //new Car(2019, "red"  , "rio"     , "automatic" , 190000),new Car(2019, "blue", "rio", "manual",150000),
            //new Car(2019, "blue" , "rio"     , "automatic" , 190000), new Car(2019, "red", "rio", "manual",150000),
            //new Car(2019, "black", "sportage", "automatic", 460000),new Car(2019, "black", "rio", "manual",150000),
            //new Car(2019, "red"  , "sportage", "automatic", 460000),new Car(2019, "blue", "sportage", "manual" ,420000),
            //new Car(2019, "blue" , "sportage", "automatic", 460000),new Car(2019, "red", "sportage", "manual",420000),
            //new Car(2019, "black", "cerato"  , "automatic" , 210000),new Car(2019, "black", "sportage", "manual",420000),
            //new Car(2019, "red"  , "cerato"  , "automatic", 210000),new Car(2019, "blue", "cerato", "manual", 180000),
            //new Car(2019, "blue" , "cerato"  , "automatic", 210000),new Car(2019, "black", "cerato", "manual", 180000),
            //new Car(2020, "red"  , "soul"    , "automatic",450000),new Car(2019, "red", "cerato", "manual", 180000),
            //new Car(2020, "black", "soul"    , "automatic",450000),new Car(2020, "blue", "soul", "manual",415000),
            //new Car(2020, "blue" , "soul"    , "automatic",450000),new Car(2020, "black", "soul", "manual",415000),
            //new Car(2020, "black", "rio"     , "automatic" ,250000),new Car(2020, "red", "soul", "manual",415000),
            //new Car(2020, "red"  , "rio"     , "automatic",250000),new Car(2020, "blue", "rio", "manual" , 210000),
            //new Car(2020, "blue" , "rio"     , "automatic",250000),new Car(2020, "red", "rio", "manual", 210000),
            //new Car(2020, "black", "sportage", "automatic" , 500000),new Car(2020, "black", "rio", "manual", 210000),
            //new Car(2020, "red"  , "sportage", "automatic", 500000),new Car(2020, "blue", "sportage", "manual" , 450000),
            //new Car(2020, "blue" , "sportage", "automatic", 500000),new Car(2020, "red", "sportage", "manual", 450000),
            //new Car(2020, "black", "cerato"  , "automatic", 250000),new Car(2020, "black", "sportage", "manual", 450000),
            //new Car(2020, "red  ", "cerato"  , "automatic", 250000),new Car(2020, "blue", "cerato", "manual",200000),
            //new Car(2020, "blue" , "cerato"  , "automatic", 250000),new Car(2020, "black", "cerato", "manual",200000),
            //new Car(2021, "red"  , "soul" , "automatic" , 500000),new Car(2020, "red", "cerato", "manual",200000),
            //new Car(2021, "black", "soul" , "automatic", 500000),new Car(2021, "red", "soul", "manul",470000),
            //new Car(2021, "blue" , "soul" , "automatic", 500000),new Car(2021, "blue", "soul", "manual",470000),
            //new Car(2021, "black", "rio"     , "automatic" , 270000),new Car(2021, "black", "soul", "manual",470000),
            //new Car(2021, "red"  , "rio"     , "automatic", 270000),new Car(2021, "blue", "rio", "manual",240000),
            //new Car(2021, "blue" , "rio"     , "automatic", 270000),new Car(2021, "red", "rio", "manual",240000),
            //new Car(2021, "black", "sportage", "automatic" ,520000),new Car(2021, "black", "rio", "manual",240000),
            //new Car(2021, "red"  , "sportage", "automatic",520000),new Car(2021, "blue", "sportage", "manual", 490000),
            //new Car(2021, "blue" , "sportage", "automatic",520000),new Car(2021, "red", "sportage", "manual", 490000),
            //new Car(2021, "black", "cerato"  , "automatic" , 300000),new Car(2021, "black", "sportage", "manual", 490000),
            //new Car(2021, "red"  , "cerato"  , "automatic", 300000),new Car(2021, "blue", "cerato", "manual",280000),
            //new Car(2021, "blue" , "cerato"  , "automatic", 300000),new Car(2021, "black", "cerato", "manual",280000),new Car(2021, "red", "cerato", "manual",280000)};




            //Vehicles[] trucks = {
            //new Trucks(2019, "red"  ,"k2700", "automatic",10000 ,200000),
            //new Trucks(2019, "blue" ,"k2700", "automatic",10000 ,200000),
            //new Trucks(2019, "white","k2700", "automatic",10000 ,200000),
            //new Trucks(2020, "red"  ,"k2700", "automatic",10000 ,220000),
            //new Trucks(2020, "blue" ,"k2700", "automatic",10000 ,220000),
            //new Trucks(2020, "white","k2700", "automatic",10000 ,220000),
            //new Trucks(2021, "red"  ,"k2700", "automatic",10000,240000),
            //new Trucks(2021, "blue" ,"k2700", "automatic",10000,240000),
            //new Trucks(2021, "white","k2700", "automatic",10000,240000),
            // new Trucks(2019, "red"  ,"k2700","manual",10000 ,200000),
            //new Trucks(2019, "blue" ,"k2700", "manual",10000 ,200000),
            //new Trucks(2019, "white","k2700", "manual",10000 ,200000),
            //new Trucks(2020, "red"  ,"k2700", "manual",10000 ,220000),
            //new Trucks(2020, "blue" ,"k2700", "manual",10000 ,220000),
            //new Trucks(2020, "white","k2700", "manual",10000 ,220000),
            //new Trucks(2021, "red"  ,"k2700", "manual",10000,240000),
            //new Trucks(2021, "blue" ,"k2700", "manual",10000,240000),
            //new Trucks(2021, "white","k2700", "manual",10000,240000)};


        }
       

    }
}
