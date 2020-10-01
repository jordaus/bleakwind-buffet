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

        private void TT_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<MainWindow>();
            orderControl.SwapScreen(new ThalmorTripleCustomization());
        }

        private void SS_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<MainWindow>();
            orderControl.SwapScreen(new SmokehouseSkeletonCustomize());
        }

        private void GOO_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<MainWindow>();
            orderControl.SwapScreen(new GardenOrcOmeletteCustomization());
        }

        private void PP_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<MainWindow>();
            orderControl.SwapScreen(new PhillyPoacherCustomize());
        }

        private void TTB_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<MainWindow>();
            orderControl.SwapScreen(new ThugsTBoneCustomize());
        }

        private void ss_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<MainWindow>();
            orderControl.SwapScreen(new SailorSodaCustomize());
        }

        private void mm_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<MainWindow>();
            orderControl.SwapScreen(new MarkarthMilkCustomize());
        }

        private void aj_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<MainWindow>();
            orderControl.SwapScreen(new ArentinoAppleJuiceCustomize());
        }

        private void cc_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<MainWindow>();
            orderControl.SwapScreen(new CandlehearthCoffeeCustomize());
        }

        private void ww_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<MainWindow>();
            orderControl.SwapScreen(new WarriorWaterCustomize());
        }

        private void vS_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<MainWindow>();
            orderControl.SwapScreen(new VokunSaladCustomize());
        }

        private void fM_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<MainWindow>();
            orderControl.SwapScreen(new FriedMiraakCustomize());
        }

        private void moG_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<MainWindow>();
            orderControl.SwapScreen(new MadOtarGritsCustomize());
        }

        private void dwF_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<MainWindow>();
            orderControl.SwapScreen(new DragonbornWaffleFriesCustomize());
        }
    }
}
