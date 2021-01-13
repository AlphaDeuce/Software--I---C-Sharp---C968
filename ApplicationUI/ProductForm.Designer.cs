
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
            this.candidatePartsGridView = new System.Windows.Forms.DataGridView();
            this.candidatePartsGridViewSearchValue = new System.Windows.Forms.TextBox();
            this.candidatePartsSearchButton = new System.Windows.Forms.Button();
            this.partsGridViewLabel = new System.Windows.Forms.Label();
            this.associatedPartsGridView = new System.Windows.Forms.DataGridView();
            this.productsGridViewLabel = new System.Windows.Forms.Label();
            this.candidatePartsAddButton = new System.Windows.Forms.Button();
            this.associatedPartsDeleteButton = new System.Windows.Forms.Button();
            this.productCancelButton = new System.Windows.Forms.Button();
            this.productSaveButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.candidatePartsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.associatedPartsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // productIDValue
            // 
            this.productIDValue.BackColor = System.Drawing.Color.DarkGray;
            this.productIDValue.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productIDValue.Location = new System.Drawing.Point(342, 258);
            this.productIDValue.Name = "productIDValue";
            this.productIDValue.ReadOnly = true;
            this.productIDValue.Size = new System.Drawing.Size(297, 34);
            this.productIDValue.TabIndex = 2;
            // 
            // productIDLabel
            // 
            this.productIDLabel.AutoSize = true;
            this.productIDLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productIDLabel.Location = new System.Drawing.Point(202, 260);
            this.productIDLabel.Name = "productIDLabel";
            this.productIDLabel.Size = new System.Drawing.Size(41, 32);
            this.productIDLabel.TabIndex = 1;
            this.productIDLabel.Text = "ID";
            // 
            // productMinValue
            // 
            this.productMinValue.BackColor = System.Drawing.Color.Red;
            this.productMinValue.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productMinValue.Location = new System.Drawing.Point(528, 562);
            this.productMinValue.Name = "productMinValue";
            this.productMinValue.Size = new System.Drawing.Size(137, 34);
            this.productMinValue.TabIndex = 12;
            this.productMinValue.TextChanged += new System.EventHandler(this.productMinValue_TextChanged);
            // 
            // productMinLabel
            // 
            this.productMinLabel.AutoSize = true;
            this.productMinLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productMinLabel.Location = new System.Drawing.Point(445, 562);
            this.productMinLabel.Name = "productMinLabel";
            this.productMinLabel.Size = new System.Drawing.Size(60, 32);
            this.productMinLabel.TabIndex = 11;
            this.productMinLabel.Text = "Min";
            // 
            // productMaxValue
            // 
            this.productMaxValue.BackColor = System.Drawing.Color.Red;
            this.productMaxValue.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productMaxValue.Location = new System.Drawing.Point(235, 562);
            this.productMaxValue.Name = "productMaxValue";
            this.productMaxValue.Size = new System.Drawing.Size(137, 34);
            this.productMaxValue.TabIndex = 10;
            this.productMaxValue.TextChanged += new System.EventHandler(this.productMaxValue_TextChanged);
            // 
            // productMaxLabel
            // 
            this.productMaxLabel.AutoSize = true;
            this.productMaxLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productMaxLabel.Location = new System.Drawing.Point(131, 562);
            this.productMaxLabel.Name = "productMaxLabel";
            this.productMaxLabel.Size = new System.Drawing.Size(64, 32);
            this.productMaxLabel.TabIndex = 9;
            this.productMaxLabel.Text = "Max";
            // 
            // productPriceValue
            // 
            this.productPriceValue.BackColor = System.Drawing.Color.Red;
            this.productPriceValue.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productPriceValue.Location = new System.Drawing.Point(342, 475);
            this.productPriceValue.Name = "productPriceValue";
            this.productPriceValue.Size = new System.Drawing.Size(297, 34);
            this.productPriceValue.TabIndex = 8;
            this.productPriceValue.TextChanged += new System.EventHandler(this.productPriceValue_TextChanged);
            // 
            // productPriceLabel
            // 
            this.productPriceLabel.AutoSize = true;
            this.productPriceLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productPriceLabel.Location = new System.Drawing.Point(96, 477);
            this.productPriceLabel.Name = "productPriceLabel";
            this.productPriceLabel.Size = new System.Drawing.Size(147, 32);
            this.productPriceLabel.TabIndex = 7;
            this.productPriceLabel.Text = "Price / Cost";
            // 
            // productNameValue
            // 
            this.productNameValue.BackColor = System.Drawing.Color.Red;
            this.productNameValue.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productNameValue.Location = new System.Drawing.Point(342, 326);
            this.productNameValue.Name = "productNameValue";
            this.productNameValue.Size = new System.Drawing.Size(297, 34);
            this.productNameValue.TabIndex = 4;
            this.productNameValue.TextChanged += new System.EventHandler(this.productNameValue_TextChanged);
            // 
            // productNameLabel
            // 
            this.productNameLabel.AutoSize = true;
            this.productNameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productNameLabel.Location = new System.Drawing.Point(161, 326);
            this.productNameLabel.Name = "productNameLabel";
            this.productNameLabel.Size = new System.Drawing.Size(82, 32);
            this.productNameLabel.TabIndex = 3;
            this.productNameLabel.Text = "Name";
            // 
            // productInventoryValue
            // 
            this.productInventoryValue.BackColor = System.Drawing.Color.Red;
            this.productInventoryValue.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productInventoryValue.Location = new System.Drawing.Point(342, 401);
            this.productInventoryValue.Name = "productInventoryValue";
            this.productInventoryValue.Size = new System.Drawing.Size(297, 34);
            this.productInventoryValue.TabIndex = 6;
            this.productInventoryValue.TextChanged += new System.EventHandler(this.productInventoryValue_TextChanged);
            // 
            // productInventoryLabel
            // 
            this.productInventoryLabel.AutoSize = true;
            this.productInventoryLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productInventoryLabel.Location = new System.Drawing.Point(116, 401);
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
            // candidatePartsGridView
            // 
            this.candidatePartsGridView.AllowUserToAddRows = false;
            this.candidatePartsGridView.AllowUserToDeleteRows = false;
            this.candidatePartsGridView.AllowUserToResizeColumns = false;
            this.candidatePartsGridView.AllowUserToResizeRows = false;
            this.candidatePartsGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.candidatePartsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.candidatePartsGridView.Location = new System.Drawing.Point(806, 153);
            this.candidatePartsGridView.Name = "candidatePartsGridView";
            this.candidatePartsGridView.ReadOnly = true;
            this.candidatePartsGridView.RowHeadersWidth = 62;
            this.candidatePartsGridView.RowTemplate.Height = 28;
            this.candidatePartsGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.candidatePartsGridView.Size = new System.Drawing.Size(810, 230);
            this.candidatePartsGridView.TabIndex = 15;
            this.candidatePartsGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.candidatePartsGridView_CellClick);
            // 
            // candidatePartsGridViewSearchValue
            // 
            this.candidatePartsGridViewSearchValue.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.candidatePartsGridViewSearchValue.Location = new System.Drawing.Point(1218, 108);
            this.candidatePartsGridViewSearchValue.Name = "candidatePartsGridViewSearchValue";
            this.candidatePartsGridViewSearchValue.Size = new System.Drawing.Size(297, 34);
            this.candidatePartsGridViewSearchValue.TabIndex = 14;
            this.candidatePartsGridViewSearchValue.TextChanged += new System.EventHandler(this.candidatePartsGridViewSearchValue_TextChanged);
            // 
            // candidatePartsSearchButton
            // 
            this.candidatePartsSearchButton.FlatAppearance.BorderSize = 5;
            this.candidatePartsSearchButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.candidatePartsSearchButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.candidatePartsSearchButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.candidatePartsSearchButton.Location = new System.Drawing.Point(1521, 106);
            this.candidatePartsSearchButton.Name = "candidatePartsSearchButton";
            this.candidatePartsSearchButton.Size = new System.Drawing.Size(95, 39);
            this.candidatePartsSearchButton.TabIndex = 13;
            this.candidatePartsSearchButton.Text = "Search";
            this.candidatePartsSearchButton.UseVisualStyleBackColor = true;
            this.candidatePartsSearchButton.Click += new System.EventHandler(this.candidatePartsSearchButton_Click);
            // 
            // partsGridViewLabel
            // 
            this.partsGridViewLabel.AutoSize = true;
            this.partsGridViewLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partsGridViewLabel.Location = new System.Drawing.Point(800, 113);
            this.partsGridViewLabel.Name = "partsGridViewLabel";
            this.partsGridViewLabel.Size = new System.Drawing.Size(218, 32);
            this.partsGridViewLabel.TabIndex = 28;
            this.partsGridViewLabel.Text = "All candidate Parts";
            // 
            // associatedPartsGridView
            // 
            this.associatedPartsGridView.AllowUserToAddRows = false;
            this.associatedPartsGridView.AllowUserToDeleteRows = false;
            this.associatedPartsGridView.AllowUserToResizeColumns = false;
            this.associatedPartsGridView.AllowUserToResizeRows = false;
            this.associatedPartsGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.associatedPartsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.associatedPartsGridView.Location = new System.Drawing.Point(806, 506);
            this.associatedPartsGridView.Name = "associatedPartsGridView";
            this.associatedPartsGridView.ReadOnly = true;
            this.associatedPartsGridView.RowHeadersWidth = 62;
            this.associatedPartsGridView.RowTemplate.Height = 28;
            this.associatedPartsGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.associatedPartsGridView.Size = new System.Drawing.Size(810, 230);
            this.associatedPartsGridView.TabIndex = 17;
            this.associatedPartsGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.associatedPartsGridView_CellClick);
            // 
            // productsGridViewLabel
            // 
            this.productsGridViewLabel.AutoSize = true;
            this.productsGridViewLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productsGridViewLabel.Location = new System.Drawing.Point(800, 460);
            this.productsGridViewLabel.Name = "productsGridViewLabel";
            this.productsGridViewLabel.Size = new System.Drawing.Size(405, 32);
            this.productsGridViewLabel.TabIndex = 32;
            this.productsGridViewLabel.Text = "Parts Associated with this Product";
            // 
            // candidatePartsAddButton
            // 
            this.candidatePartsAddButton.FlatAppearance.BorderSize = 5;
            this.candidatePartsAddButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.candidatePartsAddButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.candidatePartsAddButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.candidatePartsAddButton.Location = new System.Drawing.Point(1528, 389);
            this.candidatePartsAddButton.Name = "candidatePartsAddButton";
            this.candidatePartsAddButton.Size = new System.Drawing.Size(88, 39);
            this.candidatePartsAddButton.TabIndex = 16;
            this.candidatePartsAddButton.Text = "Add";
            this.candidatePartsAddButton.UseVisualStyleBackColor = true;
            this.candidatePartsAddButton.Click += new System.EventHandler(this.candidatePartsAddButton_Click);
            // 
            // associatedPartsDeleteButton
            // 
            this.associatedPartsDeleteButton.FlatAppearance.BorderSize = 5;
            this.associatedPartsDeleteButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.associatedPartsDeleteButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.associatedPartsDeleteButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.associatedPartsDeleteButton.Location = new System.Drawing.Point(1520, 742);
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
            this.productCancelButton.Location = new System.Drawing.Point(877, 843);
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
            this.productSaveButton.Location = new System.Drawing.Point(753, 843);
            this.productSaveButton.Name = "productSaveButton";
            this.productSaveButton.Size = new System.Drawing.Size(88, 39);
            this.productSaveButton.TabIndex = 19;
            this.productSaveButton.Text = "Save";
            this.productSaveButton.UseVisualStyleBackColor = true;
            this.productSaveButton.Click += new System.EventHandler(this.productSaveButton_Click);
            // 
            // ProductForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1728, 974);
            this.Controls.Add(this.productCancelButton);
            this.Controls.Add(this.productSaveButton);
            this.Controls.Add(this.associatedPartsDeleteButton);
            this.Controls.Add(this.candidatePartsAddButton);
            this.Controls.Add(this.associatedPartsGridView);
            this.Controls.Add(this.productsGridViewLabel);
            this.Controls.Add(this.candidatePartsGridView);
            this.Controls.Add(this.candidatePartsGridViewSearchValue);
            this.Controls.Add(this.candidatePartsSearchButton);
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
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product";
            ((System.ComponentModel.ISupportInitialize)(this.candidatePartsGridView)).EndInit();
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
        private System.Windows.Forms.DataGridView candidatePartsGridView;
        private System.Windows.Forms.TextBox candidatePartsGridViewSearchValue;
        private System.Windows.Forms.Button candidatePartsSearchButton;
        private System.Windows.Forms.Label partsGridViewLabel;
        private System.Windows.Forms.DataGridView associatedPartsGridView;
        private System.Windows.Forms.Label productsGridViewLabel;
        private System.Windows.Forms.Button candidatePartsAddButton;
        private System.Windows.Forms.Button associatedPartsDeleteButton;
        private System.Windows.Forms.Button productCancelButton;
        private System.Windows.Forms.Button productSaveButton;
    }
}