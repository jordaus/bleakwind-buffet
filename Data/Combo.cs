using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using BleakwindBuffet.Data.Interface;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
/*
 * Represents the Combo Class
 */
namespace BleakwindBuffet.Data
{
    public class Combo : IOrderItem, INotifyPropertyChanged
    {
        public Combo(Entree e, Side s, Drink d)
        {
            drink = d;
            side = s;
            entree = e;
        }
        /// <summary>
        /// Event for all classes
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// calories in combo
        /// </summary>
        /// <returns>Overall combo calories</returns>
        public uint Calories { get { return Drink.Calories + Entree.Calories + Side.Calories; } }

        /// <summary>
        /// Special Instructions in the Lists
        /// </summary>
        /// <returns>The Special Instructions in the whole combo</returns>
        public List<string> SpecialInstructions 
        {
            get 
            { 
                List<string> sI = new List<string>();
                sI.Add(Entree.ToString());
                sI.AddRange(Entree.SpecialInstructions);
                sI.Add(Drink.ToString());
                sI.AddRange(Drink.SpecialInstructions);
                sI.Add(Side.ToString());
                sI.AddRange(Side.SpecialInstructions);
                return sI;
            } 
        }

        /// <summary>
        /// represents the drinks
        /// </summary>
        private Drink drink;
        public Drink Drink 
        {
            get { return drink; }
            set
            {
                drink = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Size"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            } 
        }

        /// <summary>
        /// represnets the entree
        /// </summary>
        public Entree entree;
        public Entree Entree 
        { 
            get { return entree; }
            set
            {
                entree = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <summary>
        /// represents the sides
        /// </summary>
        public Side side;
        public Side Side 
        { 
            get { return side; }
            set
            {
                side = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Size"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <summary>
        /// represents the price of combo
        /// </summary>
        public double Price
        {
            get { return Drink.Price + Entree.Price + Side.Price - 1; }
        }


    }
}
