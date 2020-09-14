/*
 * Author: Jordan Austin
 * Class: Sides.cs
 * Purpose: Produces the sides class
 */
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Interface;

namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// A basic class representing the common properties of sides
    /// </summary>
    public abstract class Side : IOrderItem
    {
        /// <summary>
        /// size of the side
        /// </summary>
        public virtual Size Size { get; set; }

        /// <summary>
        /// price of the side 
        /// </summary>
        /// <value>
        /// In USD
        /// </value>
        public abstract double Price { get; }

        /// <summary>
        /// calories in the side
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// special instructions for side
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }
    }
}
