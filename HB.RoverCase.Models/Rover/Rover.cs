using System;
using System.Collections.Generic;

namespace HB.RoverCase.Models
{
    public class Rover : IRover
    {
        private ILocation Location { get; set; }
        private IPlateau Plateau { get; set; }
        private List<ICommand> Commands { get; set; }
        public Rover(Location location, Plateau plateau)
        {
            Location = location;
            Plateau = plateau;
            Commands = new List<ICommand>();
        }

        public ILocation GetLocation() => Location;
        public IPlateau GetPlateau() => Plateau;

        public void ExecuteCommands()
        {
            foreach (var command in Commands)
            {
                command.Execute();
            }
            Console.WriteLine(Location);
        }
        public void SetCommands(List<ICommand> commands) => Commands.AddRange(commands);
    }
}
