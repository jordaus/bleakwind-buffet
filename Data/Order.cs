using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using BleakwindBuffet.Data.Interface;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using System.Collections.Specialized;
using System.Collections;
/*
* Represents the Order Class
*/
namespace BleakwindBuffet.Data
{
    public class Order : ICollection<IOrderItem>, INotifyPropertyChanged, INotifyCollectionChanged
    {

        /// <summary>
        /// Event for all classes
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        public event NotifyCollectionChangedEventHandler CollectionChanged;

        List<IOrderItem> orderItems = new List<IOrderItem>();

        public void Add(IOrderItem item)
        {
            orderItems.Add(item);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Tax"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Total"));
            CollectionChanged?.Invoke(this, new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Add, item));
            item.PropertyChanged += ItemEventChange;
        }

        public bool Remove(IOrderItem item)
        {
            bool removeCheck = orderItems.Remove(item);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Tax"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Total"));
            CollectionChanged?.Invoke(this, new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Remove, item));
            item.PropertyChanged -= ItemEventChange;
            return removeCheck;
        }

        public void Clear()
        {
            ((ICollection<IOrderItem>)orderItems).Clear();
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Tax"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Total"));
            CollectionChanged?.Invoke(this, new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Reset));
        }

        public bool Contains(IOrderItem item)
        {
            return ((ICollection<IOrderItem>)orderItems).Contains(item);
        }

        public void CopyTo(IOrderItem[] array, int arrayIndex)
        {
            ((ICollection<IOrderItem>)orderItems).CopyTo(array, arrayIndex);
        }

        public IEnumerator<IOrderItem> GetEnumerator()
        {
            return ((IEnumerable<IOrderItem>)orderItems).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)orderItems).GetEnumerator();
        }

        public double SalesTaxRate { get; set; } = 0.12;

        private double subtotal;
        public double Subtotal 
        { 
            get 
            {
                foreach(IOrderItem io in orderItems)
                {
                    subtotal += io.Price;
                }
                return subtotal;
            } 
        }

        private double tax;
        public double Tax 
        {
            get
            {
                tax = Subtotal * SalesTaxRate;
                return tax;
            }
        }

        private double total;
        public double Total 
        {
            get
            {
                total = Subtotal + Tax;
                return total;
            }
        }

        public int Number { get; set; }

        public uint Calories
        {
            get
            {
                uint calories = 0;
                foreach(IOrderItem io in orderItems)
                {
                    calories += io.Calories;
                }
                return calories;
            }
        }

        public int Count => ((ICollection<IOrderItem>)orderItems).Count;

        public bool IsReadOnly => ((ICollection<IOrderItem>)orderItems).IsReadOnly;

        private void ItemEventChange(object sender, PropertyChangedEventArgs e)
        {
            if(e.PropertyName == "Price")
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Tax"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Total"));
            }
            if(e.PropertyName == "Calories")
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
            }
        }
    }
}
