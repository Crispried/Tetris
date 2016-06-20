using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TetrisLibrary;

namespace Console2DTetris
{
    public class Point2D : Point
    {
        private Coordinate x, y;

        public Point2D(List<Coordinate> coordinates) : base(coordinates)
        {
            x = coordinates[0];
            y = coordinates[1];
        }

        public Coordinate X
        {
            get
            {
                return x;
            }
            set
            {
                x = value;
            }
        }

        public Coordinate Y
        {
            get
            {
                return y;
            }
            set
            {
                y = value;
            }
        }
    }
}
