using RobotWars.Parsers;
using NUnit.Framework;
using RobotWars.Enums;
using RobotWars.Model;
using RobotWars.Exceptions;

namespace RobotWars.Tests
{
    public class RobotCommandParserTests
    {
        [Test]
        public void Should_Return_Parse_Commands_Correctly()
        {
            var robotCommandParser = new RobotCommandParser();
            var robot = new Robot();
            robot.XCoordinate = 1;
            robot.YCoordinate = 2;
            robot.Orientation = Orientation.N;
            
            var arena = new Arena();
            arena.UpperBoundX = 5;
            arena.UpperBoundY = 5;


            robotCommandParser.ProcessRobotCommands("LMLMLMLMM", robot, arena);
            
            Assert.That(robot.XCoordinate == 1);
            Assert.That(robot.YCoordinate == 3);
            Assert.That(robot.Orientation == Orientation.N);

        }


        [Test]
        public void Should_Return_Parse_Commands_Correctly_Test_2()
        {
            var robotCommandParser = new RobotCommandParser();
            var robot = new Robot();
            robot.XCoordinate = 3;
            robot.YCoordinate = 3;
            robot.Orientation = Orientation.E;

            var arena = new Arena();
            arena.UpperBoundX = 5;
            arena.UpperBoundY = 5;


            robotCommandParser.ProcessRobotCommands("MMRMMRMRRM", robot, arena);

            Assert.That(robot.XCoordinate == 5);
            Assert.That(robot.YCoordinate == 1);
            Assert.That(robot.Orientation == Orientation.E);

        }

        [Test]
        public void Should_Throw_Exception_When_Invalid_Command_Given()
        {
            var robotCommandParser = new RobotCommandParser();
            var robot = new Robot();
            robot.XCoordinate = 3;
            robot.YCoordinate = 3;
            robot.Orientation = Orientation.E;

            var arena = new Arena();
            arena.UpperBoundX = 5;
            arena.UpperBoundY = 5;


            Assert.Throws<InvalidRobotCommandException>( () => robotCommandParser.ProcessRobotCommands("MMRMXXXRMRRM", robot, arena));


        }


    }
}
