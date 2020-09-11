using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Interface;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Menu
{
    /// <summary>
    /// represents the menu class
    /// </summary>
    public static class Menu
    {
        /// <summary>
        /// returns entrees in an IEnumerable
        /// </summary>
        /// <returns></returns>
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
        /// returns drinks in IEnumerable
        /// </summary>
        /// <returns></returns>
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
        /// returns sides in IEnumerable
        /// </summary>
        /// <returns></returns>
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

        public static IEnumerable<IOrderItem> FullMenu()
        {
            List<IOrderItem> menuList = new List<IOrderItem>();

            menuList.AddRange(Entrees());
            menuList.AddRange(Drinks());
            menuList.AddRange(Sides());

            return menuList;
        }
    }
}
