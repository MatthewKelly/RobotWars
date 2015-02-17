using System.Linq;
using RobotWars.Model;

namespace RobotWars.Parsers
{
    public class ArenaParser
    {
        public Arena ParseArena(string arenaInput) {
            var arena = new Arena();
            var arenaBounds = arenaInput.Split().Select(int.Parse);
            arena.UpperBoundX = arenaBounds.ElementAt(0);
            arena.UpperBoundY = arenaBounds.ElementAt(1);
            return arena;
        }

    }
}
