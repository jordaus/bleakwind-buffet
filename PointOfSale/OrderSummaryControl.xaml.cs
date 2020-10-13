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
using BleakwindBuffet.Data.Interface;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Sides;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for OrderSummaryControl.xaml
    /// </summary>
    public partial class OrderSummaryControl : UserControl
    {
        private OrderSummaryControl screen;

        /// <summary>
        /// Constructor
        /// </summary>
        Order order;
        public OrderSummaryControl(OrderSummaryControl menuScreen)
        {
            InitializeComponent();

            screen = menuScreen;
        }

        void DeleteItemFromOrder(Order sender, RoutedEventArgs e)
        {
            if(DataContext is Order order)
            {
                //var removalItem = (IOrderItem)currentOrder.SelectedItem;
                //order.Remove(removalItem);
            }
        }

        private void EditSelectedItem(object sender, RoutedEventArgs e)
        {
            if(DataContext is Order order)
            {
               /* var currentItem = ((Button)sender).DataContext;
                if (currentItem is BriarheartBurger bb) screen.menuBorder.Child = new BriarheartBurgerCustomization(screen, bb, order);
                if (currentItem is DoubleDraugr dd) screen.menuBorder.Child = new DoubleDragurCustomization(screen, dd, order);
                if (currentItem is ThalmorTriple tt) screen.menuBorder.Child = new ThalmorTripleCustomization(screen, tt, order);
                if (currentItem is GardenOrcOmelette go) screen.menuBorder.Child = new GardenOrcOmeletteCustomization(screen, go, order);
                if (currentItem is PhillyPoacher pp) screen.menuBorder.Child = new PhillyPoacherCustomize(screen, pp, order);
                if (currentItem is SmokehouseSkeleton ss) screen.menuBorder.Child = new SmokehouseSkeletonCustomize(screen, ss, order);
                if (currentItem is ThugsTBone tb) screen.menuBorder.Child = new ThugsTBoneCustomize(screen, tb, order);
                if (currentItem is AretinoAppleJuice aj) screen.menuBorder.Child = new ArentinoAppleJuiceCustomize(screen, aj, order);
                if (currentItem is CandlehearthCoffee cc) screen.menuBorder.Child = new CandlehearthCoffeeCustomize(screen, cc, order);
                if (currentItem is MarkarthMilk mm) screen.menuBorder.Child = new MarkarthMilkCustomize(screen, mm, order);
                if (currentItem is SailorSoda sS) screen.menuBorder.Child = new SailorSodaCustomize(screen, sS, order);
                if (currentItem is WarriorWater ww) screen.menuBorder.Child = new WarriorWaterCustomize(screen, ww, order);
                if (currentItem is DragonbornWaffleFries dwf) screen.menuBorder.Child = new DragonbornWaffleFriesCustomize(screen, dwf, order);
                if (currentItem is FriedMiraak fm) screen.menuBorder.Child = new FriedMiraakCustomize(screen, fm, order);
                if (currentItem is MadOtarGrits mo) screen.menuBorder.Child = new MadOtarGritsCustomize(screen, mo, order);
                if (currentItem is VokunSalad vs) screen.menuBorder.Child = new VokunSaladCustomize(screen, vs, order);*/
            }
        }
    }
}
