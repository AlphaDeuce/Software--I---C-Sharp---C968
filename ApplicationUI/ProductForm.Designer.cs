
namespace ApplicationUI
{
    partial class ProductForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.productIDValue = new System.Windows.Forms.TextBox();
            this.productIDLabel = new System.Windows.Forms.Label();
            this.productMinValue = new System.Windows.Forms.TextBox();
            this.productMinLabel = new System.Windows.Forms.Label();
            this.productMaxValue = new System.Windows.Forms.TextBox();
            this.productMaxLabel = new System.Windows.Forms.Label();
            this.productPriceValue = new System.Windows.Forms.TextBox();
            this.productPriceLabel = new System.Windows.Forms.Label();
            this.productNameValue = new System.Windows.Forms.TextBox();
            this.productNameLabel = new System.Windows.Forms.Label();
            this.productInventoryValue = new System.Windows.Forms.TextBox();
            this.productInventoryLabel = new System.Windows.Forms.Label();
            this.headerLabel = new System.Windows.Forms.Label();
            this.canidatePartsGridView = new System.Windows.Forms.DataGridView();
            this.canidatePartsGridViewSearchValue = new System.Windows.Forms.TextBox();
            this.canidatePartsSearchButton = new System.Windows.Forms.Button();
            this.partsGridViewLabel = new System.Windows.Forms.Label();
            this.associatedPartsGridView = new System.Windows.Forms.DataGridView();
            this.productsGridViewLabel = new System.Windows.Forms.Label();
            this.canidatePartsAddButton = new System.Windows.Forms.Button();
            this.associatedPartsDeleteButton = new System.Windows.Forms.Button();
            this.productCancelButton = new System.Windows.Forms.Button();
            this.productSaveButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.canidatePartsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.associatedPartsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // productIDValue
            // 
            this.productIDValue.BackColor = System.Drawing.Color.DarkGray;
            this.productIDValue.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productIDValue.Location = new System.Drawing.Point(392, 370);
            this.productIDValue.Name = "productIDValue";
            this.productIDValue.ReadOnly = true;
            this.productIDValue.Size = new System.Drawing.Size(297, 34);
            this.productIDValue.TabIndex = 2;
            // 
            // productIDLabel
            // 
            this.productIDLabel.AutoSize = true;
            this.productIDLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productIDLabel.Location = new System.Drawing.Point(252, 372);
            this.productIDLabel.Name = "productIDLabel";
            this.productIDLabel.Size = new System.Drawing.Size(41, 32);
            this.productIDLabel.TabIndex = 1;
            this.productIDLabel.Text = "ID";
            // 
            // productMinValue
            // 
            this.productMinValue.BackColor = System.Drawing.Color.Red;
            this.productMinValue.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productMinValue.Location = new System.Drawing.Point(578, 674);
            this.productMinValue.Name = "productMinValue";
            this.productMinValue.Size = new System.Drawing.Size(137, 34);
            this.productMinValue.TabIndex = 12;
            this.productMinValue.TextChanged += new System.EventHandler(this.productMinValue_TextChanged);
            // 
            // productMinLabel
            // 
            this.productMinLabel.AutoSize = true;
            this.productMinLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productMinLabel.Location = new System.Drawing.Point(495, 674);
            this.productMinLabel.Name = "productMinLabel";
            this.productMinLabel.Size = new System.Drawing.Size(60, 32);
            this.productMinLabel.TabIndex = 11;
            this.productMinLabel.Text = "Min";
            // 
            // productMaxValue
            // 
            this.productMaxValue.BackColor = System.Drawing.Color.Red;
            this.productMaxValue.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productMaxValue.Location = new System.Drawing.Point(285, 674);
            this.productMaxValue.Name = "productMaxValue";
            this.productMaxValue.Size = new System.Drawing.Size(137, 34);
            this.productMaxValue.TabIndex = 10;
            this.productMaxValue.TextChanged += new System.EventHandler(this.productMaxValue_TextChanged);
            // 
            // productMaxLabel
            // 
            this.productMaxLabel.AutoSize = true;
            this.productMaxLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productMaxLabel.Location = new System.Drawing.Point(181, 674);
            this.productMaxLabel.Name = "productMaxLabel";
            this.productMaxLabel.Size = new System.Drawing.Size(64, 32);
            this.productMaxLabel.TabIndex = 9;
            this.productMaxLabel.Text = "Max";
            // 
            // productPriceValue
            // 
            this.productPriceValue.BackColor = System.Drawing.Color.Red;
            this.productPriceValue.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productPriceValue.Location = new System.Drawing.Point(392, 587);
            this.productPriceValue.Name = "productPriceValue";
            this.productPriceValue.Size = new System.Drawing.Size(297, 34);
            this.productPriceValue.TabIndex = 8;
            this.productPriceValue.TextChanged += new System.EventHandler(this.productPriceValue_TextChanged);
            // 
            // productPriceLabel
            // 
            this.productPriceLabel.AutoSize = true;
            this.productPriceLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productPriceLabel.Location = new System.Drawing.Point(146, 589);
            this.productPriceLabel.Name = "productPriceLabel";
            this.productPriceLabel.Size = new System.Drawing.Size(147, 32);
            this.productPriceLabel.TabIndex = 7;
            this.productPriceLabel.Text = "Price / Cost";
            // 
            // productNameValue
            // 
            this.productNameValue.BackColor = System.Drawing.Color.Red;
            this.productNameValue.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productNameValue.Location = new System.Drawing.Point(392, 438);
            this.productNameValue.Name = "productNameValue";
            this.productNameValue.Size = new System.Drawing.Size(297, 34);
            this.productNameValue.TabIndex = 4;
            this.productNameValue.TextChanged += new System.EventHandler(this.productNameValue_TextChanged);
            // 
            // productNameLabel
            // 
            this.productNameLabel.AutoSize = true;
            this.productNameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productNameLabel.Location = new System.Drawing.Point(211, 438);
            this.productNameLabel.Name = "productNameLabel";
            this.productNameLabel.Size = new System.Drawing.Size(82, 32);
            this.productNameLabel.TabIndex = 3;
            this.productNameLabel.Text = "Name";
            // 
            // productInventoryValue
            // 
            this.productInventoryValue.BackColor = System.Drawing.Color.Red;
            this.productInventoryValue.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productInventoryValue.Location = new System.Drawing.Point(392, 513);
            this.productInventoryValue.Name = "productInventoryValue";
            this.productInventoryValue.Size = new System.Drawing.Size(297, 34);
            this.productInventoryValue.TabIndex = 6;
            this.productInventoryValue.TextChanged += new System.EventHandler(this.productInventoryValue_TextChanged);
            // 
            // productInventoryLabel
            // 
            this.productInventoryLabel.AutoSize = true;
            this.productInventoryLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productInventoryLabel.Location = new System.Drawing.Point(166, 513);
            this.productInventoryLabel.Name = "productInventoryLabel";
            this.productInventoryLabel.Size = new System.Drawing.Size(127, 32);
            this.productInventoryLabel.TabIndex = 5;
            this.productInventoryLabel.Text = "Inventory";
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.Location = new System.Drawing.Point(40, 29);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(160, 32);
            this.headerLabel.TabIndex = 27;
            this.headerLabel.Text = "Add Product";
            // 
            // canidatePartsGridView
            // 
            this.canidatePartsGridView.AllowUserToAddRows = false;
            this.canidatePartsGridView.AllowUserToDeleteRows = false;
            this.canidatePartsGridView.AllowUserToResizeColumns = false;
            this.canidatePartsGridView.AllowUserToResizeRows = false;
            this.canidatePartsGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.canidatePartsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.canidatePartsGridView.Location = new System.Drawing.Point(950, 110);
            this.canidatePartsGridView.Name = "canidatePartsGridView";
            this.canidatePartsGridView.ReadOnly = true;
            this.canidatePartsGridView.RowHeadersWidth = 62;
            this.canidatePartsGridView.RowTemplate.Height = 28;
            this.canidatePartsGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.canidatePartsGridView.Size = new System.Drawing.Size(810, 336);
            this.canidatePartsGridView.TabIndex = 15;
            this.canidatePartsGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.canidatePartsGridView_CellClick);
            // 
            // canidatePartsGridViewSearchValue
            // 
            this.canidatePartsGridViewSearchValue.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.canidatePartsGridViewSearchValue.Location = new System.Drawing.Point(1463, 65);
            this.canidatePartsGridViewSearchValue.Name = "canidatePartsGridViewSearchValue";
            this.canidatePartsGridViewSearchValue.Size = new System.Drawing.Size(297, 34);
            this.canidatePartsGridViewSearchValue.TabIndex = 14;
            this.canidatePartsGridViewSearchValue.TextChanged += new System.EventHandler(this.canidatePartsGridViewSearchValue_TextChanged);
            // 
            // canidatePartsSearchButton
            // 
            this.canidatePartsSearchButton.FlatAppearance.BorderSize = 5;
            this.canidatePartsSearchButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.canidatePartsSearchButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.canidatePartsSearchButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.canidatePartsSearchButton.Location = new System.Drawing.Point(1346, 63);
            this.canidatePartsSearchButton.Name = "canidatePartsSearchButton";
            this.canidatePartsSearchButton.Size = new System.Drawing.Size(95, 39);
            this.canidatePartsSearchButton.TabIndex = 13;
            this.canidatePartsSearchButton.Text = "Search";
            this.canidatePartsSearchButton.UseVisualStyleBackColor = true;
            this.canidatePartsSearchButton.Click += new System.EventHandler(this.canidatePartsSearchButton_Click);
            // 
            // partsGridViewLabel
            // 
            this.partsGridViewLabel.AutoSize = true;
            this.partsGridViewLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partsGridViewLabel.Location = new System.Drawing.Point(944, 70);
            this.partsGridViewLabel.Name = "partsGridViewLabel";
            this.partsGridViewLabel.Size = new System.Drawing.Size(218, 32);
            this.partsGridViewLabel.TabIndex = 28;
            this.partsGridViewLabel.Text = "All Canidate Parts";
            // 
            // associatedPartsGridView
            // 
            this.associatedPartsGridView.AllowUserToAddRows = false;
            this.associatedPartsGridView.AllowUserToDeleteRows = false;
            this.associatedPartsGridView.AllowUserToResizeColumns = false;
            this.associatedPartsGridView.AllowUserToResizeRows = false;
            this.associatedPartsGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.associatedPartsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.associatedPartsGridView.Location = new System.Drawing.Point(941, 668);
            this.associatedPartsGridView.Name = "associatedPartsGridView";
            this.associatedPartsGridView.ReadOnly = true;
            this.associatedPartsGridView.RowHeadersWidth = 62;
            this.associatedPartsGridView.RowTemplate.Height = 28;
            this.associatedPartsGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.associatedPartsGridView.Size = new System.Drawing.Size(810, 336);
            this.associatedPartsGridView.TabIndex = 17;
            this.associatedPartsGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.associatedPartsGridView_CellClick);
            // 
            // productsGridViewLabel
            // 
            this.productsGridViewLabel.AutoSize = true;
            this.productsGridViewLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productsGridViewLabel.Location = new System.Drawing.Point(944, 608);
            this.productsGridViewLabel.Name = "productsGridViewLabel";
            this.productsGridViewLabel.Size = new System.Drawing.Size(405, 32);
            this.productsGridViewLabel.TabIndex = 32;
            this.productsGridViewLabel.Text = "Parts Associated with this Product";
            // 
            // canidatePartsAddButton
            // 
            this.canidatePartsAddButton.FlatAppearance.BorderSize = 5;
            this.canidatePartsAddButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.canidatePartsAddButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.canidatePartsAddButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.canidatePartsAddButton.Location = new System.Drawing.Point(1623, 465);
            this.canidatePartsAddButton.Name = "canidatePartsAddButton";
            this.canidatePartsAddButton.Size = new System.Drawing.Size(88, 39);
            this.canidatePartsAddButton.TabIndex = 16;
            this.canidatePartsAddButton.Text = "Add";
            this.canidatePartsAddButton.UseVisualStyleBackColor = true;
            this.canidatePartsAddButton.Click += new System.EventHandler(this.canidatePartsAddButton_Click);
            // 
            // associatedPartsDeleteButton
            // 
            this.associatedPartsDeleteButton.FlatAppearance.BorderSize = 5;
            this.associatedPartsDeleteButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.associatedPartsDeleteButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.associatedPartsDeleteButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.associatedPartsDeleteButton.Location = new System.Drawing.Point(1623, 1010);
            this.associatedPartsDeleteButton.Name = "associatedPartsDeleteButton";
            this.associatedPartsDeleteButton.Size = new System.Drawing.Size(96, 39);
            this.associatedPartsDeleteButton.TabIndex = 18;
            this.associatedPartsDeleteButton.Text = "Delete";
            this.associatedPartsDeleteButton.UseVisualStyleBackColor = true;
            this.associatedPartsDeleteButton.Click += new System.EventHandler(this.associatedPartsDeleteButton_Click);
            // 
            // productCancelButton
            // 
            this.productCancelButton.FlatAppearance.BorderSize = 5;
            this.productCancelButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.productCancelButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.productCancelButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productCancelButton.Location = new System.Drawing.Point(978, 1094);
            this.productCancelButton.Name = "productCancelButton";
            this.productCancelButton.Size = new System.Drawing.Size(98, 39);
            this.productCancelButton.TabIndex = 20;
            this.productCancelButton.Text = "Cancel";
            this.productCancelButton.UseVisualStyleBackColor = true;
            this.productCancelButton.Click += new System.EventHandler(this.productCancelButton_Click);
            // 
            // productSaveButton
            // 
            this.productSaveButton.FlatAppearance.BorderSize = 5;
            this.productSaveButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.productSaveButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.productSaveButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productSaveButton.Location = new System.Drawing.Point(833, 1094);
            this.productSaveButton.Name = "productSaveButton";
            this.productSaveButton.Size = new System.Drawing.Size(88, 39);
            this.productSaveButton.TabIndex = 19;
            this.productSaveButton.Text = "Save";
            this.productSaveButton.UseVisualStyleBackColor = true;
            this.productSaveButton.Click += new System.EventHandler(this.productSaveButton_Click);
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1909, 1218);
            this.Controls.Add(this.productCancelButton);
            this.Controls.Add(this.productSaveButton);
            this.Controls.Add(this.associatedPartsDeleteButton);
            this.Controls.Add(this.canidatePartsAddButton);
            this.Controls.Add(this.associatedPartsGridView);
            this.Controls.Add(this.productsGridViewLabel);
            this.Controls.Add(this.canidatePartsGridView);
            this.Controls.Add(this.canidatePartsGridViewSearchValue);
            this.Controls.Add(this.canidatePartsSearchButton);
            this.Controls.Add(this.partsGridViewLabel);
            this.Controls.Add(this.headerLabel);
            this.Controls.Add(this.productIDValue);
            this.Controls.Add(this.productIDLabel);
            this.Controls.Add(this.productMinValue);
            this.Controls.Add(this.productMinLabel);
            this.Controls.Add(this.productMaxValue);
            this.Controls.Add(this.productMaxLabel);
            this.Controls.Add(this.productPriceValue);
            this.Controls.Add(this.productPriceLabel);
            this.Controls.Add(this.productNameValue);
            this.Controls.Add(this.productNameLabel);
            this.Controls.Add(this.productInventoryValue);
            this.Controls.Add(this.productInventoryLabel);
            this.Name = "ProductForm";
            this.Text = "Product";
            ((System.ComponentModel.ISupportInitialize)(this.canidatePartsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.associatedPartsGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox productIDValue;
        private System.Windows.Forms.Label productIDLabel;
        private System.Windows.Forms.TextBox productMinValue;
        private System.Windows.Forms.Label productMinLabel;
        private System.Windows.Forms.TextBox productMaxValue;
        private System.Windows.Forms.Label productMaxLabel;
        private System.Windows.Forms.TextBox productPriceValue;
        private System.Windows.Forms.Label productPriceLabel;
        private System.Windows.Forms.TextBox productNameValue;
        private System.Windows.Forms.Label productNameLabel;
        private System.Windows.Forms.TextBox productInventoryValue;
        private System.Windows.Forms.Label productInventoryLabel;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.DataGridView canidatePartsGridView;
        private System.Windows.Forms.TextBox canidatePartsGridViewSearchValue;
        private System.Windows.Forms.Button canidatePartsSearchButton;
        private System.Windows.Forms.Label partsGridViewLabel;
        private System.Windows.Forms.DataGridView associatedPartsGridView;
        private System.Windows.Forms.Label productsGridViewLabel;
        private System.Windows.Forms.Button canidatePartsAddButton;
        private System.Windows.Forms.Button associatedPartsDeleteButton;
        private System.Windows.Forms.Button productCancelButton;
        private System.Windows.Forms.Button productSaveButton;
    }
}