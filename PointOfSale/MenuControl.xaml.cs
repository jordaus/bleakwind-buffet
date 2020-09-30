using PointOfSale.ExtensionMethod;
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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for ScreenSwitch.xaml
    /// </summary>
    public partial class MenuControl : UserControl
    {
        public MenuControl()
        {
            InitializeComponent();
        }

        private void BB_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<MainWindow>();
            orderControl.SwapScreen(new BriarheartBurgerCustomization());
        }

        private void DD_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<MainWindow>();
            orderControl.SwapScreen(new DoubleDragurCustomization());  
        }
    }
}
