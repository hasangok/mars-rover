using System;
using Xunit;
using HB.RoverCase.Models;
using HB.RoverCase.Extensions;
using System.Collections.Generic;

namespace HB.RoverCase.Tests
{
    public class CommandExtensionTest
    {
        // every M command creates an additional CheckBoundriesCommand
        [Theory]
        [InlineData("LMLMLMLMM", 14)]
        [InlineData("MMRMMRMRRM", 16)]
        public void Input_String_Should_Parsed_To_Commands(string input, int commandCountInList)
        {
            //arrange
            var plateau = new Plateau(10, 10);
            var location = new Location(5, 5, Heading.West);
            var rover = new Rover(location, plateau);
            //act
            var commands = input.GetCommandsFromInputString(rover);

            //assert
            Assert.IsAssignableFrom(typeof(List<ICommand>), commands);
            Assert.Equal(commands.Count, commandCountInList);
        }

    }
}
