using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Collections.ObjectModel;

namespace TempWpfApplication1 {
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window {
        public Window1() {
            ObservableCollection<Item> ContactList = new ObservableCollection<Item>()    {
                new Item(){ Name="Item1", No1="1"},
                new Item(){ Name="Item2", No1="2"},   
                new Item(){ Name="Item3", No1="3"},
                new Item(){ Name="Item4", No1="4"}
            };

            InitializeComponent();
            dataGrid1.ItemsSource = ContactList;
        }
    }



   


}
