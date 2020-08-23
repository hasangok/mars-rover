namespace HB.RoverCase.Models
{
    public class TurnRightCommand : ICommand
    {
        private ILocation Location { get; set; }
        public TurnRightCommand(ILocation location)
        {
            Location = location;
        }
        public void Execute()
        {
            Location.TurnRight();
        }
    }
}
