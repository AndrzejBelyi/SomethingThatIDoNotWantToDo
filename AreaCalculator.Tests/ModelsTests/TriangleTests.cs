using NUnit.Framework;
using SmthThatIDoNotWantToDo.Models;
using System;

namespace AreaCalculator.Tests.ModelsTests
{
    [TestFixture]
    public class TriangleTests
    {

        [TestCase(new[] { 2d, 2d, 3d }, new[] { 2d, 2d, 3d })]
        public void Triangle_Constructor_ShouldBeCreated(double[] sides, double[] expectedSides)
        {
            //Arrange
            //Act
            var triangle = new Triangle(sides[0], sides[1], sides[2]);

            //Assert
            Assert.AreEqual(expectedSides[0], triangle.SideA);
            Assert.AreEqual(expectedSides[1], triangle.SideB);
            Assert.AreEqual(expectedSides[2], triangle.SideC);
        }

        [TestCase(new[] { -1d, 2d, 1d })]
        //Triangle inequality check
        [TestCase(new[] { 4d, 2d, 1d })]

        public void Triangle_Constructor_ShouldThrowArgumentException(double[] sides)
        {
            //Arrange
            //Act
            //Assert
            Assert.Throws<ArgumentException>(() => new Triangle(sides[0], sides[1], sides[2]));
        }
    }
}
