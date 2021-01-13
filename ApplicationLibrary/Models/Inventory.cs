using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace ApplicationLibrary.Models
{
    public static class Inventory
    {   
        public static BindingList<Product> Products { get; set; } = new BindingList<Product>();
        public static BindingList<Product> ProductResults = new BindingList<Product>();

        public static BindingList<Part> AllParts { get; set; } = new BindingList<Part>();
        public static BindingList<Part> PartResults = new BindingList<Part>();


        public static Part SelectedPart { get; set; }
        public static int SelectedPartPartID { get; set; }
        public static string SelectedPartName { get; set; }
        public static decimal SelectedPartPrice { get; set; }
        public static int SelectedPartInStock { get; set; }
        public static int SelectedPartMin { get; set; }
        public static int SelectedPartMax { get; set; }

        public static void AddPart(Part newPart)
        {
            AllParts.Add(newPart);
        }
        
        public static bool DeletePart(Part deletePart)
        {
            string n = deletePart.Name;
            int prodCount = 0;
            int i = 0;
            
            string message = string.Format("Are you sure that you would like to delete {0}?", deletePart.Name);
            const string caption = "Confirm Delete";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);

            
            if (result == DialogResult.Yes)
            {
                foreach (Product prod in Inventory.Products)
                {
                    int i2 = 0;
                    foreach (Part part in Inventory.Products[i].AssociatedParts)
                    {
                        if (Inventory.Products[i].AssociatedParts[i2].Name == n) { prodCount++; }
                        i2++;
                        
                    }
                    i++;
                }
                
                
                if (prodCount == 0) 
                { 
                    return true; 
                } else 
                {
                    MessageBox.Show(string.Format("The part {0} is associated with {1} product(s) and can not be deleted.", n, prodCount));
                    return false; 
                }
                
            }
            return false;
        }

        public static void LookupPart(int idx)
        {            
            PartResults.Add(Inventory.AllParts[idx]);
        }

        public static void UpdatePart(int idx, Part selectedPart)
        {
            AllParts.Insert(idx, selectedPart);
            AllParts.RemoveAt(idx + 1);
        }

        public static Product SelectedProduct { get; set; }
        public static int SelectedProductProductID { get; set; }
        public static string SelectedProductName { get; set; }
        public static decimal SelectedProductPrice { get; set; }
        public static int SelectedProductInStock { get; set; }
        public static int SelectedProductMin { get; set; }
        public static int SelectedProductMax { get; set; }

        public static void AddProduct(Product newProduct)
        {
            Products.Add(newProduct);
        }

        public static bool DeleteProduct(Product deleteProduct)
        {
            string message = string.Format("Are you sure that you would like to delete {0}?", deleteProduct.Name);
            const string caption = "Confirm Delete";
            var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                {
                    return true;
                }
                return false;
        }

        public static void LookupProduct(int idx)
        {
            ProductResults.Add(Inventory.Products[idx]);
        }

        public static void UpdateProduct(int idx, Product selectedProduct)
        {
            Products.Insert(idx, selectedProduct);
            Products.RemoveAt(idx + 1);
        }
    }

}
