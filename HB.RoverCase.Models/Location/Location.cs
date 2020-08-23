namespace HB.RoverCase.Models
{
    public class Location : ILocation
    {
        private int X { get; set; }
        private int Y { get; set; }
        private Heading Heading { get; set; }

        public Location(int x, int y, Heading heading)
        {
            X = x;
            Y = y;
            Heading = heading;
        }

        public int GetX() => X;
        public int GetY() => Y;
        public Heading GetHeading() => Heading;
        public void TurnLeft()
        {
            if (Heading == Heading.North)
            {
                Heading = Heading.West;
            }
            else
            {
                Heading = Heading - 1;
            }
        }
        public void TurnRight()
        {
            if (Heading == Heading.West)
            {
                Heading = Heading.North;
            }
            else
            {
                Heading = Heading + 1;
            }
        }
        public void Move()
        {
            switch (Heading)
            {
                case Heading.North: Y++; break;
                case Heading.East: X++; break;
                case Heading.South: Y--; break;
                case Heading.West: X--; break;
                default: break;
            }
        }
    }
}