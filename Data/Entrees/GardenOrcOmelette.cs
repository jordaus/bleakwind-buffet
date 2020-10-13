using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Interface;
using System.ComponentModel;
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
    public class GardenOrcOmelette : Entree, IOrderItem, INotifyPropertyChanged
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
        private bool broccoli = true;
        public bool Broccoli
        {
            get
            {
                return broccoli;
            }
            set
            {
                broccoli = value;
                OnPropertyChanged(("Broccoli"));
                OnPropertyChanged(("SpecialInstructions"));
            }
        }

        /// <summary>
        /// Decides if you want Mushrooms
        /// </summary>
        private bool mushrooms = true;
        public bool Mushrooms
        {
            get
            {
                return mushrooms;
            }
            set
            {
                mushrooms = value;
                OnPropertyChanged(("Mushrooms"));
                OnPropertyChanged(("SpecialInstructions"));
            }
        }

        /// <summary>
        /// Decides if you want Tomatos
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
        /// Decides if you want Cheddar
        /// </summary>
        private bool cheddar = true;
        public bool Cheddar
        {
            get
            {
                return cheddar;
            }
            set
            {
                cheddar = value;
                OnPropertyChanged(("Cheddar"));
                OnPropertyChanged(("SpecialInstructions"));
            }
        }

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
