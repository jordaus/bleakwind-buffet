using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Interface;
using System.ComponentModel;
/*
 * Author: Jordan Austin
 * Class name: ThalmorTriple.cs
 * Purpose: Class used to represent the 1lb burger
 */

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// class represents a tripple burger
    /// </summary>
    public class ThalmorTriple : Entree, IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// Gets the price of the burger
        /// </summary>
        public override double Price => 8.32;

        /// <summary>
        /// Gets the calorie amount in a burger
        /// </summary>
        public override uint Calories => 943;

        /// <summary>
        /// Decides if you want ketchup
        /// </summary>
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
        /// Decides if you want tomatos
        /// </summary>
        private bool tomato = true;
        public bool Tomato
        {
            get
            {
                return tomato;
            }
            set
            {
                tomato = value;
                OnPropertyChanged(("Tomato"));
                OnPropertyChanged(("SpecialInstructions"));
            }
        }

        /// <summary>
        /// Decides if you want lettuce
        /// </summary>
        private bool lettuce = true;
        public bool Lettuce
        {
            get
            {
                return lettuce;
            }
            set
            {
                lettuce = value;
                OnPropertyChanged(("Lettuce"));
                OnPropertyChanged(("SpecialInstructions"));
            }
        }

        /// <summary>
        /// Decides if you want mayo
        /// </summary>
        private bool mayo = true;
        public bool Mayo
        {
            get
            {
                return mayo;
            }
            set
            {
                mayo = value;
                OnPropertyChanged(("Mayo"));
                OnPropertyChanged(("SpecialInstructions"));
            }
        }

        /// <summary>
        /// Decides if you want bacon
        /// </summary>
        private bool bacon = true;
        public bool Bacon
        {
            get
            {
                return bacon;
            }
            set
            {
                bacon = value;
                OnPropertyChanged(("Bacon"));
                OnPropertyChanged(("SpecialInstructions"));
            }
        }

        /// <summary>
        /// Decides if you want egg
        /// </summary>
        private bool egg = true;
        public bool Egg
        {
            get
            {
                return egg;
            }
            set
            {
                egg = value;
                OnPropertyChanged(("Egg"));
                OnPropertyChanged(("SpecialInstructions"));
            }
        }

        /// <summary>
        /// This basically checks what conditions you want on your burger
        /// </summary>
        /// <returns>instructions</returns>
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
        /// <returns>string of the food</returns>
        public override string ToString()
        {
            return "Thalmor Triple";
        }
    }
}
