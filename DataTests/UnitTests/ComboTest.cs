using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using Xunit;

namespace BleakwindBuffet.DataTests.UnitTests
{
    public class ComboTest
    {
        /// <summary>
        /// class comboTest that contains the tests of combo class
        /// </summary>
        public class ComboTests
        {
            /// <summary>
            /// checks if variety of combo items are correct
            /// </summary>
            [Fact]
            public void IfSpecialInstructionsIsCorrect()
            {
                BriarheartBurger bb = new BriarheartBurger();
                DragonbornWaffleFries db = new DragonbornWaffleFries();
                AretinoAppleJuice aj = new AretinoAppleJuice();
                Combo combo = new Combo(bb, db, aj);

                List<string> list = new List<string>();
                list.Add(bb.ToString());
                list.AddRange(bb.SpecialInstructions);

                list.Add(db.ToString());
                list.AddRange(db.SpecialInstructions);

                list.Add(aj.ToString());
                list.AddRange(aj.SpecialInstructions);


                Assert.Equal(list, combo.SpecialInstructions);
            }
        }
    }
}
