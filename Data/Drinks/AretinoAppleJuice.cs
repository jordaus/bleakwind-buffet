using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

/*
 * Author: Jordan Austin
 * Class name: AretinoAppleJuice.cs
 * Purpose: Class used to represent apple juice
 */
namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// class representing apple juice
    /// </summary>
    public class AretinoAppleJuice : Drink
    {
        /// <summary>
        /// Size of drink
        /// </summary>
        /// <returns>size of drink</returns>
        private Size size = Size.Small;

        /// <summary>
        /// Price for drink
        /// </summary>
        /// <exception cref="System.NotImplementedException">
        /// Thrown if price of size is unknown
        /// </exception>
        /// <returns>price of drink</returns>
        public override double Price
        {
            get
            {
                switch(Size)
                {
                    case Size.Small: return 0.62;
                    case Size.Medium: return 0.87;
                    case Size.Large: return 1.01;
                    default: throw new NotImplementedException("Should never be reached!");
                }
            }
        }

        /// <summary>
        /// Calories in drink
        /// </summary>
        /// <exception cref="System.NotImplementedException">
        /// Thrown if Calories for size isn't known
        /// </exception>
        /// <returns>calories for drink</returns>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small: return 44;
                    case Size.Medium: return 88;
                    case Size.Large: return 132;
                    default: throw new NotImplementedException("Should never be reached!");
                }
            }
        }

        /// <summary>
        /// Sees if theres Ice added
        /// </summary>
        public bool Ice { get; set; } = false;

        public override Size Size
        {
            get { return size; }
            set { size = value;  }
        }

        /// <summary>
        /// This basically checks what conditions you want in your drink
        /// </summary>
        /// <returns>The special instructions you really want</returns>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (Ice) instructions.Add("Add ice");

                return instructions;
            }
        }

        /// <summary>
        /// returns the string name
        /// </summary>
        /// <returns>The string of the drink</returns>
        public override string ToString()
        {
            return size.ToString() + " Aretino Apple Juice";
        }
    }
}
