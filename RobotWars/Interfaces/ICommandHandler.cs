using RobotWars.Model;

namespace RobotWars.Interfaces
{
    public interface ICommandHandler
    {
        void Execute(Robot robot, Arena arena);
    }
}
