namespace HB.RoverCase.Models
{
    public class MoveCommand : ICommand
    {
        private ILocation Location { get; set; }
        public MoveCommand(ILocation location)
        {
            Location = location;
        }
        public void Execute()
        {
            Location.Move();
        }
    }
}
