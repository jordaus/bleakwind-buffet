using System;
using System.Collections.Generic;
using System.Text;

/*
 * Author: Jordan Austin
 * Class name: SmokehouseSkeleton.cs
 * Purpose: Class used to represent the smokehouse skeleton
 */

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// class represents food Smokehouse Skeleton
    /// </summary>
    public class SmokehouseSkeleton
    {
        /// <summary>
        /// Gets the price of the burger
        /// </summary>
        public double Price => 5.62;

        /// <summary>
        /// Gets the calorie amount in a burger
        /// </summary>
        public uint Calories => 602;

        /// <summary>
        /// Decides if you want sausage links
        /// </summary>
        public bool SausageLink { get; set; } = true;

        /// <summary>
        /// Decides if you want hash browns
        /// </summary>
        public bool HashBrowns { get; set; } = true;

        /// <summary>
        /// Decides if you want egg
        /// </summary>
        public bool Egg { get; set; } = true;

        /// <summary>
        /// Decides if you want pancakes
        /// </summary>
        public bool Pancake { get; set; } = true;

        /// <summary>
        /// This basically checks what conditions you want on your food
        /// </summary>
        /// <returns>special instructions</returns>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!SausageLink) instructions.Add("Hold sausage");
                if (!HashBrowns) instructions.Add("Hold hash browns");
                if (!Pancake) instructions.Add("Hold pancakes");
                if (!Egg) instructions.Add("Hold egg");

                return instructions;
            }
        }

        /// <summary>
        /// returns the string name
        /// </summary>
        /// <returns>string name of food</returns>
        public override string ToString()
        {
            return "Smokehouse Skeleton";
        }
    }
}
