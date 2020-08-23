using System;
using HB.RoverCase.Models;

namespace HB.RoverCase.Extensions
{
    public static class Extensions
    {
        public static int GetX(this string value)
        {
            return Convert.ToInt32(value.Split(' ')[0]);
        }
        public static int GetY(this string value)
        {
            return Convert.ToInt32(value.Split(' ')[1]);
        }
        public static Heading GetHeading(this string value)
        {
            Heading h = Heading.North;
            var heading = value.Split(' ')[2];
            switch(heading)
            {
                case "E": h = Heading.East; break;
                case "S": h = Heading.South; break;
                case "W": h = Heading.West; break;
            }
            return h;
        }
    }

}
