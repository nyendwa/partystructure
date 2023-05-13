using PartyDB.UserControls;
using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace PartyDB.View
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

     

        
         private void ListViewMenu_SelectionChanged(object sender, SelectionChangedEventArgs e)
         {
             int index=ListViewMenu.SelectedIndex;
            switch (index)
            {
                case 0:
                    MainGrid.Children.Clear();
                    MainGrid.Children.Add(new Lusaka());
                    break;
                    case 1:
                    MainGrid.Children.Clear();
                    MainGrid.Children.Add(new Central());
                    break;
                    case 2:
                    MainGrid.Children.Clear();
                    MainGrid.Children.Add(new Copperbelt());
                    break;
                    case 3:
                    MainGrid.Children.Clear();
                    MainGrid.Children.Add(new Eastern());
                    break;
                    case 4:
                    MainGrid.Children.Clear();
                    MainGrid.Children.Add(new Luapula());
                    break;
                    case 5:
                    MainGrid.Children.Clear();
                    MainGrid.Children.Add(new Muchinga());
                    break;
                    case 6:
                    MainGrid.Children.Clear();
                    MainGrid.Children.Add(new Northern());
                    break;
                    case 7:
                    MainGrid.Children.Clear();
                    MainGrid.Children.Add(new NorthWestern());
                    break;
                    case 8:
                    MainGrid.Children.Clear();
                    MainGrid.Children.Add(new Western());
                    break;
                    case 9:
                    MainGrid.Children.Clear();
                    MainGrid.Children.Add(new Southern());
                    break;

            }
            
         }
        
         
    }
}
