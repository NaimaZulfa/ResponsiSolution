using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ResponsiSolution.Controller;
using ResponsiSolution.Model;

namespace ResponsiSolution
{
    public partial class Penawaran : Window
    {
        PenawaranController controller;
        OnPenawaranChangedListener listener;
        public Penawaran()
        {
            InitializeComponent();

            controller = new PenawaranController();
            listPenawarann.ItemsSource = controller.getItems();

            generateContentPenawaran();

        }

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }

        public void SetOnItemSelectedListener(OnPenawaranChangedListener listener)
        {
            this.listener = listener;
        }

        private void generateContentPenawaran()
        {
            Item drink1 = new Item("Ice tea", 8000);
            Item drink2 = new Item("Ice lemon tea", 5000);
            Item drink3 = new Item("Ice lemon", 7000);
            Item food4 = new Item("Bakso", 17000);
            Item food5 = new Item("Gado-gado", 14000);
            Item food6 = new Item("Sate", 15000);

            controller.addItem(drink1);
            controller.addItem(drink2);
            controller.addItem(drink3);
            controller.addItem(food4);
            controller.addItem(food5);
            controller.addItem(food6);

            listPenawarann.Items.Refresh();
        }

        private void listPenawaran_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ListBox listbox = sender as ListBox;
            Item item = listbox.SelectedItem as Item;
            Debug.WriteLine(item.tittle);

            this.listener.onPenawaranSelected(item);
        }
    }
    public interface OnPenawaranChangedListener
    {
        void onPenawaranSelected(Item item);
    }
}
