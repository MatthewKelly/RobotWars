using RobotWars.CommandHandlers;
using RobotWars.Exceptions;
using RobotWars.Interfaces;
using RobotWars.Model;

namespace RobotWars.Parsers
{
    public class RobotCommandParser
    {
        public void ProcessRobotCommands(string robotCommandsInput, Robot robot, Arena arena) {

            var commands = robotCommandsInput.ToCharArray();
            var rightCommandHandler = new RightCommandHandler();
            var leftCommandHandler = new LeftCommandHandler();
            var moveCommandHandler = new MoveCommandHandler();

            foreach (var command in commands)
            {
                
                ICommandHandler commandHander;
                switch (command)
                {
                    case 'R':
                        commandHander = rightCommandHandler;
                        break;
                    case 'L':
                        commandHander = leftCommandHandler;
                        break;
                    case 'M':
                        commandHander = moveCommandHandler;
                        break;
                    default:
                        throw new InvalidRobotCommandException();
                }

                commandHander.Execute(robot, arena);
            }

        }
    }
}
