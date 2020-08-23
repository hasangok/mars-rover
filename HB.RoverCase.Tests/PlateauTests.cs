using System;
using Xunit;
using HB.RoverCase.Models;

namespace HB.RoverCase.Tests
{
    public class PlateauTests
    {
        [Fact]
        public void Plateau_Should_Have_Positive_X_Value()
        {
            //arrange
            var random = new Random();

            //act
            var plateau = new Plateau(random.Next(), random.Next());

            //assert
            Assert.True(plateau.GetX() >= 0, "Plateau should have a positive int value on X property");
        }

        [Fact]
        public void Plateau_Should_Have_Positive_Y_Value()
        {
            //arrange
            var random = new Random();

            //act
            var plateau = new Plateau(random.Next(), random.Next());

            //assert
            Assert.True(plateau.GetY() >= 0, "Plateau should have a positive int value on Y property");
        }
    }
}
