using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace PointOfSale.ExtensionMethod
{
    public static class ExtensionMethod
    {
        public static T FindAncestor<T>(this DependencyObject element) where T : DependencyObject
        {
            var parent = VisualTreeHelper.GetParent(element);
            if (parent == null) return null;
            if (parent is T) return parent as T;
            return parent.FindAncestor<T>();
        }
    }
}
