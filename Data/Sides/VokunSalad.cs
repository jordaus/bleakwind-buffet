using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

/*
 * Author: Jordan Austin
 * Class name: VokunSalad.cs
 * Purpose: Class used to represent salad
 */
namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// represents salad class
    /// </summary>
    public class VokunSalad
    {
        /// <summary>
        /// Price for side
        /// </summary>
        /// <exception cref="System.NotImplementedException">
        /// Throws if size in invalid
        /// </exception>
        /// <returns>price of side</returns>
        public double Price
        {
            get
            {
                if (size == Size.Small)
                {
                    return 0.93;
                }
                else if (size == Size.Medium)
                {
                    return 1.28;
                }
                else if (size == Size.Large)
                {
                    return 1.82;
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// Calories in side
        /// </summary>
        /// <exception cref="System.NotImplementedException">
        /// Throws if size in invalid
        /// </exception>
        /// <returns>calories in side</returns>
        public uint Calories
        {
            get
            {
                if (size == Size.Small)
                {
                    return 41;
                }
                else if (size == Size.Medium)
                {
                    return 52;
                }
                else if (size == Size.Large)
                {
                    return 73;
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// Size of side
        /// </summary>
        private Size size = Size.Small;

        /// <summary>
        /// Size of side
        /// </summary>
        /// <returns>size of side</returns>
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
        /// This basically checks what conditions you want on your side
        /// </summary>
        /// <returns>special instructions</returns>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();

                return instructions;
            }
        }

        /// <summary>
        /// returns the string name
        /// </summary>
        /// <returns>sting of side</returns>
        public override string ToString()
        {
            return size.ToString() + " Vokun Salad";
        }
    }
}
