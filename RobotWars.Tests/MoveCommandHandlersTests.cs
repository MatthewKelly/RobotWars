using RobotWars.CommandHandlers;
using RobotWars.Enums;
using RobotWars.Exceptions;
using RobotWars.Model;
using NUnit.Framework;

namespace RobotWars.Tests
{
    public class MoveCommandHandlerTests
    {
        [Test]
        public void Should_Moverobot_In_Correct_Direction()
        {
            var robot = new Robot();
            var arena = new Arena();

            robot.Orientation = Orientation.N;
            robot.XCoordinate = 0;
            robot.YCoordinate = 0;

            arena.UpperBoundX = 5;
            arena.UpperBoundY = 5;

            var moveCommandHandler = new MoveCommandHandler();
            moveCommandHandler.Execute(robot, arena);

            Assert.That(robot.XCoordinate == 0);
            Assert.That(robot.YCoordinate == 1);

            robot.Orientation = Orientation.E;
            moveCommandHandler.Execute(robot, arena);

            Assert.That(robot.XCoordinate == 1);
            Assert.That(robot.YCoordinate == 1);

            robot.Orientation = Orientation.W;
            moveCommandHandler.Execute(robot, arena);

            Assert.That(robot.XCoordinate == 0);
            Assert.That(robot.YCoordinate == 1);


            robot.Orientation = Orientation.S;
            moveCommandHandler.Execute(robot, arena);

            Assert.That(robot.XCoordinate == 0);
            Assert.That(robot.YCoordinate == 0);
           

        }


        [Test]
        public void Should_Throw_Exception_When_Outside_Arena()
        {
            var robot = new Robot();
            var arena = new Arena();

            robot.Orientation = Orientation.N;
            robot.XCoordinate = 3;
            robot.YCoordinate = 0;

            arena.UpperBoundX = 3;
            arena.UpperBoundX = 3;

            var moveCommandHandler = new MoveCommandHandler();
            Assert.Throws<InvalidMoveException>(() => moveCommandHandler.Execute(robot, arena));  

        }


    }
}
