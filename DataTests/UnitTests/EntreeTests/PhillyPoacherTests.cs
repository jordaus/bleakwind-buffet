/*
 * Author: Jordan Austin
 * Class: PhillyPoacherTests.cs
 * Purpose: Test the PhillyPoacher.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    /// <summary>
    /// class represents test cases for Philly Poacher
    /// </summary>
    public class PhillyPoacherTests
    {
        /// <summary>
        /// checks to see if entree is an object
        /// </summary>
        [Fact]
        public void ShouldBeAnEntree()
        {
            PhillyPoacher pp = new PhillyPoacher();
            Assert.IsAssignableFrom<Entree>(pp);
        }

        /// <summary>
        /// tests to see if sirloin is a default option
        /// </summary>
        [Fact]
        public void ShouldInlcudeSirloinByDefault()
        {
            PhillyPoacher pp = new PhillyPoacher();
            Assert.True(pp.Sirloin);
        }

        /// <summary>
        /// tests to see if onion is a default option
        /// </summary>
        [Fact]
        public void ShouldInlcudeOnionByDefault()
        {
            PhillyPoacher pp = new PhillyPoacher();
            Assert.True(pp.Onion);
        }

        /// <summary>
        /// tests to see if roll is a default option
        /// </summary>
        [Fact]
        public void ShouldInlcudeRollByDefault()
        {
            PhillyPoacher pp = new PhillyPoacher();
            Assert.True(pp.Roll);
        }

        /// <summary>
        /// tests to see if sirloin can be set
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetSirloin()
        {
            PhillyPoacher pp = new PhillyPoacher();
            pp.Sirloin = true;
            Assert.True(pp.Sirloin);
            pp.Sirloin = false;
            Assert.False(pp.Sirloin);
        }

        /// <summary>
        /// tests to see if onions can be set
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetOnions()
        {
            PhillyPoacher pp = new PhillyPoacher();
            pp.Onion = true;
            Assert.True(pp.Onion);
            pp.Onion = false;
            Assert.False(pp.Onion);
        }

        /// <summary>
        /// tests to see if roll can be set
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetRoll()
        {
            PhillyPoacher pp = new PhillyPoacher();
            pp.Roll = true;
            Assert.True(pp.Roll);
            pp.Roll = false;
            Assert.False(pp.Roll);
        }

        /// <summary>
        /// test to see if price returns correctly
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            PhillyPoacher pp = new PhillyPoacher();
            Assert.Equal(7.23, pp.Price);
        }

        /// <summary>
        /// tests to see if calories returns correctly
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            PhillyPoacher pp = new PhillyPoacher();
            Assert.Equal(784.0, pp.Calories);
        }

        /// <summary>
        /// tests the special instructions
        /// </summary>
        /// <param name="includeSirloin">sirloin parameter</param>
        /// <param name="includeOnion">onion parameter</param>
        /// <param name="includeRoll">roll parameter</param>
        [Theory]
        [InlineData(true, true, true)]
        [InlineData(false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeSirloin, bool includeOnion,
                                                            bool includeRoll)
        {
            PhillyPoacher pp = new PhillyPoacher();
            pp.Sirloin = includeSirloin;
            pp.Onion = includeOnion;
            pp.Roll = includeRoll;
            if (includeSirloin == true && includeOnion == true && includeRoll == true) Assert.Empty(pp.SpecialInstructions);
            else if (includeSirloin == false) Assert.Contains("Hold sirloin", pp.SpecialInstructions);
            else if (includeOnion == false) Assert.Contains("Hold onion", pp.SpecialInstructions);
            else if (includeRoll == false) Assert.Contains("Hold roll", pp.SpecialInstructions);
        }

        /// <summary>
        /// tests if string returns correctly
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectToString()
        {
            PhillyPoacher pp = new PhillyPoacher();
            Assert.Equal("Philly Poacher", pp.ToString());
        }

        /// <summary>
        /// Checks if sirloin property is notified
        /// </summary>
        [Fact]
        public void ChangingSirloinNotifiesSirloinProperty()
        {
            var bb = new PhillyPoacher();

            Assert.PropertyChanged(bb, "Sirloin", () =>
            {
                bb.Sirloin = true;
            });

            Assert.PropertyChanged(bb, "Sirloin", () =>
            {
                bb.Sirloin = false;
            });
        }

        /// <summary>
        /// Checks if onion property is notified
        /// </summary>
        [Fact]
        public void ChangingOnionNotifiesOnionProperty()
        {
            var bb = new PhillyPoacher();

            Assert.PropertyChanged(bb, "Onion", () =>
            {
                bb.Onion = true;
            });

            Assert.PropertyChanged(bb, "Onion", () =>
            {
                bb.Onion = false;
            });
        }

        /// <summary>
        /// Checks if roll property is notified
        /// </summary>
        [Fact]
        public void ChangingRollNotifiesRollProperty()
        {
            var bb = new PhillyPoacher();

            Assert.PropertyChanged(bb, "Roll", () =>
            {
                bb.Roll = true;
            });

            Assert.PropertyChanged(bb, "Roll", () =>
            {
                bb.Roll = false;
            });
        }

        /// <summary>
        /// Implements the INotify Property Change
        /// </summary>
        [Fact]
        public void ImplementsINotifyPropertyChange()
        {
            PhillyPoacher bb = new PhillyPoacher();
            Assert.IsAssignableFrom<System.ComponentModel.INotifyPropertyChanged>(bb);
        }
    }
}