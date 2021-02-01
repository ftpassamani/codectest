using System;
namespace codectest
{
    public class Robot
    {
        public EDirection ChangeDirection(EDirection direction, char leftRight)
        {
            EDirection ret;

            switch (direction)
            {
                case EDirection.North:
                    if (leftRight == 'L')
                        ret = EDirection.West;
                    else
                        ret = EDirection.East;
                    break;
                case EDirection.South:
                    if (leftRight == 'L')
                        ret = EDirection.East;
                    else
                        ret = EDirection.West;
                    break;
                case EDirection.East:
                    if (leftRight == 'L')
                        ret = EDirection.North;
                    else
                        ret = EDirection.South;
                    break;
                default:
                    if (leftRight == 'L')
                        ret = EDirection.South;
                    else
                        ret = EDirection.North;
                    break;
            }
            return ret;
        }

    }
}
