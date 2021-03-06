﻿/*
 * Author: Jordan Austin
 * Class: GardenOrcOmeletteTests.cs
 * Purpose: Test the GardenOrcOmelette.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    /// <summary>
    /// class tests for Garden Orc Omelette class
    /// </summary>
    public class GardenOrcOmeletteTests
    {
        /// <summary>
        /// checks to see if object is an entree
        /// </summary>
        [Fact]
        public void ShouldBeAnEntree()
        {
            GardenOrcOmelette goo = new GardenOrcOmelette();
            Assert.IsAssignableFrom<Entree>(goo);
        }

        /// <summary>
        /// tests if broccoli is a default option
        /// </summary>
        [Fact]
        public void ShouldInlcudeBroccoliByDefault()
        {
            GardenOrcOmelette goo = new GardenOrcOmelette();
            Assert.True(goo.Broccoli);
        }

        /// <summary>
        /// tests if mushrooms is a default option
        /// </summary>
        [Fact]
        public void ShouldInlcudeMushroomsByDefault()
        {
            GardenOrcOmelette goo = new GardenOrcOmelette();
            Assert.True(goo.Mushrooms);
        }

        /// <summary>
        /// tests if tomatos is a default option
        /// </summary>
        [Fact]
        public void ShouldInlcudeTomatoByDefault()
        {
            GardenOrcOmelette goo = new GardenOrcOmelette();
            Assert.True(goo.Tomato);
        }

        /// <summary>
        /// tests if cheddar is a default option
        /// </summary>
        [Fact]
        public void ShouldInlcudeCheddarByDefault()
        {
            GardenOrcOmelette goo = new GardenOrcOmelette();
            Assert.True(goo.Cheddar);
        }

        /// <summary>
        /// tests if broccoli options can be changed
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetBroccoli()
        {
            GardenOrcOmelette goo = new GardenOrcOmelette();
            goo.Broccoli = true;
            Assert.True(goo.Broccoli);
            goo.Broccoli = false;
            Assert.False(goo.Broccoli);
        }

        /// <summary>
        /// tests if mushrooms option can be changed
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetMushrooms()
        {
            GardenOrcOmelette goo = new GardenOrcOmelette();
            goo.Mushrooms = true;
            Assert.True(goo.Mushrooms);
            goo.Mushrooms = false;
            Assert.False(goo.Mushrooms);
        }

        /// <summary>
        /// tests if tomatos option can be changed
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetTomato()
        {
            GardenOrcOmelette goo = new GardenOrcOmelette();
            goo.Tomato = true;
            Assert.True(goo.Tomato);
            goo.Tomato = false;
            Assert.False(goo.Tomato);
        }

        /// <summary>
        /// tests if cheddar option can be changed
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetCheddar()
        {
            GardenOrcOmelette goo = new GardenOrcOmelette();
            goo.Cheddar = true;
            Assert.True(goo.Cheddar);
            goo.Cheddar = false;
            Assert.False(goo.Cheddar);
        }

        /// <summary>
        /// tests if price can be returned correctly
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            GardenOrcOmelette goo = new GardenOrcOmelette();
            Assert.Equal(4.57, goo.Price);
        }

        /// <summary>
        /// tests if calories can be returned correctly
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            GardenOrcOmelette goo = new GardenOrcOmelette();
            Assert.Equal(404.0, goo.Calories);
        }

        /// <summary>
        /// tests if special instructions work
        /// </summary>
        /// <param name="includeBroccoli">broccoli parameter</param>
        /// <param name="includeMushrooms">mushrooms parameter</param>
        /// <param name="includeTomato">tomato paramater</param>
        /// <param name="includeCheddar">cheddar parameter</param>
        [Theory]
        [InlineData(true, true, true, true)]
        [InlineData(false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeBroccoli, bool includeMushrooms,
                                                            bool includeTomato, bool includeCheddar)
        {
            GardenOrcOmelette goo = new GardenOrcOmelette();
            goo.Broccoli = includeBroccoli;
            goo.Mushrooms = includeMushrooms;
            goo.Tomato = includeTomato;
            goo.Cheddar = includeCheddar;
            if (includeBroccoli == true && includeMushrooms == true && includeTomato == true && includeCheddar == true) Assert.Empty(goo.SpecialInstructions);
            else if (includeBroccoli == false) Assert.Contains("Hold broccoli", goo.SpecialInstructions);
            else if (includeMushrooms == false) Assert.Contains("Hold mushrooms", goo.SpecialInstructions);
            else if (includeTomato == false) Assert.Contains("Hold tomato", goo.SpecialInstructions);
            else if (includeCheddar == false) Assert.Contains("Hold cheddar", goo.SpecialInstructions);
        }

        /// <summary>
        /// tests if string is retured correctly
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectToString()
        {
            GardenOrcOmelette goo = new GardenOrcOmelette();
            Assert.Equal("Garden Orc Omelette", goo.ToString());
        }

        /// <summary>
        /// Checks if tomato property is notified
        /// </summary>
        [Fact]
        public void ChangingTomatoNotifiesTomatoProperty()
        {
            var bb = new GardenOrcOmelette();

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
        /// Checks if mushrooms property is notified
        /// </summary>
        [Fact]
        public void ChangingMushroomsNotifiesMushroomsProperty()
        {
            var bb = new GardenOrcOmelette();

            Assert.PropertyChanged(bb, "Mushrooms", () =>
            {
                bb.Mushrooms = true;
            });

            Assert.PropertyChanged(bb, "Mushrooms", () =>
            {
                bb.Mushrooms = false;
            });
        }

        /// <summary>
        /// Checks if broccoli property is notified
        /// </summary>
        [Fact]
        public void ChangingBroccoliNotifiesBroccoliProperty()
        {
            var bb = new GardenOrcOmelette();

            Assert.PropertyChanged(bb, "Broccoli", () =>
            {
                bb.Broccoli = true;
            });

            Assert.PropertyChanged(bb, "Broccoli", () =>
            {
                bb.Broccoli = false;
            });
        }

        /// <summary>
        /// Checks if cheddar property is notified
        /// </summary>
        [Fact]
        public void ChangingCheddarNotifiesCheedarProperty()
        {
            var bb = new GardenOrcOmelette();

            Assert.PropertyChanged(bb, "Cheddar", () =>
            {
                bb.Cheddar = true;
            });

            Assert.PropertyChanged(bb, "Cheddar", () =>
            {
                bb.Cheddar = false;
            });
        }

        /// <summary>
        /// Implements the INotify Property Change
        /// </summary>
        [Fact]
        public void ImplementsINotifyPropertyChange()
        {
            GardenOrcOmelette bb = new GardenOrcOmelette();
            Assert.IsAssignableFrom<System.ComponentModel.INotifyPropertyChanged>(bb);
        }
    }
}