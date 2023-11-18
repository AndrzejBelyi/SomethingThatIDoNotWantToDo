using NUnit.Framework;
using SmthThatIDoNotWantToDo;
using SmthThatIDoNotWantToDo.Models;
using System;

namespace AreaCalculator.Tests
{
    [TestFixture]
    public class CircleTests
    {
        [TestCase(0.01, 0.01, 0.01)]
        [TestCase(1d, 1d, 1d)]
        public void Circle_Constructor_ShouldBeCreated(double radius, double expectedSemiMajorAxis, double expectedSemiMinorAxis)
        {
            //Arrange
            //Act
            var circle = new Circle(radius);

            //Assert
            Assert.AreEqual(expectedSemiMajorAxis, circle.SemiMajorAxis);
            Assert.AreEqual(expectedSemiMinorAxis, circle.SemiMinorAxis);
            Assert.AreEqual(circle.SemiMajorAxis, circle.SemiMinorAxis);
        }

        [TestCase(0d)]
        [TestCase(-1d)]
        public void Circle_Constructor_ShouldThrowArgumentException(double radius)
        {
            //Arrange
            //Act
            //Assert
            Assert.Throws<ArgumentException>(() => new Circle(0));
        }

        [TestCase(0.01)]
        [TestCase(1d)]
        public void Circle_GetArea_Tests(double radius)
        {
            //Arrange
            var expectedArea = Math.PI * radius * radius;

            //Act
            var circle = new Circle(radius);

            //Assert
            Assert.AreEqual(expectedArea, circle.GetArea(), CalculationConsts.Percision);
        }
    }
}
