using System;
using codectest;
using Xunit;

namespace Test
{
    public class RobotTest
    {
        #region ChangeDirection

        [Fact]
        public void ChangeDirectionNorthLeft()
        {
            var robot = new Robot();
            robot.Direction = EDirection.North;
            robot.TurnLeft();

            Assert.Equal(EDirection.West, robot.Direction);
        }

        [Fact]
        public void ChangeDirectionNorthRight()
        {
            var robot = new Robot();
            robot.Direction = EDirection.North;
            robot.TurnRight();

            Assert.Equal(EDirection.East, robot.Direction);
        }

        [Fact]
        public void ChangeDirectionEastLeft()
        {
            var robot = new Robot();
            robot.Direction = EDirection.East;
            robot.TurnLeft();

            Assert.Equal(EDirection.North, robot.Direction);
        }

        [Fact]
        public void ChangeDirectionEastRight()
        {
            var robot = new Robot();
            robot.Direction = EDirection.East;
            robot.TurnRight();

            Assert.Equal(EDirection.South, robot.Direction);
        }

        [Fact]
        public void ChangeDirectionSouthLeft()
        {
            var robot = new Robot();
            robot.Direction = EDirection.South;
            robot.TurnLeft();

            Assert.Equal(EDirection.East, robot.Direction);
        }

        [Fact]
        public void ChangeDirectionSouthRight()
        {
            var robot = new Robot();
            robot.Direction = EDirection.South;
            robot.TurnRight();

            Assert.Equal(EDirection.West, robot.Direction);
        }

        [Fact]
        public void ChangeDirectionWestLeft()
        {
            var robot = new Robot();
            robot.Direction = EDirection.West;
            robot.TurnLeft();

            Assert.Equal(EDirection.South, robot.Direction);
        }

        [Fact]
        public void ChangeDirectionWestRight()
        {
            var robot = new Robot();
            robot.Direction = EDirection.West;
            robot.TurnRight();

            Assert.Equal(EDirection.North, robot.Direction);
        }

        #endregion

        #region MoveForward

        [Fact]
        public void MoveForwardNorth()
        {
            var robot = new Robot();
            robot.Direction = EDirection.North;
            robot.MoveForward();

            Assert.Equal(2, robot.Y);
        }

        [Fact]
        public void MoveForwardSouth()
        {
            var robot = new Robot();
            robot.Direction = EDirection.South;
            robot.MoveForward();

            Assert.Equal(0, robot.Y);
        }

        [Fact]
        public void MoveForwardEast()
        {
            var robot = new Robot();
            robot.Direction = EDirection.East;
            robot.MoveForward();

            Assert.Equal(2, robot.X);
        }

        [Fact]
        public void MoveForwardWest()
        {
            var robot = new Robot();
            robot.Direction = EDirection.West;
            robot.MoveForward();

            Assert.Equal(0, robot.X);
        }

        #endregion
    }
}
