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
using System.Windows.Navigation;
using System.Windows.Shapes;
using BleakwindBuffet.Data;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var order = new Order();
            DataContext = order;
        }

        public void SwapScreen(UIElement ui)
        {
            buttonColumn.Child = ui;
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            if(e.Source is Button button && button.Name == "CancelOrder")
            {
                var freshOrder = new Order();
                DataContext = freshOrder;
            }
        }
    }
}
