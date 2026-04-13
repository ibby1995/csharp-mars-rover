using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Console
{
    public class Position
    {
        public int x { get; set; }
        public int y { get; set; }
        public CompassDirection Facing { get; set; }
        public Position(int x, int y, CompassDirection facing)
        {
            this.x = x;
            this.y = y;
            Facing = facing;
        }
    }
}
