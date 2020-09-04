using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

/*
 * Author: Jordan Austin
 * Class name: WarriorWater.cs
 * Purpose: Class used to represent water
 */
namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// class represents water
    /// </summary>
    public class WarriorWater
    {
        /// <summary>
        /// Price for drink
        /// </summary>
        /// <exception cref="System.NotImplementedException">
        /// Throws if size is invalid with calories
        /// </exception>
        /// <returns>the price drink</returns>
        public double Price
        {
            get
            {
                if (size == Size.Small)
                {
                    return 0;
                }
                else if (size == Size.Medium)
                {
                    return 0;
                }
                else if (size == Size.Large)
                {
                    return 0;
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// Calories in drink
        /// </summary>
        /// <exception cref="System.NotImplementedException">
        /// Throws if size is invalid with calories
        /// </exception>
        /// <returns>the amount of calories in drink</returns>
        public uint Calories
        {
            get
            {
                if (size == Size.Small)
                {
                    return 0;
                }
                else if (size == Size.Medium)
                {
                    return 0;
                }
                else if (size == Size.Large)
                {
                    return 0;
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// Size of drink
        /// </summary>
        /// <returns>Size of Drink</returns>
        private Size size = Size.Small;

        public Size Size
        {
            get
            {
                return size;
            }
            set
            {
                size = value;
            }
        }

        /// <summary>
        /// Sees if theres Ice added
        /// </summary>
        private bool ice = true;
        public bool Ice { get; set; } = true;

        /// <summary>
        /// Sees if theres Lemon needed
        /// </summary>
        private bool lemon = false;
        public bool Lemon { get; set; } = false;

        /// <summary>
        /// This basically checks what conditions you want in your drink
        /// </summary>
        /// <returns>Special Instructions on drink</returns>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Ice) instructions.Add("Hold ice");
                if (Lemon) instructions.Add("Add lemon");

                return instructions;
            }
        }

        /// <summary>
        /// returns the string name
        /// </summary>
        /// <returns>The string of the drink</returns>
        public override string ToString()
        {
            return size.ToString() + " Warrior Water";
        }
    }
}
