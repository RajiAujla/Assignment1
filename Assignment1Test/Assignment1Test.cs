using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Assignment1;

namespace Assignment1Test
{
    [TestFixture]
    public class Assignment1Test
    {

        [Test]
        public void checkIntegerLength()
        {
            RectangleClass rcObj = new RectangleClass(10,10);
            int result = rcObj.GetLength();
            Assert.AreEqual(10,result);
        }

        [Test]
        public void checkIntegerSetLength()
        {
            RectangleClass rcObj = new RectangleClass();
            int result = rcObj.SetLength(12);
            Assert.AreEqual(12,result);
        }

        [Test]
        public void checkIntegerWidth()
        {
            RectangleClass rcObj = new RectangleClass(4, 4);
            int result = rcObj.GetWidth();
            Assert.AreEqual(4, result);
        }

        [Test]
        public void checkIntegerSetWidth()
        {
            RectangleClass rcObj = new RectangleClass();
            int result = rcObj.SetLength(5);
            Assert.AreEqual(5, result);
        }

        [Test]
        public void checkIntegerParameter()
        {
            RectangleClass rcObj = new RectangleClass(2,2);
            int result = rcObj.GetPerimeter();
            Assert.AreEqual(8, result);
        }

        [Test]
        public void checkIntegerArea()
        {
            RectangleClass rcObj = new RectangleClass(2, 2);
            int result = rcObj.GetArea();
            Assert.AreEqual(4, result);
        }

    }
}
