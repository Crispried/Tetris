using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using TetrisLibrary;
using Console2DTetris;

namespace UnitTests
{
    [TestFixture]
    class TestPoint
    {
        [Test]
        public void PointEqualsTestTrue()
        {
            //Assume
            var myPoint = new Point2D(new List<Coordinate>()
            {
                new Coordinate(5), new Coordinate(5)
            });
            var testPoint = new Point2D(new List<Coordinate>()
            {
                new Coordinate(5), new Coordinate(5)
            });
            //Act
            var result = myPoint.Equals(testPoint);
            //Arrange
            Assert.IsTrue(result);
        }

        [Test]
        public void PointEqualsTestFalse()
        {
            //Assume
            var myPoint = new Point2D(new List<Coordinate>()
            {
                new Coordinate(5), new Coordinate(5)
            });
            var testPoint = new Point2D(new List<Coordinate>()
            {
                new Coordinate(6), new Coordinate(5)
            });
            //Act
            var result = myPoint.Equals(testPoint);
            //Arrange
            Assert.IsFalse(result);
        }
    }
}
