using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TetrisLibrary;
using NUnit.Framework;

namespace UnitTests
{
    [TestFixture]
    class AxesParserTest
    {
        [Test]
        public void ParseTest()
        {
            //Assert
            string pathToFile = "axes.xml";
            //Act
            var axes = AxisParser.Parse(pathToFile);
            //Arrange
            Assert.IsTrue(axes[0].Equals(new Axis("x")));
            Assert.IsTrue(axes[1].Equals(new Axis("y")));
        }
    }
}
