using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreasLibrary
{
    public class Triangle : Shape
    {
        readonly double[] Sides;

        /// <summary>
        /// Get Triangle Area
        /// </summary>
        /// <param name="a">A side length of a triangle</param>
        /// <param name="b">B side length of a triangle</param>
        /// <param name="c">C side length of a triangle</param>
        public Triangle(double a, double b, double c) : base
            (Math.Sqrt((a + b + c) / 2 * (((a + b + c) / 2) - a) * (((a + b + c) / 2) - b) * (((a + b + c) / 2) - c)))
        {
            if (a <= 0 || b <= 0 || c <= 0)
                throw new ArgumentException("Provided side length is not a positive double");
            else if (a + b < c || b + c < a || a + c < b)
                throw new ArgumentException("Provided sides do not form a triangle");

            Sides = new double[3] { a, b, c };
        }


        /// <summary>
        /// Triangle is Right
        /// </summary>
        /// <param name="eps">Optional parameter - Accuracy</param>
        /// <returns>True/False</returns>
        public bool IsRight(double eps = 1E-6)
        {
            Array.Sort(Sides);
            return Math.Abs(Math.Pow(Sides[0], 2) + Math.Pow(Sides[1], 2) - Math.Pow(Sides[2], 2)) <= eps;
        }
    }
}
