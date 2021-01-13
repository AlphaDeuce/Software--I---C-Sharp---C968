using ApplicationLibrary.Models;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace ApplicationUI
{
    public partial class MainScreenForm : Form
    {
        public int selectedPartIdx, selectedProductIdx;

        public MainScreenForm()
        {
            InitializeComponent();
            selectedPartIdx = -1;
            partsGridView.DefaultCellStyle.SelectionBackColor = partsGridView.DefaultCellStyle.BackColor;
            partsGridView.DefaultCellStyle.SelectionForeColor = partsGridView.DefaultCellStyle.ForeColor;
            partsGridView.RowHeadersVisible = false;
            partsGridView.DataSource = Inventory.AllParts;
            
            selectedProductIdx = -1;
            productsGridView.DefaultCellStyle.SelectionBackColor = partsGridView.DefaultCellStyle.BackColor;
            productsGridView.DefaultCellStyle.SelectionForeColor = partsGridView.DefaultCellStyle.ForeColor;
            productsGridView.RowHeadersVisible = false;
            productsGridView.DataSource = Inventory.Products;


            
        }

        /// 
        /// Below is the event handlers for the Parts
        /// 
        private void partsGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                partsGridView.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Yellow;
                partsGridView.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;

                Inventory.SelectedPartPartID = (int)partsGridView.SelectedRows[0].Cells[0].Value;
                Inventory.SelectedPart = Inventory.AllParts[Inventory.SelectedPartPartID];
                Inventory.SelectedPartName = Inventory.AllParts[Inventory.SelectedPartPartID].Name;
                Inventory.SelectedPartInStock = Inventory.AllParts[Inventory.SelectedPartPartID].InStock;
                Inventory.SelectedPartPrice = Inventory.AllParts[Inventory.SelectedPartPartID].Price;
                Inventory.SelectedPartMax = Inventory.AllParts[Inventory.SelectedPartPartID].Max;
                Inventory.SelectedPartMin = Inventory.AllParts[Inventory.SelectedPartPartID].Min;
            }
        }

        private void partsAddButton_Click(object sender, EventArgs e)
        {
            
            //PartForm addPart = new PartForm();
            //this.Hide();
            //addPart.Show();
            this.Hide();
            PartForm addPart = new PartForm();
            addPart.ShowDialog();
            addPart = null;
            this.Show();

        }

        private void partsModifyButton_Click(object sender, EventArgs e)
        {
            if (partsGridView.DefaultCellStyle.SelectionBackColor == System.Drawing.Color.Yellow)
            {
                partsGridView.ClearSelection();
                this.Hide();
                PartForm modifyPart = new PartForm(Inventory.SelectedPartPartID);
                modifyPart.ShowDialog();
                modifyPart = null;
                this.Show();
            }
            else
            {
                MessageBox.Show("No part is selected.");
            }

        }

        private void partsDeleteButton_Click(object sender, EventArgs e)
        {
            if (partsGridView.DefaultCellStyle.SelectionBackColor == System.Drawing.Color.Yellow)
            {
                if(Inventory.DeletePart(Inventory.AllParts[partsGridView.SelectedRows[0].Index]))
                {
                    Inventory.AllParts.Remove(Inventory.AllParts[partsGridView.SelectedRows[0].Index]);
                    // iterate through list to reassign partIDs in order.
                    for (int i = 0; i < Inventory.AllParts.Count; i++)
                    {
                        Inventory.AllParts[i].PartID = i;
                    }
                }
                partsGridView.ClearSelection();
                selectedPartIdx = -1;
            }
            else
            {
                MessageBox.Show("No part is selected.");
            }
        }

        private void partsSearchButton_Click(object sender, EventArgs e)
        {
            bool found = false;
            Inventory.PartResults.Clear();
            if (partsSearchValue.Text != "")
            {
                for (int i = 0; i < Inventory.AllParts.Count; i++)
                {
                    if (Inventory.AllParts[i].Name.ToUpper().Contains(partsSearchValue.Text.ToUpper()))
                    {
                        Product.LookupAssociatedPart(i);
                        found = true;
                    }
                }
                if (found)
                    partsGridView.DataSource = Inventory.PartResults;
                if (!found)
                {
                    MessageBox.Show(string.Format("{0} was not located", partsSearchValue.Text));
                }
            }
            if (partsSearchValue.Text == "")
            {
                MessageBox.Show("Please enter a part name to search for.");
            }
        }

        private void partsSearchValue_TextChanged(object sender, EventArgs e)
        {
            if (partsSearchValue.Text == "") { partsGridView.DataSource = Inventory.AllParts; }
        }

        /// 
        /// Below is the event handlers for the Products
        /// 

        private void productsGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                productsGridView.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Yellow;
                productsGridView.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
                
                Inventory.SelectedProductProductID = (int)productsGridView.SelectedRows[0].Cells[0].Value;
                Inventory.SelectedProduct = Inventory.Products[Inventory.SelectedProductProductID];
                Inventory.SelectedProductName = Inventory.Products[Inventory.SelectedProductProductID].Name;
                Inventory.SelectedProductInStock = Inventory.Products[Inventory.SelectedProductProductID].InStock;
                Inventory.SelectedProductPrice = Inventory.Products[Inventory.SelectedProductProductID].Price;
                Inventory.SelectedProductMax = Inventory.Products[Inventory.SelectedProductProductID].Max;
                Inventory.SelectedProductMin = Inventory.Products[Inventory.SelectedProductProductID].Min;
            }
        }

        private void productAddButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProductForm addProduct = new ProductForm();
            addProduct.ShowDialog();
            addProduct = null;
            this.Show();
        }

        private void productModifyButton_Click(object sender, EventArgs e)
        {
            if (productsGridView.DefaultCellStyle.SelectionBackColor == System.Drawing.Color.Yellow)
            {
                productsGridView.ClearSelection();
                this.Hide();
                ProductForm modifyProduct = new ProductForm(Inventory.SelectedProductProductID);
                modifyProduct.ShowDialog();
                modifyProduct = null;
                this.Show();
            }
            else
            {
                MessageBox.Show("No product is selected.");
            }
        }

        private void productDeleteButton_Click(object sender, EventArgs e)
        {
            if (productsGridView.DefaultCellStyle.SelectionBackColor == System.Drawing.Color.Yellow)
            {
                if (Inventory.DeleteProduct(Inventory.Products[productsGridView.SelectedRows[0].Index]))
                {
                    Inventory.Products.Remove(Inventory.Products[productsGridView.SelectedRows[0].Index]);
                    // iterate through list to reassign partIDs in order.
                    for (int i = 0; i < Inventory.Products.Count; i++)
                    {
                        Inventory.Products[i].ProductID = i;
                    }
                }
                productsGridView.ClearSelection();
                selectedProductIdx = -1;
            }
            else
            {
                MessageBox.Show("No product is selected.");
            }
        }

        private void productsSearchButton_Click(object sender, EventArgs e)
        {
            bool found = false;
            Inventory.ProductResults.Clear();
            if (productsSearchValue.Text != "")
            {
                for (int i = 0; i < Inventory.Products.Count; i++)
                {
                    if (Inventory.Products[i].Name.ToUpper().Contains(productsSearchValue.Text.ToUpper()))
                    {
                        Inventory.LookupProduct(i);
                        found = true;
                    }
                }
                if (found)
                    productsGridView.DataSource = Inventory.ProductResults;
                if (!found)
                {
                    MessageBox.Show(string.Format("{0} was not located", productsSearchValue.Text));
                }
            }
            if (productsSearchValue.Text == "")
            {
                MessageBox.Show("Please enter a product name to search for.");
            }
        }

        private void productsSearchValue_TextChanged(object sender, EventArgs e)
        {
            if (productsSearchValue.Text == "") { productsGridView.DataSource = Inventory.Products; }
        }

        private void exitApplicationButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}


