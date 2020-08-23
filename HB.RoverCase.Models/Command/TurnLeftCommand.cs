namespace HB.RoverCase.Models
{
    public class TurnLeftCommand : ICommand
    {
        private ILocation Location { get; set; }
        public TurnLeftCommand(ILocation location)
        {
            Location = location;
        }
        public void Execute()
        {
            Location.TurnLeft();
        }
    }
}
