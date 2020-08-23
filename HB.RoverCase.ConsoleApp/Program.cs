using System;
using System.IO;
using HB.RoverCase.Models;
using HB.RoverCase.Extensions;

namespace HB.RoverCase.ConsoleApp
{
    static class Program
    {
        static void Main(string[] args)
        {
            string[] command = File.ReadAllLines("command.txt");

            string plateauInput = command[0];
            Plateau plateau = new Plateau(plateauInput.GetX(), plateauInput.GetY());

            for (int i = 1; i <= command.Length - 1; i = i + 2)
            {
                try
                {
                    var initCommand = command[i];
                    var movementCommand = command[i + 1];
                    Rover r = new Rover(new Location(initCommand.GetX(), initCommand.GetY(), initCommand.GetHeading()), plateau);
                    var commands = movementCommand.GetCommandsFromInputString(r);
                    r.SetCommands(commands);
                    r.ExecuteCommands();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }
        }
    }
}
