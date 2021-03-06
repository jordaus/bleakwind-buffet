﻿using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Interface;
using System.ComponentModel;
/*
 * Author: Jordan Austin
 * Class name: DoubleDragur.cs
 * Purpose: Class used to represent the 1/2lb burger
 */
namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// class represents a double burger
    /// </summary>
    public class DoubleDraugr : Entree, IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// Description of item
        /// </summary>
        public override string Description
        {
            get
            {
                return "Double patty burger on a brioche bun. Comes with ketchup, mustard, pickle, cheese, tomato, lettuce, and mayo.";
            }
        }
        /// <summary>
        /// Gets the price of the burger
        /// </summary>
        public override double Price => 7.32;

        /// <summary>
        /// Gets the calorie amount in a burger
        /// </summary>
        public override uint Calories => 843;

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

                return instructions;
            }
        }

        /// <summary>
        /// returns the string name
        /// </summary>
        /// <returns>name of food</returns>
        public override string ToString()
        {
            return "Double Draugr";
        }
    }
}
