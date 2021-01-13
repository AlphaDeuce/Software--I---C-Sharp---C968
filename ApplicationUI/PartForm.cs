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
    public partial class PartForm : Form
    {

        public BindingList<Part> newPart = new BindingList<Part>();

        string name, companyName;
        int min, max, inStock, machineID, selectedIdx;
        decimal price;
        int partID = Inventory.AllParts.Count;

        public bool updatePart;
        public bool formValid;

        

        public PartForm()
        {
            InitializeComponent();

            partIDValue.Text = partID.ToString();
            partSaveButton.Enabled = false;

        }

        public PartForm(int idx)
        {
            InitializeComponent();
            selectedIdx = idx;
            headerLabel.Text = "Modify Part";
            partIDValue.Text = idx.ToString();
            partNameValue.Text = Inventory.SelectedPartName;
            partInventoryValue.Text = Inventory.SelectedPartInStock.ToString();
            partPriceValue.Text = Inventory.SelectedPartPrice.ToString();
            partMaxValue.Text = Inventory.SelectedPartMax.ToString();
            partMinValue.Text = Inventory.SelectedPartMin.ToString();
            if (Inventory.SelectedPart is InHouse)
            {
                InHouse machine = (InHouse)Inventory.SelectedPart;
                partSourceValue.Text = machine.MachineID.ToString();
                parttInHouseRadioButton.Checked = true;
                partSourceLabel.Text = "Machine ID";

            }
            if (Inventory.SelectedPart is Outsourced)
            {
                Outsourced company = (Outsourced)Inventory.SelectedPart;
                partSourceValue.Text = company.CompanyName.ToString();
                partOutsourcedRadioButton.Checked = true;
                partSourceLabel.Text = "Company Name";

            }

            updatePart = true;
            partSaveButton.Enabled = false;
        }

        private void parttInHouseRadioButton_CheckedChanged(object sender, EventArgs e)
        {

            partSourceLabel.Text = "Machine ID";
            if (!Int32.TryParse(partSourceValue.Text, out machineID))
            { partSourceValue.BackColor = System.Drawing.Color.Red; }
            else
            { partSourceValue.BackColor = System.Drawing.Color.White; }
            partSaveButton.Enabled = enableSave();
        }

        private void partOutsourcedRadioButton_CheckedChanged(object sender, EventArgs e)
        {

            partSourceLabel.Text = "Company Name";
            if (string.IsNullOrEmpty(partSourceValue.Text))
            { partSourceValue.BackColor = System.Drawing.Color.Red; }
            else
            {
                partSourceValue.BackColor = System.Drawing.Color.White;
                companyName = partSourceValue.Text;
            }
            partSaveButton.Enabled = enableSave();
        }

        private void partNameValue_TextChanged(object sender, EventArgs e)
        {
            
            if (string.IsNullOrEmpty(partNameValue.Text))
                { partNameValue.BackColor = System.Drawing.Color.Red; }
            else
                { partNameValue.BackColor = System.Drawing.Color.White; name = partNameValue.Text; }
            partSaveButton.Enabled = enableSave();
        }

        private void partInventoryValue_TextChanged(object sender, EventArgs e)
        {
            
            if (string.IsNullOrEmpty(partInventoryValue.Text) || !Int32.TryParse(partInventoryValue.Text, out inStock))
                { partInventoryValue.BackColor = System.Drawing.Color.Red; }
            else
                { partInventoryValue.BackColor = System.Drawing.Color.White; }
            partSaveButton.Enabled = enableSave();
        }

        private void partPriceValue_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(partPriceValue.Text) || !decimal.TryParse(partPriceValue.Text, out price))
            { partPriceValue.BackColor = System.Drawing.Color.Red;}
            else
            { partPriceValue.BackColor = System.Drawing.Color.White; }
            partSaveButton.Enabled = enableSave();
        }

        private void partMaxValue_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(partMaxValue.Text) || !Int32.TryParse(partMaxValue.Text, out max))
            { partMaxValue.BackColor = System.Drawing.Color.Red;}
            else
            { partMaxValue.BackColor = System.Drawing.Color.White; }
            partSaveButton.Enabled = enableSave();
        }

        private void partMinValue_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(partMinValue.Text) || !Int32.TryParse(partMinValue.Text, out min))
            { partMinValue.BackColor = System.Drawing.Color.Red;}
            else
            { partMinValue.BackColor = System.Drawing.Color.White; }
            partSaveButton.Enabled = enableSave();
        }

        private void partSourceValue_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(partSourceValue.Text) || parttInHouseRadioButton.Checked && (!Int32.TryParse(partSourceValue.Text, out machineID)))
            { partSourceValue.BackColor = System.Drawing.Color.Red; }
            else
            { partSourceValue.BackColor = System.Drawing.Color.White; }
            partSaveButton.Enabled = enableSave();
        }

        private bool enableSave()
        {
            int num;
            decimal deci;

            return (!string.IsNullOrEmpty(partNameValue.Text)) &&
                (!(string.IsNullOrEmpty(partInventoryValue.Text) || !Int32.TryParse(partInventoryValue.Text, out num))) &&
                (!(string.IsNullOrEmpty(partPriceValue.Text) || !decimal.TryParse(partPriceValue.Text, out deci))) &&
                (!(string.IsNullOrEmpty(partMaxValue.Text) || !Int32.TryParse(partMaxValue.Text, out num))) &&
                (!(string.IsNullOrEmpty(partMinValue.Text) || !Int32.TryParse(partMinValue.Text, out num))) &&
                (!(string.IsNullOrEmpty(partSourceValue.Text) || (parttInHouseRadioButton.Checked && !Int32.TryParse(partSourceValue.Text, out num)))) &&
                (parttInHouseRadioButton.Checked || partOutsourcedRadioButton.Checked) &&
                (min <= inStock && inStock <= max);

        }

        private void partSaveButton_Click(object sender, EventArgs e)
        {
            if (updatePart)
            {

                if (!partOutsourcedRadioButton.Checked)
                {
                    Inventory.UpdatePart(selectedIdx, (new InHouse(selectedIdx, name, price, inStock, min, max, machineID)));
                }
                else
                {
                    Inventory.UpdatePart(selectedIdx, (new Outsourced(selectedIdx, name, price, inStock, min, max, companyName)));
                }
            }
            else
            {
                if (!partOutsourcedRadioButton.Checked)
                {
                    Inventory.AddPart(new InHouse(partID, name, price, inStock, min, max, machineID));
                }
                else
                {
                    Inventory.AddPart(new Outsourced(partID, name, price, inStock, min, max, companyName));
                }
            }


            this.Close();
        }

        private void partCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
