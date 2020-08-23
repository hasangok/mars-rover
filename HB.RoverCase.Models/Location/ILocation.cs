namespace HB.RoverCase.Models
{
    public interface ILocation
    {
        int GetX();
        int GetY();
        Heading GetHeading();
        void Move();
        void TurnLeft();
        void TurnRight();
    }
}
