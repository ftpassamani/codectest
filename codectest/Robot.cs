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

        public void ChangeDirection(char leftRight)
        {
            switch (this.Direction)
            {
                case EDirection.North:
                    if (leftRight == 'L')
                        Direction = EDirection.West;
                    else
                        Direction = EDirection.East;
                    break;
                case EDirection.South:
                    if (leftRight == 'L')
                        Direction = EDirection.East;
                    else
                        Direction = EDirection.West;
                    break;
                case EDirection.East:
                    if (leftRight == 'L')
                        Direction = EDirection.North;
                    else
                        Direction = EDirection.South;
                    break;
                default:
                    if (leftRight == 'L')
                        Direction = EDirection.South;
                    else
                        Direction = EDirection.North;
                    break;
            }
        }
    }
}
