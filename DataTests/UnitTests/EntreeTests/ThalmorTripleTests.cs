/*
 * Author: Jordan Austin
 * Class: ThalmorTripleTests.cs
 * Purpose: Test the ThalmorTriple.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    /// <summary>
    /// class represents tests for Thalmor Triple class
    /// </summary>
    public class ThalmorTripleTests
    {
        /// <summary>
        /// Tests to see if bun is a default option
        /// </summary>
        [Fact]
        public void ShouldIncludeBunByDefault()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.True(tt.Bun);
        }

        /// <summary>
        /// Tests to see if ketchup is a default option
        /// </summary>
        [Fact]
        public void ShouldIncludeKetchupByDefault()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.True(tt.Ketchup);
        }

        /// <summary>
        /// Tests to see if mustard is a default option
        /// </summary>
        [Fact]
        public void ShouldIncludeMustardByDefault()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.True(tt.Mustard);
        }

        /// <summary>
        /// Tests to see if pickles are a default option
        /// </summary>
        [Fact]
        public void ShouldIncludePickleByDefault()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.True(tt.Pickles);
        }

        /// <summary>
        /// Tests to see if cheese is a default option
        /// </summary>
        [Fact]
        public void ShouldIncludeCheeseByDefault()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.True(tt.Cheese);
        }

        /// <summary>
        /// Tests to see if tomato is a default option
        /// </summary>
        [Fact]
        public void ShouldIncludeTomatoByDefault()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.True(tt.Tomato);
        }

        /// <summary>
        /// Tests to see if lettuce is a default option
        /// </summary>
        [Fact]
        public void ShouldIncludeLettuceByDefault()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.True(tt.Lettuce);
        }

        /// <summary>
        /// Tests to see if mayo is a default option
        /// </summary>
        [Fact]
        public void ShouldIncludeMayoByDefault()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.True(tt.Mayo);
        }

        /// <summary>
        /// Tests to see if bacon is a default option
        /// </summary>
        [Fact]
        public void ShouldIncludeBaconByDefault()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.True(tt.Bacon);
        }

        /// <summary>
        /// Tests to see if egg is a default option
        /// </summary>
        [Fact]
        public void ShouldIncludeEggByDefault()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.True(tt.Egg);
        }

        /// <summary>
        /// Tests to see if bun can be set to true or false
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetBun()
        {
            ThalmorTriple tt = new ThalmorTriple();
            tt.Bun = true;
            Assert.True(tt.Bun);
            tt.Bun = false;
            Assert.False(tt.Bun);
        }

        /// <summary>
        /// Tests to see if ketchup can be set to true or false
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetKetchup()
        {
            ThalmorTriple tt = new ThalmorTriple();
            tt.Ketchup = true;
            Assert.True(tt.Ketchup);
            tt.Ketchup = false;
            Assert.False(tt.Ketchup);
        }

        /// <summary>
        /// Tests to see if mustard can be set to true or false
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetMustard()
        {
            ThalmorTriple tt = new ThalmorTriple();
            tt.Mustard = true;
            Assert.True(tt.Mustard);
            tt.Mustard = false;
            Assert.False(tt.Mustard);
        }

        /// <summary>
        /// Tests to see if pickle can be set to true or false
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetPickle()
        {
            ThalmorTriple tt = new ThalmorTriple();
            tt.Pickles = true;
            Assert.True(tt.Pickles);
            tt.Pickles = false;
            Assert.False(tt.Pickles);
        }

        /// <summary>
        /// Tests to see if cheese can be set to true or false
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetCheese()
        {
            ThalmorTriple tt = new ThalmorTriple();
            tt.Cheese = true;
            Assert.True(tt.Cheese);
            tt.Cheese = false;
            Assert.False(tt.Cheese);
        }

        /// <summary>
        /// Tests to see if tomato can be set to true or false
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetTomato()
        {
            ThalmorTriple tt = new ThalmorTriple();
            tt.Tomato = true;
            Assert.True(tt.Tomato);
            tt.Tomato = false;
            Assert.False(tt.Tomato);
        }

        /// <summary>
        /// Tests to see if lettuce can be set to true or false
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetLettuce()
        {
            ThalmorTriple tt = new ThalmorTriple();
            tt.Lettuce = true;
            Assert.True(tt.Lettuce);
            tt.Lettuce = false;
            Assert.False(tt.Lettuce);
        }

        /// <summary>
        /// Tests to see if mayo can be set to true or false
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetMayo()
        {
            ThalmorTriple tt = new ThalmorTriple();
            tt.Mayo = true;
            Assert.True(tt.Mayo);
            tt.Mayo = false;
            Assert.False(tt.Mayo);
        }

        /// <summary>
        /// Tests to see if bacon can be set to true or false
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetBacon()
        {
            ThalmorTriple tt = new ThalmorTriple();
            tt.Bacon = true;
            Assert.True(tt.Bacon);
            tt.Bacon = false;
            Assert.False(tt.Bacon);
        }

        /// <summary>
        /// Tests to see if egg can be set to true or false
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetEgg()
        {
            ThalmorTriple tt = new ThalmorTriple();
            tt.Egg = true;
            Assert.True(tt.Egg);
            tt.Egg = false;
            Assert.False(tt.Egg);
        }

        /// <summary>
        /// Tests if pricing matches
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.Equal(8.32, tt.Price);
        }

        /// <summary>
        /// Tests if calories match
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.Equal(943.0, tt.Calories);
        }

        /// <summary>
        /// tests for special instructions
        /// </summary>
        /// <param name="includeBun">bun parameter</param>
        /// <param name="includeKetchup">kecthup parameter</param>
        /// <param name="includeMustard">mustard parameter</param>
        /// <param name="includePickle">pickle parameter</param>
        /// <param name="includeCheese">cheese parameter</param>
        /// <param name="includeTomato">tomato parameter</param>
        /// <param name="includeLettuce">lettuce parameter</param>
        /// <param name="includeMayo">mayo parameter</param>
        /// <param name="includeBacon">bacon paramater</param>
        /// <param name="includeEgg">egg parameter</param>
        [Theory]
        [InlineData(true, true, true, true, true, true, true, true, true, true)]
        [InlineData(false, false, false, false, false, false, false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeBun, bool includeKetchup, bool includeMustard,
                                                                    bool includePickle, bool includeCheese, bool includeTomato,
                                                                    bool includeLettuce, bool includeMayo,
                                                                    bool includeBacon, bool includeEgg)
        {
            ThalmorTriple tt = new ThalmorTriple();
            tt.Bun = includeBun;
            tt.Ketchup = includeKetchup;
            tt.Mustard = includeMustard;
            tt.Pickles = includePickle;
            tt.Cheese = includeCheese;
            tt.Tomato = includeTomato;
            tt.Lettuce = includeLettuce;
            tt.Mayo = includeMayo;
            tt.Bacon = includeBacon;
            tt.Egg = includeEgg;
            if (includeBacon == true && includeEgg == true && includeTomato == true && includeLettuce == true && includeMayo == true && includeBun == true && includeKetchup == true && includeMustard == true && includePickle == true && includeCheese == true) Assert.Empty(tt.SpecialInstructions);
            else if (includeBun == false) Assert.Contains("Hold bun", tt.SpecialInstructions);
            else if (includeKetchup == false) Assert.Contains("Hold ketchup", tt.SpecialInstructions);
            else if (includeMustard == false) Assert.Contains("Hold mustard", tt.SpecialInstructions);
            else if (includePickle == false) Assert.Contains("Hold pickles", tt.SpecialInstructions);
            else if (includeCheese == false) Assert.Contains("Hold cheese", tt.SpecialInstructions);
            else if (includeTomato == false) Assert.Contains("Hold tomato", tt.SpecialInstructions);
            else if (includeLettuce == false) Assert.Contains("Hold lettuce", tt.SpecialInstructions);
            else if (includeMayo == false) Assert.Contains("Hold mayo", tt.SpecialInstructions);
            else if (includeBacon == false) Assert.Contains("Hold bacon", tt.SpecialInstructions);
            else if (includeEgg == false) Assert.Contains("Hold egg", tt.SpecialInstructions);
        }

        /// <summary>
        /// Tests if strings match
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectToString()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.Equal("Thalmor Triple", tt.ToString());
        }
    }
}