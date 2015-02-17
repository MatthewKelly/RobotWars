using RobotWars.Parsers;
using NUnit.Framework;

namespace RobotWars.Tests
{
    public class ArenaParserTests
    {
        [Test]
        public void Should_Return_Arena_With_Correct_Boundaries()
        {
            var arenaParser = new ArenaParser();
            var arena = arenaParser.ParseArena("5 5");

            Assert.That(arena.UpperBoundX == 5);
            Assert.That(arena.UpperBoundY == 5);

        }


    }
}
