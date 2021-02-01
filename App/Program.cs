using System;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nEnter plateau: ");
            string plateau = Console.ReadLine();

            Console.WriteLine("\nEnter command: ");
            string command = Console.ReadLine();

            Console.WriteLine(MoveRobot(plateau, command));
            Console.Write("\nPress any key to exit...");
            Console.ReadKey(true);
        }

        private static string MoveRobot(string plateau, string command)
        {
            if (ValidateInputs(plateau, command))
            {
                var splitPlateau = plateau.Split('x');
                var plateauX = int.Parse(splitPlateau[0]);
                int plateauY = int.Parse(splitPlateau[1]);

                var robot = new Robot(plateauX, plateauY);

                foreach (var item in command)
                {
                    if (item == 'F')
                        robot.MoveForward();
                    else if (item == 'L')
                        robot.TurnLeft();
                    else if (item == 'R')
                        robot.TurnRight();
                }

                return robot.PositionX + "," + robot.PositionY + "," + robot.Direction;
            }

            return "Invalid Inputs";
        }

        private static bool ValidateInputs(string plateau, string command)
        {
            try
            {
                if (!string.IsNullOrEmpty(plateau)
                    && plateau.Contains('x')
                    && plateau.Split('x').Length == 2
                    && !string.IsNullOrEmpty(command))
                {
                    var splitPlateau = plateau.Split('x');
                    int plateauX;
                    int plateauY;
                    int.TryParse(splitPlateau[0], out plateauX);
                    int.TryParse(splitPlateau[1], out plateauY);

                    if (plateauX > 0 && plateauY > 0)
                        return true;
                }

                return false;
            }
            catch
            {
                return false;
            }
        }
    }
}
