using System;
using System.Collections.Generic;
using HB.RoverCase.Models;

namespace HB.RoverCase.Extensions
{
    public static class CommandExtensions
    {
        public static List<ICommand> GetCommandsFromInputString(this string command, Rover rover)
        {
            var commands = new List<ICommand>();
            foreach (char c in command)
            {
                switch (c)
                {
                    case 'L': commands.Add(new TurnLeftCommand(rover.GetLocation())); break;
                    case 'R': commands.Add(new TurnRightCommand(rover.GetLocation())); break;
                    case 'M': commands.Add(new MoveCommand(rover.GetLocation())); commands.Add(new CheckBoundriesCommand(rover)); break;
                    default: Console.WriteLine("Inapporiate command!"); break;
                }
            }
            return commands;
        }
    }

}
