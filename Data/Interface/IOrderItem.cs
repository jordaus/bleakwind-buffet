/*
 * Author: Jordan Austin
 * Class: IOrderItem.cs
 * Purpose: Makes the IEnumerables
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Interface
{
    public interface IOrderItem
    {
        double Price { get; }

        uint Calories { get; }

        List<string> SpecialInstructions { get; }
    }
}
