﻿using PointOfSale.ExtensionMethod;
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
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Enums;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for ArentinoAppleJuiceCustomize.xaml
    /// </summary>
    public partial class ArentinoAppleJuiceCustomize : UserControl
    {
        AretinoAppleJuice itemTemp;

        public ArentinoAppleJuiceCustomize()
        {
            InitializeComponent();
        }

        private void Done_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<MainWindow>();
            orderControl.SwapScreen(new MenuControl());
        }
    }
}
