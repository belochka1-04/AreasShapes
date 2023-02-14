using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreasLibrary
{
    public class Circle : Shape
    {
        /// <summary>
        /// Get Circle Area
        /// </summary>
        /// <param name="r">Radius</param>
        public Circle(double r) : base(Math.PI * r * r)
        {
            if (r <= 0.0)
                throw new ArgumentException("Provided radius should be > 0");
        }
    }
}
