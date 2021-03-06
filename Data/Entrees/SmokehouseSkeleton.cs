﻿using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Interface;
using System.ComponentModel;
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
    public class SmokehouseSkeleton : Entree, IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// Description of item
        /// </summary>
        public override string Description
        {
            get
            {
                return "Put some meat on those bones with a small stack of pancakes. Includes sausage links, eggs, and hash browns on the side. Topped with the syrup of your choice.";
            }
        }
        /// <summary>
        /// Gets the price of the burger
        /// </summary>
        public override double Price => 5.62;

        /// <summary>
        /// Gets the calorie amount in a burger
        /// </summary>
        public override uint Calories => 602;

        /// <summary>
        /// Decides if you want sausage links
        /// </summary>
        private bool sausagelink = true;
        public bool SausageLink
        {
            get
            {
                return sausagelink;
            }
            set
            {
                sausagelink = value;
                OnPropertyChanged(("Sausage"));
                OnPropertyChanged(("SpecialInstructions"));
            }
        }

        /// <summary>
        /// Decides if you want hash browns
        /// </summary>
        private bool hashbrowns = true;
        public bool HashBrowns
        {
            get
            {
                return hashbrowns;
            }
            set
            {
                hashbrowns = value;
                OnPropertyChanged(("HashBrowns"));
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
        /// Decides if you want pancakes
        /// </summary>
        private bool pancake = true;
        public bool Pancake
        {
            get
            {
                return pancake;
            }
            set
            {
                pancake = value;
                OnPropertyChanged(("Pancake"));
                OnPropertyChanged(("SpecialInstructions"));
            }
        }

        /// <summary>
        /// This basically checks what conditions you want on your food
        /// </summary>
        /// <returns>special instructions</returns>
        public override List<string> SpecialInstructions
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
