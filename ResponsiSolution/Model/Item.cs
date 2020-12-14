using System;
using System.Collections.Generic;
using System.Text;

namespace ResponsiSolution.Model
{
    public class Item
    {
        public string tittle { get; set; }
        public double price { get; set; }

        public Item(string title, double price)
        {
            this.tittle = tittle;
            this.price = price;
        }
    }
}
