using System;
using System.Collections.Generic;
using System.Text;

namespace ExceptionsExercises
{
    class Triangle
    {
        int _sideA, _sideB, _sideC;

        List<int> _sides = new List<int>();
        public Triangle(int a, int b, int c)
        {
            _sideA = a;
            _sideB = b;
            _sideC = c;
        }

        public bool IsRightAngled()
        {
            return (Math.Pow(_sideA, 2) + Math.Pow(_sideB, 2) == Math.Pow(_sideC, 2));
        }

        public void TriangleException(int length)
        {
            throw new ArgumentException(String.Format("The triangle is not valid because the side with length {0} is greater than the sum of the other two lengths", length),
                                      "side");
        }
        public void isValid()
        {
            if (_sideA + _sideB > _sideC && _sideA + _sideC > _sideB && _sideB + _sideC > _sideA)
                TriangleException(Math.Max(Math.Max(_sideA, _sideB), _sideC));
        }
    }
}
