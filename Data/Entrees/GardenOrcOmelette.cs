using System;
using System.Collections.Generic;
using System.Text;

/*
 * Author: Jordan Austin
 * Class name: GardenOrcOmelette.cs
 * Purpose: Class used to represent the omelette
 */

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// class represents Garden Orc Omelette
    /// </summary>
    public class GardenOrcOmelette : Entree
    {
        /// <summary>
        /// Gets the price of the burger
        /// </summary>
        public override double Price => 4.57;

        /// <summary>
        /// Gets the calorie amount in a burger
        /// </summary>
        public override uint Calories => 404;

        /// <summary>
        /// Decides if you want Broccoli
        /// </summary>
        public bool Broccoli { get; set; } = true;

        /// <summary>
        /// Decides if you want Mushrooms
        /// </summary>
        public bool Mushrooms { get; set; } = true;

        /// <summary>
        /// Decides if you want Tomatos
        /// </summary>
        public bool Tomato { get; set; } = true;

        /// <summary>
        /// Decides if you want Cheddar
        /// </summary>
        public bool Cheddar { get; set; } = true;

        /// <summary>
        /// This basically checks what conditions you want on your food
        /// </summary>
        /// <returns>instructions</returns>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Broccoli) instructions.Add("Hold broccoli");
                if (!Mushrooms) instructions.Add("Hold mushrooms");
                if (!Tomato) instructions.Add("Hold tomato");
                if (!Cheddar) instructions.Add("Hold Cheddar");

                return instructions;
            }
        }

        /// <summary>
        /// returns the string name
        /// </summary>
        /// <returns>string name of food</returns>
        public override string ToString()
        {
            return "Garden Orc Omelette";
        }
    }
}
