using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;
/*
 * Author: Jordan Austin
 * Class name: BriarheartBurger.cs
 * Purpose: Class used to represent the 1/4lb burger
 */

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// class represents a burger
    /// </summary>
    public class BriarheartBurger
    {
        /// <summary>
        /// Gets the price of the burger
        /// </summary>
        public double Price => 6.32;

        /// <summary>
        /// Gets the amount of calories in a burger
        /// </summary>
        public uint Calories => 743;

        private bool ketchup;

        /// <summary>
        /// Checks to see if you want ketchup
        /// </summary>
        public bool Ketchup { get; set; } = true;

        /// <summary>
        /// Checks to see if you want a bun
        /// </summary>
        public bool Bun { get; set; } = true;

        private bool mustard = true;

        /// <summary>
        /// Checks to see if you want mustard
        /// </summary>
        public bool Mustard
        {
            get => mustard;
            set => mustard = value;
        }

        /// <summary>
        /// Checks to see if you want pickles
        /// </summary>
        public bool Pickles { get; set; } = true;

        /// <summary>
        /// Checks to see if you want cheese
        /// </summary>
        public bool Cheese { get; set; } = true;

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

                return instructions;
            }
        }

        /// <summary>
        /// returns the string name
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Briarheart Burger";
        }
    }
}
