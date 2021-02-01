using System;
namespace codectest
{
    public class Robot
    {
        public int X { get; set; }
        public int Y { get; set; }
        public EDirection Direction { get; set; }

        public Robot()
        {
            X = 1;
            Y = 1;
            Direction = EDirection.North;
        }

        public void TurnRight()
        {
            switch (this.Direction)
            {
                case EDirection.North:
                    Direction = EDirection.East;
                    break;
                case EDirection.South:
                    Direction = EDirection.West;
                    break;
                case EDirection.East:
                    Direction = EDirection.South;
                    break;
                default:
                    Direction = EDirection.North;
                    break;
            }
        }

        public void TurnLeft()
        {
            switch (this.Direction)
            {
                case EDirection.North:
                    Direction = EDirection.West;
                    break;
                case EDirection.South:
                    Direction = EDirection.East;
                    break;
                case EDirection.East:
                    Direction = EDirection.North;
                    break;
                default:
                    Direction = EDirection.South;
                    break;
            }
        }
    }
}
