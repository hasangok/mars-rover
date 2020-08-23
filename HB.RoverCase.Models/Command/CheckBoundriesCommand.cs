using System;

namespace HB.RoverCase.Models
{
    public class CheckBoundriesCommand : ICommand
    {
        private IRover Rover { get; set; }
        public CheckBoundriesCommand(IRover rover)
        {
            Rover = rover;
        }
        public void Execute()
        {
            var location = Rover.GetLocation();
            var plateau = Rover.GetPlateau();
            if(location.GetX() > plateau.GetX() || location.GetX() < 0 || location.GetY() > plateau.GetY() || location.GetY() < 0)
            {
                Console.WriteLine("Movement outside of plateau boundries!");
            }
        }
    }
}
