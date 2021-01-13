using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ApplicationLibrary.Models;

namespace ApplicationUI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Inventory.AllParts.Add(new InHouse(0, "Wheel", 12.11M, 15, 5, 25, 001234));
            Inventory.AllParts.Add(new Outsourced(1, "Pedal", 12.41M, 11, 5, 25, "All Chained Up"));
            Inventory.AllParts.Add(new InHouse(2, "Chain", 8.33M, 12, 5, 25, 0058789));
            Inventory.AllParts.Add(new Outsourced(3, "Seat", 4.55M, 8, 2, 15, "The Cycle"));


            Inventory.Products.Add(new Product(0, "Red Bicycle", 11.44M, 15, 1, 25));
            Inventory.Products.Add(new Product(1, "Yellow Bicycle", 9.66M, 15, 1, 20));
            Inventory.Products.Add(new Product(2, "Blue Bicycle", 12.77M, 8, 1, 25));


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainScreenForm());


    }
    }
}
