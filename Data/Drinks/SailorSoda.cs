using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

/*
 * Author: Jordan Austin
 * Class name: BriarheartBurger.cs
 * Purpose: Class used to represent the soda
 */
namespace BleakwindBuffet.Data.Drinks
{
    public class SailorSoda
    {
        /// <summary>
        /// Price for drink
        /// </summary>
        public double Price
        {
            get
            {
                if(size == Size.Small)
                {
                    return 1.42;
                }
                else if(size == Size.Small)
                {
                    return 1.74;
                }
                else if(size == Size.Large)
                {
                    return 2.07;
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
                if(size == Size.Small)
                {
                    return 117;
                }
                else if(size == Size.Medium)
                {
                    return 153;
                }
                else if(size == Size.Large)
                {
                    return 205;
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
        /// Checks for ice
        /// </summary>
        private bool ice = true;

        /// <summary>
        /// Sees if theres Ice added
        /// </summary>
        public bool Ice { get; set; } = true;

        /// <summary>
        /// default soda flavor
        /// </summary>
        private SodaFlavor flavor = SodaFlavor.Cherry;

        /// <summary>
        /// get set method for the soda flavor
        /// </summary>
        public SodaFlavor Flavor
        {
            get
            {
                return flavor;
            }
            set
            {
                flavor = value;
            }
        }

        /// <summary>
        /// This basically checks what conditions you want in your drink
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Ice) instructions.Add("Hold ice");

                return instructions;
            }
        }

        /// <summary>
        /// returns the string name
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return size.ToString() + flavor.ToString() + " Sailor's Soda";
        }

    }
}
