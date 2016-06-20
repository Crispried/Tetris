using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TetrisLibrary;

namespace Console2DTetris
{
    public class Mover2D : IMover
    {
        public void Move(Shape shape, Axis axis, Direction direction)
        {
            switch (axis.Name)
            {
                case "x":
                    XMovement(shape, direction);
                    break;
                case "y":
                    YMovement(shape, direction);
                    break;
            }
        }

        private void XMovement(Shape shape, Direction direction)
        {
            switch (direction.GetDirectionType)
            {
                case DirectionType.Negative:
                    MoveLeft(shape);
                    break;
                case DirectionType.Positive:
                    MoveRight(shape);
                    break;
            }
        }

        private void MoveLeft(Shape shape)
        {
            List<Point> newPoints = new List<Point>();
            foreach (Point2D point in shape.Points)
            {
                newPoints.Add(new Point2D(new List<Coordinate>()
                {
                    new Coordinate(point.X.Value - 1), point.Y
                }));
            }
            shape.Points = newPoints;
        }

        private void MoveRight(Shape shape)
        {
            List<Point> newPoints = new List<Point>();
            foreach (Point2D point in shape.Points)
            {
                newPoints.Add(new Point2D(new List<Coordinate>()
                {
                    new Coordinate(point.X.Value + 1), point.Y
                }));
            }
            shape.Points = newPoints;
        }

        /// <summary>
        /// probably we don't need direction here, because in common 2D tetris
        /// we can't move our shape in up direction, but
        /// we will support oportunity to move our shape in up direction
        /// it's more expected in this case and why not?
        /// </summary>
        private void YMovement(Shape shape, Direction direction)
        {
            // we will think that positive direction on Y axis is the direction
            // in which our shape moves as default
            // so positive direction matches to mothed MoveDown
            switch (direction.GetDirectionType)
            {
                case DirectionType.Negative:
                    MoveUp(shape);
                    break;
                case DirectionType.Positive:
                    MoveDown(shape);
                    break;
            }
        }

        private void MoveUp(Shape shape)
        {
            List<Point> newPoints = new List<Point>();
            foreach (Point2D point in shape.Points)
            {
                newPoints.Add(new Point2D(new List<Coordinate>()
                {
                    point.X, new Coordinate(point.Y.Value - 1)
                }));
            }
            shape.Points = newPoints;
        }

        private void MoveDown(Shape shape)
        {
            List<Point> newPoints = new List<Point>();
            foreach (Point2D point in shape.Points)
            {
                newPoints.Add(new Point2D(new List<Coordinate>()
                {
                    point.X, new Coordinate(point.Y.Value + 1)
                }));
            }
            shape.Points = newPoints;
        }
    }
}
