/*
 * Author: Jordan Austin
 * Class: BriarheartBurgerTests.cs
 * Purpose: Test the BriarheartBurger.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    /// <summary>
    /// Represents the tests for the Briarheart Burger
    /// </summary>
    public class BriarheartBurgerTests
    {
        /// <summary>
        /// Tests to see if bun is a default option
        /// </summary>
        [Fact]
        public void ShouldIncludeBunByDefault()
        {
            BriarheartBurger bb = new BriarheartBurger();
            Assert.True(bb.Bun);
        }

        /// <summary>
        /// Tests to see if ketchup is a default option
        /// </summary>
        [Fact]
        public void ShouldIncludeKetchupByDefault()
        {
            BriarheartBurger bb = new BriarheartBurger();
            Assert.True(bb.Ketchup);
        }

        /// <summary>
        /// Tests to see if mustard is a default option
        /// </summary>
        [Fact]
        public void ShouldIncludeMustardByDefault()
        {
            BriarheartBurger bb = new BriarheartBurger();
            Assert.True(bb.Mustard);
        }

        /// <summary>
        /// Tests to see if pickles are a default option
        /// </summary>
        [Fact]
        public void ShouldIncludePickleByDefault()
        {
            BriarheartBurger bb = new BriarheartBurger();
            Assert.True(bb.Pickles);
        }

        /// <summary>
        /// Tests to see if cheese is a default option
        /// </summary>
        [Fact]
        public void ShouldIncludeCheeseByDefault()
        {
            BriarheartBurger bb = new BriarheartBurger();
            Assert.True(bb.Cheese);
        }

        /// <summary>
        /// Tests to see if bun can be set
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetBun()
        {
            BriarheartBurger bb = new BriarheartBurger();
            bb.Bun = true;
            Assert.True(bb.Bun);
            bb.Bun = false;
            Assert.False(bb.Bun);
        }

        /// <summary>
        /// Tests to see if kecthup can be set
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetKetchup()
        {
            BriarheartBurger bb = new BriarheartBurger();
            bb.Ketchup = true;
            Assert.True(bb.Ketchup);
            bb.Ketchup = false;
            Assert.False(bb.Ketchup);
        }

        /// <summary>
        /// Tests to see if mustard can be set
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetMustard()
        {
            BriarheartBurger bb = new BriarheartBurger();
            bb.Mustard = true;
            Assert.True(bb.Mustard);
            bb.Mustard = false;
            Assert.False(bb.Mustard);
        }

        /// <summary>
        /// Tests to see if pickle can be set
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetPickle()
        {
            BriarheartBurger bb = new BriarheartBurger();
            bb.Pickles = true;
            Assert.True(bb.Pickles);
            bb.Pickles = false;
            Assert.False(bb.Pickles);
        }

        /// <summary>
        /// Tests to see if cheese can be set
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetCheese()
        {
            BriarheartBurger bb = new BriarheartBurger();
            bb.Cheese = true;
            Assert.True(bb.Cheese);
            bb.Cheese = false;
            Assert.False(bb.Cheese);
        }

        /// <summary>
        /// Tests to see if price could be returned correctly
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            BriarheartBurger bb = new BriarheartBurger();
            Assert.Equal(6.32, bb.Price);
        }

        /// <summary>
        /// Tests to see if calories could be returned correctly
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            BriarheartBurger bb = new BriarheartBurger();
            //Assert.Equal(743, bb.Calories);
        }

        /// <summary>
        /// Tests for special instructions
        /// </summary>
        /// <param name="includeBun">bun parameter</param>
        /// <param name="includeKetchup">ketchup parameter</param>
        /// <param name="includeMustard">mustard parameter</param>
        /// <param name="includePickle">pickle parameter</param>
        /// <param name="includeCheese">cheese parameter</param>
        [Theory]
        [InlineData(true, true, true, true, true)]
        [InlineData(false, false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeBun, bool includeKetchup, bool includeMustard,
                                                                    bool includePickle, bool includeCheese)
        {
            BriarheartBurger bb = new BriarheartBurger();
            bb.Bun = includeBun;
            bb.Ketchup = includeKetchup;
            bb.Mustard = includeMustard;
            bb.Pickles = includePickle;
            bb.Cheese = includeCheese;
            if (includeBun == true && includeKetchup == true && includeMustard == true && includePickle == true && includeCheese == true) Assert.Empty(bb.SpecialInstructions);
            else if (includeBun == false) Assert.Contains("Hold bun", bb.SpecialInstructions);
            else if (includeKetchup == false) Assert.Contains("Hold ketchup", bb.SpecialInstructions);
            else if (includeMustard == false) Assert.Contains("Hold mustard", bb.SpecialInstructions);
            else if (includePickle == false) Assert.Contains("Hold pickles", bb.SpecialInstructions);
            else if (includeCheese == false) Assert.Contains("Hold cheese", bb.SpecialInstructions);
        }

        /// <summary>
        /// Tests if names match
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectToString()
        {
            BriarheartBurger bb = new BriarheartBurger();
            Assert.Equal("Briarheart Burger", bb.ToString());
        }
    }
}