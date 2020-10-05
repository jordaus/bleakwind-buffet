/*
 * Author: Jordan Austin
 * Class: VokunSaladTests.cs
 * Purpose: Test the VokunSalad.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.DataTests.UnitTests.SideTests
{
    /// <summary>
    /// represents salad test class
    /// </summary>
    public class VokunSaladTests
    {
        /// <summary>
        /// Checks to see if object is a side
        /// </summary>
        [Fact]
        public void ShouldBeASide()
        {
            VokunSalad vs = new VokunSalad();
            Assert.IsAssignableFrom<Side>(vs);
        }

        /// <summary>
        /// checks if small is default size
        /// </summary>
        [Fact]
        public void ShouldBeSmallByDefault()
        {
            VokunSalad vs = new VokunSalad();
            Assert.Equal(Size.Small, vs.Size);
        }

        /// <summary>
        /// Checks if side can be changed
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            VokunSalad vs = new VokunSalad();
            vs.Size = Size.Large;
            Assert.Equal(Size.Large, vs.Size);
            vs.Size = Size.Medium;
            Assert.Equal(Size.Medium, vs.Size);
            vs.Size = Size.Small;
            Assert.Equal(Size.Small, vs.Size);
        }

        /// <summary>
        /// Checks if special instructions are correct
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectSpecialInstructions()
        {
            VokunSalad vs = new VokunSalad();
            Assert.Empty(vs.SpecialInstructions);
        }

        /// <summary>
        /// checks if price and size are in sync
        /// </summary>
        /// <param name="size">size of side</param>
        /// <param name="price">price of side</param>
        [Theory]
        [InlineData(Size.Small, 0.93)]
        [InlineData(Size.Medium, 1.28)]
        [InlineData(Size.Large, 1.82)]
        public void ShouldReturnCorrectPriceBasedOnSize(Size size, double price)
        {
            VokunSalad vs = new VokunSalad();
            vs.Size = size;
            Assert.Equal(price, vs.Price);
        }

        /// <summary>
        /// checks if calories and size are in sync
        /// </summary>
        /// <param name="size">size of side</param>
        /// <param name="calories">calories in side</param>
        [Theory]
        [InlineData(Size.Small, 41)]
        [InlineData(Size.Medium, 52)]
        [InlineData(Size.Large, 73)]
        public void ShouldReturnCorrectCaloriesBasedOnSize(Size size, uint calories)
        {
            VokunSalad vs = new VokunSalad();
            vs.Size = size;
            Assert.Equal(calories, vs.Calories);
        }

        /// <summary>
        /// checks if string returned is correct
        /// </summary>
        /// <param name="size">size of side</param>
        /// <param name="name">name of side</param>
        [Theory]
        [InlineData(Size.Small, "Small Vokun Salad")]
        [InlineData(Size.Medium, "Medium Vokun Salad")]
        [InlineData(Size.Large, "Large Vokun Salad")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            VokunSalad vs = new VokunSalad();
            vs.Size = size;
            Assert.Equal(name, vs.ToString());
        }

        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void ChangingSizeNotifiesSizeProperty(Size size)
        {
            var aj = new VokunSalad();
            Assert.PropertyChanged(aj, "Size", () => aj.Size = size);
        }

        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void ChangingSizeNotifiesCaloriesProperty(Size size)
        {
            var aj = new VokunSalad();
            Assert.PropertyChanged(aj, "Calories", () => aj.Size = size);
        }

        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void ChangingSizeNotifiesPriceProperty(Size size)
        {
            var aj = new VokunSalad();
            Assert.PropertyChanged(aj, "Price", () => aj.Size = size);
        }

        /// <summary>
        /// Implements the INotify Property Change
        /// </summary>
        [Fact]
        public void ImplementsINotifyPropertyChange()
        {
            var bb = new VokunSalad();
            Assert.IsAssignableFrom<System.ComponentModel.INotifyPropertyChanged>(bb);
        }
    }
}