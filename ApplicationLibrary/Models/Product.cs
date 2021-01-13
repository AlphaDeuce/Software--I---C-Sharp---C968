using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Forms;

namespace ApplicationLibrary.Models
{
    public class Product 
    {
        public BindingList<Part> AssociatedParts { get; set; } = new BindingList<Part>();
        

        public int ProductID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int InStock { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }

        public Product(int productID, string name, decimal price, int inStock, int min, int max)
        {
            ProductID = productID;
            Name = name;
            InStock = inStock;
            Price = price;
            Min = min;
            Max = max;
        }

        public static void AddAssociatedPart(Part selectedPart)
        {

            Inventory.Products[Inventory.SelectedProductProductID].AssociatedParts.Add(selectedPart);

        }

        public static bool RemoveAssociatedPart(Part removePart)
        {
            string message = string.Format("Are you sure that you would like to remove {0}?", removePart.Name);
            const string caption = "Confirm Remove";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);


            if (result == DialogResult.Yes)
            {
                return true;
            }
            return false;
        }

        public static void LookupAssociatedPart(int idx)
        {
            Inventory.PartResults.Add(Inventory.AllParts[idx]);
        }
    }

}
