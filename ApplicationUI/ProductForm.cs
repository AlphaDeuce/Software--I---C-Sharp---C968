using ApplicationLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApplicationUI
{
    public partial class ProductForm : Form
    {
        string name;
        int min, max, inStock, selectedIdx, upperIdx, lowerIdx;
        decimal price;
        int productID = Inventory.Products.Count;
        public bool updateProduct;

        

        public ProductForm()
        {
            InitializeComponent();
            
            productIDValue.Text = productID.ToString();
            productSaveButton.Enabled = false;
            Inventory.SelectedProductProductID = productID;

            Inventory.AddProduct(new Product(productID, name, price, inStock, min, max));
            

            upperIdx = -1;
            canidatePartsGridView.DefaultCellStyle.SelectionBackColor = canidatePartsGridView.DefaultCellStyle.BackColor;
            canidatePartsGridView.DefaultCellStyle.SelectionForeColor = canidatePartsGridView.DefaultCellStyle.ForeColor;
            canidatePartsGridView.RowHeadersVisible = false;
            canidatePartsGridView.DataSource = Inventory.AllParts;

            lowerIdx = -1;
            associatedPartsGridView.DefaultCellStyle.SelectionBackColor = associatedPartsGridView.DefaultCellStyle.BackColor;
            associatedPartsGridView.DefaultCellStyle.SelectionForeColor = associatedPartsGridView.DefaultCellStyle.ForeColor;
            associatedPartsGridView.RowHeadersVisible = false;
            associatedPartsGridView.DataSource = Inventory.Products[productID].AssociatedParts;


        }

        public ProductForm(int idx)
        {
            InitializeComponent();
            selectedIdx = idx;

            headerLabel.Text = "Modify Product";
            productIDValue.Text = idx.ToString();
            productNameValue.Text = Inventory.SelectedProductName;
            productInventoryValue.Text = Inventory.SelectedProductInStock.ToString();
            productPriceValue.Text = Inventory.SelectedProductPrice.ToString();
            productMaxValue.Text = Inventory.SelectedProductMax.ToString();
            productMinValue.Text = Inventory.SelectedProductMin.ToString();

            upperIdx = -1;
            canidatePartsGridView.DefaultCellStyle.SelectionBackColor = canidatePartsGridView.DefaultCellStyle.BackColor;
            canidatePartsGridView.DefaultCellStyle.SelectionForeColor = canidatePartsGridView.DefaultCellStyle.ForeColor;
            canidatePartsGridView.RowHeadersVisible = false;
            canidatePartsGridView.DataSource = Inventory.AllParts;


            lowerIdx = -1;
            associatedPartsGridView.DefaultCellStyle.SelectionBackColor = associatedPartsGridView.DefaultCellStyle.BackColor;
            associatedPartsGridView.DefaultCellStyle.SelectionForeColor = associatedPartsGridView.DefaultCellStyle.ForeColor;
            associatedPartsGridView.RowHeadersVisible = false;
            associatedPartsGridView.DataSource = Inventory.Products[Inventory.SelectedProductProductID].AssociatedParts;

            updateProduct = true;
            productSaveButton.Enabled = false;
        }

        private void productNameValue_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(productNameValue.Text))
            { productNameValue.BackColor = System.Drawing.Color.Red; }
            else
            { productNameValue.BackColor = System.Drawing.Color.White; name = productNameValue.Text; }
            productSaveButton.Enabled = enableSave();
        }

        private void productInventoryValue_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(productInventoryValue.Text) || !Int32.TryParse(productInventoryValue.Text, out inStock))
            { productInventoryValue.BackColor = System.Drawing.Color.Red; }
            else
            { productInventoryValue.BackColor = System.Drawing.Color.White; }
            productSaveButton.Enabled = enableSave();
        }

        private void productPriceValue_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(productPriceValue.Text) || !decimal.TryParse(productPriceValue.Text, out price))
            { productPriceValue.BackColor = System.Drawing.Color.Red; }
            else
            { productPriceValue.BackColor = System.Drawing.Color.White; }
            productSaveButton.Enabled = enableSave();
        }

        private void productMaxValue_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(productMaxValue.Text) || !Int32.TryParse(productMaxValue.Text, out max))
            { productMaxValue.BackColor = System.Drawing.Color.Red; }
            else
            { productMaxValue.BackColor = System.Drawing.Color.White; }
            productSaveButton.Enabled = enableSave();
        }

        private void productMinValue_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(productMinValue.Text) || !Int32.TryParse(productMinValue.Text, out min))
            { productMinValue.BackColor = System.Drawing.Color.Red; }
            else
            { productMinValue.BackColor = System.Drawing.Color.White; }
            productSaveButton.Enabled = enableSave();
        }

        private void canidatePartsGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                upperIdx = e.RowIndex;

                canidatePartsGridView.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Yellow;
                canidatePartsGridView.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;

                Inventory.SelectedPartPartID = (int)canidatePartsGridView.SelectedRows[0].Cells[0].Value;
                Inventory.SelectedPart = Inventory.AllParts[Inventory.SelectedPartPartID];


            }
        }

        private void canidatePartsAddButton_Click(object sender, EventArgs e)
        {
            if (upperIdx >= 0)
            {
                canidatePartsGridView.ClearSelection();
                Product.AddAssociatedPart(Inventory.SelectedPart);
                upperIdx = -1;
                productSaveButton.Enabled = enableSave();
            }
            else
            {
                MessageBox.Show("No part is selected.");
            }
        }

        private void canidatePartsSearchButton_Click(object sender, EventArgs e)
        {
            bool found = false;
            Inventory.PartResults.Clear();
            canidatePartsGridView.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;
            canidatePartsGridView.ClearSelection();
            if (canidatePartsGridViewSearchValue.Text != "")
            {
                for (int i = 0; i < Inventory.AllParts.Count; i++)
                {
                    if (Inventory.AllParts[i].Name.ToUpper().Contains(canidatePartsGridViewSearchValue.Text.ToUpper()))
                    {
                        Inventory.LookupPart(i);
                        found = true;
                    }
                }
                if (found)
                    canidatePartsGridView.DataSource = Inventory.PartResults;
                if (!found)
                {
                    MessageBox.Show(string.Format("{0} was not located", canidatePartsGridViewSearchValue.Text));
                }
            }
            if (canidatePartsGridViewSearchValue.Text == "")
            {
                MessageBox.Show("Please enter a part name to search for.");
            }
        }

        private void canidatePartsGridViewSearchValue_TextChanged(object sender, EventArgs e)
        {
            if (canidatePartsGridViewSearchValue.Text == "") { canidatePartsGridView.DataSource = Inventory.AllParts; }
        }

        private void associatedPartsDeleteButton_Click(object sender, EventArgs e)
        {
            if (lowerIdx >= 0)
            {
                if (Product.RemoveAssociatedPart(Inventory.Products[Inventory.SelectedProductProductID].AssociatedParts[lowerIdx]))
                {
                    Inventory.Products[Inventory.SelectedProductProductID].AssociatedParts.Remove(Inventory.Products[Inventory.SelectedProductProductID].AssociatedParts[lowerIdx]);
                    productSaveButton.Enabled = enableSave();
                }
            }
            else
            {
                MessageBox.Show("No part is selected.");
            }
            associatedPartsGridView.ClearSelection();
        }

        private void associatedPartsGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                lowerIdx = e.RowIndex;

                associatedPartsGridView.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Yellow;
                associatedPartsGridView.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            }
        }

        private bool enableSave()
        {
            int num;
            decimal deci;

            return (!string.IsNullOrEmpty(productNameValue.Text)) &&
                (!(string.IsNullOrEmpty(productInventoryValue.Text) || !Int32.TryParse(productInventoryValue.Text, out num))) &&
                (!(string.IsNullOrEmpty(productPriceValue.Text) || !decimal.TryParse(productPriceValue.Text, out deci))) &&
                (!(string.IsNullOrEmpty(productMaxValue.Text) || !Int32.TryParse(productMaxValue.Text, out num))) &&
                (!(string.IsNullOrEmpty(productMinValue.Text) || !Int32.TryParse(productMinValue.Text, out num))) &&
                (min <= inStock && inStock <= max);

        }

        private void productSaveButton_Click(object sender, EventArgs e)
        {
            if (updateProduct)
            {
               Inventory.UpdateProduct(selectedIdx, Inventory.SelectedProduct);
            }
            else
            {
                Inventory.UpdateProduct(productID, (new Product(productID, name, price, inStock, min, max)));
            }
            this.Close();
        }

        private void productCancelButton_Click(object sender, EventArgs e)
        {
            
            if (!enableSave()) 
            { 
                Inventory.Products.Remove(Inventory.Products[productID]);
                
            }
            else
            {
                //Inventory.Products[Inventory.SelectedProductProductID].TempAssociatedParts.Clear();
            }

           
            
            this.Close();
        }


    }
}
