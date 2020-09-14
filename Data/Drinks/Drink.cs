/*
 * Author: Jordan Austin
 * Class: Drinks.cs
 * Purpose: Produces the drinks class
 */
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Interface;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// A basic class representing the common properties of drinks
    /// </summary>
    public abstract class Drink : IOrderItem
    {
        /// <summary>
        /// size of the drink
        /// </summary>
        public virtual Size Size { get; set; }

        /// <summary>
        /// price of the drink 
        /// </summary>
        /// <value>
        /// In USD
        /// </value>
        public abstract double Price { get; }

        /// <summary>
        /// calories in the drink
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// special instructions for the drink
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }
    }
}
