
namespace ApplicationUI
{
    partial class PartForm
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
            this.partInventoryLabel = new System.Windows.Forms.Label();
            this.partInventoryValue = new System.Windows.Forms.TextBox();
            this.partNameValue = new System.Windows.Forms.TextBox();
            this.partNameLabel = new System.Windows.Forms.Label();
            this.partPriceValue = new System.Windows.Forms.TextBox();
            this.partPriceLabel = new System.Windows.Forms.Label();
            this.partSourceValue = new System.Windows.Forms.TextBox();
            this.partSourceLabel = new System.Windows.Forms.Label();
            this.partMaxValue = new System.Windows.Forms.TextBox();
            this.partMaxLabel = new System.Windows.Forms.Label();
            this.partMinValue = new System.Windows.Forms.TextBox();
            this.partMinLabel = new System.Windows.Forms.Label();
            this.partSaveButton = new System.Windows.Forms.Button();
            this.partCancelButton = new System.Windows.Forms.Button();
            this.parttInHouseRadioButton = new System.Windows.Forms.RadioButton();
            this.partOutsourcedRadioButton = new System.Windows.Forms.RadioButton();
            this.partIDValue = new System.Windows.Forms.TextBox();
            this.partIDLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.Location = new System.Drawing.Point(29, 28);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(116, 32);
            this.headerLabel.TabIndex = 1;
            this.headerLabel.Text = "Add Part";
            // 
            // partInventoryLabel
            // 
            this.partInventoryLabel.AutoSize = true;
            this.partInventoryLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partInventoryLabel.Location = new System.Drawing.Point(131, 338);
            this.partInventoryLabel.Name = "partInventoryLabel";
            this.partInventoryLabel.Size = new System.Drawing.Size(127, 32);
            this.partInventoryLabel.TabIndex = 7;
            this.partInventoryLabel.Text = "Inventory";
            // 
            // partInventoryValue
            // 
            this.partInventoryValue.BackColor = System.Drawing.Color.Red;
            this.partInventoryValue.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partInventoryValue.Location = new System.Drawing.Point(357, 338);
            this.partInventoryValue.Name = "partInventoryValue";
            this.partInventoryValue.Size = new System.Drawing.Size(297, 34);
            this.partInventoryValue.TabIndex = 8;
            this.partInventoryValue.TextChanged += new System.EventHandler(this.partInventoryValue_TextChanged);
            // 
            // partNameValue
            // 
            this.partNameValue.BackColor = System.Drawing.Color.Red;
            this.partNameValue.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partNameValue.Location = new System.Drawing.Point(357, 263);
            this.partNameValue.Name = "partNameValue";
            this.partNameValue.Size = new System.Drawing.Size(297, 34);
            this.partNameValue.TabIndex = 6;
            this.partNameValue.TextChanged += new System.EventHandler(this.partNameValue_TextChanged);
            // 
            // partNameLabel
            // 
            this.partNameLabel.AutoSize = true;
            this.partNameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partNameLabel.Location = new System.Drawing.Point(176, 263);
            this.partNameLabel.Name = "partNameLabel";
            this.partNameLabel.Size = new System.Drawing.Size(82, 32);
            this.partNameLabel.TabIndex = 5;
            this.partNameLabel.Text = "Name";
            // 
            // partPriceValue
            // 
            this.partPriceValue.BackColor = System.Drawing.Color.Red;
            this.partPriceValue.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partPriceValue.Location = new System.Drawing.Point(357, 412);
            this.partPriceValue.Name = "partPriceValue";
            this.partPriceValue.Size = new System.Drawing.Size(297, 34);
            this.partPriceValue.TabIndex = 10;
            this.partPriceValue.TextChanged += new System.EventHandler(this.partPriceValue_TextChanged);
            // 
            // partPriceLabel
            // 
            this.partPriceLabel.AutoSize = true;
            this.partPriceLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partPriceLabel.Location = new System.Drawing.Point(111, 414);
            this.partPriceLabel.Name = "partPriceLabel";
            this.partPriceLabel.Size = new System.Drawing.Size(147, 32);
            this.partPriceLabel.TabIndex = 9;
            this.partPriceLabel.Text = "Price / Cost";
            // 
            // partSourceValue
            // 
            this.partSourceValue.BackColor = System.Drawing.Color.Red;
            this.partSourceValue.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partSourceValue.Location = new System.Drawing.Point(357, 574);
            this.partSourceValue.Name = "partSourceValue";
            this.partSourceValue.Size = new System.Drawing.Size(297, 34);
            this.partSourceValue.TabIndex = 16;
            this.partSourceValue.TextChanged += new System.EventHandler(this.partSourceValue_TextChanged);
            // 
            // partSourceLabel
            // 
            this.partSourceLabel.AutoSize = true;
            this.partSourceLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partSourceLabel.Location = new System.Drawing.Point(113, 576);
            this.partSourceLabel.Name = "partSourceLabel";
            this.partSourceLabel.Size = new System.Drawing.Size(145, 32);
            this.partSourceLabel.TabIndex = 15;
            this.partSourceLabel.Text = "Machine ID";
            // 
            // partMaxValue
            // 
            this.partMaxValue.BackColor = System.Drawing.Color.Red;
            this.partMaxValue.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partMaxValue.Location = new System.Drawing.Point(250, 499);
            this.partMaxValue.Name = "partMaxValue";
            this.partMaxValue.Size = new System.Drawing.Size(137, 34);
            this.partMaxValue.TabIndex = 12;
            this.partMaxValue.TextChanged += new System.EventHandler(this.partMaxValue_TextChanged);
            // 
            // partMaxLabel
            // 
            this.partMaxLabel.AutoSize = true;
            this.partMaxLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partMaxLabel.Location = new System.Drawing.Point(146, 499);
            this.partMaxLabel.Name = "partMaxLabel";
            this.partMaxLabel.Size = new System.Drawing.Size(64, 32);
            this.partMaxLabel.TabIndex = 11;
            this.partMaxLabel.Text = "Max";
            // 
            // partMinValue
            // 
            this.partMinValue.BackColor = System.Drawing.Color.Red;
            this.partMinValue.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partMinValue.Location = new System.Drawing.Point(543, 499);
            this.partMinValue.Name = "partMinValue";
            this.partMinValue.Size = new System.Drawing.Size(137, 34);
            this.partMinValue.TabIndex = 14;
            this.partMinValue.TextChanged += new System.EventHandler(this.partMinValue_TextChanged);
            // 
            // partMinLabel
            // 
            this.partMinLabel.AutoSize = true;
            this.partMinLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partMinLabel.Location = new System.Drawing.Point(460, 499);
            this.partMinLabel.Name = "partMinLabel";
            this.partMinLabel.Size = new System.Drawing.Size(60, 32);
            this.partMinLabel.TabIndex = 13;
            this.partMinLabel.Text = "Min";
            // 
            // partSaveButton
            // 
            this.partSaveButton.FlatAppearance.BorderSize = 5;
            this.partSaveButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.partSaveButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.partSaveButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partSaveButton.Location = new System.Drawing.Point(421, 776);
            this.partSaveButton.Name = "partSaveButton";
            this.partSaveButton.Size = new System.Drawing.Size(88, 39);
            this.partSaveButton.TabIndex = 17;
            this.partSaveButton.Text = "Save";
            this.partSaveButton.UseVisualStyleBackColor = true;
            this.partSaveButton.Click += new System.EventHandler(this.partSaveButton_Click);
            // 
            // partCancelButton
            // 
            this.partCancelButton.FlatAppearance.BorderSize = 5;
            this.partCancelButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.partCancelButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.partCancelButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partCancelButton.Location = new System.Drawing.Point(566, 776);
            this.partCancelButton.Name = "partCancelButton";
            this.partCancelButton.Size = new System.Drawing.Size(98, 39);
            this.partCancelButton.TabIndex = 18;
            this.partCancelButton.Text = "Cancel";
            this.partCancelButton.UseVisualStyleBackColor = true;
            this.partCancelButton.Click += new System.EventHandler(this.partCancelButton_Click);
            // 
            // parttInHouseRadioButton
            // 
            this.parttInHouseRadioButton.AutoSize = true;
            this.parttInHouseRadioButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parttInHouseRadioButton.Location = new System.Drawing.Point(205, 112);
            this.parttInHouseRadioButton.Name = "parttInHouseRadioButton";
            this.parttInHouseRadioButton.Size = new System.Drawing.Size(122, 32);
            this.parttInHouseRadioButton.TabIndex = 1;
            this.parttInHouseRadioButton.Text = "In-House";
            this.parttInHouseRadioButton.UseVisualStyleBackColor = true;
            this.parttInHouseRadioButton.CheckedChanged += new System.EventHandler(this.parttInHouseRadioButton_CheckedChanged);
            // 
            // partOutsourcedRadioButton
            // 
            this.partOutsourcedRadioButton.AutoSize = true;
            this.partOutsourcedRadioButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partOutsourcedRadioButton.Location = new System.Drawing.Point(421, 112);
            this.partOutsourcedRadioButton.Name = "partOutsourcedRadioButton";
            this.partOutsourcedRadioButton.Size = new System.Drawing.Size(146, 32);
            this.partOutsourcedRadioButton.TabIndex = 2;
            this.partOutsourcedRadioButton.Text = "Outsourced";
            this.partOutsourcedRadioButton.UseVisualStyleBackColor = true;
            this.partOutsourcedRadioButton.CheckedChanged += new System.EventHandler(this.partOutsourcedRadioButton_CheckedChanged);
            // 
            // partIDValue
            // 
            this.partIDValue.BackColor = System.Drawing.Color.DarkGray;
            this.partIDValue.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partIDValue.Location = new System.Drawing.Point(357, 195);
            this.partIDValue.Name = "partIDValue";
            this.partIDValue.ReadOnly = true;
            this.partIDValue.Size = new System.Drawing.Size(297, 34);
            this.partIDValue.TabIndex = 4;
            // 
            // partIDLabel
            // 
            this.partIDLabel.AutoSize = true;
            this.partIDLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partIDLabel.Location = new System.Drawing.Point(217, 197);
            this.partIDLabel.Name = "partIDLabel";
            this.partIDLabel.Size = new System.Drawing.Size(41, 32);
            this.partIDLabel.TabIndex = 3;
            this.partIDLabel.Text = "ID";
            // 
            // PartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(818, 953);
            this.Controls.Add(this.partIDValue);
            this.Controls.Add(this.partIDLabel);
            this.Controls.Add(this.partOutsourcedRadioButton);
            this.Controls.Add(this.parttInHouseRadioButton);
            this.Controls.Add(this.partCancelButton);
            this.Controls.Add(this.partSaveButton);
            this.Controls.Add(this.partMinValue);
            this.Controls.Add(this.partMinLabel);
            this.Controls.Add(this.partMaxValue);
            this.Controls.Add(this.partMaxLabel);
            this.Controls.Add(this.partSourceValue);
            this.Controls.Add(this.partSourceLabel);
            this.Controls.Add(this.partPriceValue);
            this.Controls.Add(this.partPriceLabel);
            this.Controls.Add(this.partNameValue);
            this.Controls.Add(this.partNameLabel);
            this.Controls.Add(this.partInventoryValue);
            this.Controls.Add(this.partInventoryLabel);
            this.Controls.Add(this.headerLabel);
            this.Name = "PartForm";
            this.Text = "Part";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Label partInventoryLabel;
        private System.Windows.Forms.TextBox partInventoryValue;
        private System.Windows.Forms.TextBox partNameValue;
        private System.Windows.Forms.Label partNameLabel;
        private System.Windows.Forms.TextBox partPriceValue;
        private System.Windows.Forms.Label partPriceLabel;
        private System.Windows.Forms.TextBox partSourceValue;
        private System.Windows.Forms.Label partSourceLabel;
        private System.Windows.Forms.TextBox partMaxValue;
        private System.Windows.Forms.Label partMaxLabel;
        private System.Windows.Forms.TextBox partMinValue;
        private System.Windows.Forms.Label partMinLabel;
        private System.Windows.Forms.Button partSaveButton;
        private System.Windows.Forms.Button partCancelButton;
        private System.Windows.Forms.RadioButton parttInHouseRadioButton;
        private System.Windows.Forms.RadioButton partOutsourcedRadioButton;
        private System.Windows.Forms.TextBox partIDValue;
        private System.Windows.Forms.Label partIDLabel;
    }
}