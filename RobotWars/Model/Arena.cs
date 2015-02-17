using System.Collections.Generic;

namespace RobotWars.Model
{
    public class Arena
    {
        public List<Robot> Robots { get; private set; }
        public int UpperBoundX {get; set; }
        public int UpperBoundY { get; set; }

        public Arena()
        {
            Robots = new List<Robot>();
        }
    }
}
