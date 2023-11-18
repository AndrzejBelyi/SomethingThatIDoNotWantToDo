using SmthThatIDoNotWantToDo.Extensions;
using System;

namespace SmthThatIDoNotWantToDo.Models
{
    public class Triangle : Polygone
    {
        public double SideA { get => _sides[0]; }

        public double SideB { get => _sides[1]; }

        public double SideC { get => _sides[2]; }

        public bool IsRightTriangle { get => IsRight(); }

        public Triangle(double a, double b, double c)
            : base(a, b, c)
        {
            //triangle inequality
            if (!(a + b > c && a + c > b && b + c > a))
            {
                throw new ArgumentException();
            }
        }

        public override double GetArea()
        {
            return Math.Sqrt(Perimeter * (Perimeter - SideA) * (Perimeter - SideB) * (Perimeter - SideC));
        }

        private bool IsRight()
        {
            return (Math.Pow(SideA, 2) + Math.Pow(SideB, 2)).EqualsWithPercision(Math.Pow(SideC, 2))
                || (Math.Pow(SideA, 2) + Math.Pow(SideC, 2)).EqualsWithPercision(Math.Pow(SideB, 2))
                || (Math.Pow(SideB, 2) + Math.Pow(SideC, 2)).EqualsWithPercision(Math.Pow(SideA, 2));
        }
    }
}
