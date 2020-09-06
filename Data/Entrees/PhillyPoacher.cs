using System;
using System.Collections.Generic;
using System.Text;

/*
 * Author: Jordan Austin
 * Class name: PhillyPoacher.cs
 * Purpose: Class used to represent the philly
 */

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// class represents a philly cheesesteak
    /// </summary>
    public class PhillyPoacher
    {
        /// <summary>
        /// Gets the price of the burger
        /// </summary>
        public double Price => 7.23;

        /// <summary>
        /// Gets the calorie amount in a burger
        /// </summary>
        public uint Calories => 784;

        /// <summary>
        /// Decides if you want Sirloin
        /// </summary>
        public bool Sirloin { get; set; } = true;

        /// <summary>
        /// Decides if you want Onion
        /// </summary>
        public bool Onion { get; set; } = true;

        /// <summary>
        /// Decides if you want Roll
        /// </summary>
        public bool Roll { get; set; } = true;

        /// <summary>
        /// This basically checks what conditions you want on your food
        /// </summary>
        /// <returns>instructions</returns>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Sirloin) instructions.Add("Hold sirloin");
                if (!Onion) instructions.Add("Hold onion");
                if (!Roll) instructions.Add("Hold roll");

                return instructions;
            }
        }

        /// <summary>
        /// returns the string name
        /// </summary>
        /// <returns>string name of food</returns>
        public override string ToString()
        {
            return "Philly Poacher";
        }
    }
}
