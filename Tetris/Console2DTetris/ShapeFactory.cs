using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TetrisLibrary;
using Console2DTetris.Shapes;

namespace Console2DTetris
{
    public class ShapeFactory : IShapeFactory
    {
        public Shape CreateShape(Point startPosition)
        {
            Shape result = null;
            switch (GetRandomNumber(2))
            {
                case 0:
                    result = new OShape((Point2D)startPosition);
                    break;
                case 1:
                    result = new ZShape((Point2D)startPosition);
                    break;
            }
            return result;
        }

        private int GetRandomNumber(int numberOfShapes)
        {
            Random r = new Random();
            return r.Next(numberOfShapes);
        }
    }
}
