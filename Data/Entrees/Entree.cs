﻿/*
 * Author: Jordan Austin
 * Class: Entree.cs
 * Purpose: Produes the entree class
 */
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Interface;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// A basic class representing the common properties of entrees
    /// </summary>
    public abstract class Entree : IOrderItem, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// price of the entree
        /// </summary>
        /// <value>
        /// In USD
        /// </value>
        public abstract double Price { get; }

        /// <summary>
        /// calories in entree
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// special instructons for entree
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }

        public abstract string Description { get; }

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
