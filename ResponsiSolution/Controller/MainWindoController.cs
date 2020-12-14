using System;
using System.Collections.Generic;
using System.Text;
using ResponsiSolution.Model;

namespace ResponsiSolution.Controller
{
    class MainWindoController
    {
        KeranjangBelanja keranjangBelanja;
        public MainWindoController(KeranjangBelanja keranjangBelanja)
        {
            this.keranjangBelanja = keranjangBelanja;
        }
        public void addItem(Item item)
        {
            this.keranjangBelanja.addItem(item);
        }
        public List<Item> getSelectedItems()
        {
            return this.keranjangBelanja.getItems();
        }
        public void deleteSelectedItem(Item item)
        {
            this.keranjangBelanja.removeItem(item);
        }
    }
}
