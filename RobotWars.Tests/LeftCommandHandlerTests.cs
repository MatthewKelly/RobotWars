using RobotWars.CommandHandlers;
using RobotWars.Enums;
using RobotWars.Model;
using NUnit.Framework;

namespace RobotWars.Tests
{
    public class LeftCommandHandlerTests
    {
        [Test]
        public void Should_Moverobot_To_The_Left()
        {
            var robot = new Robot();
            var arena = new Arena();
            robot.Orientation = Orientation.N;

            var leftCommandHandler = new LeftCommandHandler();
            leftCommandHandler.Execute(robot, arena);

            Assert.That(robot.Orientation == Orientation.W);

            leftCommandHandler.Execute(robot, arena);

            Assert.That(robot.Orientation == Orientation.S);

            leftCommandHandler.Execute(robot, arena);

            Assert.That(robot.Orientation == Orientation.E);

            leftCommandHandler.Execute(robot, arena);

            Assert.That(robot.Orientation == Orientation.N);

        }


    }
}
