using System;
using Xunit;
using HB.RoverCase.Models;
using HB.RoverCase.Extensions;

namespace HB.RoverCase.Tests
{
    public class ExtensionTests
    {
        [Theory]
        [InlineData("1 2 N", 1)]
        [InlineData("5 11 S", 5)]
        public void GetX_Extension_Should_Return_First_Number_As_Integer(string input, int expected)
        {
            //act
            int value = input.GetX();

            //assert
            Assert.IsAssignableFrom(typeof(int), value);
            Assert.Equal(value, expected);
        }

        [Theory]
        [InlineData("1 2 E", 2)]
        [InlineData("5 11 W", 11)]
        public void GetY_Extension_Should_Return_Second_Number_As_Integer(string input, int expected)
        {
            //act
            int value = input.GetY();

            //assert
            Assert.IsAssignableFrom(typeof(int), value);
            Assert.Equal(value, expected);
        }

        [Theory]
        [InlineData("1 2 N", Heading.North)]
        [InlineData("5 11 E", Heading.East)]
        [InlineData("5 11 S", Heading.South)]
        [InlineData("5 11 W", Heading.West)]
        public void GetHeading_Extension_Should_Return_Heading_Value(string input, Heading expected)
        {
            //act
            Heading value = input.GetHeading();

            //assert
            Assert.IsAssignableFrom(typeof(Heading), value);
            Assert.Equal(value, expected);
        }
    }
}
