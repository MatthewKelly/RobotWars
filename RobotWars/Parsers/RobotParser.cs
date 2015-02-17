using System;
using System.Linq;
using RobotWars.Enums;
using RobotWars.Model;

namespace RobotWars.Parsers
{
    public class RobotParser {


        public Robot ParseRobot(string robotStartingPositionInput, Arena arena)
        {
            if (robotStartingPositionInput == string.Empty)
            {
                return null;
            }
            var robot = InitializeRobot(robotStartingPositionInput);
            arena.Robots.Add(robot);
            return robot;
        }


        private static Robot InitializeRobot(string robotStartingPositionInput)
        {
            var robot = new Robot();
            var robotStartingPosition = robotStartingPositionInput.Split(' ');
            robot.XCoordinate = int.Parse(robotStartingPosition.ElementAt(0));
            robot.YCoordinate = int.Parse(robotStartingPosition.ElementAt(1));
            robot.Orientation = (Orientation)(Enum.Parse(typeof(Orientation), robotStartingPosition.ElementAt(2)));
            return robot;
        }

    }
}
