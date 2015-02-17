using RobotWars.Parsers;
using NUnit.Framework;
using RobotWars.Enums;
using RobotWars.Model;

namespace RobotWars.Tests
{
    public class RobotParserTests
    {
        [Test]
        public void Should_Return_Correctrobot()
        {
            var robotParser = new RobotParser();
            var arena = new Arena(); 
            var robot = robotParser.ParseRobot("1 2 N", arena);

            Assert.That(robot.Orientation == Orientation.N);
            Assert.That(robot.XCoordinate == 1);
            Assert.That(robot.YCoordinate == 2);

        }


    }
}
