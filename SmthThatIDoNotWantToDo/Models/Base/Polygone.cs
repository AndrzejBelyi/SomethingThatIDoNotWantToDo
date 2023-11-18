using System;
using System.Linq;

namespace SmthThatIDoNotWantToDo.Models
{
    //This is abstract due to difficulties to implement GetArea for polygone. Need to know angles, type of polygone, intersections of sides etc.
    public abstract class Polygone : FigureBase
    {
        private protected readonly double[] _sides = Array.Empty<double>();

        public int SidesCount { get { return _sides.Length; } }

        public double Perimeter { get => _sides.Sum(); }

        protected Polygone(params double[] sides)
        {
            if (sides == null)
            {
                throw new ArgumentNullException(nameof(sides));
            }

            ///Polygone can't be build by 2 or less sides(1 - point, 2 - line)
            if (sides.Length < 3)
            {
                throw new ArgumentException(nameof(sides));
            }

            if (sides.Any(s => s <= 0))
            {
                throw new ArgumentException(nameof(sides));
            }

            _sides = sides;
        }
    }
}