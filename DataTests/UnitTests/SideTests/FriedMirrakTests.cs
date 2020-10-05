/*
 * Author: Jordan Austin
 * Class: FriedMiraakTests.cs
 * Purpose: Test the FriedMiraak.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.DataTests.UnitTests.SideTests
{
    /// <summary>
    /// represents fried miraak tests
    /// </summary>
    public class FriedMiraakTests
    {
        /// <summary>
        /// checks if object is a side
        /// </summary>
        [Fact]
        public void ShouldBeASide()
        {
            FriedMiraak fm = new FriedMiraak();
            Assert.IsAssignableFrom<Side>(fm);
        }
        /// <summary>
        /// checks if default size is small
        /// </summary>
        [Fact]
        public void ShouldBeSmallByDefault()
        {
            FriedMiraak fm = new FriedMiraak();
            Assert.Equal(Size.Small, fm.Size);
        }

        /// <summary>
        /// checks if size can be changed
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            FriedMiraak fm = new FriedMiraak();
            fm.Size = Size.Large;
            Assert.Equal(Size.Large, fm.Size);
            fm.Size = Size.Medium;
            Assert.Equal(Size.Medium, fm.Size);
            fm.Size = Size.Small;
            Assert.Equal(Size.Small, fm.Size);
        }

        /// <summary>
        /// Checks special instructions
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectSpecialInstructions()
        {
            FriedMiraak fm = new FriedMiraak();
            Assert.Empty(fm.SpecialInstructions);
        }

        /// <summary>
        /// checks if price and size are in sync
        /// </summary>
        /// <param name="size">size of side</param>
        /// <param name="price">price of side</param>
        [Theory]
        [InlineData(Size.Small, 1.78)]
        [InlineData(Size.Medium, 2.01)]
        [InlineData(Size.Large, 2.88)]
        public void ShouldReturnCorrectPriceBasedOnSize(Size size, double price)
        {
            FriedMiraak fm = new FriedMiraak();
            fm.Size = size;
            Assert.Equal(price, fm.Price);
        }

        /// <summary>
        /// checks if calories and size are in sync
        /// </summary>
        /// <param name="size">size of side</param>
        /// <param name="calories">calories in side</param>
        [Theory]
        [InlineData(Size.Small, 151)]
        [InlineData(Size.Medium, 236)]
        [InlineData(Size.Large, 306)]
        public void ShouldReturnCorrectCaloriesBasedOnSize(Size size, uint calories)
        {
            FriedMiraak fm = new FriedMiraak();
            fm.Size = size;
            Assert.Equal(calories, fm.Calories);
        }

        /// <summary>
        /// checks if string returned is correct
        /// </summary>
        /// <param name="size">size of side</param>
        /// <param name="name">name of side</param>
        [Theory]
        [InlineData(Size.Small, "Small Fried Miraak")]
        [InlineData(Size.Medium, "Medium Fried Miraak")]
        [InlineData(Size.Large, "Large Fried Miraak")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            FriedMiraak fm = new FriedMiraak();
            fm.Size = size;
            Assert.Equal(name, fm.ToString());
        }

        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void ChangingSizeNotifiesSizeProperty(Size size)
        {
            var aj = new FriedMiraak();
            Assert.PropertyChanged(aj, "Size", () => aj.Size = size);
        }

        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void ChangingSizeNotifiesCaloriesProperty(Size size)
        {
            var aj = new FriedMiraak();
            Assert.PropertyChanged(aj, "Calories", () => aj.Size = size);
        }

        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void ChangingSizeNotifiesPriceProperty(Size size)
        {
            var aj = new FriedMiraak();
            Assert.PropertyChanged(aj, "Price", () => aj.Size = size);
        }

        /// <summary>
        /// Implements the INotify Property Change
        /// </summary>
        [Fact]
        public void ImplementsINotifyPropertyChange()
        {
            var bb = new FriedMiraak();
            Assert.IsAssignableFrom<System.ComponentModel.INotifyPropertyChanged>(bb);
        }
    }
}