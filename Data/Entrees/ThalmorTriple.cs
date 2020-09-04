using System;
using System.Collections.Generic;
using System.Text;

/*
 * Author: Jordan Austin
 * Class name: ThalmorTriple.cs
 * Purpose: Class used to represent the 1lb burger
 */

namespace BleakwindBuffet.Data.Entrees
{
    public class ThalmorTriple
    {
        /// <summary>
        /// Gets the price of the burger
        /// </summary>
        public double Price => 8.32;

        /// <summary>
        /// Gets the calorie amount in a burger
        /// </summary>
        public uint Calories => 943;

        /// <summary>
        /// Decides if you want ketchup
        /// </summary>
        public bool Ketchup { get; set; } = true;

        /// <summary>
        /// Decides if you want a bun
        /// </summary>
        public bool Bun { get; set; } = true;

        /// <summary>
        /// Decides if you want mustard
        /// </summary>
        public bool Mustard { get; set; } = true;

        /// <summary>
        /// Decides if you want pickles
        /// </summary>
        public bool Pickles { get; set; } = true;

        /// <summary>
        /// Decides if you want cheese
        /// </summary>
        public bool Cheese { get; set; } = true;

        /// <summary>
        /// Decides if you want tomatos
        /// </summary>
        public bool Tomato { get; set; } = true;

        /// <summary>
        /// Decides if you want lettuce
        /// </summary>
        public bool Lettuce { get; set; } = true;

        /// <summary>
        /// Decides if you want mayo
        /// </summary>
        public bool Mayo { get; set; } = true;

        /// <summary>
        /// Decides if you want bacon
        /// </summary>
        public bool Bacon { get; set; } = true;

        /// <summary>
        /// Decides if you want egg
        /// </summary>
        public bool Egg { get; set; } = true;

        /// <summary>
        /// This basically checks what conditions you want on your burger
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Bun) instructions.Add("Hold bun");
                if (!Ketchup) instructions.Add("Hold ketchup");
                if (!Mustard) instructions.Add("Hold mustard");
                if (!Pickles) instructions.Add("Hold pickles");
                if (!Cheese) instructions.Add("Hold cheese");
                if (!Tomato) instructions.Add("Hold tomato");
                if (!Lettuce) instructions.Add("Hold lettuce");
                if (!Mayo) instructions.Add("Hold mayo");
                if (!Bacon) instructions.Add("Hold bacon");
                if (!Egg) instructions.Add("Hold egg");

                return instructions;
            }
        }

        /// <summary>
        /// returns the string name
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Thalmor Triple";
        }
    }
}
