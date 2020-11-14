using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Interface;
using System.ComponentModel;
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
    public class PhillyPoacher : Entree, IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// Description of item
        /// </summary>
        public override string Description
        {
            get
            {
                return "Cheesesteak sandwich made from grilled sirloin, topped with onions on a fried roll.";
            }
        }
        /// <summary>
        /// Gets the price of the burger
        /// </summary>
        public override double Price => 7.23;

        /// <summary>
        /// Gets the calorie amount in a burger
        /// </summary>
        public override uint Calories => 784;

        /// <summary>
        /// Decides if you want Sirloin
        /// </summary>
        private bool sirloin = true;
        public bool Sirloin
        {
            get
            {
                return sirloin;
            }
            set
            {
                sirloin = value;
                OnPropertyChanged(("Sirloin"));
                OnPropertyChanged(("SpecialInstructions"));
            }
        }

        /// <summary>
        /// Decides if you want Onion
        /// </summary>
        private bool onion = true;
        public bool Onion
        {
            get
            {
                return onion;
            }
            set
            {
                onion = value;
                OnPropertyChanged(("Onion"));
                OnPropertyChanged(("SpecialInstructions"));
            }
        }

        /// <summary>
        /// Decides if you want Roll
        /// </summary>
        private bool roll = true;
        public bool Roll
        {
            get
            {
                return roll;
            }
            set
            {
                roll = value;
                OnPropertyChanged(("Roll"));
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
