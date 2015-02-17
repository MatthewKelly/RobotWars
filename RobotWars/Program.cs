using System;
using RobotWars.Parsers;
using RobotWars.Model;

namespace RobotWars
{
    class Program
    {
        static void Main(string[] args)
        {
            var arenaParser = new ArenaParser();
            var robotParser = new RobotParser();
            var robotCommandParser = new RobotCommandParser();

            var arena = arenaParser.ParseArena(Console.ReadLine());

            var robot = new Robot();
            while( robot != null)
            {
                robot = robotParser.ParseRobot(Console.ReadLine(), arena);
                robotCommandParser.ProcessRobotCommands(Console.ReadLine(), robot, arena);
            }

            foreach (var finalRobot in arena.Robots)
            {
                Console.WriteLine(string.Format("{0} {1} {2}", finalRobot.XCoordinate, finalRobot.YCoordinate, finalRobot.Orientation.ToString()));
            }
            Console.ReadLine();
        }

      
    }
}
