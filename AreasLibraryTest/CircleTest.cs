using AreasLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreasLibraryTest
{
    [TestClass]
    public class CircleTest
    {
        /// <summary>
        /// Check for ArgumentException (The radius of the circle is zero)
        /// Should throw away ArgumentException!
        /// </summary>
        [ExpectedException(typeof(System.ArgumentException), "")]
        [TestMethod]
        public void CircleRadiusIsZero()
        {
            Circle _ = new Circle(0.0);
        }


        /// <summary>
        /// Check for ArgumentException (The radius of the circle is less than zero)
        /// </summary>
        [ExpectedException(typeof(System.ArgumentException), "")]
        [TestMethod]
        public void CircleRadiusIsLessThanZero()
        {
            Circle _ = new Circle(-0.5);
        }


        /// <summary>
        /// Checking the calculation of the area of the circle with accuracy
        /// </summary>
        [TestMethod]
        public void CircleAreaDeltaCompute()
        {
            Circle crc = new Circle(5.0);
            Assert.AreEqual(78.53981633, crc.GetArea, 1E-6, "Result out of range!");
        }
    }
}
