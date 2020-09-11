using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

/*
 * Author: Jordan Austin
 * Class name: CandlehearthCoffee.cs
 * Purpose: Class used to represent the coffee
 */
namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// class represents coffee
    /// </summary>
    public class CandlehearthCoffee : Drink
    {
        /// <summary>
        /// Price for drink
        /// </summary>
        /// <exception cref="System.NotImplementedException">
        /// Exception Thrown if size is not valid
        /// </exception>
        /// <returns>price of drink</returns>
        public override double Price
        {
            get
            {
                if (size == Size.Small)
                {
                    return 0.75;
                }
                else if (size == Size.Medium)
                {
                    return 1.25;
                }
                else if (size == Size.Large)
                {
                    return 1.75;
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
        /// Thrown if size is not valid
        /// </exception>
        /// <returns>calories of drink</returns>
        public override uint Calories
        {
            get
            {
                if (size == Size.Small)
                {
                    return 7;
                }
                else if (size == Size.Medium)
                {
                    return 10;
                }
                else if (size == Size.Large)
                {
                    return 20;
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
        /// <returns>size of drink</returns>
        private Size size = Size.Small;

        public override Size Size
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
        private bool ice = false;
        public bool Ice { get; set; } = false;

        /// <summary>
        /// Sees if cream is needed
        /// </summary>
        private bool roomForCream = false;
        public bool RoomForCream { get; set; } = false;


        /// <summary>
        /// Sees if Caffine is needed
        /// </summary>
        public bool Decaf { get; set; } = false;

        /// <summary>
        /// This basically checks what conditions you want in your drink
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (Ice) instructions.Add("Add ice");
                if (RoomForCream) instructions.Add("Add cream");

                return instructions;
            }
        }

        /// <summary>
        /// returns the string name
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            if (Decaf == false)
            {
                return size.ToString() + " Candlehearth Coffee";
            }
            else
            {
                return size.ToString() + " Decaf Candlehearth Coffee";
            }
        }
    }
}
