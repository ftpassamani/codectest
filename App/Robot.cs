namespace App
{
    public class Robot : IRobot
    {
        public int PositionX { get; set; }
        public int PositionY { get; set; }
        public int PlateauX { get; set; }
        public int PlateauY { get; set; }
        public EDirection Direction { get; set; }

        public Robot(int plateauX, int plateauY)
        {
            PositionX = 1;
            PositionY = 1;
            PlateauX = plateauX;
            PlateauY = plateauY;
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

        public void MoveForward()
        {
            switch (this.Direction)
            {
                case EDirection.North:
                    if((PositionY + 1) >= 1 && (PositionY + 1) <= PlateauY)
                        PositionY++;
                    break;
                case EDirection.South:
                    if ((PositionY - 1) >= 1 && (PositionY - 1) <= PlateauY)
                        PositionY--;
                    break;
                case EDirection.East:
                    if ((PositionX + 1) >= 1 && (PositionX + 1) <= PlateauX)
                        PositionX++;
                    break;
                default:
                    if ((PositionX - 1) >= 1 && (PositionX - 1) <= PlateauX)
                        PositionX--;
                    break;
            }
        }
    }
}
