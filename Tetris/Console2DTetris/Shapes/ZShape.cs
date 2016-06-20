using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TetrisLibrary;

namespace Console2DTetris.Shapes
{
    public class ZShape : Shape
    {
        public ZShape(Point2D point) : base(point)
        {
            points = new List<Point>(4);
            points.Add(point);
            points.Add(new Point2D(new List<Coordinate>()
            {
                new Coordinate(point.X.Value + 1), point.Y
            }));
            points.Add(new Point2D(new List<Coordinate>()
            {
                new Coordinate(point.X.Value + 1), new Coordinate(point.X.Value + 1)
            }));
            points.Add(new Point2D(new List<Coordinate>()
            {
                new Coordinate(point.X.Value + 2), new Coordinate(point.X.Value + 1)
            }));
        }

        public override void Rotate(Axis axis)
        {
            Console.WriteLine("OShape was rotated round " + axis.Name + " axis.");
        }
    }
}
