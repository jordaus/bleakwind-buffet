using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Interface;
using System.ComponentModel;
/*
 * Author: Jordan Austin
 * Class name: ThugsTBone.cs
 * Purpose: Class used to represent the TBone
 */

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// class represents a TBone Steak
    /// </summary>
    public class ThugsTBone : Entree, IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// Gets the price of the burger
        /// </summary>
        public override double Price => 6.44;

        /// <summary>
        /// Gets the calorie amount in a burger
        /// </summary>
        public override uint Calories => 982;

        /// <summary>
        /// This basically checks what conditions you want on your food
        /// </summary>
        /// <returns>instructions</returns>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();

                return instructions;
            }
        }

        /// <summary>
        /// returns the string name
        /// </summary>
        /// <returns>string name of food</returns>
        public override string ToString()
        {
            return "Thugs T-Bone";
        }
    }
}
