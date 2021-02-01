using App;
using Xunit;

namespace Test
{
    public class RobotTest
    {
        #region ChangeDirection

        [Fact]
        public void ChangeDirectionNorthLeft()
        {
            var robot = new Robot(1, 1);
            robot.Direction = EDirection.North;
            robot.TurnLeft();

            Assert.Equal(EDirection.West, robot.Direction);
        }

        [Fact]
        public void ChangeDirectionNorthRight()
        {
            var robot = new Robot(1, 1);
            robot.Direction = EDirection.North;
            robot.TurnRight();

            Assert.Equal(EDirection.East, robot.Direction);
        }

        [Fact]
        public void ChangeDirectionEastLeft()
        {
            var robot = new Robot(1, 1);
            robot.Direction = EDirection.East;
            robot.TurnLeft();

            Assert.Equal(EDirection.North, robot.Direction);
        }

        [Fact]
        public void ChangeDirectionEastRight()
        {
            var robot = new Robot(1, 1);
            robot.Direction = EDirection.East;
            robot.TurnRight();

            Assert.Equal(EDirection.South, robot.Direction);
        }

        [Fact]
        public void ChangeDirectionSouthLeft()
        {
            var robot = new Robot(1, 1);
            robot.Direction = EDirection.South;
            robot.TurnLeft();

            Assert.Equal(EDirection.East, robot.Direction);
        }

        [Fact]
        public void ChangeDirectionSouthRight()
        {
            var robot = new Robot(1, 1);
            robot.Direction = EDirection.South;
            robot.TurnRight();

            Assert.Equal(EDirection.West, robot.Direction);
        }

        [Fact]
        public void ChangeDirectionWestLeft()
        {
            var robot = new Robot(1, 1);
            robot.Direction = EDirection.West;
            robot.TurnLeft();

            Assert.Equal(EDirection.South, robot.Direction);
        }

        [Fact]
        public void ChangeDirectionWestRight()
        {
            var robot = new Robot(1, 1);
            robot.Direction = EDirection.West;
            robot.TurnRight();

            Assert.Equal(EDirection.North, robot.Direction);
        }

        #endregion

        #region MoveForward

        [Fact]
        public void MoveForwardNorth()
        {
            var robot = new Robot(2, 2);
            robot.Direction = EDirection.North;
            robot.MoveForward();

            Assert.Equal(2, robot.PositionY);
        }

        [Fact]
        public void MoveForwardSouth()
        {
            var robot = new Robot(2, 2);
            robot.Direction = EDirection.South;
            robot.PositionX = 2;
            robot.PositionY = 2;
            robot.MoveForward();

            Assert.Equal(1, robot.PositionY);
        }

        [Fact]
        public void MoveForwardEast()
        {
            var robot = new Robot(2, 2);
            robot.Direction = EDirection.East;
            robot.MoveForward();

            Assert.Equal(2, robot.PositionX);
        }

        [Fact]
        public void MoveForwardWest()
        {
            var robot = new Robot(2, 2);
            robot.Direction = EDirection.West;
            robot.PositionX = 2;
            robot.PositionY = 2;
            robot.MoveForward();

            Assert.Equal(1, robot.PositionX);
        }

        [Fact]
        public void MoveForwardNorthReachesLimits()
        {
            var robot = new Robot(1, 1);
            robot.Direction = EDirection.North;
            robot.MoveForward();

            Assert.Equal(1, robot.PositionY);
        }

        [Fact]
        public void MoveForwardSouthReachesLimits()
        {
            var robot = new Robot(1, 1);
            robot.Direction = EDirection.South;
            robot.MoveForward();

            Assert.Equal(1, robot.PositionY);
        }

        [Fact]
        public void MoveForwardEastReachesLimits()
        {
            var robot = new Robot(1, 1);
            robot.Direction = EDirection.East;
            robot.MoveForward();

            Assert.Equal(1, robot.PositionX);
        }

        [Fact]
        public void MoveForwardWestReachesLimits()
        {
            var robot = new Robot(1, 1);
            robot.Direction = EDirection.West;
            robot.MoveForward();

            Assert.Equal(1, robot.PositionX);
        }

        #endregion
    }
}
