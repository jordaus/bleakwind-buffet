/*
 * Author: Jordan Austin
 * Class: SmokehouseSkeletonTests.cs
 * Purpose: Test the SmokehouseSkeleton.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    /// <summary>
    /// class represents the tests for the Smokehouse Skeleton class
    /// </summary>
    public class SmokehouseSkeletonTests
    {
        /// <summary>
        /// tests to see if sausage is a default option
        /// </summary>
        [Fact]
        public void ShouldInlcudeSausageByDefault()
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            Assert.True(ss.SausageLink);
        }

        /// <summary>
        /// tests to see if egg is a default option
        /// </summary>
        [Fact]
        public void ShouldInlcudeEggByDefault()
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            Assert.True(ss.Egg);
        }

        /// <summary>
        /// tests to see if hash browns is a default option
        /// </summary>
        [Fact]
        public void ShouldInlcudeHashbrownsByDefault()
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            Assert.True(ss.HashBrowns);
        }

        /// <summary>
        /// tests to see if pancakes is a default option
        /// </summary>
        [Fact]
        public void ShouldInlcudePancakeByDefault()
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            Assert.True(ss.Pancake);
        }

        /// <summary>
        /// tests to see if sausage can be set
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetSausage()
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            ss.SausageLink = true;
            Assert.True(ss.SausageLink);
            ss.SausageLink = false;
            Assert.False(ss.SausageLink);
        }

        /// <summary>
        /// tests to see if egg can be set
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetEgg()
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            ss.Egg = true;
            Assert.True(ss.Egg);
            ss.Egg = false;
            Assert.False(ss.Egg);
        }

        /// <summary>
        /// tests to see if hash browns can be set
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetHashbrowns()
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            ss.HashBrowns = true;
            Assert.True(ss.HashBrowns);
            ss.HashBrowns = false;
            Assert.False(ss.HashBrowns);
        }

        /// <summary>
        /// test to see if pancakes can be set
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetPancake()
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            ss.Pancake = true;
            Assert.True(ss.Pancake);
            ss.Pancake = false;
            Assert.False(ss.Pancake);
        }

        /// <summary>
        /// tests to see if price can be returned correctly
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            Assert.Equal(5.62, ss.Price);
        }

        /// <summary>
        /// tests to see if calories can be returned correctly
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectCalories()
        {
        }

        /// <summary>
        /// tests the special instructions
        /// </summary>
        /// <param name="includeSausage">sausage parameter</param>
        /// <param name="includeEgg">egg parameter</param>
        /// <param name="includeHashbrowns">hashbrown parameter</param>
        /// <param name="includePancake">pancake parameter</param>
        [Theory]
        [InlineData(true, true, true, true)]
        [InlineData(false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeSausage, bool includeEgg,
                                                            bool includeHashbrowns, bool includePancake)
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            ss.SausageLink = includeSausage;
            ss.Egg = includeEgg;
            ss.HashBrowns = includeHashbrowns;
            ss.Pancake = includePancake;
            if (includeSausage == true && includeEgg == true && includeHashbrowns == true && includePancake == true) Assert.Empty(ss.SpecialInstructions);
            if (includeSausage == false) Assert.Contains("Hold sausage", ss.SpecialInstructions);
            if (includeEgg == false) Assert.Contains("Hold egg", ss.SpecialInstructions);
            if (includeHashbrowns == false) Assert.Contains("Hold hash browns", ss.SpecialInstructions);
            if (includePancake == false) Assert.Contains("Hold pancakes", ss.SpecialInstructions);
        }

        /// <summary>
        /// tests if the string returns correctly
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectToString()
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            Assert.Equal("Smokehouse Skeleton", ss.ToString());
        }
    }
}