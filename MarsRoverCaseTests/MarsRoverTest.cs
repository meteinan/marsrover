using MarsRoverCase;
using System;
using Xunit;

namespace MarsRoverCaseTests
{
    public class MarsRoverTest
    {
        [Fact]
        public void TurnLeft()
        {
            Rover rover = new Rover("1 2 N");
            rover.TurnLeft();
            Assert.Equal("W", rover.direction);
        }

        [Fact]
        public void TurnRight()
        {
            Rover rover = new Rover("1 2 N");
            rover.TurnRight();
            Assert.Equal("E", rover.direction);
        }

        [Fact]
        public void Step()
        {
            Rover rover = new Rover("1 2 N");
            rover.Step();
            Assert.Equal(3, rover.y);
        }

        [Fact]
        public void Case_1_2_N()
        {
            Rover rover = new Rover("1 2 N");
            rover.Move("LMLMLMLM");
            Assert.Equal("1 3 N", rover.x + " " + rover.y + " " + rover.direction);
        }

        [Fact]
        public void Case_3_3_E()
        {
            Rover rover = new Rover("3 3 E");
            rover.Move("MMRMMRMRRM");
            Assert.Equal("5 1 E", rover.x + " " + rover.y + " " + rover.direction);
        }
    }
}
