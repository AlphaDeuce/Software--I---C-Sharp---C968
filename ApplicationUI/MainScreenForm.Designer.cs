
namespace ApplicationUI
{
    partial class MainScreenForm
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
            this.headerLabel = new System.Windows.Forms.Label();
            this.partsLabel = new System.Windows.Forms.Label();
            this.partsSearchButton = new System.Windows.Forms.Button();
            this.partsSearchValue = new System.Windows.Forms.TextBox();
            this.partsAddButton = new System.Windows.Forms.Button();
            this.partsModifyButton = new System.Windows.Forms.Button();
            this.partsDeleteButton = new System.Windows.Forms.Button();
            this.exitApplicationButton = new System.Windows.Forms.Button();
            this.productDeleteButton = new System.Windows.Forms.Button();
            this.productModifyButton = new System.Windows.Forms.Button();
            this.productAddButton = new System.Windows.Forms.Button();
            this.productsSearchValue = new System.Windows.Forms.TextBox();
            this.productsSearchButton = new System.Windows.Forms.Button();
            this.productLabel = new System.Windows.Forms.Label();
            this.partsGridView = new System.Windows.Forms.DataGridView();
            this.productsGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.partsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.Location = new System.Drawing.Point(31, 27);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(372, 32);
            this.headerLabel.TabIndex = 0;
            this.headerLabel.Text = "Inventory Management System";
            // 
            // partsLabel
            // 
            this.partsLabel.AutoSize = true;
            this.partsLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partsLabel.Location = new System.Drawing.Point(78, 193);
            this.partsLabel.Name = "partsLabel";
            this.partsLabel.Size = new System.Drawing.Size(73, 32);
            this.partsLabel.TabIndex = 2;
            this.partsLabel.Text = "Parts";
            // 
            // partsSearchButton
            // 
            this.partsSearchButton.FlatAppearance.BorderSize = 5;
            this.partsSearchButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.partsSearchButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.partsSearchButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partsSearchButton.Location = new System.Drawing.Point(640, 193);
            this.partsSearchButton.Name = "partsSearchButton";
            this.partsSearchButton.Size = new System.Drawing.Size(90, 34);
            this.partsSearchButton.TabIndex = 4;
            this.partsSearchButton.Text = "Search";
            this.partsSearchButton.UseVisualStyleBackColor = true;
            this.partsSearchButton.Click += new System.EventHandler(this.partsSearchButton_Click);
            // 
            // partsSearchValue
            // 
            this.partsSearchValue.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partsSearchValue.Location = new System.Drawing.Point(337, 193);
            this.partsSearchValue.Name = "partsSearchValue";
            this.partsSearchValue.Size = new System.Drawing.Size(297, 34);
            this.partsSearchValue.TabIndex = 3;
            this.partsSearchValue.TextChanged += new System.EventHandler(this.partsSearchValue_TextChanged);
            // 
            // partsAddButton
            // 
            this.partsAddButton.FlatAppearance.BorderSize = 5;
            this.partsAddButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.partsAddButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.partsAddButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partsAddButton.Location = new System.Drawing.Point(456, 607);
            this.partsAddButton.Name = "partsAddButton";
            this.partsAddButton.Size = new System.Drawing.Size(88, 39);
            this.partsAddButton.TabIndex = 5;
            this.partsAddButton.Text = "Add";
            this.partsAddButton.UseVisualStyleBackColor = true;
            this.partsAddButton.Click += new System.EventHandler(this.partsAddButton_Click);
            // 
            // partsModifyButton
            // 
            this.partsModifyButton.FlatAppearance.BorderSize = 5;
            this.partsModifyButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.partsModifyButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.partsModifyButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partsModifyButton.Location = new System.Drawing.Point(550, 607);
            this.partsModifyButton.Name = "partsModifyButton";
            this.partsModifyButton.Size = new System.Drawing.Size(88, 39);
            this.partsModifyButton.TabIndex = 6;
            this.partsModifyButton.Text = "Modify";
            this.partsModifyButton.UseVisualStyleBackColor = true;
            this.partsModifyButton.Click += new System.EventHandler(this.partsModifyButton_Click);
            // 
            // partsDeleteButton
            // 
            this.partsDeleteButton.FlatAppearance.BorderSize = 5;
            this.partsDeleteButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.partsDeleteButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.partsDeleteButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partsDeleteButton.Location = new System.Drawing.Point(642, 607);
            this.partsDeleteButton.Name = "partsDeleteButton";
            this.partsDeleteButton.Size = new System.Drawing.Size(88, 39);
            this.partsDeleteButton.TabIndex = 7;
            this.partsDeleteButton.Text = "Delete";
            this.partsDeleteButton.UseVisualStyleBackColor = true;
            this.partsDeleteButton.Click += new System.EventHandler(this.partsDeleteButton_Click);
            // 
            // exitApplicationButton
            // 
            this.exitApplicationButton.FlatAppearance.BorderSize = 5;
            this.exitApplicationButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.exitApplicationButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.exitApplicationButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitApplicationButton.Location = new System.Drawing.Point(1417, 841);
            this.exitApplicationButton.Name = "exitApplicationButton";
            this.exitApplicationButton.Size = new System.Drawing.Size(88, 39);
            this.exitApplicationButton.TabIndex = 8;
            this.exitApplicationButton.Text = "Exit";
            this.exitApplicationButton.UseVisualStyleBackColor = true;
            this.exitApplicationButton.Click += new System.EventHandler(this.exitApplicationButton_Click);
            // 
            // productDeleteButton
            // 
            this.productDeleteButton.FlatAppearance.BorderSize = 5;
            this.productDeleteButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.productDeleteButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.productDeleteButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productDeleteButton.Location = new System.Drawing.Point(1511, 607);
            this.productDeleteButton.Name = "productDeleteButton";
            this.productDeleteButton.Size = new System.Drawing.Size(88, 39);
            this.productDeleteButton.TabIndex = 15;
            this.productDeleteButton.Text = "Delete";
            this.productDeleteButton.UseVisualStyleBackColor = true;
            this.productDeleteButton.Click += new System.EventHandler(this.productDeleteButton_Click);
            // 
            // productModifyButton
            // 
            this.productModifyButton.FlatAppearance.BorderSize = 5;
            this.productModifyButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.productModifyButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.productModifyButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productModifyButton.Location = new System.Drawing.Point(1417, 607);
            this.productModifyButton.Name = "productModifyButton";
            this.productModifyButton.Size = new System.Drawing.Size(88, 39);
            this.productModifyButton.TabIndex = 14;
            this.productModifyButton.Text = "Modify";
            this.productModifyButton.UseVisualStyleBackColor = true;
            this.productModifyButton.Click += new System.EventHandler(this.productModifyButton_Click);
            // 
            // productAddButton
            // 
            this.productAddButton.FlatAppearance.BorderSize = 5;
            this.productAddButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.productAddButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.productAddButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productAddButton.Location = new System.Drawing.Point(1323, 607);
            this.productAddButton.Name = "productAddButton";
            this.productAddButton.Size = new System.Drawing.Size(88, 39);
            this.productAddButton.TabIndex = 13;
            this.productAddButton.Text = "Add";
            this.productAddButton.UseVisualStyleBackColor = true;
            this.productAddButton.Click += new System.EventHandler(this.productAddButton_Click);
            // 
            // productsSearchValue
            // 
            this.productsSearchValue.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productsSearchValue.Location = new System.Drawing.Point(1213, 193);
            this.productsSearchValue.Name = "productsSearchValue";
            this.productsSearchValue.Size = new System.Drawing.Size(297, 34);
            this.productsSearchValue.TabIndex = 11;
            this.productsSearchValue.TextChanged += new System.EventHandler(this.productsSearchValue_TextChanged);
            // 
            // productsSearchButton
            // 
            this.productsSearchButton.FlatAppearance.BorderSize = 5;
            this.productsSearchButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.productsSearchButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.productsSearchButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productsSearchButton.Location = new System.Drawing.Point(1516, 193);
            this.productsSearchButton.Name = "productsSearchButton";
            this.productsSearchButton.Size = new System.Drawing.Size(83, 34);
            this.productsSearchButton.TabIndex = 12;
            this.productsSearchButton.Text = "Search";
            this.productsSearchButton.UseVisualStyleBackColor = true;
            this.productsSearchButton.Click += new System.EventHandler(this.productsSearchButton_Click);
            // 
            // productLabel
            // 
            this.productLabel.AutoSize = true;
            this.productLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productLabel.Location = new System.Drawing.Point(934, 193);
            this.productLabel.Name = "productLabel";
            this.productLabel.Size = new System.Drawing.Size(117, 32);
            this.productLabel.TabIndex = 10;
            this.productLabel.Text = "Products";
            // 
            // partsGridView
            // 
            this.partsGridView.AllowUserToAddRows = false;
            this.partsGridView.AllowUserToDeleteRows = false;
            this.partsGridView.AllowUserToResizeColumns = false;
            this.partsGridView.AllowUserToResizeRows = false;
            this.partsGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.partsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.partsGridView.Location = new System.Drawing.Point(71, 240);
            this.partsGridView.MultiSelect = false;
            this.partsGridView.Name = "partsGridView";
            this.partsGridView.ReadOnly = true;
            this.partsGridView.RowHeadersWidth = 62;
            this.partsGridView.RowTemplate.Height = 28;
            this.partsGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.partsGridView.Size = new System.Drawing.Size(659, 361);
            this.partsGridView.TabIndex = 16;
            this.partsGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.partsGridView_CellClick);
            // 
            // productsGridView
            // 
            this.productsGridView.AllowUserToAddRows = false;
            this.productsGridView.AllowUserToDeleteRows = false;
            this.productsGridView.AllowUserToResizeColumns = false;
            this.productsGridView.AllowUserToResizeRows = false;
            this.productsGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.productsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productsGridView.Location = new System.Drawing.Point(940, 240);
            this.productsGridView.MultiSelect = false;
            this.productsGridView.Name = "productsGridView";
            this.productsGridView.ReadOnly = true;
            this.productsGridView.RowHeadersWidth = 62;
            this.productsGridView.RowTemplate.Height = 28;
            this.productsGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.productsGridView.Size = new System.Drawing.Size(659, 361);
            this.productsGridView.TabIndex = 17;
            this.productsGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productsGridView_CellClick);
            // 
            // MainScreenForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1728, 974);
            this.Controls.Add(this.productsGridView);
            this.Controls.Add(this.partsGridView);
            this.Controls.Add(this.productDeleteButton);
            this.Controls.Add(this.productModifyButton);
            this.Controls.Add(this.productAddButton);
            this.Controls.Add(this.productsSearchValue);
            this.Controls.Add(this.productsSearchButton);
            this.Controls.Add(this.productLabel);
            this.Controls.Add(this.exitApplicationButton);
            this.Controls.Add(this.partsDeleteButton);
            this.Controls.Add(this.partsModifyButton);
            this.Controls.Add(this.partsAddButton);
            this.Controls.Add(this.partsSearchValue);
            this.Controls.Add(this.partsSearchButton);
            this.Controls.Add(this.partsLabel);
            this.Controls.Add(this.headerLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "MainScreenForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Screen";
            ((System.ComponentModel.ISupportInitialize)(this.partsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Label partsLabel;
        private System.Windows.Forms.Button partsSearchButton;
        private System.Windows.Forms.TextBox partsSearchValue;
        private System.Windows.Forms.Button partsAddButton;
        private System.Windows.Forms.Button partsModifyButton;
        private System.Windows.Forms.Button partsDeleteButton;
        private System.Windows.Forms.Button exitApplicationButton;
        private System.Windows.Forms.Button productDeleteButton;
        private System.Windows.Forms.Button productModifyButton;
        private System.Windows.Forms.Button productAddButton;
        private System.Windows.Forms.TextBox productsSearchValue;
        private System.Windows.Forms.Button productsSearchButton;
        private System.Windows.Forms.Label productLabel;
        private System.Windows.Forms.DataGridView partsGridView;
        private System.Windows.Forms.DataGridView productsGridView;
    }
}