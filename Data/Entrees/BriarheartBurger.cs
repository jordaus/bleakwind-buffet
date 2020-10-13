using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Interface;
using System.ComponentModel;
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
    public class BriarheartBurger : Entree, IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// Gets the price of the burger
        /// </summary>
        public override double Price => 6.32;

        /// <summary>
        /// Gets the amount of calories in a burger
        /// </summary>
        public override uint Calories => 743;

        private bool ketchup = true;

        /// <summary>
        /// Checks to see if you want ketchup
        /// </summary>
        public bool Ketchup
        {
            get
            {
                return ketchup;
            }
            set
            {
                ketchup = value;
                OnPropertyChanged(("Ketchup"));
                OnPropertyChanged(("SpecialInstructions"));
            }
        }

        /// <summary>
        /// Checks to see if you want a bun
        /// </summary>
        private bool bun = true;
        public bool Bun
        {
            get
            {
                return bun;
            }
            set
            {
                bun = value;
                OnPropertyChanged(("Bun"));
                OnPropertyChanged(("SpecialInstructions"));
            }
        }

        private bool mustard = true;

        /// <summary>
        /// Checks to see if you want mustard
        /// </summary>
        public bool Mustard
        {
            get
            {
                return mustard;
            }
            set
            {
                mustard = value;
                OnPropertyChanged(("Mustard"));
                OnPropertyChanged(("SpecialInstructions"));
            }
        }

        /// <summary>
        /// Checks to see if you want pickles
        /// </summary>
        private bool pickles = true;
        public bool Pickles
        {
            get
            {
                return pickles;
            }
            set
            {
                pickles = value;
                OnPropertyChanged(("Pickles"));
                OnPropertyChanged(("SpecialInstructions"));
            }
        }

        /// <summary>
        /// Checks to see if you want cheese
        /// </summary>
        private bool cheese = true;
        public bool Cheese
        {
            get
            {
                return cheese;
            }
            set
            {
                cheese = value;
                OnPropertyChanged(("Cheese"));
                OnPropertyChanged(("SpecialInstructions"));
            }
        }

        /// <summary>
        /// This basically checks what conditions you want on your burger
        /// </summary>
        public override List<string> SpecialInstructions
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
