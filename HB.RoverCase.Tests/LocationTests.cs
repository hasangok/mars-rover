using System;
using Xunit;
using HB.RoverCase.Models;

namespace HB.RoverCase.Tests
{
    public class LocationTests
    {
        [Fact]
        public void Location_Should_Have_Positive_X_Value()
        {
            //arrange
            var random = new Random();

            //act
            var location = new Location(random.Next(), random.Next(), (Heading)random.Next(4));

            //assert
            Assert.True(location.GetX() >= 0, "Location should have a positive int value on X property");
        }

        [Fact]
        public void Location_Should_Have_Positive_Y_Value()
        {
            //arrange
            var random = new Random();

            //act
            var location = new Location(random.Next(), random.Next(), (Heading)random.Next(4));

            //assert
            Assert.True(location.GetY() >= 0, "Location should have a positive int value on Y property");
        }

        [Fact]
        public void Location_Should_Have_A_Valid_Heading_Value()
        {
            //arrange
            var random = new Random();

            //act
            var location = new Location(random.Next(), random.Next(), (Heading)random.Next(4));

            //assert
            Assert.True((int)location.GetHeading() >= 0 && (int)location.GetHeading() <= 3, "Location should have a valid heading value");
            Assert.False((int)location.GetHeading() < 0 || (int)location.GetHeading() > 3, "Location should have a valid heading value");
        }

        [Theory]
        [InlineData(Heading.North, Heading.West)]
        [InlineData(Heading.West, Heading.South)]
        [InlineData(Heading.South, Heading.East)]
        [InlineData(Heading.East, Heading.North)]
        public void Location_Turn_Left_Behavior(Heading input, Heading expected)
        {
            //arrange
            var random = new Random();

            //act
            var location = new Location(random.Next(), random.Next(), input);
            location.TurnLeft();

            //assert
            Assert.Equal(location.GetHeading(), expected);
        }

        [Theory]
        [InlineData(Heading.North, Heading.East)]
        [InlineData(Heading.East, Heading.South)]
        [InlineData(Heading.South, Heading.West)]
        [InlineData(Heading.West, Heading.North)]
        public void Location_Turn_Right_Behavior(Heading input, Heading expected)
        {
            //arrange
            var random = new Random();

            //act
            var location = new Location(random.Next(), random.Next(), input);
            location.TurnRight();

            //assert
            Assert.Equal(location.GetHeading(), expected);
        }

        [Theory]
        [InlineData(Heading.North, 2, 3)]
        [InlineData(Heading.East, 3, 2)]
        [InlineData(Heading.South, 2, 1)]
        [InlineData(Heading.West, 1, 2)]
        public void Location_Movement_Behavior(Heading input, int expectedX, int expectedY)
        {
            //arrange
            var location = new Location(2, 2, input);

            //act
            location.Move();

            //assert
            Assert.Equal(location.GetX(), expectedX);
            Assert.Equal(location.GetY(), expectedY);
        }
    }
}
