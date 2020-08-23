using System;

namespace HB.RoverCase.Models
{
    public class Plateau : IPlateau
    {
        private int XEdge { get; set; }
        private int YEdge { get; set; }
        public Plateau(int xEdge, int yEdge)
        {
            XEdge = xEdge;
            YEdge = yEdge;
            Console.WriteLine($"Plateau is initialized with ({xEdge},{yEdge})");
        }

        public int GetX() => XEdge;
        public int GetY() => YEdge;
    }
}
