using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

/*
 * Author: Jordan Austin
 * Class name: WarriorWater.cs
 * Purpose: Class used to represent water
 */
namespace BleakwindBuffet.Data.Drink
{
    public class WarriorWater
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
                    return 1.42;
                }
                else if (size == Size.Small)
                {
                    return 1.74;
                }
                else if (size == Size.Large)
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
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Ice) instructions.Add("Hold ice");
                if (!Lemon) instructions.Add("Add lemon");

                return instructions;
            }
        }

        /// <summary>
        /// returns the string name
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return size.ToString() + " Warrior's Water";
        }
    }
}
