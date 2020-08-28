﻿using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

/*
 * Author: Jordan Austin
 * Class name: DragonbornWaffleFries.cs
 * Purpose: Class used to represent fries
 */
namespace BleakwindBuffet.Data.Sides
{
    public class DragonbornWaffleFries
    {
        /// <summary>
        /// Price for side
        /// </summary>
        public double Price
        {
            get
            {
                if (size == Size.Small)
                {
                    return 0.42;
                }
                else if (size == Size.Small)
                {
                    return 0.76;
                }
                else if (size == Size.Large)
                {
                    return 0.96;
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
        public uint Calories
        {
            get
            {
                if (size == Size.Small)
                {
                    return 77;
                }
                else if (size == Size.Medium)
                {
                    return 89;
                }
                else if (size == Size.Large)
                {
                    return 100;
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
        /// <returns></returns>
        public override string ToString()
        {
            return size.ToString() + " Dragonborn Waffle Fries";
        }
    }
}