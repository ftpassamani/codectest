using System;
using codectest;
using Xunit;

namespace Test
{
    public class RobotTest
    {
        [Fact]
        public void ChangeDirectionNorthLeft()
        {
            var robot = new Robot();
            var result = robot.ChangeDirection(EDirection.North, 'L');

            Assert.Equal(EDirection.West, result);
        }

        [Fact]
        public void ChangeDirectionNorthRight()
        {
            var robot = new Robot();
            var result = robot.ChangeDirection(EDirection.North, 'R');

            Assert.Equal(EDirection.East, result);
        }

        [Fact]
        public void ChangeDirectionEastLeft()
        {
            var robot = new Robot();
            var result = robot.ChangeDirection(EDirection.East, 'L');

            Assert.Equal(EDirection.North, result);
        }

        [Fact]
        public void ChangeDirectionEastRight()
        {
            var robot = new Robot();
            var result = robot.ChangeDirection(EDirection.East, 'R');

            Assert.Equal(EDirection.South, result);
        }

        [Fact]
        public void ChangeDirectionSouthLeft()
        {
            var robot = new Robot();
            var result = robot.ChangeDirection(EDirection.South, 'L');

            Assert.Equal(EDirection.East, result);
        }

        [Fact]
        public void ChangeDirectionSouthRight()
        {
            var robot = new Robot();
            var result = robot.ChangeDirection(EDirection.South, 'R');

            Assert.Equal(EDirection.West, result);
        }

        [Fact]
        public void ChangeDirectionWestLeft()
        {
            var robot = new Robot();
            var result = robot.ChangeDirection(EDirection.West, 'L');

            Assert.Equal(EDirection.South, result);
        }

        [Fact]
        public void ChangeDirectionWestRight()
        {
            var robot = new Robot();
            var result = robot.ChangeDirection(EDirection.West, 'R');

            Assert.Equal(EDirection.North, result);
        }
    }
}
