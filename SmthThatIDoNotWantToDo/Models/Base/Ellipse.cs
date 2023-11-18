using System;

namespace SmthThatIDoNotWantToDo.Models
{
    public class Ellipse : FigureBase
    {
        public double SemiMajorAxis { get; }

        public double SemiMinorAxis { get; }

        public Ellipse(double majorAxis, double minorAxis)
        {
            if (majorAxis <= 0)
            {
                throw new ArgumentException(nameof(majorAxis));
            }

            if (minorAxis <= 0)
            {
                throw new ArgumentException(nameof(minorAxis));
            }

            SemiMajorAxis = majorAxis;
            SemiMinorAxis = minorAxis;
        }

        public override double GetArea()
        {
            return Math.PI * SemiMajorAxis * SemiMinorAxis;
        }
    }
}
