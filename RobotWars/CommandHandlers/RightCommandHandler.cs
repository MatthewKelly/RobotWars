using System;
using RobotWars.Enums;
using RobotWars.Interfaces;
using RobotWars.Model;

namespace RobotWars.CommandHandlers
{
   public class RightCommandHandler : ICommandHandler {

       public void Execute(Robot robot, Arena arena) {
            switch (robot.Orientation)
            {
                case Orientation.N:
                    robot.Orientation = Orientation.E;
                    break;
                case Orientation.E:
                    robot.Orientation = Orientation.S;
                    break;
                case Orientation.S:
                    robot.Orientation = Orientation.W;
                    break;
                case Orientation.W:
                    robot.Orientation = Orientation.N;
                    break;
            }
        }
    }
}


