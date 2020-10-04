/*
 * Author: Jordan Austin
 * Class: DoubleDraugrTests.cs
 * Purpose: Test the DoubleDraugr.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    /// <summary>
    /// represents test class for Double Dragur
    /// </summary>
    public class DoubleDraugrTests
    {
        /// <summary>
        /// Checks if object is an entree
        /// </summary>
        [Fact]
        public void ShouldBeAnEntree()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.IsAssignableFrom<Entree>(dd);
        }

        /// <summary>
        /// Tests to see if bun is a default option
        /// </summary>
        [Fact]
        public void ShouldIncludeBunByDefault()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.True(dd.Bun);
        }

        /// <summary>
        /// Tests to see if ketchup is a default option
        /// </summary>
        [Fact]
        public void ShouldIncludeKetchupByDefault()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.True(dd.Ketchup);
        }

        /// <summary>
        /// Tests to see if mustard is a default option
        /// </summary>
        [Fact]
        public void ShouldIncludeMustardByDefault()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.True(dd.Mustard);
        }

        /// <summary>
        /// Tests to see if pickles are a default option
        /// </summary>
        [Fact]
        public void ShouldIncludePickleByDefault()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.True(dd.Pickles);
        }

        /// <summary>
        /// Tests to see if cheese is a default option
        /// </summary>
        [Fact]
        public void ShouldIncludeCheeseByDefault()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.True(dd.Cheese);
        }

        /// <summary>
        /// Tests to see if tomato is a default option
        /// </summary>
        [Fact]
        public void ShouldIncludeTomatoByDefault()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.True(dd.Tomato);
        }

        /// <summary>
        /// Tests to see if lettuce is a default option
        /// </summary>
        [Fact]
        public void ShouldIncludeLettuceByDefault()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.True(dd.Lettuce);
        }

        /// <summary>
        /// Tests to see if mayo is a default option
        /// </summary>
        [Fact]
        public void ShouldIncludeMayoByDefault()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.True(dd.Mayo);
        }

        /// <summary>
        /// Tests to see if bun can be set to true or false
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetBun()
        {
            DoubleDraugr dd = new DoubleDraugr();
            dd.Bun = true;
            Assert.True(dd.Bun);
            dd.Bun = false;
            Assert.False(dd.Bun);
        }

        /// <summary>
        /// Tests to see if ketchup can be set to true or false
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetKetchup()
        {
            DoubleDraugr dd = new DoubleDraugr();
            dd.Ketchup = true;
            Assert.True(dd.Ketchup);
            dd.Ketchup = false;
            Assert.False(dd.Ketchup);
        }

        /// <summary>
        /// Tests to see if mustard can be set to true or false
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetMustard()
        {
            DoubleDraugr dd = new DoubleDraugr();
            dd.Mustard = true;
            Assert.True(dd.Mustard);
            dd.Mustard = false;
            Assert.False(dd.Mustard);
        }

        /// <summary>
        /// Tests to see if pickle can be set to true or false
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetPickle()
        {
            DoubleDraugr dd = new DoubleDraugr();
            dd.Pickles = true;
            Assert.True(dd.Pickles);
            dd.Pickles = false;
            Assert.False(dd.Pickles);
        }

        /// <summary>
        /// Tests to see if cheese can be set to true or false
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetCheese()
        {
            DoubleDraugr dd = new DoubleDraugr();
            dd.Cheese = true;
            Assert.True(dd.Cheese);
            dd.Cheese = false;
            Assert.False(dd.Cheese);
        }

        /// <summary>
        /// Tests to see if tomato can be set to true or false
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetTomato()
        {
            DoubleDraugr dd = new DoubleDraugr();
            dd.Tomato = true;
            Assert.True(dd.Tomato);
            dd.Tomato = false;
            Assert.False(dd.Tomato);
        }

        /// <summary>
        /// Tests to see if lettuce can be set to true or false
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetLettuce()
        {
            DoubleDraugr dd = new DoubleDraugr();
            dd.Lettuce = true;
            Assert.True(dd.Lettuce);
            dd.Lettuce = false;
            Assert.False(dd.Lettuce);
        }

        /// <summary>
        /// Tests to see if mayo can be set to true or false
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetMayo()
        {
            DoubleDraugr dd = new DoubleDraugr();
            dd.Mayo = true;
            Assert.True(dd.Mayo);
            dd.Mayo = false;
            Assert.False(dd.Mayo);
        }

        /// <summary>
        /// Tests for correct price return
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.Equal(7.32, dd.Price);
        }

        /// <summary>
        /// Tests for correct calorie return
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.Equal(843.0, dd.Calories);
        }

        /// <summary>
        /// Tests for special instructions
        /// </summary>
        /// <param name="includeBun">bun parameter</param>
        /// <param name="includeKetchup">ketchup parameter</param>
        /// <param name="includeMustard">mustard parameter</param>
        /// <param name="includePickle">pickle parameter</param>
        /// <param name="includeCheese">cheese parameter</param>
        /// <param name="includeTomato">tomoato parameter</param>
        /// <param name="includeLettuce">lettuce parameter</param>
        /// <param name="includeMayo">mayo parameter</param>
        [Theory]
        [InlineData(true, true, true, true, true, true, true, true)]
        [InlineData(false, false, false, false, false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeBun, bool includeKetchup, bool includeMustard,
                                                                    bool includePickle, bool includeCheese, bool includeTomato,
                                                                    bool includeLettuce, bool includeMayo)
        {
            DoubleDraugr dd = new DoubleDraugr();
            dd.Bun = includeBun;
            dd.Ketchup = includeKetchup;
            dd.Mustard = includeMustard;
            dd.Pickles = includePickle;
            dd.Cheese = includeCheese;
            dd.Tomato = includeTomato;
            dd.Lettuce = includeLettuce;
            dd.Mayo = includeMayo;
            if (includeTomato == true && includeLettuce == true && includeMayo == true && includeBun == true && includeKetchup == true && includeMustard == true && includePickle == true && includeCheese == true) Assert.Empty(dd.SpecialInstructions);
            else if (includeBun == false) Assert.Contains("Hold bun", dd.SpecialInstructions);
            else if (includeKetchup == false) Assert.Contains("Hold ketchup", dd.SpecialInstructions);
            else if (includeMustard == false) Assert.Contains("Hold mustard", dd.SpecialInstructions);
            else if (includePickle == false) Assert.Contains("Hold pickles", dd.SpecialInstructions);
            else if (includeCheese == false) Assert.Contains("Hold cheese", dd.SpecialInstructions);
            else if (includeTomato == false) Assert.Contains("Hold tomato", dd.SpecialInstructions);
            else if (includeLettuce == false) Assert.Contains("Hold lettuce", dd.SpecialInstructions);
            else if (includeMayo == false) Assert.Contains("Hold mayo", dd.SpecialInstructions);
        }

        /// <summary>
        /// tests for correct name
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectToString()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.Equal("Double Draugr", dd.ToString());
        }

        /// <summary>
        /// Checks if ketchup property is notified
        /// </summary>
        [Fact]
        public void ChangingKetchupNotifiesKetchupProperty()
        {
            var dd = new DoubleDraugr();

            Assert.PropertyChanged(dd, "Ketchup", () =>
            {
                dd.Ketchup = true;
            });

            Assert.PropertyChanged(dd, "Ketchup", () =>
            {
                dd.Ketchup = false;
            });
        }

        /// <summary>
        /// Checks if bun property is notified
        /// </summary>
        [Fact]
        public void ChangingBunNotifiesBunProperty()
        {
            var bb = new DoubleDraugr();

            Assert.PropertyChanged(bb, "Bun", () =>
            {
                bb.Bun = true;
            });

            Assert.PropertyChanged(bb, "Bun", () =>
            {
                bb.Bun = false;
            });
        }

        /// <summary>
        /// Checks if Mustard property is notified
        /// </summary>
        [Fact]
        public void ChangingMustardNotifiesMustardProperty()
        {
            var bb = new DoubleDraugr();

            Assert.PropertyChanged(bb, "Mustard", () =>
            {
                bb.Mustard = true;
            });

            Assert.PropertyChanged(bb, "Mustard", () =>
            {
                bb.Mustard = false;
            });
        }

        /// <summary>
        /// Checks if Pickles property is notified
        /// </summary>
        [Fact]
        public void ChangingPicklesNotifiesPicklesProperty()
        {
            var bb = new ThalmorTriple();

            Assert.PropertyChanged(bb, "Pickles", () =>
            {
                bb.Pickles = true;
            });

            Assert.PropertyChanged(bb, "Pickles", () =>
            {
                bb.Pickles = false;
            });
        }

        /// <summary>
        /// Checks if cheese property is notified
        /// </summary>
        [Fact]
        public void ChangingCheeseNotifiesCheeseProperty()
        {
            var bb = new DoubleDraugr();

            Assert.PropertyChanged(bb, "Cheese", () =>
            {
                bb.Cheese = true;
            });

            Assert.PropertyChanged(bb, "Cheese", () =>
            {
                bb.Cheese = false;
            });
        }

        /// <summary>
        /// Checks if tomato property is notified
        /// </summary>
        [Fact]
        public void ChangingTomatoNotifiesTomatoProperty()
        {
            var bb = new DoubleDraugr();

            Assert.PropertyChanged(bb, "Tomato", () =>
            {
                bb.Tomato = true;
            });

            Assert.PropertyChanged(bb, "Tomato", () =>
            {
                bb.Tomato = false;
            });
        }

        /// <summary>
        /// Checks if lettuce property is notified
        /// </summary>
        [Fact]
        public void ChangingLettuceNotifiesLettuceProperty()
        {
            var bb = new DoubleDraugr();

            Assert.PropertyChanged(bb, "Lettuce", () =>
            {
                bb.Lettuce = true;
            });

            Assert.PropertyChanged(bb, "Lettuce", () =>
            {
                bb.Lettuce = false;
            });
        }

        /// <summary>
        /// Checks if mayo property is notified
        /// </summary>
        [Fact]
        public void ChangingMayoNotifiesMayoProperty()
        {
            var bb = new DoubleDraugr();

            Assert.PropertyChanged(bb, "Mayo", () =>
            {
                bb.Mayo = true;
            });

            Assert.PropertyChanged(bb, "Mayo", () =>
            {
                bb.Mayo = false;
            });
        }
    }
}