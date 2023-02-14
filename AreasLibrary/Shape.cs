using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreasLibrary
{
    public abstract class Shape
    {
        private readonly double area;
        public double GetArea => area;
        protected Shape(double area) => this.area = area;
        public override string ToString() =>
            $"Type: {this.GetType().Name}, Area = {area:F3}";
    }
}
