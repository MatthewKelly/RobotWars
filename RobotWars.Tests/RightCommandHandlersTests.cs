using RobotWars.CommandHandlers;
using RobotWars.Enums;
using RobotWars.Model;
using NUnit.Framework;

namespace RobotWars.Tests
{
    public class RightCommandHandlerTests
    {
        [Test]
        public void Should_Moverobot_To_The_Right()
        {
            var robot = new Robot();
            var arena = new Arena();
            robot.Orientation = Orientation.N;

            var rightCommandHandler = new RightCommandHandler();
            rightCommandHandler.Execute(robot, arena);

            Assert.That(robot.Orientation == Orientation.E);

            rightCommandHandler.Execute(robot, arena);

            Assert.That(robot.Orientation == Orientation.S);

            rightCommandHandler.Execute(robot, arena);

            Assert.That(robot.Orientation == Orientation.W);

            rightCommandHandler.Execute(robot, arena);

            Assert.That(robot.Orientation == Orientation.N);

        }


    }
}
