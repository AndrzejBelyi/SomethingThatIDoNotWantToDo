using NUnit.Framework;
using SmthThatIDoNotWantToDo;
using SmthThatIDoNotWantToDo.Models;
using System;

namespace AreaCalculator.Tests.ModelsTests
{
    [TestFixture]
    public class EllipseTests
    {
        [TestCase(0.01, 0.01, 0.01, 0.01)]
        [TestCase(1d, 1d, 1d, 1d)]
        [TestCase(1d, 2d, 1d, 2d)]
        public void Ellipse_Constructor_ShouldBeCreated(double semiMajorAxis, double semiMinorAxis, double expectedMajorAxis, double expectedMinorAxis)
        {
            //Arrange
            //Act
            var ellipse = new Ellipse(semiMajorAxis, semiMinorAxis);

            //Assert
            Assert.AreEqual(expectedMajorAxis, ellipse.SemiMajorAxis);
            Assert.AreEqual(expectedMinorAxis, ellipse.SemiMinorAxis);
        }

        [TestCase(0d, 0d)]
        [TestCase(-1d, 1d)]
        [TestCase(1d, -1d)]
        [TestCase(-1d, -1d)]
        public void Ellipse_Constructor_ShouldThrowArgumentException(double semiMajorAxis, double semiMinorAxis)
        {
            //Arrange
            //Act
            //Assert
            Assert.Throws<ArgumentException>(() => new Ellipse(semiMajorAxis, semiMinorAxis));
        }

        [TestCase(0.01, 0.01)]
        [TestCase(1d, 1d)]
        [TestCase(2d, 3d)]
        public void Ellipse_GetArea_Tests(double semiMajorAxis, double semiMinorAxis)
        {
            //Arrange
            var expectedArea = Math.PI * semiMajorAxis * semiMinorAxis;

            //Act
            var ellipse = new Ellipse(semiMajorAxis, semiMinorAxis);

            //Assert
            Assert.AreEqual(expectedArea, ellipse.GetArea(), CalculationConsts.Percision);
        }
    }
}
