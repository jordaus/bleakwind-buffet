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
    /// <summary>
    /// class represents soda
    /// </summary>
    public class SailorSoda : Drink
    {
        /// <summary>
        /// Price for drink
        /// </summary>
        /// <exception cref="System.NotImplementedException">
        /// Throws if size is invalid with proce
        /// </exception>
        /// <returns>price of drink</returns>
        public override double Price
        {
            get
            {
                if(size == Size.Small)
                {
                    return 1.42;
                }
                else if(size == Size.Medium)
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
        /// /// <exception cref="System.NotImplementedException">
        /// Throws if size is invalid with calories
        /// </exception>
        /// <returns>calories in drink</returns>
        public override uint Calories
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
        /// Checks for ice
        /// </summary>

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
        /// <returns>soda flavor</returns>
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
        /// <returns>Special Instructions of drink</returns>
        public override List<string> SpecialInstructions
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
            return size.ToString() + " " + flavor.ToString() + " Sailor Soda";
        }

    }
}
