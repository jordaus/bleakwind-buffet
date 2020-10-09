/*
 * Author: Jordan Austin
 * Class: IOrderItem.cs
 * Purpose: Makes the IEnumerables
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Interface
{
    public interface IOrderItem : INotifyPropertyChanged
    {
        double Price { get; }

        uint Calories { get; }

        List<string> SpecialInstructions { get; }
    }
}
