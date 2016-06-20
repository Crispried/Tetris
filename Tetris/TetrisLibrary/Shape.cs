using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TetrisLibrary
{
    public abstract class Shape
    {
        protected List<Point> points;

        /// <summary>
        /// referencePoint is a point concerning which will be
        /// described concrete Shape as a list of the points
        /// </summary>
        /// <param name="referencePoint"></param>
        public Shape(Point referencePoint)
        {
        }

        public List<Point> Points
        {
            get
            {
                return points;
            }
            set
            {
                points = value;
            }
        }

        public abstract void Rotate(Axis axis);
    }
}
