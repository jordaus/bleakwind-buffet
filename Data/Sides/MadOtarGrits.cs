using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

/*
 * Author: Jordan Austin
 * Class name: MadOtarGrits.cs
 * Purpose: Class used to represent grits
 */
namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// represents grits class
    /// </summary>
    public class MadOtarGrits : Side
    {
        /// <summary>
        /// Price for side
        /// </summary>
        /// <exception cref="System.NotImplementedException">
        /// Throws if size in invalid
        /// </exception>
        /// <returns>price via size</returns>
        public override double Price
        {
            get
            {
                if (size == Size.Small)
                {
                    return 1.22;
                }
                else if (size == Size.Medium)
                {
                    return 1.58;
                }
                else if (size == Size.Large)
                {
                    return 1.93;
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
        /// <returns>calories via size</returns>
        public override uint Calories
        {
            get
            {
                if (size == Size.Small)
                {
                    return 105;
                }
                else if (size == Size.Medium)
                {
                    return 142;
                }
                else if (size == Size.Large)
                {
                    return 179;
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
        /// <returns>size</returns>
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
        /// This basically checks what conditions you want on your side
        /// </summary>
        /// <returns>instructions</returns>
        public override List<string> SpecialInstructions
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
        /// <returns>string of grits</returns>
        public override string ToString()
        {
            return size.ToString() + " Mad Otar Grits";
        }
    }
}
