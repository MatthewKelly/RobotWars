using RobotWars.Enums;
using RobotWars.Exceptions;
using RobotWars.Interfaces;
using RobotWars.Model;

namespace RobotWars.CommandHandlers
{
    public class MoveCommandHandler : ICommandHandler  {


        public void Execute(Robot robot, Arena arena) {

            if (    (robot.Orientation == Orientation.W &&  robot.XCoordinate == 0)
                    || (robot.Orientation == Orientation.S && robot.YCoordinate == 0)
                    || (robot.Orientation == Orientation.N && robot.YCoordinate == arena.UpperBoundY)
                    || (robot.Orientation == Orientation.E && robot.XCoordinate == arena.UpperBoundX)
                ) {
                    throw new InvalidMoveException();
            }

            switch (robot.Orientation) {
                case Orientation.N:
                    robot.YCoordinate++;
                    break;
                case Orientation.E:
                    robot.XCoordinate++;
                    break;
                case Orientation.S:
                    robot.YCoordinate--;
                    break;
                case Orientation.W:
                    robot.XCoordinate--;
                    break;
            }
        }
    }
}
