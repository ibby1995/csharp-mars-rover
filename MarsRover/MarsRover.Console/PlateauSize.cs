using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Console
{
    public class PlateauSize
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public PlateauSize(int width, int height)
        {
            Width = width;
            Height = height;
        }
    }
}
