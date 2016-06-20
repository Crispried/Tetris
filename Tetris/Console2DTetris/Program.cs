using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Console2DTetris.Shapes;
using TetrisLibrary;

namespace Console2DTetris
{
    class Program
    {
        static void Main(string[] args)
        {
            Point2D zPoint = new Point2D(new List<Coordinate>(){
                new Coordinate(5), new Coordinate(5)
            });
            ZShape z = new ZShape(zPoint);
            var axes = AxisParser.Parse("axes.xml");
            z.Rotate(axes[0]);
            z.Rotate(axes[1]);
            Mover2D mover2D = new Mover2D();
            Direction negativeDirection = new Direction(DirectionType.Negative);
            foreach (Point2D item in z.Points)
            {
                Console.WriteLine("(" + item.X.Value + ", " + item.Y.Value + ")");
            }
            mover2D.Move(z, axes[0], negativeDirection);
            Console.WriteLine("-----------------");
            foreach (Point2D item in z.Points)
            {
                Console.WriteLine("(" + item.X.Value + ", " + item.Y.Value + ")");
            }

            Console.WriteLine("------------------------");
            ShapeFactory factory = new ShapeFactory();
            var newShape = factory.CreateShape(new Point2D(new List<Coordinate>()
            {
                new Coordinate(10), new Coordinate(8)
            }));
            foreach (Point2D item in newShape.Points)
            {
                Console.WriteLine("(" + item.X.Value + ", " + item.Y.Value + ")");
            }
        }
    }
}
