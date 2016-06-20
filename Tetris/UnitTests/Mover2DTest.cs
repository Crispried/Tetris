using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Console2DTetris;
using Console2DTetris.Shapes;
using TetrisLibrary;

namespace UnitTests
{
    [TestFixture]
    class Mover2DTest
    {
        [Test]
        public void MoveRightTest()
        {
            //Assert
            Axis xAxis = new Axis("x");
            Direction positiveDirection = new Direction(DirectionType.Positive);
            Mover2D mover2D = new Mover2D();
            Shape shape = CreateTestShape();
            //Act
            mover2D.Move(shape, xAxis, positiveDirection);
            //Arrange
            Assert.IsTrue(shape.Points[0].Equals(new Point2D(new List<Coordinate>()
            {
                new Coordinate(6), new Coordinate(5)
            })));
            Assert.IsTrue(shape.Points[1].Equals(new Point2D(new List<Coordinate>()
            {
                new Coordinate(6), new Coordinate(6)
            })));
            Assert.IsTrue(shape.Points[2].Equals(new Point2D(new List<Coordinate>()
            {
                new Coordinate(7), new Coordinate(6)
            })));
            Assert.IsTrue(shape.Points[3].Equals(new Point2D(new List<Coordinate>()
            {
                new Coordinate(7), new Coordinate(7)
            })));          
        }

        [Test]
        public void MoveLeftTest()
        {
            //Assert
            Axis xAxis = new Axis("x");
            Direction positiveDirection = new Direction(DirectionType.Negative);
            Mover2D mover2D = new Mover2D();
            Shape shape = CreateTestShape();
            //Act
            mover2D.Move(shape, xAxis, positiveDirection);
            //Arrange
            Assert.IsTrue(shape.Points[0].Equals(new Point2D(new List<Coordinate>()
            {
                new Coordinate(4), new Coordinate(5)
            })));
            Assert.IsTrue(shape.Points[1].Equals(new Point2D(new List<Coordinate>()
            {
                new Coordinate(4), new Coordinate(6)
            })));
            Assert.IsTrue(shape.Points[2].Equals(new Point2D(new List<Coordinate>()
            {
                new Coordinate(5), new Coordinate(6)
            })));
            Assert.IsTrue(shape.Points[3].Equals(new Point2D(new List<Coordinate>()
            {
                new Coordinate(5), new Coordinate(7)
            })));
        }

        [Test]
        public void MoveDown()
        {
            //Assert
            Axis xAxis = new Axis("y");
            Direction positiveDirection = new Direction(DirectionType.Positive);
            Mover2D mover2D = new Mover2D();
            Shape shape = CreateTestShape();
            //Act
            mover2D.Move(shape, xAxis, positiveDirection);
            //Arrange
            Assert.IsTrue(shape.Points[0].Equals(new Point2D(new List<Coordinate>()
            {
                new Coordinate(5), new Coordinate(6)
            })));
            Assert.IsTrue(shape.Points[1].Equals(new Point2D(new List<Coordinate>()
            {
                new Coordinate(5), new Coordinate(7)
            })));
            Assert.IsTrue(shape.Points[2].Equals(new Point2D(new List<Coordinate>()
            {
                new Coordinate(6), new Coordinate(7)
            })));
            Assert.IsTrue(shape.Points[3].Equals(new Point2D(new List<Coordinate>()
            {
                new Coordinate(6), new Coordinate(8)
            })));
        }

        [Test]
        public void MoveUpTest()
        {
            //Assert
            Axis xAxis = new Axis("y");
            Direction positiveDirection = new Direction(DirectionType.Negative);
            Mover2D mover2D = new Mover2D();
            Shape shape = CreateTestShape();
            //Act
            mover2D.Move(shape, xAxis, positiveDirection);
            //Arrange
            Assert.IsTrue(shape.Points[0].Equals(new Point2D(new List<Coordinate>()
            {
                new Coordinate(5), new Coordinate(4)
            })));
            Assert.IsTrue(shape.Points[1].Equals(new Point2D(new List<Coordinate>()
            {
                new Coordinate(5), new Coordinate(5)
            })));
            Assert.IsTrue(shape.Points[2].Equals(new Point2D(new List<Coordinate>()
            {
                new Coordinate(6), new Coordinate(5)
            })));
            Assert.IsTrue(shape.Points[3].Equals(new Point2D(new List<Coordinate>()
            {
                new Coordinate(6), new Coordinate(6)
            })));
        }

        private Shape CreateTestShape()
        {
            Point2D zPoint = new Point2D(new List<Coordinate>(){
                new Coordinate(5), new Coordinate(5)
            });
            Shape shape = new ZShape(zPoint);
            return shape;
        }
    }
}
