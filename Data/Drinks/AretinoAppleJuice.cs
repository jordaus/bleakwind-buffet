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
    public class AretinoAppleJuice
    {
        /// <summary>
        /// Price for drink
        /// </summary>
        public double Price
        {
            get
            {
                if (size == Size.Small)
                {
                    return 0.62;
                }
                else if (size == Size.Small)
                {
                    return 0.87;
                }
                else if (size == Size.Large)
                {
                    return 1.01;
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
        public uint Calories
        {
            get
            {
                if (size == Size.Small)
                {
                    return 44;
                }
                else if (size == Size.Medium)
                {
                    return 88;
                }
                else if (size == Size.Large)
                {
                    return 132;
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
        private bool ice = false;
        public bool Ice { get; set; } = false;

        /// <summary>
        /// This basically checks what conditions you want in your drink
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Ice) instructions.Add("Add ice");

                return instructions;
            }
        }

        /// <summary>
        /// returns the string name
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return size.ToString() + " Aretino Apple Juice";
        }
    }
}
