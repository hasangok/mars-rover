using System;
using Xunit;
using HB.RoverCase.Models;

namespace HB.RoverCase.Tests
{
    public class CommandTests
    {
        [Theory]
        [InlineData(Heading.North, 2, 3)]
        [InlineData(Heading.East, 3, 2)]
        [InlineData(Heading.South, 2, 1)]
        [InlineData(Heading.West, 1, 2)]
        public void Move_Command_Should_Change_Location_According_to_Heading(Heading input, int expectedX, int expectedY)
        {
            //arrange
            var location = new Location(2, 2, input);
            ICommand command = new MoveCommand(location);

            //act
            command.Execute();

            //assert
            Assert.Equal(location.GetX(), expectedX);
            Assert.Equal(location.GetY(), expectedY);
        }

        [Theory]
        [InlineData(Heading.North, Heading.East)]
        [InlineData(Heading.East, Heading.South)]
        [InlineData(Heading.South, Heading.West)]
        [InlineData(Heading.West, Heading.North)]
        public void Turn_Right_Command_Should_Change_Heading_Accordingly(Heading input, Heading expected)
        {
            //arrange
            var random = new Random();
            var location = new Location(random.Next(), random.Next(), input);
            ICommand command = new TurnRightCommand(location);

            //act
            command.Execute();

            //assert
            Assert.Equal(location.GetHeading(), expected);
        }

        [Theory]
        [InlineData(Heading.North, Heading.West)]
        [InlineData(Heading.West, Heading.South)]
        [InlineData(Heading.South, Heading.East)]
        [InlineData(Heading.East, Heading.North)]
        public void Turn_Left_Command_Should_Change_Heading_Accordingly(Heading input, Heading expected)
        {
            //arrange
            var random = new Random();
            var location = new Location(random.Next(), random.Next(), input);
            ICommand command = new TurnLeftCommand(location);

            //act
            command.Execute();

            //assert
            Assert.Equal(location.GetHeading(), expected);
        }
    }
}
