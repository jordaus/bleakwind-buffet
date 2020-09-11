/*
 * Author: Jordan Austin
 * Class: WarriorWaterTests.cs
 * Purpose: Test the WarriorWater.cs class in the Data library
 */
using System;
using System.Collections.Generic;
using System.Text;

using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.DataTests.UnitTests.DrinkTests
{
    /// <summary>
    /// represents test for water
    /// </summary>
    public class WarriorWaterTests
    {
        /// <summary>
        /// Tests to see if object is a drink
        /// </summary>
        [Fact]
        public void ShouldBeADrink()
        {
            WarriorWater ww = new WarriorWater();
            Assert.IsAssignableFrom<Drink>(ww);
        }

        /// <summary>
        /// Tests to see if Ice is a default
        /// </summary>
        [Fact]
        public void ShouldIncludeIceByDefault()
        {
            WarriorWater ww = new WarriorWater();
            Assert.True(ww.Ice);
        }

        /// <summary>
        /// Tests to see if no lemon is a default
        /// </summary>
        [Fact]
        public void ShouldNotIncludeLemonByDefault()
        {
            WarriorWater ww = new WarriorWater();
            Assert.False(ww.Lemon);
        }

        /// <summary>
        /// Tests to see if the default size is small
        /// </summary>
        [Fact]
        public void ShouldBeSmallByDefault()
        {
            WarriorWater ww = new WarriorWater();
            Assert.Equal(Size.Small, ww.Size);
        }

        /// <summary>
        /// Tests to see if Ice can be added or not
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetIce()
        {
            WarriorWater ww = new WarriorWater();
            ww.Ice = true;
            Assert.True(ww.Ice);
            ww.Ice = false;
            Assert.False(ww.Ice);
        }

        /// <summary>
        /// Sets size to various sizes
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            WarriorWater ww = new WarriorWater();
            ww.Size = Size.Large;
            Assert.Equal(Size.Large, ww.Size);
            ww.Size = Size.Medium;
            Assert.Equal(Size.Medium, ww.Size);
            ww.Size = Size.Small;
            Assert.Equal(Size.Small, ww.Size);
        }

        /// <summary>
        /// makes sure the size and prices are synced correctly
        /// </summary>
        /// <param name="size">size of drink</param>
        /// <param name="price">price of drink</param>
        [Theory]
        [InlineData(Size.Small, 0)]
        [InlineData(Size.Medium, 0)]
        [InlineData(Size.Large, 0)]
        public void ShouldHaveCorrectPriceForSize(Size size, double price)
        {
            WarriorWater ww = new WarriorWater();
            ww.Size = size;
            Assert.Equal(price, ww.Price);
        }

        /// <summary>
        /// Checks if size and calories are synced correctly
        /// </summary>
        /// <param name="size">size of drink</param>
        /// <param name="cal">calories of drink</param>
        [Theory]
        [InlineData(Size.Small, 0)]
        [InlineData(Size.Medium, 0)]
        [InlineData(Size.Large, 0)]
        public void ShouldHaveCorrectCaloriesForSize(Size size, uint cal)
        {
            WarriorWater ww = new WarriorWater();
            ww.Size = size;
            Assert.Equal(cal, ww.Calories);
        }

        /// <summary>
        /// checks special instructions are used correctly
        /// </summary>
        /// <param name="includeIce">ice check</param>
        /// <param name="includeLemon">lemon check</param>
        [Theory]
        [InlineData(true, true)]
        [InlineData(true, false)]
        [InlineData(false, true)]
        [InlineData(false, false)]
        public void ShouldHaveCorrectSpecialInstructions(bool includeIce, bool includeLemon)
        {
            WarriorWater ww = new WarriorWater();
            ww.Ice = includeIce;
            ww.Lemon = includeLemon;
            if (includeIce == true && includeLemon == false) Assert.Empty(ww.SpecialInstructions);
            else if (includeIce == false) Assert.Contains("Hold ice", ww.SpecialInstructions);
            else if (includeLemon == true) Assert.Contains("Add lemon", ww.SpecialInstructions);
        }

        /// <summary>
        /// Checks if string is returned correctly
        /// </summary>
        /// <param name="size">size of drink</param>
        /// <param name="name">name of drink</param>
        [Theory]
        [InlineData(Size.Small, "Small Warrior Water")]
        [InlineData(Size.Medium, "Medium Warrior Water")]
        [InlineData(Size.Large, "Large Warrior Water")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            WarriorWater ww = new WarriorWater();
            ww.Size = size;
            Assert.Equal(name, ww.ToString());
        }
    }
}
