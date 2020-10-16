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
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data;

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
            var screen = new BriarheartBurgerCustomization();
            var bb = new BriarheartBurger();
            screen.DataContext = bb;
            if(DataContext is Order order)
            {
                order.Add(bb);
            }
            orderControl.SwapScreen(screen);
        }

        private void DD_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<MainWindow>();
            var screen = new DoubleDragurCustomization();
            screen.DataContext = new DoubleDraugr();
            orderControl.SwapScreen(screen);  
        }

        private void TT_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<MainWindow>();
            var screen = new ThalmorTripleCustomization();
            screen.DataContext = new ThalmorTriple();
            orderControl.SwapScreen(screen);
        }

        private void SS_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<MainWindow>();
            var screen = new SmokehouseSkeletonCustomize();
            screen.DataContext = new SmokehouseSkeleton();
            orderControl.SwapScreen(screen);
        }

        private void GOO_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<MainWindow>();
            var screen = new GardenOrcOmeletteCustomization();
            screen.DataContext = new GardenOrcOmelette();
            orderControl.SwapScreen(screen);
        }

        private void PP_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<MainWindow>();
            var screen = new PhillyPoacherCustomize();
            screen.DataContext = new PhillyPoacher();
            orderControl.SwapScreen(screen);
        }

        private void TTB_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<MainWindow>();
            var screen = new ThugsTBoneCustomize();
            screen.DataContext = new ThugsTBone();
            orderControl.SwapScreen(screen);
        }

        private void ss_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<MainWindow>();
            var screen = new SailorSodaCustomize();
            screen.DataContext = new SailorSoda();
            orderControl.SwapScreen(screen);
        }

        private void mm_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<MainWindow>();
            var screen = new MarkarthMilkCustomize();
            screen.DataContext = new MarkarthMilk();
            orderControl.SwapScreen(screen);
        }

        private void aj_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<MainWindow>();
            var screen = new ArentinoAppleJuiceCustomize();
            screen.DataContext = new AretinoAppleJuice();
            orderControl.SwapScreen(screen);
        }

        private void cc_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<MainWindow>();
            var screen = new CandlehearthCoffeeCustomize();
            screen.DataContext = new CandlehearthCoffee();
            orderControl.SwapScreen(screen);
        }

        private void ww_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<MainWindow>();
            var screen = new WarriorWaterCustomize();
            screen.DataContext = new WarriorWater();
            orderControl.SwapScreen(screen);
        }

        private void vS_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<MainWindow>();
            var screen = new VokunSaladCustomize();
            screen.DataContext = new VokunSalad();
            orderControl.SwapScreen(screen);
        }

        private void fM_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<MainWindow>();
            var screen = new FriedMiraakCustomize();
            screen.DataContext = new FriedMiraak();
            orderControl.SwapScreen(screen);
        }

        private void moG_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<MainWindow>();
            var screen = new MadOtarGritsCustomize();
            screen.DataContext = new MadOtarGrits();
            orderControl.SwapScreen(screen);
        }

        private void dwF_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<MainWindow>();
            var screen = new DragonbornWaffleFriesCustomize();
            screen.DataContext = new DragonbornWaffleFries();
            orderControl.SwapScreen(screen);
        }
    }
}
