using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;


namespace ApplicationLibrary.Models
{
    public abstract class Part
    {
        public int PartID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int InStock { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }

        public BindingList<Part> Subcomponents = new BindingList<Part>();

        public Part(int partID, string name, decimal price, int inStock, int min, int max)
        {
            PartID = partID;
            Name = name;
            InStock = inStock;
            Price = price;
            Min = min;
            Max = max;
        }
    }
}
