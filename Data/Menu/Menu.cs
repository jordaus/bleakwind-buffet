/*
 * Author: Jordan Austin
 * Class: Menu.cs
 * Purpose: Produces the menu class
 */
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Interface;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Enums;
using System.Linq;

namespace BleakwindBuffet.Data.Menu
{
    /// <summary>
    /// represents the menu class
    /// </summary>
    public static class Menu
    {
        /// <summary>
        /// returns all known entrees in an IEnumerable
        /// </summary>
        /// <returns>all entrees</returns>
        public static IEnumerable<IOrderItem> Entrees()
        {
            List<IOrderItem> entreeList = new List<IOrderItem>();

            BriarheartBurger bb = new BriarheartBurger();

            entreeList.Add(bb);

            DoubleDraugr dd = new DoubleDraugr();

            entreeList.Add(dd);

            GardenOrcOmelette goo = new GardenOrcOmelette();

            entreeList.Add(goo);

            PhillyPoacher pp = new PhillyPoacher();

            entreeList.Add(pp);

            SmokehouseSkeleton ss = new SmokehouseSkeleton();

            entreeList.Add(ss);

            ThalmorTriple tt = new ThalmorTriple();

            entreeList.Add(tt);

            ThugsTBone ttb = new ThugsTBone();

            entreeList.Add(ttb);

            return entreeList;
        }

        /// <summary>
        /// returns all known drinks in IEnumerable
        /// </summary>
        /// <returns>all drinks</returns>
        public static IEnumerable<IOrderItem> Drinks()
        {
            List<IOrderItem> drinkList = new List<IOrderItem>();
            
            foreach(Size s in Enum.GetValues(typeof(Size)))
            {
                AretinoAppleJuice aj = new AretinoAppleJuice();
                aj.Size = s;
                drinkList.Add(aj);

                foreach(SodaFlavor f in Enum.GetValues(typeof(SodaFlavor)))
                {
                    SailorSoda ss = new SailorSoda();
                    ss.Size = s;
                    ss.Flavor = f;

                    drinkList.Add(ss);
                }

                CandlehearthCoffee cc = new CandlehearthCoffee();
                cc.Size = s;
                drinkList.Add(cc);

                CandlehearthCoffee ccd = new CandlehearthCoffee();
                ccd.Size = s;
                ccd.Decaf = true;
                drinkList.Add(ccd);

                MarkarthMilk mm = new MarkarthMilk();
                mm.Size = s;
                drinkList.Add(mm);

                WarriorWater ww = new WarriorWater();
                ww.Size = s;
                drinkList.Add(ww);
            }

            return drinkList;
        }

        /// <summary>
        /// returns all known sides in IEnumerable
        /// </summary>
        /// <returns>all sides</returns>
        public static IEnumerable<IOrderItem> Sides()
        {
            List<IOrderItem> sideList = new List<IOrderItem>();

            foreach(Size s in Enum.GetValues(typeof(Size)))
            {
                DragonbornWaffleFries dwf = new DragonbornWaffleFries();
                dwf.Size = s;
                sideList.Add(dwf);

                FriedMiraak fm = new FriedMiraak();
                fm.Size = s;
                sideList.Add(fm);

                MadOtarGrits mog = new MadOtarGrits();
                mog.Size = s;
                sideList.Add(mog);

                VokunSalad vs = new VokunSalad();
                vs.Size = s;
                sideList.Add(vs);
            }

            return sideList;
        }

        /// <summary>
        /// returns the whole menu in IEnumerable
        /// </summary>
        /// <returns>the whole menu</returns>
        public static IEnumerable<IOrderItem> FullMenu()
        {
            List<IOrderItem> menuList = new List<IOrderItem>();

            menuList.AddRange(Entrees());
            menuList.AddRange(Drinks());
            menuList.AddRange(Sides());

            return menuList;
        }
        
        /// <summary>
        /// Search engine for website
        /// </summary>
        /// <param name="terms">string parametr</param>
        /// <returns>search results</returns>
        public static IEnumerable<IOrderItem> Search(string terms)
        {
            List<IOrderItem> Food = new List<IOrderItem>();
            if(terms == null)
            {
                return FullMenu();
            }

            foreach(IOrderItem io in FullMenu())
            {
                if (io.ToString().Contains(terms))
                {
                    Food.Add(io);
                }
            }

            return Food;
        }

        /// <summary>
        /// just a list for types of food
        /// </summary>
        public static string[] FoodType
        {
            get => new string[]
            {
                "Entree",
                "Side",
                "Drink"
            };
        }

        /// <summary>
        /// filters website by type of food
        /// </summary>
        /// <param name="food">food list</param>
        /// <param name="type">type parameter</param>
        /// <returns>returns food results</returns>
        public static IEnumerable<IOrderItem> FilterByFoodType(IEnumerable<IOrderItem> food, IEnumerable<string> type)
        {
            if (type == null || type.Count() == 0) return food;

            List<IOrderItem> Order = new List<IOrderItem>();

            foreach(IOrderItem io in food)
            {
                if(io is Entree e && type.Contains("Entree"))
                {
                    Order.Add(io);
                }
                else if(io is Drink && type.Contains("Drink"))
                {
                    Order.Add(io);
                }
                else if(io is Side && type.Contains("Side"))
                {
                    Order.Add(io);
                }
            }

            return Order;
        }

        /// <summary>
        /// Filters the website by calories
        /// </summary>
        /// <param name="food">food list</param>
        /// <param name="min">min param</param>
        /// <param name="max">max param</param>
        /// <returns>returns calories filter</returns>
        public static IEnumerable<IOrderItem> FilterByCalories(IEnumerable<IOrderItem> food, int? min, int? max)
        {
            if (min == null && max == null) return food;
            var results = new List<IOrderItem>();

            if(min == null)
            {
                foreach(IOrderItem io in food)
                {
                    if (io.Calories <= max) results.Add(io);
                }
                return results;
            }

            if(max == null)
            {
                foreach(IOrderItem io in food)
                {
                    if (io.Calories >= min) results.Add(io);
                }
                return results;
            }

            foreach(IOrderItem io in food)
            {
                if(io.Calories >= min && io.Calories <= max)
                {
                    results.Add(io);
                }
            }
            return results;
        }

        /// <summary>
        /// Filters the website by price
        /// </summary>
        /// <param name="food">food list</param>
        /// <param name="min">min param</param>
        /// <param name="max">max param</param>
        /// <returns>returns price filter</returns>
        public static IEnumerable<IOrderItem> FilterByPrice(IEnumerable<IOrderItem> food, double? min, double? max)
        {
            if (min == null && max == null) return food;
            var results = new List<IOrderItem>();

            if (min == null)
            {
                foreach (IOrderItem io in food)
                {
                    if (io.Price <= max) results.Add(io);
                }
                return results;
            }

            if (max == null)
            {
                foreach (IOrderItem io in food)
                {
                    if (io.Price >= min) results.Add(io);
                }
                return results;
            }

            foreach (IOrderItem io in food)
            {
                if (io.Price >= min && io.Price <= max)
                {
                    results.Add(io);
                }
            }
            return results;
        }
    }


}
