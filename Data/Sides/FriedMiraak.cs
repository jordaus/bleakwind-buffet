using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Interface;
using System.ComponentModel;

/*
 * Author: Jordan Austin
 * Class name: FriedMiraak.cs
 * Purpose: Class used to represent Hash Browns
 */
namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// represents hashbrown pancake
    /// </summary>
    public class FriedMiraak : Side, IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// Description of item
        /// </summary>
        public override string Description
        {
            get
            {
                return "Perfectly prepared hash brown pancakes.";
            }
        }
        /// <summary>
        /// Price for side
        /// </summary>
        /// <exception cref="System.NotImplementedException">
        /// Throws if size in invalid
        /// </exception>
        /// <returns>price of side</returns>
        public override double Price
        {
            get
            {
                if (size == Size.Small)
                {
                    return 1.78;
                }
                else if (size == Size.Medium)
                {
                    return 2.01;
                }
                else if (size == Size.Large)
                {
                    return 2.88;
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
        /// <returns>calories in side</returns>
        public override uint Calories
        {
            get
            {
                if (size == Size.Small)
                {
                    return 151;
                }
                else if (size == Size.Medium)
                {
                    return 236;
                }
                else if (size == Size.Large)
                {
                    return 306;
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
        public override Size Size
        {
            get { return size; }
            set
            {
                size = value;
                OnPropertyChanged(("Size"));
                OnPropertyChanged(("Price"));
                OnPropertyChanged(("Calories"));
            }
        }

        /// <summary>
        /// This basically checks what conditions you want on your side
        /// </summary>
        /// <returns>special instructions</returns>
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
        /// <returns>string of side</returns>
        public override string ToString()
        {
            return size.ToString() + " Fried Miraak";
        }
    }
}
