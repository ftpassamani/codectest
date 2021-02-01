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
            robot.Direction = EDirection.North;
            robot.ChangeDirection('L');

            Assert.Equal(EDirection.West, robot.Direction);
        }

        [Fact]
        public void ChangeDirectionNorthRight()
        {
            var robot = new Robot();
            robot.Direction = EDirection.North;
            robot.ChangeDirection('R');

            Assert.Equal(EDirection.East, robot.Direction);
        }

        [Fact]
        public void ChangeDirectionEastLeft()
        {
            var robot = new Robot();
            robot.Direction = EDirection.East;
            robot.ChangeDirection('L');

            Assert.Equal(EDirection.North, robot.Direction);
        }

        [Fact]
        public void ChangeDirectionEastRight()
        {
            var robot = new Robot();
            robot.Direction = EDirection.East;
            robot.ChangeDirection('R');

            Assert.Equal(EDirection.South, robot.Direction);
        }

        [Fact]
        public void ChangeDirectionSouthLeft()
        {
            var robot = new Robot();
            robot.Direction = EDirection.South;
            robot.ChangeDirection('L');

            Assert.Equal(EDirection.East, robot.Direction);
        }

        [Fact]
        public void ChangeDirectionSouthRight()
        {
            var robot = new Robot();
            robot.Direction = EDirection.South;
            robot.ChangeDirection('R');

            Assert.Equal(EDirection.West, robot.Direction);
        }

        [Fact]
        public void ChangeDirectionWestLeft()
        {
            var robot = new Robot();
            robot.Direction = EDirection.West;
            robot.ChangeDirection('L');

            Assert.Equal(EDirection.South, robot.Direction);
        }

        [Fact]
        public void ChangeDirectionWestRight()
        {
            var robot = new Robot();
            robot.Direction = EDirection.West;
            robot.ChangeDirection('R');

            Assert.Equal(EDirection.North, robot.Direction);
        }
    }
}
