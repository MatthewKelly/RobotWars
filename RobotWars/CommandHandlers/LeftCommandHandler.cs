using System;
using RobotWars.Enums;
using RobotWars.Interfaces;
using RobotWars.Model;

namespace RobotWars.CommandHandlers
{
   public class LeftCommandHandler : ICommandHandler {

       public void Execute(Robot robot, Arena areana) {
            switch (robot.Orientation)
            {
                case Orientation.N:
                    robot.Orientation = Orientation.W;
                    break;
                case Orientation.E:
                    robot.Orientation = Orientation.N;
                    break;
                case Orientation.S:
                    robot.Orientation = Orientation.E;
                    break;
                case Orientation.W:
                    robot.Orientation = Orientation.S;
                    break;
            }
        }
    }
}
